namespace WeddingManagementApplication
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.Label();
            this.tbDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(37, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên dịch vụ:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(37, 55);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(28, 16);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Giá:";
            // 
            // button1
            // 
            //this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.button1.Location = new System.Drawing.Point(772, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 43);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(143, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(286, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.AutoSize = true;
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(85, 55);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(72, 22);
            this.tbPrice.TabIndex = 4;
            // 
            // tbDetail
            // 
            this.tbDetail.MaximumSize = new System.Drawing.Size(288, 0);
            this.tbDetail.AutoSize = true;
            this.tbDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetail.Location = new System.Drawing.Point(445, 15);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(288, 99);
            this.tbDetail.TabIndex = 5;
            this.tbDetail.Text = "";
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Name = "Services";
            this.Size = new System.Drawing.Size(832, 128);
            this.Click += new System.EventHandler(this.Services_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tbName;
        private System.Windows.Forms.Label tbPrice;
        private System.Windows.Forms.Label tbDetail;
    }
}
