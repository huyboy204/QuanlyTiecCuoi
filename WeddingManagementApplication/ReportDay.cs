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
    public partial class ReportDay : Form
    {

        public static string currentReportId = "";
        public static int currentReportDay = 0;
        DataTable table1 = new DataTable();
        public ReportDay()
        {
            InitializeComponent();
            ReportLoad();
        }
        
        private void ReportLoad()
        {
            table1 =  new  DataTable();
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT D.IdReport, D.Day, R.Month, D.DayRevenue, R.RevenueToTal, D.AmoutOfWedding FROM REVENUE_REPORT R, REVENUE_REPORT_DT D", sql)) 
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table1);
                    }
                }
            }
            table1.Columns[0].ColumnMapping = MappingType.Hidden;
            table1.Columns[1].Caption = "Day";
            table1.Columns[2].Caption = "Month";
            table1.Columns[3].Caption = "Day Revenue";
            table1.Columns[4].Caption = "Month Revenue";
            table1.Columns[5].Caption = "Amout Of Wedding";
            DataColumn column = new DataColumn("Ratio", typeof(float));
            column.Caption = "Ratio";
            table1.Columns.Add(column);
            foreach (DataRow row in table1.Rows)
            {
                row["Ratio"] = Convert.ToSingle(row["DayRevenue"]) / Convert.ToSingle(row["RevenueToTal"]);
            }
            dataRPD.DataSource = table1;
            foreach (DataGridViewColumn col in dataRPD.Columns)
            {
                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
            }
            dataRPD.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataWedding_RowHeaderMouseClick);
            
        }
        private void dataWedding_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get the row of the cell clicked from dataGridView1
            var rowItem = (DataRowView)dataRPD.Rows[e.RowIndex].DataBoundItem;
            // find the row of the cell clicked in table
            int i = table1.Rows.IndexOf(rowItem.Row);
            DataRow row = table1.Rows[i];
            
            // select weddingID
            currentReportId = row["idReport"].ToString();
            currentReportDay = (short)row["Day"];
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int index = comboBoxDay.SelectedIndex;
            int index2 = comboBoxMonth.SelectedIndex;
            if (!int.TryParse(textBoxYear.Text, out int year)) {
                MessageBox.Show("Please enter year number correctly!", "ERROR!", MessageBoxButtons.OK);
                return;
            }
            if (index < 0 || index2 < 0)
            {
                MessageBox.Show("Please fill full the fields!");
                return;
            }
            if (!int.TryParse(comboBoxDay.SelectedItem.ToString(), out int day))
            {
                MessageBox.Show("Input error: Day!", "ERROR", MessageBoxButtons.OK);
            }
            if (!int.TryParse(comboBoxMonth.SelectedItem.ToString(), out int month))
            {
                MessageBox.Show("Input error: Month!", "ERROR", MessageBoxButtons.OK);
            }
            GetRevenue(year, month, day);
            ReportLoad();
        }

        public static void GetRevenue(int year, int month, int day, bool silent = false)
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                long total = 0;
                int count = 0;
                string Id = "";

                using (SqlCommand cmd2 = new SqlCommand("SELECT * from BILL where (DAY(PaymentDate)=@day and Month(PaymentDate)=@month and Year(PaymentDate)=@year) AND MoneyLeft <= 0", sql))
                {
                    cmd2.Parameters.AddWithValue("@day", day);
                    cmd2.Parameters.AddWithValue("@month", month);
                    cmd2.Parameters.AddWithValue("@year", year);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            total += (long)reader["Total"];
                            count += 1;
                        }
                    }
                }
                bool existed = false;
                using (SqlCommand cmd2 = new SqlCommand("SELECT * FROM REVENUE_REPORT WHERE Month = @month AND Year = @year", sql))
                {
                    cmd2.Parameters.AddWithValue("@month", month);
                    cmd2.Parameters.AddWithValue("@year", year);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader["idReport"].ToString();
                            existed = true;
                        }
                        else
                        {
                            Id = "RR" + WeddingClient.GetNewIdFromTable("RR").ToString();
                        }
                    }
                }
                if (!existed) // month not found, add
                {
                    using (SqlCommand cmd2 = new SqlCommand("INSERT INTO REVENUE_REPORT (IdReport, Month, Year, RevenueTotal) VALUES (@id, @month, @year, 0) ", sql))
                    {
                        cmd2.Parameters.AddWithValue("@id", Id);
                        cmd2.Parameters.AddWithValue("@month", month);
                        cmd2.Parameters.AddWithValue("@year", year);
                        if (cmd2.ExecuteNonQuery() > 0)
                        {
                            using (SqlCommand cmd3 = new SqlCommand("Insert into REVENUE_REPORT_DT(IdReport,Day,DayRevenue,AmoutOfWedding) values(@id, @day, @rday, @amout)", sql))
                            {
                                cmd3.Parameters.AddWithValue("@id", Id);
                                cmd3.Parameters.AddWithValue("@day", day);
                                cmd3.Parameters.AddWithValue("@rday", total);
                                cmd3.Parameters.AddWithValue("@amout", count);
                                if (cmd3.ExecuteNonQuery() > 0)
                                {
                                    using (SqlCommand cmd4 = new SqlCommand("UPDATE REVENUE_REPORT SET RevenueTotal = RevenueTotal + @plus WHERE IdReport = @Id", sql))
                                    {
                                        cmd4.Parameters.AddWithValue("@plus", total);
                                        cmd4.Parameters.AddWithValue("@Id", Id);
                                        if (cmd4.ExecuteNonQuery() > 0)
                                        {
                                            //textBoxAOW.Text = count.ToString();
                                            //textBoxDayRevenue.Text = total.ToString();
                                            if (!silent) MessageBox.Show("Add new day report successfully!", "SUCCESS", MessageBoxButtons.OK);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else // month found, update
                {
                    using (SqlCommand cmd2 = new SqlCommand("SELECT DayRevenue FROM REVENUE_REPORT_DT WHERE IdReport = @Id AND Day = @day", sql))
                    {
                        cmd2.Parameters.AddWithValue("@Id", Id);
                        cmd2.Parameters.AddWithValue("@day", day);
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.Read()) // day found, update
                            {
                                long oldRevenue = (long)reader["DayRevenue"];
                                using (SqlCommand cmd3 = new SqlCommand("UPDATE REVENUE_REPORT_DT SET DayRevenue = @rday, AmoutOfWedding = @amout WHERE IdReport = @Id AND Day = @day", sql))
                                {
                                    cmd3.Parameters.AddWithValue("@rday", total);
                                    cmd3.Parameters.AddWithValue("@amout", count);
                                    cmd3.Parameters.AddWithValue("@Id", Id);
                                    cmd3.Parameters.AddWithValue("@day", day);
                                    if (cmd3.ExecuteNonQuery() > 0)
                                    {
                                        using (SqlCommand cmd4 = new SqlCommand("UPDATE REVENUE_REPORT SET RevenueTotal = RevenueTotal + @plus WHERE IdReport = @Id", sql))
                                        {
                                            cmd4.Parameters.AddWithValue("@plus", total - oldRevenue);
                                            cmd4.Parameters.AddWithValue("@Id", Id);
                                            if (cmd4.ExecuteNonQuery() > 0)
                                            {
                                                //textBoxAOW.Text = count.ToString();
                                                //textBoxDayRevenue.Text = total.ToString();
                                                if (!silent) MessageBox.Show("Add new day report successfully" , "SUCCESS", MessageBoxButtons.OK);
                                            }
                                        }
                                    }
                                }
                            }
                            else // day not found, add
                            {
                                using (SqlCommand cmd3 = new SqlCommand("Insert into REVENUE_REPORT_DT(IdReport,Day,DayRevenue,AmoutOfWedding) values(@id, @day, @rday, @amout)", sql))
                                {
                                    cmd3.Parameters.AddWithValue("@id", Id);
                                    cmd3.Parameters.AddWithValue("@day", day);
                                    cmd3.Parameters.AddWithValue("@rday", total);
                                    cmd3.Parameters.AddWithValue("@amout", count);
                                    if (cmd3.ExecuteNonQuery() > 0)
                                    {
                                        using (SqlCommand cmd4 = new SqlCommand("UPDATE REVENUE_REPORT SET RevenueTotal = RevenueTotal + @plus WHERE IdReport = @Id", sql))
                                        {
                                            cmd4.Parameters.AddWithValue("@plus", total);
                                            cmd4.Parameters.AddWithValue("@Id", Id);
                                            if (cmd4.ExecuteNonQuery() > 0)
                                            {
                                                //textBoxAOW.Text = count.ToString();
                                                //textBoxDayRevenue.Text = total.ToString();
                                                if (!silent) MessageBox.Show("Add new day report successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ReportDay_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_rpDay_Click(object sender, EventArgs e)
        {
            if(rBtn_day.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT D.IdReport, D.Day, R.Month, D.DayRevenue, R.RevenueToTal, D.AmoutOfWedding FROM REVENUE_REPORT R, REVENUE_REPORT_DT D WHERE D.IdReport = R.IdReport AND D.Day LIKE @searchRPD";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchRPD", "%" + tb_seacrh_rpDay.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            DataColumn[] keys = new DataColumn[2];
                            keys[0] = table1.Columns["IdReport"];
                            keys[1] = table1.Columns["Day"];
                            table1.PrimaryKey = keys;
                            table1.Columns[0].ColumnMapping = MappingType.Hidden;
                            table1.Columns[1].Caption = "Day";
                            table1.Columns[2].Caption = "Month";
                            table1.Columns[3].Caption = "Day Revenue";
                            table1.Columns[4].Caption = "Month Revenue";
                            table1.Columns[5].Caption = "Amout Of Wedding";
                            DataColumn column = new DataColumn("Ratio", typeof(float));
                            column.Caption = "Ratio";
                            table1.Columns.Add(column);
                            for (int i = 0; i < table1.Rows.Count; i++)
                            {
                                table1.Rows[i]["Ratio"] = Convert.ToSingle(table1.Rows[i]["DayRevenue"]) / Convert.ToSingle(table1.Rows[i]["RevenueToTal"]);
                            }
                            dataRPD.DataSource = table1;
                            foreach (DataGridViewColumn col in dataRPD.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
            /*
            if(rBtn_amount.Checked)
            {
                using (SqlConnection sqlconn = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    string sqlquery = "SELECT Day, Month, Year, DayRevenue, Ratio, AmoutOfWedding" +
                        " FROM REVENUE_REPORT_DT RP_D, REVENUE_REPORT RP" +
                        " WHERE RP_D. IdReport = RP.IdReport AND AmoutOfWedding LIKE @searchRPD";
                    sqlconn.Open();
                    using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                    {
                        sqlcomm.Parameters.AddWithValue("@searchRPD", "%" + tb_seacrh_rpDay.Text + "%");
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcomm))
                        {
                            table1 = new DataTable();
                            sqlDataAdapter.Fill(table1);
                            DataColumn[] keys = new DataColumn[1];
                            keys[0] = table1.Columns["IdReport, Day"];
                            table1.PrimaryKey = keys;
                        //    table1.Columns["IdReport"].ColumnMapping = MappingType.Hidden;
                            dataRPD.DataSource = table1;
                            foreach (DataGridViewColumn col in dataRPD.Columns)
                            {
                                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
                            }
                        }
                    }
                }
            }
            */
        }
    }
}
