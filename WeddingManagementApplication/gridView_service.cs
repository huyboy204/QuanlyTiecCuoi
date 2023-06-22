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
    public partial class gridView_service : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string idWedding = "";

        public gridView_service(string idWedding)
        {
            this.idWedding = idWedding;
            InitializeComponent();
            load_data_service();
        }
        void load_data_service()
        {
            using(SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString)){
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT WD.IdWedding, Representative, ServiceName, AmountOfService,TotalServicePrice, SVD.Note FROM WEDDING_INFOR WD, SERVICE SV, SERVICE_DETAIL SVD WHERE WD.IdWedding = SVD.IdWedding AND SVD.IdService = SV.IdService AND WD.IdWedding = @idWedding", sql))
                {
                    cmd.Parameters.AddWithValue("@idWedding", idWedding);
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dataService.DataSource = table;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
