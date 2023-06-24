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
    public partial class FormBill : Form
    {
        public FormBill()
        {               
            InitializeComponent();
            load_comboBox_staff();
            //load_gridView_Dishes();
            tb_lobby_price.ReadOnly = true;
            tb_moneyLeft.ReadOnly = true;
            tb_penalty.ReadOnly = false;
            tb_phone.ReadOnly = true;
            tb_representative.ReadOnly = true;
            tb_serviceTotal.ReadOnly = true;
            tb_tableTotal.ReadOnly = true;
            tb_total.ReadOnly = true;


            // make invoice date time picker readonly
            invoiceDTP.Enabled = false;

        }

        private void pay_yes_Click(object sender, EventArgs e)
        {
            this.tb_moneyLeft.Text = "0";
        }

        private void pay_no_Click(object sender, EventArgs e)
        {
            if (rBtn_yes.Checked)
            {
                tb_moneyLeft.Text = penaltyTotal.ToString();
            }
            else
            {
                if (currentMoneyLeft > 0)
                    tb_moneyLeft.Text = baseTotal.ToString();
                else
                    tb_moneyLeft.Text = "0";
            }
        }

        public string id;
        public long currentMoneyLeft = 0;

        public FormBill(string id) : this()
        {
            this.id = id;
            load_gridView_Dishes(id);
            load_gridView_Service(id);
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using(SqlCommand cmd = new SqlCommand("SELECT Value FROM PARAMETER WHERE IdParamater = 'PenaltyRate'", sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_penalty.Text = reader.GetInt32(0).ToString();
                        }
                    }
                }
                using (SqlCommand sqlcomm = new SqlCommand("SELECT W.Representative, W.PhoneNumber, W.Deposit, B.TablePriceTotal, B.ServicePriceTotal, B.Total, B.InvoiceDate, B.PaymentDate, B.MoneyLeft FROM BILL B, WEDDING_INFOR W WHERE IdWedding = IdBill AND IdBill = @id", sql))
                {
                    sqlcomm.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = sqlcomm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_representative.Text = reader.GetString(0);
                            tb_phone.Text = reader.GetString(1);
                            tb_lobby_price.Text = reader.GetInt64(2).ToString();
                            tb_tableTotal.Text = reader.GetInt64(3).ToString();
                            tb_serviceTotal.Text = reader.GetInt64(4).ToString();
                            tb_total.Text = reader.GetInt64(5).ToString();
                            baseTotal = reader.GetInt64(5);
                            invoiceDTP.Value = reader.GetDateTime(6);
                            paymentDTP.Value = reader[7] != DBNull.Value ? reader.GetDateTime(7) : DateTime.Now;
                            tb_moneyLeft.Text = reader.GetInt64(8).ToString();
                            this.currentMoneyLeft = reader.GetInt64(8);
                            if (currentMoneyLeft <= 0)
                            {
                                // disable radio buttons
                                rBtn_yes.Enabled = false;
                                rBtn_no.Enabled = false;
                                pay_yes.Enabled = false;
                                pay_no.Enabled = false;
                                rBtn_yes.Checked = false;
                                rBtn_no.Checked = false;
                                pay_yes.Checked = false;
                                pay_no.Checked = false;
                                
                                tb_penalty.ReadOnly = true;

                                // make payment date time picker readonly
                                paymentDTP.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private long trueBaseTotal;
        
        public long baseTotal { 
            get
            {
                return trueBaseTotal;
            }
            set
            {
                trueBaseTotal = value;
            } 
        }

        public long penaltyTotal
        {
            get
            {
                TimeSpan timeSpan = paymentDTP.Value - invoiceDTP.Value;
                if (int.TryParse(tb_penalty.Text, out int penalty))
                {
                    return (long)(timeSpan.Days * (penalty*1.0/100) * baseTotal + baseTotal);
                }
                else
                {
                    return baseTotal;
                }
            }
        }

        private void RBtn_yes_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tb_lobby_price);
            int y = Convert.ToInt32(penaltyTotal);
            int z = y - x;
            tb_moneyLeft.Text = z.ToString();
        }

        private void RBtn_no_Click(object sender, EventArgs e)
        {
            if (currentMoneyLeft > 0)
            {
                int x = Convert.ToInt32(tb_lobby_price);
                int y = Convert.ToInt32(baseTotal);
                int z = y - x;
                tb_moneyLeft.Text = z.ToString();
            }
            else
                tb_moneyLeft.Text = "0";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // save all bill data to database
            int indexStaff = cbb_staff.SelectedIndex;
            StaffsData staff = WeddingClient.listStaffs[indexStaff];
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                if (pay_yes.Checked)
                {
                    if (rBtn_yes.Checked && int.TryParse(tb_penalty.Text, out int penalty))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE BILL SET Total = @Total, PaymentDate = @PaymentDate, MoneyLeft = 0, Staff=@Staff WHERE IdBill = @IdBill", sql))
                        {
                            cmd.Parameters.AddWithValue("@Total", tb_total.Text);
                            cmd.Parameters.AddWithValue("@PaymentDate", paymentDTP.Value);
                            cmd.Parameters.AddWithValue("@IdBill", id);
                            cmd.Parameters.AddWithValue("@Staff", staff.idStaff);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Saved!");
                        }
                    }
                    else if (rBtn_no.Checked)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE BILL SET PaymentDate = @PaymentDate, MoneyLeft = 0 WHERE IdBill = @IdBill", sql))
                        {
                            cmd.Parameters.AddWithValue("@PaymentDate", paymentDTP.Value);
                            cmd.Parameters.AddWithValue("@IdBill", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Saved!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter penalty");
                    }
                }
                else
                {
                    MessageBox.Show("Saved!");
                    this.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void load_comboBox_staff()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Username, Pw, Priority, Name, Identification  FROM ACCOUNT", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listShifts = new List<ShiftData>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            cbb_staff.DataSource = dt;
                            cbb_staff.DisplayMember = "Name";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listStaffs.Add(new StaffsData(
                                    Convert.ToInt32(row["Id"]),
                                    row["Username"].ToString(),
                                    row["Pw"].ToString(),
                                    Convert.ToInt32(row["Priority"]),
                                    row["Name"].ToString(),
                                    row["Identification"].ToString()));
                            }
                        }
                    }
                }
            }
        }

        private void tb_penalty_TextChanged(object sender, EventArgs e)
        {

        }

        public static string currentWeddingId = "";
        DataTable tableDishes = new DataTable();
        DataTable tableService = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        void load_gridView_Dishes(String x)
        {
            //load_data_Dishes();
            DataColumn column;
            DataRow row;

            // Create first column and add to the DataTable.
            /*column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "idWedding";
            column.AutoIncrement = false;
            column.Caption = "id Wedding";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableDishes.Columns.Add(column);

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Representative";
            column.AutoIncrement = false;
            column.Caption = "Representative";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableDishes.Columns.Add(column);*/

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "dishesName";
            column.AutoIncrement = false;
            column.Caption = "Dishes name";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableDishes.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AmountOfDishes";
            column.AutoIncrement = false;
            column.Caption = "Quantity";
            column.ReadOnly = false;
            column.Unique = false;
            tableDishes.Columns.Add(column);

            // create third column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TotalDishesPrice";
            column.AutoIncrement = false;
            column.Caption = "Total Dishes Price";
            column.ReadOnly = false;
            column.Unique = false;
            tableDishes.Columns.Add(column);

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Note";
            column.AutoIncrement = false;
            column.Caption = "Note";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableDishes.Columns.Add(column);

            dataDishes.DataSource = tableDishes;
            foreach (DataGridViewColumn col in dataDishes.Columns)
            {
                col.HeaderText = tableDishes.Columns[col.DataPropertyName].Caption;
            }
                

                // Thực hiện truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string query = "SELECT dishesName, AmountOfDishes,TotalDishesPrice, TBD.Note FROM WEDDING_INFOR WD, MENU MN, TABLE_DETAIL TBD WHERE WD.idWedding = TBD.idWedding AND TBD.idDishes = MN.idDishes AND WD.idWedding = @idBill";
                using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    sql.Open();

                    // Tạo một đối tượng SqlCommand và thiết lập các tham số
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@idBill", x);

                    // Tạo một đối tượng SqlDataAdapter để lấy dữ liệu từ SqlCommand
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Tạo một đối tượng DataTable để chứa dữ liệu từ SqlDataAdapter
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable cho DataSource của DataGridView
                    dataDishes.DataSource = dataTable;

                    // Đóng kết nối
                    sql.Close();
                }

            //dataDishes.Columns["idWedding"].Visible = false;
            //dataDishes.Columns["Representative"].Visible = false;

            /*using (SqlCommand cmd = new SqlCommand("SELECT WD.idWedding, Representative, dishesName, AmountOfDishes,TotalDishesPrice, TBD.Note FROM WEDDING_INFOR WD, MENU MN, TABLE_DETAIL TBD WHERE WD.idWedding = TBD.idWedding AND TBD.idDishes = MN.idDishes AND WD.idWedding = @idBill", sql))
            {
                cmd.Parameters.AddWithValue("@idBill", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cbb_lobby.SelectedIndex = WeddingClient.listLobbies.FindIndex(x => x.idLobby == reader["IdLobby"].ToString());
                        cbb_shift.SelectedIndex = WeddingClient.listShifts.FindIndex(x => x.idShift == reader["IdShift"].ToString());
                        tb_representative.Text = reader.GetString(2);
                        tb_phone.Text = reader.GetString(3);
                        date_booking.Value = reader.GetDateTime(4);
                        date_wedding.Value = reader.GetDateTime(5);
                        tb_groom.Text = reader.GetString(6);
                        tb_bride.Text = reader.GetString(7);
                        tb_table.Text = reader.GetInt32(8).ToString();
                        tb_contigency.Text = reader.GetInt32(9).ToString();
                        tb_deposit.Text = reader.GetInt64(11).ToString();

                        DataRow row = table1.NewRow();
                        row.ItemArray = new object[] { reader["LobbyName"].ToString(), reader["ShiftName"].ToString(), tb_representative.Text, tb_phone.Text, date_booking.Value.ToString(), date_wedding.Value.ToString(), tb_groom.Text, tb_bride.Text, tb_table.Text, tb_contigency.Text, 0, tb_deposit.Text, id };
                        table1.Rows.Add(row);
                    }
                }

            }
        }*/

        }

        void load_gridView_Service(String x)
        {
            DataColumn column;
            DataRow row;

            // Create first column and add to the DataTable.
            /*column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "idWedding";
            column.AutoIncrement = false;
            column.Caption = "id Wedding";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableService.Columns.Add(column);

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Representative";
            column.AutoIncrement = false;
            column.Caption = "Representative";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableService.Columns.Add(column);*/

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ServiceName";
            column.AutoIncrement = false;
            column.Caption = "Service name";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableService.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AmountOfService";
            column.AutoIncrement = false;
            column.Caption = "Quantity";
            column.ReadOnly = false;
            column.Unique = false;
            tableService.Columns.Add(column);

            // create third column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TotalServicePrice";
            column.AutoIncrement = false;
            column.Caption = "Total Dishes Price";
            column.ReadOnly = false;
            column.Unique = false;
            tableService.Columns.Add(column);

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Note";
            column.AutoIncrement = false;
            column.Caption = "Note";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            tableService.Columns.Add(column);

            dataService.DataSource = tableService;
            foreach (DataGridViewColumn col in dataService.Columns)
            {
                col.HeaderText = tableService.Columns[col.DataPropertyName].Caption;
            }


            // Thực hiện truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
            string query = "SELECT  ServiceName, AmountOfService,TotalServicePrice, SVD.Note FROM WEDDING_INFOR WD, SERVICE SV, SERVICE_DETAIL SVD WHERE WD.IdWedding = SVD.IdWedding AND SVD.IdService = SV.IdService AND WD.IdWedding = @idBill";
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();

                // Tạo một đối tượng SqlCommand và thiết lập các tham số
                SqlCommand command = new SqlCommand(query, sql);
                command.Parameters.AddWithValue("@idBill", x);

                // Tạo một đối tượng SqlDataAdapter để lấy dữ liệu từ SqlCommand
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Tạo một đối tượng DataTable để chứa dữ liệu từ SqlDataAdapter
                DataTable dataTable2 = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable2);

                // Gán DataTable cho DataSource của DataGridView
                dataService.DataSource = dataTable2;

                // Đóng kết nối
                sql.Close();
            }

            //dataService.Columns["id Wedding"].Visible = false;
            //dataService.Columns["Representative"].Visible = false;
        }

            private void FormBill_Load(object sender, EventArgs e)
        {

        }
    }

}
