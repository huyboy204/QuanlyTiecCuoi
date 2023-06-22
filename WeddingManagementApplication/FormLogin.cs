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
    
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void TextBoxUserName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // check if key is enter
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void TextBoxPassWord_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // check if key is enter
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login(object sender, EventArgs e)
        {
            if (this.EmptyTextBoxes())
            {
                if (EmptyTextBoxes())
                {
                    //labelWarning.Text = "Something is missing!";
                    Console.WriteLine("Something is missing!");
                    return;
                }
            }
            else
            {
                if (CheckInvalidUsernameCharacter())
                {
                    //labelWarning.Text = "User name or Password is incorrect";
                    Console.WriteLine("Invalid username");
                    return;
                }
                else
                {
                    if (CheckInvalidPasswordCharacter())
                    {
                        //labelWarning.Text = "User name or Password is incorrect";
                        Console.WriteLine("Invalid characters in password");
                        return;
                    }
                    else
                    {
                        if (!CorrectPassword())
                        {
                            //labelWarning.Text = "User name or Password is incorrect";
                            Console.WriteLine("Incorrect password");
                            return;
                        }
                    }
                }
            }
            //labelWarning.Text = "You have logged in successfully".ToUpper();
            //labelWarning.ForeColor = Color.FromArgb(37, 75, 133);
            Console.WriteLine("Form creating");
            var frm = new FormHome();
            frm.Location = new System.Drawing.Point(Screen.FromControl(this).WorkingArea.Width / 4, Screen.FromControl(this).WorkingArea.Height / 4);
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.FormClosing += delegate { this.Show(); this.Opacity = 1; };
            this.ResetTexts();
            frm.Show();
            this.Hide();
            Program.mainform = frm;
            Console.WriteLine("Client thread started");
        }

        private void ResetTexts()
        {
            textBoxUserName.Text = "";
            textBoxPassWord.Text = "";
        }

        private bool CorrectPassword()
        {
            bool res = WeddingClient.Logged_in(textBoxUserName.Text, textBoxPassWord.Text);
            return res;
        }

        private bool CheckInvalidPasswordCharacter()
        {
            foreach (char i in textBoxPassWord.Text)
            {
                if (!(i == 33 || i > 34 && i < 38 || i >= 42 && i <= 43 || i == 45 || i >= 48 && i <= 57 || i >= 64 && i <= 90 || i == 94 || i == 95 || i >= 97 && i <= 122))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckInvalidUsernameCharacter()
        {
            foreach (char i in textBoxUserName.Text)
            {
                if (!(i >= 48 && i <= 57 || i >= 65 && i <= 90 || i >= 97 && i <= 122 || i == 95))
                {
                    return true;
                }
            }
            return false;
        }

        private bool EmptyTextBoxes()
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxPassWord.Text))
            {
                return true;
            }
            return false;
        }
        Point lastPoint;
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
       
    }
}
