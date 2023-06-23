using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WeddingManagementApplication
{
    public partial class searchWedding : Form
    {
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();

        public searchWedding()
        {
            InitializeComponent();
            load_gridView_wedding();
            load_gridView_bill();

            dataWedding.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
     
        void load_gridView_wedding()
        {
            using (SqlConnection conn = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdWedding, WD.IdLobby, WD.IdShift, BookingDate bDate, WeddingDate wDate, LobbyName, ShiftName, Representative, PhoneNumber, FORMAT(BookingDate, 'dd/MM/yyyy') BookingDate, FORMAT(WeddingDate, 'dd/MM/yyyy') WeddingDate, GroomName, BrideName, AmountOfTable, AmountOfContingencyTable, TablePrice, Deposit FROM LOBBY LB, SHIFT S, WEDDING_INFOR WD WHERE WD.IdShift = S.IdShift AND WD.IdLobby = LB.IdLobby ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                        table.Columns["IdWedding"].ColumnMapping = MappingType.Hidden;
                        table.Columns["IdLobby"].ColumnMapping = MappingType.Hidden;
                        table.Columns["IdShift"].ColumnMapping = MappingType.Hidden;
                        table.Columns["bDate"].ColumnMapping = MappingType.Hidden;
                        table.Columns["wDate"].ColumnMapping = MappingType.Hidden;
                        table.Columns["ShiftName"].Caption = "Shift";
                        table.Columns["AmountOfTable"].Caption = "Table";
                        table.Columns["AmountOfContingencyTable"].Caption = "Contingency";
                        dataWedding.DataSource = table;
                        foreach (DataGridViewColumn col in dataWedding.Columns)
                        {
                            col.HeaderText = table.Columns[col.DataPropertyName].Caption;
                        }
                    }
                }
            }
        }
        void load_gridView_bill()
        {
            using (SqlConnection conn = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdWedding, W.IdShift, IdBill, W.IdLobby, InvoiceDate iDate, PaymentDate pDate, Representative, GroomName, BrideName, PhoneNumber, LobbyName, ShiftName, FORMAT(InvoiceDate, 'dd/MM/yyyy') InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, FORMAT(PaymentDate, 'dd/MM/yyyy') PaymentDate, MoneyLeft from WEDDING_INFOR W, BILL B, LOBBY LB, SHIFT S WHERE B.IdBill = W.IdWedding AND W.IdLobby = LB.IdLobby AND W.IdShift = S.IdShift ";
                    // cmd.CommandText = "SELECT * FROM BILL";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        table1 = new DataTable();
                        adapter.Fill(table1);
                        table1.Columns["IdWedding"].ColumnMapping = MappingType.Hidden;
                        table1.Columns["IdShift"].ColumnMapping = MappingType.Hidden;
                        table1.Columns["IdBill"].ColumnMapping = MappingType.Hidden;
                        table1.Columns["IdLobby"].ColumnMapping = MappingType.Hidden;
                        table1.Columns["iDate"].ColumnMapping = MappingType.Hidden;
                        table1.Columns["pDate"].ColumnMapping = MappingType.Hidden;
                        dataBill.DataSource = table1; 
                        foreach (DataGridViewColumn col in dataBill.Columns)
                        {
                            col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                        }
                    }
                }
            }
        }



        private void tb_search_wd_textChange(object sender, EventArgs e)
        {
            if (tb_search_wd.Text == "")
            {
                load_gridView_wedding();
                return;
            }
            if (rBtn_name.Checked)
            {
                Console.WriteLine(tb_search_wd.Text);
                using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT IdWedding, WD.IdLobby, WD.IdShift, BookingDate bDate, WeddingDate wDate, LobbyName, ShiftName, Representative, PhoneNumber, FORMAT(BookingDate, 'dd/MM/yyyy') BookingDate, FORMAT(WeddingDate, 'dd/MM/yyyy') WeddingDate, GroomName, BrideName, AmountOfTable, AmountOfContingencyTable, TablePrice, Deposit FROM LOBBY LB, SHIFT S, WEDDING_INFOR WD WHERE WD.IdShift = S.IdShift AND WD.IdLobby = LB.IdLobby AND (GroomName LIKE @searchWD OR BrideName LIKE @searchWD OR Representative LIKE @searchWD)";
                    sql.Open();
                    using (SqlCommand sqlcomm = sql.CreateCommand())
                    {
                        sqlcomm.CommandText = sqlquery;
                        sqlcomm.Parameters.AddWithValue("@searchWD", "%"+tb_search_wd.Text+"%");
                        Console.WriteLine(sqlcomm.ToString());
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table = new DataTable();
                            sqlDataAdapter.Fill(table);
                            table.Columns["IdWedding"].ColumnMapping = MappingType.Hidden;
                            table.Columns["IdLobby"].ColumnMapping = MappingType.Hidden;
                            table.Columns["IdShift"].ColumnMapping = MappingType.Hidden;
                            table.Columns["bDate"].ColumnMapping = MappingType.Hidden;
                            table.Columns["wDate"].ColumnMapping = MappingType.Hidden;
                            table.Columns["ShiftName"].Caption = "Shift";
                            table.Columns["AmountOfTable"].Caption = "Table";
                            table.Columns["AmountOfContingencyTable"].Caption = "Contingency";
                            dataWedding.DataSource = table;
                            foreach (DataGridViewColumn col in dataWedding.Columns)
                            {
                                col.HeaderText = table.Columns[col.DataPropertyName].Caption;
                            }
                            
                        }
                    }
                }
            }
            else if (rBtn_date.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT IdWedding, WD.IdLobby, WD.IdShift, BookingDate bDate, WeddingDate wDate, LobbyName, ShiftName, Representative, PhoneNumber, FORMAT(BookingDate, 'dd/MM/yyyy') BookingDate, FORMAT(WeddingDate, 'dd/MM/yyyy') WeddingDate, GroomName, BrideName, AmountOfTable, AmountOfContingencyTable, TablePrice, Deposit FROM LOBBY LB, SHIFT S, WEDDING_INFOR WD WHERE WD.IdShift = S.IdShift AND WD.IdLobby = LB.IdLobby AND (CONVERT(NVARCHAR(MAX), BookingDate, 103) LIKE @searchWD OR CONVERT(NVARCHAR(MAX), WeddingDate, 103) LIKE @searchWD)";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchWD", "%" + tb_search_wd.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table = new DataTable();
                            sqlDataAdapter.Fill(table);
                            table.Columns["IdWedding"].ColumnMapping = MappingType.Hidden;
                            table.Columns["IdLobby"].ColumnMapping = MappingType.Hidden;
                            table.Columns["IdShift"].ColumnMapping = MappingType.Hidden;
                            table.Columns["bDate"].ColumnMapping = MappingType.Hidden;
                            table.Columns["wDate"].ColumnMapping = MappingType.Hidden;
                            table.Columns["ShiftName"].Caption = "Shift";
                            table.Columns["AmountOfTable"].Caption = "Table";
                            table.Columns["AmountOfContingencyTable"].Caption = "Contingency";
                            dataWedding.DataSource = table;
                            foreach (DataGridViewColumn col in dataWedding.Columns)
                            {
                                col.HeaderText = table.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
           
        }

        private void tb_search_bill_textChange(object sender, EventArgs e)
        {
            // if text is ""
            if (tb_search_bill.Text == "")
            {
                load_gridView_bill();
                return;
            }
            if (rBtn_name.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT IdWedding, W.IdShift, IdBill, W.IdLobby, InvoiceDate iDate, PaymentDate pDate, Representative, GroomName, BrideName, PhoneNumber, LobbyName, ShiftName, FORMAT(InvoiceDate, 'dd/MM/yyyy') InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, FORMAT(PaymentDate, 'dd/MM/yyyy') PaymentDate, MoneyLeft from WEDDING_INFOR W, BILL B, LOBBY LB, SHIFT S WHERE B.IdBill = W.IdWedding AND W.IdLobby = LB.IdLobby AND W.IdShift = S.IdShift AND (GroomName LIKE @searchB OR BrideName LIKE @searchB OR Representative LIKE @searchB)";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchB", "%" + tb_search_bill.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            table1.Columns["IdWedding"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["IdShift"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["IdBill"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["IdLobby"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["iDate"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["pDate"].ColumnMapping = MappingType.Hidden;
                            dataBill.DataSource = table1; 
                            foreach (DataGridViewColumn col in dataBill.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
            else if (rBtn_date.Checked)
            {
                using (
                SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT IdWedding, W.IdShift, IdBill, W.IdLobby, InvoiceDate iDate, PaymentDate pDate, Representative, GroomName, BrideName, PhoneNumber, LobbyName, ShiftName, FORMAT(InvoiceDate, 'dd/MM/yyyy') InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, FORMAT(PaymentDate, 'dd/MM/yyyy') PaymentDate, MoneyLeft from WEDDING_INFOR W, BILL B, LOBBY LB, SHIFT S WHERE B.IdBill = W.IdWedding AND W.IdLobby = LB.IdLobby AND W.IdShift = S.IdShift AND (CONVERT(NVARCHAR(MAX), BookingDate, 103) LIKE @searchB OR CONVERT(NVARCHAR(MAX), PaymentDate, 103) LIKE @searchB)";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchB", "%" + tb_search_bill.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            table1.Columns["IdWedding"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["IdShift"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["IdBill"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["IdLobby"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["iDate"].ColumnMapping = MappingType.Hidden;
                            table1.Columns["pDate"].ColumnMapping = MappingType.Hidden;
                            dataBill.DataSource = table1;
                            foreach (DataGridViewColumn col in dataBill.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
        }

        private void dataWedding_CellDouBleClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if clicked row is not header 
            if (e.RowIndex > -1 && e.RowIndex < dataWedding.Rows.Count)
            {
                // get the row of the cell clicked from dataGridView1
                var rowItem = (DataRowView)dataWedding.Rows[e.RowIndex].DataBoundItem;
                // find the row of the cell clicked in table
                int index = table.Rows.IndexOf(rowItem.Row);
                // get selected row
                DataRow row = table.Rows[index];

                // get id of selected row
                string id = row["IdWedding"].ToString();

                // open dialog and ask if user want to edit wedding informations or pay for wedding
                DialogResult dialogResult = MessageBox.Show("Do you want to edit wedding informations or pay for wedding?", "Edit", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.No)
                {
                    // open form edit wedding informations
                    NhanTiec nt = new NhanTiec(id);
                    nt.Location = new System.Drawing.Point(Screen.FromControl(this).WorkingArea.Width / 4, Screen.FromControl(this).WorkingArea.Height / 4);
                    nt.StartPosition = FormStartPosition.CenterScreen;
                    nt.ShowDialog();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    // open form pay for wedding
                    this.Hide();
                    FormBill b = new FormBill(id);
                    b.ShowDialog();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void searchWedding_SizeChangedEvent(object sender, EventArgs e)
        {
            // get size of form
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // check if formWidth is divisible by 2
            if (formWidth % 2 == 0)
            {
                // if true, then set formWidth to formWidth - 1
                formWidth -= 1;
                this.ClientSize = new Size(formWidth, formHeight);
                return;
            }
            else
            {
                // set new size of each dataGridView 
                dataWedding.Size = new Size((formWidth - 18 - 39) / 2, dataWedding.Size.Height);
                dataBill.Size = new Size((formWidth - 18 - 39) / 2, dataBill.Size.Height);
                dataBill.Location = new Point(dataWedding.Location.X + dataWedding.Size.Width + 39, dataBill.Location.Y);
            }
        }

        private void searchWedding_ResizeBegin(object sender, EventArgs e)
        {
        }
        
        private void searchWedding_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
