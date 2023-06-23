using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    public partial class FormAccount : Form
    {
        DataTable table = new DataTable();
        public long selectedId = -1;
        public FormAccount()
        {
            InitializeComponent();
            if (WeddingClient.client_priority == 0) // system
            {
                cbb_level.DataSource = new string[]{"Director", "Manager", "Employee"};
                cbb_level.SelectedIndex = 2;
            }
            else if (WeddingClient.client_priority == 1) // director
            {
                cbb_level.DataSource = new string[] {"Manager", "Employee" };
                cbb_level.SelectedIndex = 1;
            }
            else if (WeddingClient.client_priority == 2) // manager
            {
                cbb_level.DataSource = new string[] {"Employee" };
                cbb_level.SelectedIndex = 0;
            }
            else
            {
                cbb_level.DataSource = new string[] { };
                cbb_level.SelectedIndex = -1;
            }
            gv_act.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gv_act.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Reset();
        }

        private void Reset()
        {
            this.table = new DataTable();
            // use sqldataadapter to fill the table
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Username, Name, Priority, Identification, Pw FROM ACCOUNT WHERE Priority > @myPriority", sql))
                {
                    cmd.Parameters.AddWithValue("@myPriority", WeddingClient.client_priority);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    table.Columns[0].ColumnMapping = MappingType.Hidden;
                    table.Columns[5].Caption = "Password";
                    gv_act.DataSource = table;
                    gv_act.Columns["pw"].HeaderText = "Password";
                }
            }
        }

        private void btn_update_account_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) { MessageBox.Show("Please select an account"); return; }
            bool reset = false;
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                if (tb_password.Text == "")
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE ACCOUNT SET Username = @username, Name = @name, Priority = @priority, Identification = @identification WHERE Id = @id", sql))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@username", tb_username.Text);
                        cmd.Parameters.AddWithValue("@name", tb_name.Text);
                        cmd.Parameters.AddWithValue("@priority", cbb_level.SelectedIndex + 1 + WeddingClient.client_priority);
                        cmd.Parameters.AddWithValue("@identification", tb_iden.Text);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            reset = true;
                        }
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE ACCOUNT SET Username = @username, Name = @name, Priority = @priority, Identification = @identification, Pw = @pw WHERE Id = @id", sql))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@username", tb_username.Text);
                        cmd.Parameters.AddWithValue("@name", tb_name.Text);
                        cmd.Parameters.AddWithValue("@priority", cbb_level.SelectedIndex + 1 + WeddingClient.client_priority);
                        cmd.Parameters.AddWithValue("@identification", tb_iden.Text);
                        cmd.Parameters.AddWithValue("@pw", CryptSharp.Crypter.Blowfish.Crypt(tb_password.Text));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            reset = true;
                        }
                    }
                }
            }
            if (reset)
            {
                Reset();
            }
        }

        private void btn_add_account_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "") return;
            using(SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                // check if username exists
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @username", sql))
                {
                    cmd.Parameters.AddWithValue("@username", tb_username.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Username already exists!");
                            return;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (Id, Username, Name, Pw, Priority) VALUES (@Id, @username, @name, @password, @level)", sql))
                {
                    long newId = WeddingClient.GetNewACCOUNTSId();
                    string newPass = tb_password.Text == "" ? CryptSharp.Crypter.Blowfish.Crypt("123") : CryptSharp.Crypter.Blowfish.Crypt(tb_password.Text);
                    cmd.Parameters.AddWithValue("@Id", newId);
                    cmd.Parameters.AddWithValue("@username", tb_username.Text);
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@password", newPass);
                    cmd.Parameters.AddWithValue("@level", WeddingClient.client_priority + cbb_level.SelectedIndex + 1);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        // add to grid
                        DataRow row = table.NewRow();
                        row["Id"] = newId;
                        row["Username"] = tb_username.Text;
                        row["Pw"] = newPass;
                        row["Priority"] = cbb_level.SelectedIndex + 1 + WeddingClient.client_priority;
                        table.Rows.Add(row);
                        gv_act.DataSource = table;
                        MessageBox.Show("Account created!");
                    }
                }
            }
        }

        private void btn_delete_account_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) { MessageBox.Show("Please select an account"); return; }
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ACCOUNT WHERE Id = @Id", sql))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        
                        // remove row 
                        DataRow[] rows = table.Select("Id = " + selectedId);
                        foreach (DataRow row in rows)
                        {
                            table.Rows.Remove(row);
                        }
                        gv_act.DataSource = table;
                        
                        MessageBox.Show("Account deleted!");
                    }
                }
            }
            selectedId = -1;
        }

        private void gv_act_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if row is valid
            if (e.RowIndex < 0 || e.RowIndex >= gv_act.Rows.Count) 
            {
                selectedId = -1;
                return; 
            }
            // get the row of the cell clicked from dataGridView1
            var rowItem = (DataRowView)gv_act.Rows[e.RowIndex].DataBoundItem;
            // find the row of the cell clicked in table
            int i = table.Rows.IndexOf(rowItem.Row);
            DataRow row = table.Rows[i];
            selectedId = (long)row["Id"];
            tb_username.Text = row["Username"].ToString();
            tb_password.Text = "";
            cbb_level.SelectedIndex = (short)row["Priority"] - WeddingClient.client_priority - 1;
            tb_name.Text = row["Name"].ToString();
            tb_iden.Text = row["Identification"].ToString();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
