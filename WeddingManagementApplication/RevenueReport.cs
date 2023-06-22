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

namespace WeddingManagementApplication
{
    public partial class RevenueReport : Form
    {
        public static string currentReportId = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        public RevenueReport()
        {
            InitializeComponent();
            LoadReportData();
        }
        private void LoadReportData()
        {
            this.rBtn_month.Checked = true;
            this.rBtn_year.Checked = false;
            Search();
        }
        private void dataWedding_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // select weddingID
            currentReportId = table1.Rows[e.RowIndex]["idReport"].ToString();
            Console.WriteLine(NhanTiec.currentWeddingId);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBoxMonth.SelectedIndex;
            if (index < 0 || textBox1.Text == "" || !int.TryParse(comboBoxMonth.SelectedItem.ToString(), out int month) || !int.TryParse(textBox1.Text, out int year))
            {
                MessageBox.Show("Please fill enough information and make sure month and year are numbers and month is between 1 and 12");
                return;
            }
            bool inserted = false;
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd2 = new SqlCommand("SELECT  * FROM REVENUE_REPORT WHERE (Month=@month and Year=@year) ", sql))
                {
                    cmd2.Parameters.AddWithValue("@month", month);
                    cmd2.Parameters.AddWithValue("@year", year);
                    using (SqlDataReader dr = cmd2.ExecuteReader())
                    {
                        long total = 0;
                        //MessageBox.Show(dr.HasRows.ToString());
                        if (dr.HasRows)
                        {
                            String ID = "";
                            while (dr.Read())
                            {
                                ID = dr["IdReport"].ToString();
                                //MessageBox.Show(ID);
                            }
                            dr.Close();
                            using (SqlCommand cmd3 = new SqlCommand("select * from REVENUE_REPORT_DT WHERE IdReport = @id", sql))
                            {
                                cmd3.Parameters.AddWithValue("@id", ID);
                                using(SqlDataReader reader = cmd3.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        total += long.Parse(reader["DayRevenue"].ToString());
                                    }
                                }

                            }
                            using (SqlCommand cmd3 = new SqlCommand("UPDATE REVENUE_REPORT SET RevenueTotal = @total WHERE IdReport = @id", sql))
                            {
                                cmd3.Parameters.AddWithValue("@id", ID);
                                cmd3.Parameters.AddWithValue("@total", total);
                                if (cmd3.ExecuteNonQuery() > 0)
                                {
                                    Search("");
                                    MessageBox.Show("Create new report successfully!", "SUCCESS", MessageBoxButtons.OK);
                                }
                            }
                            inserted = true;
                        }
                        else
                        {
                            // complete command for me
                            string newId = "RR" + WeddingClient.GetNewIdFromTable("RR").ToString();
                            using (SqlCommand cmd3 = new SqlCommand("INSERT INTO REVENUE_REPORT (IdReport, Month, year, RevenueTotal) VALUES (@id, @month, @year, @total) ", sql))
                            {
                                cmd3.Parameters.AddWithValue("@id", newId);
                                cmd3.Parameters.AddWithValue("@month", month);
                                cmd3.Parameters.AddWithValue("@year", year);
                                cmd3.Parameters.AddWithValue("@total", 0);
                                if (cmd3.ExecuteNonQuery() > 0)
                                {
                                    inserted = true;
                                    //Search("");
                                    MessageBox.Show("Create new report successfully!", "SUCCESS", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Fail to create new report!", "FAIL", MessageBoxButtons.OK);
                                }
                            }


                        }
                    }  
                }
            }    

            if (inserted)
            {
                for(int i = 1; i<=DateTime.DaysInMonth(year, month); i++)
                {
                    ReportDay.GetRevenue(year, month, i, true);
                }
                Search("");
            }
        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {

        }

        private void img_close_service_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search(string s)
        {
            if (rBtn_month.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT Month, Year, RevenueTotal" +
                        " FROM REVENUE_REPORT RP" +
                        " WHERE Month LIKE @searchRP";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchRP", "%" + s + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            DataColumn[] keys = new DataColumn[1];
                            keys[0] = table1.Columns["IdReport"];
                            table1.PrimaryKey = keys;
                            //   table1.Columns["IdReport"].ColumnMapping = MappingType.Hidden;
                            dataRPMonth.DataSource = table1;
                            foreach (DataGridViewColumn col in dataRPMonth.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
            if (rBtn_year.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT Month, Year, RevenueTotal" +
                        " FROM REVENUE_REPORT RP" +
                        " WHERE Year LIKE @searchRP";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchRP", "%" + s + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            DataColumn[] keys = new DataColumn[1];
                            keys[0] = table1.Columns["IdReport"];
                            table1.PrimaryKey = keys;
                            //    table1.Columns["IdReport"].ColumnMapping = MappingType.Hidden;
                            dataRPMonth.DataSource = table1;
                            foreach (DataGridViewColumn col in dataRPMonth.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
        }

        private void Search()
        {
            if (rBtn_month.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT Month, Year, RevenueTotal" +
                        " FROM REVENUE_REPORT RP" +
                        " WHERE Month LIKE @searchRP";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchRP", "%" + tb_seacrh_rpMonth.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            DataColumn[] keys = new DataColumn[1];
                            keys[0] = table1.Columns["IdReport"];
                            table1.PrimaryKey = keys;
                            //   table1.Columns["IdReport"].ColumnMapping = MappingType.Hidden;
                            dataRPMonth.DataSource = table1;
                            foreach (DataGridViewColumn col in dataRPMonth.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
            if (rBtn_year.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT Month, Year, RevenueTotal" +
                        " FROM REVENUE_REPORT RP" +
                        " WHERE Year LIKE @searchRP";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchRP", "%" + tb_seacrh_rpMonth.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            DataColumn[] keys = new DataColumn[1];
                            keys[0] = table1.Columns["IdReport"];
                            table1.PrimaryKey = keys;
                            //    table1.Columns["IdReport"].ColumnMapping = MappingType.Hidden;
                            dataRPMonth.DataSource = table1;
                            foreach (DataGridViewColumn col in dataRPMonth.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
        }

        private void btn_search_rpMonth_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
