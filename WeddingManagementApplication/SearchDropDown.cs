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
    public partial class SearchDropDown : UserControl
    {
        public SearchDropDown()
        {
            InitializeComponent();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            FormShift frmS =new FormShift();
            frmS.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to access!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            FormAccount a = new FormAccount();
            a.ShowDialog();
        }

        private void btnWedding_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            searchWedding frmS = new searchWedding();
            frmS.ShowDialog();
        }

        private void bill_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormBill frmS = new FormBill();
            frmS.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormLobbyType frm = new FormLobbyType();
            frm.ShowDialog();
            this.Visible = false;
        }

        private void btnLobby_Click(object sender, EventArgs e)
        {
            FormLobby frm = new FormLobby();
            frm.ShowDialog();
            this.Visible = false;
        }

        private void btnLobbyType_Click(object sender, EventArgs e)
        {
            FormLobbyType frm = new FormLobbyType();
            frm.ShowDialog();
            this.Visible = false;
        }
    }
}
