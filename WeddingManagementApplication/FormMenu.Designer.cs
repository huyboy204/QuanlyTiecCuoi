namespace WeddingManagementApplication
{
    partial class FormMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuItem1 = new WeddingManagementApplication.MenuItem();
            this.menuItem2 = new WeddingManagementApplication.MenuItem();
            this.menuItem3 = new WeddingManagementApplication.MenuItem();
            this.menuItem4 = new WeddingManagementApplication.MenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuItem1);
            this.flowLayoutPanel1.Controls.Add(this.menuItem2);
            this.flowLayoutPanel1.Controls.Add(this.menuItem3);
            this.flowLayoutPanel1.Controls.Add(this.menuItem4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 610);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuItem1
            // 
            this.menuItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuItem1.Location = new System.Drawing.Point(3, 3);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(797, 125);
            this.menuItem1.TabIndex = 0;
            // 
            // menuItem2
            // 
            this.menuItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuItem2.Location = new System.Drawing.Point(3, 134);
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(797, 125);
            this.menuItem2.TabIndex = 1;
            // 
            // menuItem3
            // 
            this.menuItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuItem3.Location = new System.Drawing.Point(3, 265);
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(797, 125);
            this.menuItem3.TabIndex = 2;
            // 
            // menuItem4
            // 
            this.menuItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuItem4.Location = new System.Drawing.Point(3, 396);
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(797, 125);
            this.menuItem4.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(695, 613);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private System.Windows.Forms.Button btnExit;
    }
}