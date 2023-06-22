using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    public partial class ReportDropDown : UserControl
    {
        public ReportDropDown()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReportDay frm = new ReportDay();
            frm.ShowDialog();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            RevenueReport frm = new RevenueReport();
            frm.ShowDialog();
            this.Visible=false;
        }
    }
}
