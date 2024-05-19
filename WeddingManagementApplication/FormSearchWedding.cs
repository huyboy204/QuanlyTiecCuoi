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
    public partial class FormSearchWedding : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Server=192.168.10.112;Database=ProductDB;User Id=sa;Password=20042001Huy@;MultipleActiveResultSets=true;";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();

        public FormSearchWedding()
        {
            InitializeComponent();
            load_gridView_wedding();
            load_gridView_bill();
        }

        void load_gridView_wedding()
        {
            conn = new SqlConnection(str);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT LobbyName, ShiftName, Representative, PhoneNumber, BookingDate, WeddingDate, BroomName, BrideName, AmountOfTable, " +
                "AmountOfContingencyTable, TablePrice, Deposit FROM LOBBY LB, SHIFT S, WEDDING_INFOR WD WHERE WD.idShift = S.idShift AND WD.idLobby = LB.idLobby ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataWedding.DataSource = table;
        }
        void load_gridView_bill()
        {
            conn = new SqlConnection(str);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Representative, BroomName, BrideName, InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, PaymentDate, MoneyLeft from WEDDING_INFOR W, BILL B where B.idWedding = W.idWedding ";
            // cmd.CommandText = "SELECT * FROM BILL";
            adapter.SelectCommand = cmd;
            table1.Clear();
            adapter.Fill(table1);
            dataBill.DataSource = table1;
        }



        private void tb_search_wd_textChange(object sender, EventArgs e)
        {
            if (rBtn_name.Checked)
            {
                // string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
                string mainconn = ConfigurationManager.AppSettings.Get("conString");
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select Representative, BroomName, BrideName, InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, PaymentDate, MoneyLeft " +
                    "from WEDDING_INFOR W, BILL B where B.idWedding = W.idWedding and BroomName like '%" + tb_search_wd.Text + "%' OR BrideName like '%" + tb_search_wd.Text + "%' OR Representative = '" + tb_search_wd.Text + "'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataWedding.DataSource = dt;
            }
            else if (rBtn_date.Checked)
            {
                // string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
                string mainconn = ConfigurationManager.AppSettings.Get("conString");
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select  Representative, BroomName, BrideName, InvoiceDate, TablePriceTotal, ServicePriceTotal, Total, PaymentDate, MoneyLeft" +
                    " from WEDDING_INFOR W, BILL B where B.idWedding = W.idWedding and WeddingDate like '%" + tb_search_wd.Text + "%'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataWedding.DataSource = dt;
            }

        }

        private void tb_search_bill_textChange(object sender, EventArgs e)
        {
            if (rBtn_name.Checked)
            {
                // string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
                string mainconn = ConfigurationManager.AppSettings.Get("conString");
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from WEDDING_INFOR where BroomName like '%" + tb_search_wd.Text + "%' OR BrideName like '%" + tb_search_wd.Text + "%' OR Representative = '" + tb_search_wd.Text + "'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataWedding.DataSource = dt;
            }
            else if (rBtn_date.Checked)
            {
                // string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
                string mainconn = ConfigurationManager.AppSettings.Get("conString");
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from WEDDING_INFOR where WeddingDate like '%" + tb_search_wd.Text + "%'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataWedding.DataSource = dt;
            }
        }
    }
}
