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
    public partial class FormLobbyType : Form
    {
        public static string currentTypeId = "";
        DataTable table = new DataTable();
        DataColumn column;
        DataRow row;

        void load_data_LobbyType()
        {
            table = new DataTable();
            // first column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lobbyTypeName";
            column.AutoIncrement = false;
            column.Caption = "Type";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // second column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "MinTablePrice";
            column.AutoIncrement = false;
            column.Caption = "Minimum Table Price";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // third column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "IdLobbyType";
            column.AutoIncrement = false;
            column.Caption = "IdLobbyType";
            column.ReadOnly = true;
            column.Unique = true;
            column.ColumnMapping = MappingType.Hidden;
            table.Columns.Add(column);
            
            DataColumn[] keys = new DataColumn[1];
            keys[0] = table.Columns["IdLobbyType"];
            table.PrimaryKey = keys;

            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // prevent user from adding new row
            dataGridView1.AllowUserToAddRows = false;


            List<LobbyTypeData> lobbyTypes = new List<LobbyTypeData>();
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString)) { 
                sql.Open();
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM LOBBY_TYPE WHERE Available > 0", sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lobbyTypes.Add(new LobbyTypeData(reader["IdLobbyType"].ToString(), reader["LobbyName"].ToString(), Convert.ToInt64(reader["MinTablePrice"])));
                        }
                    }
                }
            }
            WeddingClient.listLobbyTypes = lobbyTypes;
            // add rows to table
            foreach (LobbyTypeData lobbyType in lobbyTypes)
            {
                row = table.NewRow();
                row["lobbyTypeName"] = lobbyType.LobbyName;
                row["MinTablePrice"] = lobbyType.MinTablePrice;
                row["IdLobbyType"] = lobbyType.idLobbyType;
                table.Rows.Add(row);
            }
        }
        public FormLobbyType()
        {
            InitializeComponent();
        }

        private void FormLobbyType_Load(object sender, EventArgs e)
        {
            load_data_LobbyType();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= table.Rows.Count)
            {
                currentTypeId = "";
                return;
            }
            // get the row of the cell clicked from dataGridView1
            var rowItem = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            // find the row of the cell clicked in table
            int i = table.Rows.IndexOf(rowItem.Row);
            DataRow row = table.Rows[i];
            comboBox1.Text = row[0].ToString();
            textBox1.Text = row[1].ToString();
            //textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (i < WeddingClient.listLobbyTypes.Count)
            {
                currentTypeId = WeddingClient.listLobbyTypes[i].idLobbyType;
            }
            else
            {
                currentTypeId = "";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (comboBox1.Text == "" || !long.TryParse(textBox1.Text, out long price))
                {
                    MessageBox.Show("Please fill all the fields!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO LOBBY_TYPE (IdLobbyType, LobbyName, MinTablePrice, Available) VALUES (@IdLobbyType, @LobbyName, @MinTablePrice, 1)", sql))
                        {
                            string newTypeId = "LT" + WeddingClient.GetNewIdFromTable("LT").ToString().PadLeft(19, '0');
                            cmd.Parameters.AddWithValue("@IdLobbyType", newTypeId);
                            cmd.Parameters.AddWithValue("@LobbyName", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@MinTablePrice", price);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                // add to table
                                row = table.NewRow();
                                row["lobbyTypeName"] = comboBox1.Text;
                                row["MinTablePrice"] = price;
                                row["IdLobbyType"] = newTypeId;
                                table.Rows.Add(row);
                                MessageBox.Show("New type added!");
                                // add to list
                                WeddingClient.listLobbyTypes.Add(new LobbyTypeData(newTypeId, comboBox1.Text, price));
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                // check if current type ID is not empty
                if (currentTypeId == "")
                {
                    MessageBox.Show("Please select a type!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE LOBBY_TYPE SET Available = 0 WHERE IdLobbyType = @IdLobbyType", sql))
                        {
                            cmd.Parameters.AddWithValue("@IdLobbyType", currentTypeId);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                // remove from list
                                foreach (LobbyTypeData lobbyType in WeddingClient.listLobbyTypes)
                                {
                                    if (lobbyType.idLobbyType == currentTypeId)
                                    {
                                        WeddingClient.listLobbyTypes.Remove(lobbyType);
                                        break;
                                    }
                                }
                                // remove from table
                                table.Rows.Remove(table.Rows.Find(currentTypeId));
                                MessageBox.Show("Type deleted!", "SUCCESS", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                FormLobbyType.currentTypeId = "";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (comboBox1.Text == "" || !long.TryParse(textBox1.Text, out long price))
                {
                    MessageBox.Show("Please fill all the fields!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    if (currentTypeId == "")
                    {
                        MessageBox.Show("Please select a type!", "LACK", MessageBoxButtons.OK);
                    }
                    else
                    {
                        using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                        {
                            sql.Open();
                            using (SqlCommand cmd = new SqlCommand("UPDATE LOBBY_TYPE SET LobbyName=@name, MinTablePrice=@price WHERE IdLobbyType = @IdLobbyType", sql))
                            {
                                cmd.Parameters.AddWithValue("@IdLobbyType", currentTypeId);
                                cmd.Parameters.AddWithValue("@name", comboBox1.Text);
                                cmd.Parameters.AddWithValue("@price", long.Parse(textBox1.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    // remove from list
                                    // remove from table
                                    MessageBox.Show("Type Update!", "SUCCESS", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    FormLobbyType.currentTypeId = "";
                    load_data_LobbyType();
                }
            }
        }
    }
}
