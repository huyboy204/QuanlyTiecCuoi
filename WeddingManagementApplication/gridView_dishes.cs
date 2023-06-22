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
    public partial class gridView_dishes : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string idWedding = "";
        public gridView_dishes(string idWedding)
        {
            this.idWedding = idWedding;
            InitializeComponent();
            load_data_dishes();
        }

        void load_data_dishes()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT WD.idWedding, Representative, dishesName, AmountOfDishes,TotalDishesPrice, TBD.Note FROM WEDDING_INFOR WD, MENU MN, TABLE_DETAIL TBD WHERE WD.idWedding = TBD.idWedding AND TBD.idDishes = MN.idDishes AND WD.idWedding = @idWedding", sql))
                {
                    cmd.Parameters.AddWithValue("@idWedding", idWedding);
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dataDishes.DataSource = table;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
