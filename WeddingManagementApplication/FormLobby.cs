using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    public partial class FormLobby : Form
    {
        DataTable table = new DataTable();
        DataColumn column;
        DataRow row;

        void Load_data_Lobby()
        {
            // create table
            table = new DataTable();
            // first column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LobbyName";
            column.AutoIncrement = false;
            column.Caption = "Lobby Name";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // second column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LobbyType";
            column.AutoIncrement = false;
            column.Caption = "Lobby Type";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // third column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "MaxTable";
            column.AutoIncrement = false;
            column.Caption = "Max Table";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // fourth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Note";
            column.AutoIncrement = false;
            column.Caption = "Note";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // fifth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IdLobby";
            column.AutoIncrement = false;
            column.Caption = "IdLobby";
            column.ReadOnly = true;
            column.Unique = true;
            column.ColumnMapping = MappingType.Hidden;
            table.Columns.Add(column);

            // sixth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IdLobbyType";
            column.AutoIncrement = false;
            column.Caption = "IdLobbyType";
            column.ReadOnly = true;
            column.Unique = false;
            column.ColumnMapping = MappingType.Hidden;
            table.Columns.Add(column);

            // set primary key to IdLobby
            DataColumn[] keys = new DataColumn[1];
            keys[0] = table.Columns["IdLobby"];
            table.PrimaryKey = keys;

            dataGridView1.DataSource = table;
            // make dataGridView1 autosize
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            WeddingClient.listLobbyTypes = new List<LobbyTypeData>();
            // load data from database
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LOBBY_TYPE WHERE Available > 0", sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["IdLobbyType"].ToString());
                            WeddingClient.listLobbyTypes.Add(new LobbyTypeData(reader["IdLobbyType"].ToString(), reader["LobbyName"].ToString(), Convert.ToInt64(reader["MinTablePrice"])));
                        }
                    }
                }
            }
            
            // display lobby name
            lobbyTypeCombobox.DisplayMember = "LobbyName";
            // value is id
            lobbyTypeCombobox.ValueMember = "idLobbyType";
            // set combobox data source to listlobbytype
            lobbyTypeCombobox.DataSource = WeddingClient.listLobbyTypes;
            // set selected index to 0
            lobbyTypeCombobox.SelectedIndex = 0;

            WeddingClient.listLobbies = new List<LobbyData>();
            // load data from database
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT LB.IdLobby, LT.IdLobbyType LobbyTypeId, LT.LobbyName LobbyType, LB.LobbyName, LB.MaxTable, LB.Note FROM LOBBY LB, LOBBY_TYPE LT WHERE LB.IdLobbyType = LT.IdLobbyType AND LB.Available > 0", sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["IdLobby"].ToString());
                            WeddingClient.listLobbies.Add(new LobbyData(reader["IdLobby"].ToString(), reader["LobbyTypeId"].ToString(), reader["LobbyName"].ToString(), Convert.ToInt32(reader["MaxTable"]), reader["Note"].ToString()));
                            // add row to table
                            row = table.NewRow();
                            row["LobbyName"] = reader["LobbyName"].ToString();
                            row["LobbyType"] = reader["LobbyType"].ToString();
                            row["MaxTable"] = Convert.ToInt32(reader["MaxTable"]);
                            row["Note"] = reader["Note"].ToString();
                            row["IdLobby"] = reader["IdLobby"].ToString();
                            row["IdLobbyType"] = reader["LobbyTypeId"].ToString();
                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public static string currentLobbyId = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // return if row is header
            if (e.RowIndex < 0)
            {
                currentLobbyId = "";
                return;
            }
            // get the row of the cell clicked from dataGridView1
            var rowItem = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            // find the row of the cell clicked in table
            int index = table.Rows.IndexOf(rowItem.Row);

            // get selected row
            DataRow row = table.Rows[index];
            
            // set currentLobbyId
            currentLobbyId = row["IdLobby"].ToString();

            // set textbox value
            nameTextBox.Text = row["LobbyName"].ToString();
            
            // set textbox value
            maxTableTextBox.Text = (row["MaxTable"]).ToString();
            
            // set textbox value
            noteTextBox.Text = row["Note"].ToString();

            // set combobox value
            lobbyTypeCombobox.SelectedIndex = WeddingClient.listLobbyTypes.FindIndex(x => x.idLobbyType == row["IdLobbyType"].ToString());
        }


        public FormLobby()
        {
            InitializeComponent();
        }
        private Label label2;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private TextBox maxTableTextBox;
        private ComboBox lobbyTypeCombobox;
        private Button btn_delete;
        private Button btn_add;
        private Panel panel3;
        private Panel panel1;
        private Label label9;
        

        private void FormLobby_Load(object sender, EventArgs e)
        {
            Load_data_Lobby();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {// check if current type ID is not empty
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (currentLobbyId == "")
                {
                    MessageBox.Show("Please select a lobby!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE LOBBY SET Available = 0 WHERE IdLobby = @IdLobby", sql))
                        {
                            cmd.Parameters.AddWithValue("@IdLobby", currentLobbyId);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                // remove from list
                                foreach (LobbyData lobby in WeddingClient.listLobbies)
                                {
                                    if (lobby.idLobby == currentLobbyId)
                                    {
                                        WeddingClient.listLobbies.Remove(lobby);
                                        break;
                                    }
                                }
                                // remove from table
                                table.Rows.Remove(table.Rows.Find(currentLobbyId));
                                MessageBox.Show("Lobby deleted!", "SUCESS", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                FormLobby.currentLobbyId = "";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (!int.TryParse(maxTableTextBox.Text, out int maxTable))
                {
                    MessageBox.Show("Max table must be number!", "ERROR", MessageBoxButtons.OK);
                    return;
                }
                if (nameTextBox.Text == "" || maxTableTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields!", "LACK", MessageBoxButtons.OK);
                }
                else if (lobbyTypeCombobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a lobby type!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO LOBBY (IdLobby, IdLobbyType, LobbyName, MaxTable, Note, Available) VALUES (@IdLobby, @IdLobbyType, @LobbyName, @MaxTable, @Note, 1)", sql))
                        {
                            string idLobbyType = ((LobbyTypeData)lobbyTypeCombobox.SelectedItem).idLobbyType;
                            //lobbyTypeCombobox.SelectedValue.ToString()
                            string newTypeId = "LO" + WeddingClient.GetNewIdFromTable("LO").ToString().PadLeft(19, '0');
                            cmd.Parameters.AddWithValue("@IdLobby", newTypeId);
                            cmd.Parameters.AddWithValue("@IdLobbyType", idLobbyType);
                            cmd.Parameters.AddWithValue("@LobbyName", nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@MaxTable", maxTable);
                            cmd.Parameters.AddWithValue("@Note", noteTextBox.Text);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                // add to table
                                row = table.NewRow();
                                row["LobbyName"] = nameTextBox.Text;
                                row["LobbyType"] = WeddingClient.listLobbyTypes.Find(x => { if (x.idLobbyType == idLobbyType) return true; else return false; }).LobbyName;
                                row["MaxTable"] = maxTable;
                                row["Note"] = noteTextBox.Text;
                                row["IdLobby"] = newTypeId;
                                row["IdLobbyType"] = idLobbyType;
                                table.Rows.Add(row);
                                MessageBox.Show("New type added!");
                                // add to list
                                WeddingClient.listLobbies.Add(new LobbyData(newTypeId, idLobbyType, nameTextBox.Text, maxTable, noteTextBox.Text));
                            }
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // close and dispose form
            this.Close();
            this.Dispose();
        }
        Point lastPoint = new Point();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (!int.TryParse(maxTableTextBox.Text, out int maxTable))
                {
                    MessageBox.Show("Max table must be number!", "ERROR", MessageBoxButtons.OK);
                    return;
                }
                if (nameTextBox.Text == "" || maxTableTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields!", "LACK", MessageBoxButtons.OK);
                }
                else if (lobbyTypeCombobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a lobby type!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    if (currentLobbyId == "")
                    {
                        MessageBox.Show("Please select a lobby!", "LACK", MessageBoxButtons.OK);
                    }
                    else
                    {
                        using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                        {
                            sql.Open();
                            String ID = "";
                            using (SqlCommand cm = new SqlCommand("SELECT * from LOBBY_TYPE where LobbyName =@name", sql))
                            {
                                cm.Parameters.AddWithValue("@name", lobbyTypeCombobox.Text);
                                SqlDataReader rd = cm.ExecuteReader();
                                while (rd.Read())
                                {
                                    ID = rd["IdLobbytype"].ToString();
                                }
                            }
                            using (SqlCommand cmd = new SqlCommand("UPDATE LOBBY SET IdLobbyType=@idlt, LobbyName=@name, MaxTable=@table WHERE IdLobby = @IdLobby", sql))
                            {
                                cmd.Parameters.AddWithValue("@IdLobby", currentLobbyId);
                                cmd.Parameters.AddWithValue("@idlt", ID);
                                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                                cmd.Parameters.AddWithValue("@table", int.Parse(maxTableTextBox.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Lobby Update!", "SUCESS", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    FormLobby.currentLobbyId = "";
                    Load_data_Lobby();
                }
            }
        }
    }
}
