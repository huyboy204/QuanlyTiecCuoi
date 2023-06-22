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
    public partial class Services : UserControl
    {
        public Service service = new Service();
        
        public Services(Service service)
        {
            this.service = service;
            InitializeComponent();
            this.tbName.Text = service.ServiceName;
            this.tbPrice.Text = service.ServicePrice.ToString() + " VND";
            this.tbDetail.Text = service.Note;
        }
        
        public Services()
        {
            InitializeComponent();
        }
        public string _tbName
        {
            get { return this.tbName.Text; }
            set { this.tbName.Text = value; this.service.ServiceName = value; }
        }
        public string _tbPrice
        {
            get { return this.tbPrice.Text; }
            set { this.tbPrice.Text = value + " VND"; this.service.ServicePrice = Convert.ToInt64(value); }
        }
        public string _tbDetail
        {
            get { return this.tbDetail.Text; }
            set { this.tbDetail.Text = value; this.service.Note = value; }
        }
        private void Services_Click(object sender, EventArgs e)
        {
            if (button1.Visible == true)
            {
                button1.Visible = false;
                FormServices.selectedServiceIDs.TryRemove(this.service.idService, out byte _);
            }
            else
            {
                button1.Visible = true;
                FormServices.selectedServiceIDs.TryAdd(this.service.idService, 0);
            }
        }
    }
}
