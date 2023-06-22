using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    public partial class FormBill : Form
    {
        public FormBill()
        {               
            InitializeComponent();
            tb_lobby_price.ReadOnly = true;
            tb_moneyLeft.ReadOnly = true;
            tb_penalty.ReadOnly = false;
            tb_phone.ReadOnly = true;
            tb_representative.ReadOnly = true;
            tb_serviceTotal.ReadOnly = true;
            tb_tableTotal.ReadOnly = true;
            tb_total.ReadOnly = true;


            // make invoice date time picker readonly
            invoiceDTP.Enabled = false;

        }

        private void pay_yes_Click(object sender, EventArgs e)
        {
            this.tb_moneyLeft.Text = "0";
        }

        private void pay_no_Click(object sender, EventArgs e)
        {
            if (rBtn_yes.Checked)
            {
                tb_moneyLeft.Text = penaltyTotal.ToString();
            }
            else
            {
                if (currentMoneyLeft > 0)
                    tb_moneyLeft.Text = baseTotal.ToString();
                else
                    tb_moneyLeft.Text = "0";
            }
        }

        public string id;
        public long currentMoneyLeft = 0;

        public FormBill(string id) : this()
        {
            this.id = id;
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using(SqlCommand cmd = new SqlCommand("SELECT Value FROM PARAMETER WHERE IdParamater = 'PenaltyRate'", sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_penalty.Text = reader.GetInt32(0).ToString();
                        }
                    }
                }
                using (SqlCommand sqlcomm = new SqlCommand("SELECT W.Representative, W.PhoneNumber, W.TablePrice, B.TablePriceTotal, B.ServicePriceTotal, B.Total, B.InvoiceDate, B.PaymentDate, B.MoneyLeft FROM BILL B, WEDDING_INFOR W WHERE IdWedding = IdBill AND IdBill = @id", sql))
                {
                    sqlcomm.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = sqlcomm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_representative.Text = reader.GetString(0);
                            tb_phone.Text = reader.GetString(1);
                            tb_lobby_price.Text = reader.GetInt64(2).ToString();
                            tb_tableTotal.Text = reader.GetInt64(3).ToString();
                            tb_serviceTotal.Text = reader.GetInt64(4).ToString();
                            tb_total.Text = reader.GetInt64(5).ToString();
                            baseTotal = reader.GetInt64(5);
                            invoiceDTP.Value = reader.GetDateTime(6);
                            paymentDTP.Value = reader[7] != DBNull.Value ? reader.GetDateTime(7) : DateTime.Now;
                            tb_moneyLeft.Text = reader.GetInt64(8).ToString();
                            this.currentMoneyLeft = reader.GetInt64(8);
                            if (currentMoneyLeft <= 0)
                            {
                                // disable radio buttons
                                rBtn_yes.Enabled = false;
                                rBtn_no.Enabled = false;
                                pay_yes.Enabled = false;
                                pay_no.Enabled = false;
                                rBtn_yes.Checked = false;
                                rBtn_no.Checked = false;
                                pay_yes.Checked = false;
                                pay_no.Checked = false;
                                
                                tb_penalty.ReadOnly = true;

                                // make payment date time picker readonly
                                paymentDTP.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private long trueBaseTotal;
        
        public long baseTotal { 
            get
            {
                return trueBaseTotal;
            }
            set
            {
                trueBaseTotal = value;
            } 
        }

        public long penaltyTotal
        {
            get
            {
                TimeSpan timeSpan = paymentDTP.Value - invoiceDTP.Value;
                if (int.TryParse(tb_penalty.Text, out int penalty))
                {
                    return (long)(timeSpan.Days * (penalty*1.0/100) * baseTotal + baseTotal);
                }
                else
                {
                    return baseTotal;
                }
            }
        }

        private void RBtn_yes_Click(object sender, EventArgs e)
        {
            tb_moneyLeft.Text = penaltyTotal.ToString();
        }

        private void RBtn_no_Click(object sender, EventArgs e)
        {
            if (currentMoneyLeft > 0)
                tb_moneyLeft.Text = baseTotal.ToString();
            else
                tb_moneyLeft.Text = "0";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // save all bill data to database
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                if (pay_yes.Checked)
                {
                    if (rBtn_yes.Checked && int.TryParse(tb_penalty.Text, out int penalty))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE BILL SET Total = @Total, PaymentDate = @PaymentDate, MoneyLeft = 0 WHERE IdBill = @IdBill", sql))
                        {
                            cmd.Parameters.AddWithValue("@Total", tb_total.Text);
                            cmd.Parameters.AddWithValue("@PaymentDate", paymentDTP.Value);
                            cmd.Parameters.AddWithValue("@IdBill", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Saved!");
                        }
                    }
                    else if (rBtn_no.Checked)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE BILL SET PaymentDate = @PaymentDate, MoneyLeft = 0 WHERE IdBill = @IdBill", sql))
                        {
                            cmd.Parameters.AddWithValue("@PaymentDate", paymentDTP.Value);
                            cmd.Parameters.AddWithValue("@IdBill", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Saved!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter penalty");
                    }
                }
                else
                {
                    MessageBox.Show("Saved!");
                    this.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
