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
    public partial class Shift : UserControl
    {
        private string id="";
        
        public string _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _lbName
        {
            get { return this.lbName.Text; }
            set { this.lbName.Text = value; }    
        }
        public string _lbStart
        {
            get { return this.lbStart.Text; }
            set { this.lbStart.Text = value; }
        }
        public string _lbEnd
        {
            get { return this.lbEnd.Text; }
            set { this.lbEnd.Text = value; }
        }
        public string _lbStatus
        {
            get { return this.lbStatus.Text; }
            set { this.lbStatus.Text = value; }
        }
        public bool _btnCheck
        {
            get { return this.btnCheck.Visible; }
            set { this.btnCheck.Visible = value; }
        }
        public Shift()
        {
            InitializeComponent();
        }

        private void Shift_Click(object sender, EventArgs e)
        {
            this.btnCheck.Visible = !this.btnCheck.Visible;
            FormShift.onclick.Invoke(this);
        }

        private void Shift_Load(object sender, EventArgs e)
        {

        }
    }
}
