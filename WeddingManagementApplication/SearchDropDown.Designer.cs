namespace WeddingManagementApplication
{
    partial class SearchDropDown
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnWedding = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnShift);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Controls.Add(this.btnWedding);
            this.flowLayoutPanel1.Controls.Add(this.bill);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 167);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.Color.IndianRed;
            this.btnShift.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnShift.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShift.Location = new System.Drawing.Point(3, 3);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(155, 35);
            this.btnShift.TabIndex = 2;
            this.btnShift.Text = "Shift";
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.IndianRed;
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccount.Location = new System.Drawing.Point(3, 44);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(155, 35);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnWedding
            // 
            this.btnWedding.BackColor = System.Drawing.Color.IndianRed;
            this.btnWedding.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnWedding.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWedding.Location = new System.Drawing.Point(3, 85);
            this.btnWedding.Name = "btnWedding";
            this.btnWedding.Size = new System.Drawing.Size(155, 35);
            this.btnWedding.TabIndex = 4;
            this.btnWedding.Text = "Wedding";
            this.btnWedding.UseVisualStyleBackColor = false;
            this.btnWedding.Click += new System.EventHandler(this.btnWedding_Click);
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.Color.IndianRed;
            this.bill.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.bill.ForeColor = System.Drawing.SystemColors.Control;
            this.bill.Location = new System.Drawing.Point(3, 126);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(155, 35);
            this.bill.TabIndex = 5;
            this.bill.Text = "Bill";
            this.bill.UseVisualStyleBackColor = false;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // SearchDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SearchDropDown";
            this.Size = new System.Drawing.Size(161, 167);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnWedding;
        private System.Windows.Forms.Button bill;
    }
}
