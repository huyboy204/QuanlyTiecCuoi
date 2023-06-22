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
    public partial class Dishes : UserControl
    {
        public Menu menu;
        public string id = "";
        public Dishes()
        {
            InitializeComponent();
        }
        public Dishes(Menu menu)
        {
            this.menu = menu;
            this.id = menu.idDishes;
            InitializeComponent();
            this._lbNameText = menu.DishesName;
            this._lbPriceText = menu.DishesPrice.ToString();
            this._btnClick = false;
        }
        public string _lbNameText
        {
            get { return this.lbName.Text; }

            set
            {
                this.lbName.Text = value;
            }
        }
        public string _lbPriceText
        {
            get { return this.lbCost.Text; }

            set
            {
                this.lbCost.Text = value + "VND";
                this.menu.DishesPrice = Int64.Parse(value);
            }
        }

        public bool _btnClick
        {
            get { return this.btnClick.Visible; }
            set { this.btnClick.Visible = value; }
        }

        public string _imgPath
        {
            get
            {
                return this.BackgroundImage.ToString();
            }
            set
            {
                this.BackgroundImage = Image.FromFile(value);
            }
        }
        private void Dishes_Click(object sender, EventArgs e)
        {
            if (this.btnClick.Visible == true)
            {
                this.btnClick.Visible = false;
            //    FormDishes.selectedDishesIDs.TryRemove(this.id, out byte _);
            }
            else
            {
                this.btnClick.Visible = true;
                this.BorderStyle = BorderStyle.FixedSingle;
             //   FormDishes.selectedDishesIDs.AddOrUpdate(this.id, 0, (key, oldValue) => 0);
            }
        }

        private void lbCost_Click(object sender, EventArgs e)
        {

        }
    }
}
