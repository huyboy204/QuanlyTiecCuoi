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
    public partial class LobbyDropDown : UserControl
    {
        public LobbyDropDown()
        {
            InitializeComponent();
        }

        private void btnLobbyType_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLobbyType frm = new FormLobbyType();
            frm.ShowDialog();
        }

        private void btnLobby_Click(object sender, EventArgs e)
        {
            FormLobby frm = new FormLobby();
            frm.ShowDialog();
            this.Visible=false;
        }
    }
}
