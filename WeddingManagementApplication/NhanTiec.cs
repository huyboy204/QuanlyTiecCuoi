using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    public partial class NhanTiec : Form
    {
        public static string currentWeddingId = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        int priceOf1Table = 0;

        public NhanTiec()
        {
            InitializeComponent();
            load_gridView_wedding();
            load_comboBox_shift();
            load_comboBox_lobby();
            load_comboBox_menu();
            load_comboBox_service();
        }

        public NhanTiec(string id): this()
        {
            NhanTiec.currentWeddingId = id;
            Load_data_wedding(id);
        }

        void Load_data_wedding(string id)
        {
            using(SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT LobbyName, ShiftName, Representative, PhoneNumber, BookingDate, WeddingDate, GroomName, BrideName, AmountOfTable, " +
                "AmountOfContingencyTable, TablePrice, Deposit, WD.IdLobby, S.IdShift FROM LOBBY LB, SHIFT S, WEDDING_INFOR WD WHERE WD.IdShift = S.IdShift AND WD.IdLobby = LB.IdLobby AND WD.IdWedding = @id", sql))
                {
                    cmd.Parameters.AddWithValue("@id", id);
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
            }
        }

        // đổ dữ liệu từ db lên gridView
        void load_gridView_wedding()
        {
            //load_data_wedding();
            DataColumn column;
            DataRow row;
            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lobbyName";
            column.AutoIncrement = false;
            column.Caption = "Lobby name";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the DataColumnCollection.
            table1.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shiftName";
            column.AutoIncrement = false;
            column.Caption = "Shift";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create third column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "representative";
            column.AutoIncrement = false;
            column.Caption = "Representative";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create fourth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "phoneNumber";
            column.AutoIncrement = false;
            column.Caption = "Phone number";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create fifth column
            column = new DataColumn();
            // set datetype as datetime
            column.DataType = System.Type.GetType("System.DateTime");
            // set format as dd/MM/yyyy
            column.DateTimeMode = DataSetDateTime.Unspecified;
            column.ColumnName = "bookingDate";
            column.AutoIncrement = false;
            column.Caption = "Booking date";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);
            
            // create sixth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            // dd/MM/yyyy
            column.DateTimeMode = DataSetDateTime.Unspecified;
            column.ColumnName = "weddingDate";
            column.AutoIncrement = false;
            column.Caption = "Wedding date";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create seventh column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "groomName";
            column.AutoIncrement = false;
            column.Caption = "Groom name";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create eighth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "brideName";
            column.AutoIncrement = false;
            column.Caption = "Bride name";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create ninth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "amountOfTable";
            column.AutoIncrement = false;
            column.Caption = "Amount of table";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create tenth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "amountOfContingencyTable";
            column.AutoIncrement = false;
            column.Caption = "Amount of contingency table";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create eleventh column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "tablePrice";
            column.AutoIncrement = false;
            column.Caption = "Table price";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create twelfth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "deposit";
            column.AutoIncrement = false;
            column.Caption = "Deposit";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            // create thirteenth column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "idWedding";
            column.AutoIncrement = false;
            column.Caption = "idWedding";
            column.ReadOnly = false;
            column.Unique = false;
            column.ColumnMapping = MappingType.Hidden;
            table1.Columns.Add(column);

            dataWedding.DataSource = table1;
            foreach (DataGridViewColumn col in dataWedding.Columns)
            {
                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
            }
            dataWedding.Columns["bookingDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataWedding.Columns["weddingDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dataWedding.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataWedding_RowHeaderMouseClick);
        }

        private void dataWedding_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get the row of the cell clicked from dataGridView1
            var rowItem = (DataRowView)dataWedding.Rows[e.RowIndex].DataBoundItem;
            // find the row of the cell clicked in table
            int index = table1.Rows.IndexOf(rowItem.Row);
            // get selected row
            DataRow row = table1.Rows[index];
            // select weddingID
            NhanTiec.currentWeddingId = row["idWedding"].ToString();
            Console.WriteLine(NhanTiec.currentWeddingId);
        }


        // đổ dữ liệu từ db lên comboBox shift
        void load_comboBox_shift()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdShift, ShiftName, Starting, Ending FROM SHIFT where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listShifts = new List<ShiftData>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            cbb_shift.DataSource = dt;
                            cbb_shift.DisplayMember = "ShiftName";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listShifts.Add(new ShiftData()
                                {
                                    idShift = row["IdShift"].ToString(),
                                    name = row["ShiftName"].ToString(),
                                    startingTime = (TimeSpan)row["Starting"],
                                    endingTime = (TimeSpan)row["Ending"]
                                });;
                            }
                        }
                    }
                }
            }
        }

        // đổ dữ liệu từ db lên comboBox lobby
        void load_comboBox_lobby()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdLobby, IdLobbyType, LobbyName, MaxTable, Note FROM LOBBY WHERE Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listLobbies = new List<LobbyData>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            dr.Dispose();
                            cbb_lobby.DataSource = dt;
                            cbb_lobby.DisplayMember = "LobbyName";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listLobbies.Add(new LobbyData(
                                    row["IdLobby"].ToString(), 
                                    row["IdLobbyType"].ToString(), 
                                    row["LobbyName"].ToString(), 
                                    Convert.ToInt32(row["MaxTable"]), 
                                    row["Note"].ToString()));
                            }
                        }
                    }
                }
            }
        }

        // đổ dữ liệu từ db lên comboBox menu
        void load_comboBox_menu()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdDishes, DishesName, DishesPrice FROM MENU where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listDishes = new List<DishesData>();
                            var dt = new DataTable(); 
                            dt.Load(dr);
                            cbb_dishes.DataSource = dt;
                            cbb_dishes.DisplayMember = "DishesName";
                            // create list dishes from dt
                            //foreach (DataRow row in dt.Rows)
                            //{
                            //    WeddingClient.listDishes.Add(new DishesData()
                            //    {
                            //        idDishes = (row["IdDishes"]).ToString(),
                            //        DishesName = row["DishesName"].ToString(),
                            //        DishesPrice = Convert.ToInt64(row["DishesPrice"])
                            //    });
                            //}
                            tb_price_dishes.Text = WeddingClient.listDishes[0].DishesPrice.ToString() + " VND";
                        }
                    }
                }
            }
        }


        // đổ dữ liệu từ db lên comboBox service
        void load_comboBox_service()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdService, ServiceName, ServicePrice, Note FROM SERVICE where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listServices = new List<ServicesData>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            cbb_service.DataSource = dt;
                            cbb_service.DisplayMember = "ServiceName";
                            //// create list dishes from dt
                            //foreach (DataRow row in dt.Rows)
                            //{
                            //    WeddingClient.listServices.Add(new ServicesData()
                            //    {
                            //        idService = (row["IdService"]).ToString(),
                            //        ServiceName = row["ServiceName"].ToString(),
                            //        ServicePrice = Convert.ToInt64(row["ServicePrice"]),
                            //        Note = row["Note"].ToString()
                            //    });
                            //}
                            tb_price_service.Text = WeddingClient.listDishes[0].DishesPrice.ToString() + " VND";
                        }
                    }
                }
            }
        }
        
        private void cbb_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdDishes, DishesName, DishesPrice FROM MENU where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listDishes = new List<DishesData>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            // create list dishes from dt
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listDishes.Add(new DishesData()
                                {
                                    idDishes = (row["IdDishes"]).ToString(),
                                    DishesName = row["DishesName"].ToString(),
                                    DishesPrice = Convert.ToInt64(row["DishesPrice"])
                                });
                            }
                        }
                    }
                }
            }

            // get index of selected item
            int index = cbb_dishes.SelectedIndex;
            Console.WriteLine("index: " + index);
            // get DishesData from listDishes at index(error)
            DishesData dishes = WeddingClient.listDishes[index];
            // set textbox price
            tb_price_dishes.Text = dishes.DishesPrice.ToString() + " VND";
            
        }

        private void cbb_service_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdService, ServiceName, ServicePrice, Note FROM SERVICE where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listServices = new List<ServicesData>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            //// create list dishes from dt
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listServices.Add(new ServicesData()
                                {
                                    idService = (row["IdService"]).ToString(),
                                    ServiceName = row["ServiceName"].ToString(),
                                    ServicePrice = Convert.ToInt64(row["ServicePrice"]),
                                    Note = row["Note"].ToString()
                                });
                            }
                        }
                    }
                }
            }


            // get index of selected item
            int index = cbb_service.SelectedIndex;
            // get DishesData from listDishes at index
            ServicesData service = WeddingClient.listServices[index];

            // set textbox price
            tb_price_service.Text = service.ServicePrice.ToString() + " VND";
        }




        // cái hàm này để khi ấn vô cái dòng dữ liệu thì mấy ô mình nhập hiện lên các dữ liệu của dòng đó
        //private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //int i;
        //    //i = dataWedding.CurrentRow.Index;
        //    //tb_representative.Text = dataWedding.Rows[i].Cells[0].Value.ToString();
        //    //tb_phone.Text = dataWedding.Rows[i].Cells[1].Value.ToString();
        //    //date_booking.Text = dataWedding.Rows[i].Cells[2].Value.ToString();
        //    //date_wedding.Text = dataWedding.Rows[i].Cells[3].Value.ToString();
        //    //tb_groom.Text = dataWedding.Rows[i].Cells[4].Value.ToString();
        //    //tb_bride.Text = dataWedding.Rows[i].Cells[5].Value.ToString();
        //    //tb_table.Text = dataWedding.Rows[i].Cells[6].Value.ToString();
        //    //tb_contigency.Text = dataWedding.Rows[i].Cells[7].Value.ToString();
        //    //tb_deposit.Text = dataWedding.Rows[i].Cells[8].Value.ToString();
        //}


        // set sự kiện button xem chi tiết thông tin menu
        private void btn_detail_dishes_Click(object sender, EventArgs e)
        {
            if (NhanTiec.currentWeddingId != null && NhanTiec.currentWeddingId.Length == 21)
            {
                gridView_dishes show = new gridView_dishes(NhanTiec.currentWeddingId);
                show.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a wedding!", "LACK", MessageBoxButtons.OK);
            }
        }


        private int get_MinPriceOfLobby()
        {
            int MinPrice = 0;
            int index = cbb_lobby.SelectedIndex;
            string tmp = "";
            // get DishesData from listDishes at index
            LobbyData lobby = WeddingClient.listLobbies[index];
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();

                // check if (idWedding, idDishes) primary key is exist in table TABLE_DETAIL
                using (SqlCommand check = new SqlCommand("SELECT IdLobbyType FROM LOBBY WHERE  IdLobby = @IdLobby", sql))
                {

                    check.Parameters.AddWithValue("@IdLobby", lobby.idLobby);
                    using (SqlDataReader reader = check.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tmp = reader["IdLobbyType"].ToString();
                        }
                        else
                        {
                            tmp = "";
                        }
                    }
                }
                using (SqlCommand check = new SqlCommand("SELECT MinTablePrice FROM LOBBY_TYPE WHERE  IdLobbyType = @IdLobbyType", sql))
                {

                    check.Parameters.AddWithValue("@IdLobbyType", tmp);
                    using (SqlDataReader reader = check.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MinPrice = Convert.ToInt32(reader["MinTablePrice"]);
                        }
                        else
                        {
                            MinPrice = 0;
                        }
                    }    
                }
            }
            return MinPrice;
        }

        
        private void btn_add_menu_Click(object sender, EventArgs e)
        {
            if (NhanTiec.currentWeddingId != null && NhanTiec.currentWeddingId.Length == 21)
            {
                int numberOfTable = Convert.ToInt32(tb_table.Text)+ Convert.ToInt32(tb_contigency.Text);
                int MinPrice = get_MinPriceOfLobby();
                
                // get current index of comboBox dishes
                int index = cbb_dishes.SelectedIndex;
                // get DishesData from listDishes at index
                DishesData dishes = WeddingClient.listDishes[index];
                // check if tb_dishes_price is number
                if (tb_dishes_price.Text.Length > 0 && long.TryParse(tb_dishes_price.Text, out long count))
                {
                    using(SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        long currentDishesPrice = 0;
                        // check if (idWedding, idDishes) primary key is exist in table TABLE_DETAIL
                        using (SqlCommand check = new SqlCommand("SELECT AmountOfDishes FROM TABLE_DETAIL WHERE IdWedding = @idWedding AND IdDishes = @idDishes", sql))
                        {
                            check.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                            check.Parameters.AddWithValue("@idDishes", dishes.idDishes);
                            using (SqlDataReader reader = check.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentDishesPrice = Convert.ToInt32(reader["AmountOfDishes"]) * dishes.DishesPrice;
                                }
                                else
                                {
                                    currentDishesPrice = 0;
                                }
                            }
                        }
                        long newDishesPrice = 0;
                        if (currentDishesPrice == 0)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO TABLE_DETAIL (IdWedding, IdDishes, AmountOfDishes, TotalDishesPrice, Note) VALUES (@idWedding, @idDishes, @AmountOfDishes, @TotalDishesPrice, @Note)", sql))
                            {
                                cmd.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                cmd.Parameters.AddWithValue("@idDishes", dishes.idDishes);
                                cmd.Parameters.AddWithValue("@AmountOfDishes", Convert.ToInt32(tb_dishes_price.Text));
                                cmd.Parameters.AddWithValue("@TotalDishesPrice", dishes.DishesPrice * Convert.ToInt32(tb_dishes_price.Text));
                                cmd.Parameters.AddWithValue("@Note", "");
                                priceOf1Table = priceOf1Table + Convert.ToInt32(dishes.DishesPrice) * Convert.ToInt32(tb_dishes_price.Text);
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newDishesPrice = dishes.DishesPrice * Convert.ToInt32(tb_dishes_price.Text);
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL SET TablePriceTotal = TablePriceTotal + @tableChanged*@Quantity, Total = Total + @tableChanged WHERE IdBill = @idWedding", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@tableChanged", newDishesPrice);
                                        cmd2.Parameters.AddWithValue("@Quantity", numberOfTable);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            tb_dishes_price.Text = ""; 
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE TABLE_DETAIL SET AmountOfDishes = @AmountOfDishes, TotalDishesPrice = @TotalDishesPrice WHERE IdWedding = @idWedding AND IdDishes = @idDishes", sql))
                            {
                                cmd.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                cmd.Parameters.AddWithValue("@idDishes", dishes.idDishes);
                                cmd.Parameters.AddWithValue("@AmountOfDishes", Convert.ToInt32(tb_dishes_price.Text));
                                cmd.Parameters.AddWithValue("@TotalDishesPrice", dishes.DishesPrice * Convert.ToInt32(tb_dishes_price.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newDishesPrice = dishes.DishesPrice * Convert.ToInt32(tb_dishes_price.Text);
                                    long changes = newDishesPrice - currentDishesPrice;
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL SET TablePriceTotal = TablePriceTotal + @tableChanged, Total = Total + @tableChanged, MoneyLeft = MoneyLeft + @tableChanged WHERE IdBill = @idWedding", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@tableChanged", changes);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            tb_dishes_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please type amount of dish!", "LACK", MessageBoxButtons.OK);
                }

                if(priceOf1Table< MinPrice)
                {
                    MessageBox.Show("Not enough minimum table price!", "LACK", MessageBoxButtons.OK);
                    Console.WriteLine("minprice" + MinPrice);
                    Console.WriteLine("priceOf1Table" + priceOf1Table);
                }
            }
            else
            {            
                MessageBox.Show("Please add a wedding to choose dishes!", "LACK", MessageBoxButtons.OK);
            }
        }

        // sự kiện cho button detail service
        private void btn_detail_service_Click(object sender, EventArgs e)
        {
            if (NhanTiec.currentWeddingId != null && NhanTiec.currentWeddingId.Length == 21)
            {
                gridView_service show = new gridView_service(NhanTiec.currentWeddingId);
                show.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a wedding!", "LACK", MessageBoxButtons.OK);
            }
        }
        
        private void btn_add_service_Click(object sender, EventArgs e)
        {
            if (NhanTiec.currentWeddingId != null && NhanTiec.currentWeddingId.Length == 21)
            {
                // get current index of comboBox dishes
                int index = cbb_service.SelectedIndex;
                // get DishesData from listDishes at index
                ServicesData service = WeddingClient.listServices[index];
                // check if tb_dishes_price is number
                if (tb_service_price.Text.Length > 0 && long.TryParse(tb_service_price.Text, out long count))
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        long currentServicePrice = 0;
                        // check if (idWedding, idDishes) primary key is exist in table TABLE_DETAIL
                        using (SqlCommand check = new SqlCommand("SELECT AmountOfService FROM SERVICE_DETAIL WHERE IdWedding = @idWedding AND IdService = @idService", sql))
                        {
                            check.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                            check.Parameters.AddWithValue("@idService", service.idService);
                            using (SqlDataReader reader = check.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentServicePrice = Convert.ToInt32(reader["AmountOfService"]) * service.ServicePrice;
                                }
                                else
                                {
                                    currentServicePrice = 0;
                                }
                            }
                        }
                        long newServicePrice = 0;
                        if (currentServicePrice == 0)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO SERVICE_DETAIL (IdWedding, IdService, AmountOfService, TotalServicePrice, Note) VALUES (@idWedding, @idService, @AmountOfService, @TotalServicePrice, @Note)", sql))
                            {
                                cmd.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                cmd.Parameters.AddWithValue("@idService", service.idService);
                                cmd.Parameters.AddWithValue("@AmountOfService", Convert.ToInt32(tb_service_price.Text));
                                cmd.Parameters.AddWithValue("@TotalServicePrice", service.ServicePrice * Convert.ToInt32(tb_service_price.Text));
                                cmd.Parameters.AddWithValue("@Note", "");
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newServicePrice = service.ServicePrice * Convert.ToInt32(tb_service_price.Text);
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL SET ServicePriceTotal = ServicePriceTotal + @serviceChanged, Total = Total + @serviceChanged, MoneyLeft = MoneyLeft + @serviceChanged WHERE IdBill = @idWedding", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@serviceChanged", newServicePrice);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            tb_service_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE SERVICE_DETAIL SET AmountOfService = @AmountOfServide, TotalServicePrice = @TotalServicePrice WHERE IdWedding = @idWedding AND IdService = @idService", sql))
                            {
                                cmd.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                cmd.Parameters.AddWithValue("@idService", service.idService);
                                cmd.Parameters.AddWithValue("@AmountOfServide", Convert.ToInt32(tb_service_price.Text));
                                cmd.Parameters.AddWithValue("@TotalServicePrice", service.ServicePrice * Convert.ToInt32(tb_service_price.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newServicePrice = service.ServicePrice * Convert.ToInt32(tb_service_price.Text);
                                    long changes = newServicePrice - currentServicePrice;
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL SET ServicePriceTotal = ServicePriceTotal + @serviceChanged, Total = Total + @serviceChanged, MoneyLeft = MoneyLeft + @serviceChanged WHERE IdBill = @idWedding", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@idWedding", NhanTiec.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@serviceChanged", changes);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            tb_service_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please type amount of dish!", "LACK", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please add a wedding to choose services!", "LACK", MessageBoxButtons.OK);
            }
        }


        // sự kiện cho btn add wedding
        private void btn_add_wedding_Click(object sender, EventArgs e)
        {
            // get index of selected item from shift combobox
            int index = cbb_shift.SelectedIndex;
            if (index < 0 || index > WeddingClient.listShifts.Count)
            {
                MessageBox.Show("Please choose a shift!", "LACK", MessageBoxButtons.OK);
                return;
            }
            // get shift from listShift at index
            ShiftData shift = WeddingClient.listShifts[index];
            // get index of selected item from lobby combobox
            int indexLobby = cbb_lobby.SelectedIndex;
            // get lobbyType in listLobbyType at index
            if (indexLobby < 0 || indexLobby > WeddingClient.listLobbies.Count)
            {
                MessageBox.Show("Please choose a lobby!", "LACK", MessageBoxButtons.OK);
                return;
            }
            LobbyData lobby = WeddingClient.listLobbies[indexLobby];

            if (!IsLobbyAvailable(lobby.idLobby, shift.idShift))
            {
                MessageBox.Show("This lobby is not available at this shift!", "LACK", MessageBoxButtons.OK);
                return;
            }
            
            using(SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                // get price of the Type of Lobby that has IdLobby
                long typePrice = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT MinTablePrice FROM LOBBY_TYPE WHERE IdLobbyType = @IdLobbyType", sql))
                {
                    cmd.Parameters.AddWithValue("@IdLobbyType", lobby.idLobbyType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            typePrice = Convert.ToInt64(reader["MinTablePrice"]);
                        }
                    }
                }
                long basePrice = typePrice * (Convert.ToInt32(tb_table.Text) + Convert.ToInt32(tb_contigency.Text));
                string newId = "WD" + WeddingClient.GetNewIdFromTable("WD").ToString().PadLeft(19, '0');
                using (SqlCommand cmd = new SqlCommand("INSERT INTO WEDDING_INFOR (IdWedding, IdLobby, IdShift, BookingDate, WeddingDate, PhoneNumber, GroomName, BrideName, AmountOfTable, AmountOfContingencyTable, TablePrice, Deposit, Representative) VALUES (@idWedding, @idLobby, @idShift, @BookingDate, @WeddingDate, @PhoneNumber, @GroomName, @BrideName, @AmountOfTable, @AmountOfContingencyTable, @TablePrice, @Deposit, @representative )", sql))
                {
                    cmd.Parameters.AddWithValue("@idWedding", newId);
                    cmd.Parameters.AddWithValue("@idLobby", lobby.idLobby);
                    cmd.Parameters.AddWithValue("@idShift", shift.idShift);
                    cmd.Parameters.AddWithValue("@BookingDate", date_booking.Value);
                    cmd.Parameters.AddWithValue("@WeddingDate", date_wedding.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", tb_phone.Text);
                    cmd.Parameters.AddWithValue("@GroomName", tb_groom.Text);
                    cmd.Parameters.AddWithValue("@BrideName", tb_bride.Text);
                    cmd.Parameters.AddWithValue("@AmountOfTable", Convert.ToInt32(tb_table.Text));
                    cmd.Parameters.AddWithValue("@AmountOfContingencyTable", Convert.ToInt32(tb_contigency.Text));
                    cmd.Parameters.AddWithValue("@TablePrice", basePrice);
                    cmd.Parameters.AddWithValue("@Deposit", Convert.ToInt64(tb_deposit.Text));
                    cmd.Parameters.AddWithValue("@representative", tb_representative.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        using(SqlCommand cmd2 = new SqlCommand("INSERT INTO BILL (IdBill, InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, PaymentDate, MoneyLeft, Staff) VALUES (@idBill, @InvoiceDate, @TablePricetotal, @ServicePriceTotal, @Total, @PaymentDate, @MoneyLeft, NULL) ", sql))
                        {
                            cmd2.Parameters.AddWithValue("@idBill", newId);
                            cmd2.Parameters.AddWithValue("@InvoiceDate", date_wedding.Value);
                            cmd2.Parameters.AddWithValue("@TablePricetotal", 0);
                            cmd2.Parameters.AddWithValue("@ServicePriceTotal", 0);
                            cmd2.Parameters.AddWithValue("@Total", basePrice);
                            cmd2.Parameters.AddWithValue("@PaymentDate", DBNull.Value);
                            cmd2.Parameters.AddWithValue("@MoneyLeft", basePrice - Convert.ToInt64(tb_deposit.Text));
                            if (cmd2.ExecuteNonQuery() > 0)
                            {
                                DataRow row = table1.NewRow();
                                row.ItemArray = new object[] { lobby.LobbyName, shift.name, tb_representative.Text, tb_phone.Text, date_booking.Value.ToString(), date_wedding.Value.ToString(), tb_groom.Text, tb_bride.Text, tb_table.Text, tb_contigency.Text, basePrice, tb_deposit.Text, newId };
                                table1.Rows.Add(row);
                                MessageBox.Show("Add wedding successfully!", "SUCCESS", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Fail to add wedding!", "FAIL", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private bool IsLobbyAvailable(string idLobby, string idShift)
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM WEDDING_INFOR WHERE IdLobby = @idLobby AND IdShift = @idShift AND Available is NULL", sql))
                {
                    cmd.Parameters.AddWithValue("@idLobby", idLobby);
                    cmd.Parameters.AddWithValue("@idShift", idShift);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        // set sự kiện cho btn delete wedding
        private void btn_delete_wedding_Click(object sender, EventArgs e)
        {
            // chck if currentWeddingId is not null and length is 21
            if (currentWeddingId != null && currentWeddingId.Length == 21)
            {
                using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    sql.Open();
                    // complete command for me
                    using (SqlCommand cmd = new SqlCommand("UPDATE WEDDING_INFOR set Available = 0 WHERE IdWedding = @idWedding", sql))
                    {
                        cmd.Parameters.AddWithValue("@idWedding", currentWeddingId);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            //Load_data_wedding();
                            // delete row in table1
                            //dataWedding.Rows.RemoveAt(dataWedding.CurrentRow.Index);
                            table1.Rows.RemoveAt(dataWedding.CurrentRow.Index);
                            MessageBox.Show("Wedding deleted!", "SUCCESS", MessageBoxButtons.OK);
                            NhanTiec.currentWeddingId = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a wedding to delete!", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void NhanTiec_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_booking_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wedding_Enter(object sender, EventArgs e)
        {

        }

        private void dataWedding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox_menu_Enter(object sender, EventArgs e)
        {

        }

        private void label_tittle_wedding_in4_Click(object sender, EventArgs e)
        {

        }
    }
}
