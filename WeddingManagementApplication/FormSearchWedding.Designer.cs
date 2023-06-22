
namespace WeddingManagementApplication
{
    partial class FormSearchWedding
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
            this.dataWedding = new System.Windows.Forms.DataGridView();
            this.label_search = new System.Windows.Forms.Label();
            this.dataBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtn_name = new System.Windows.Forms.RadioButton();
            this.rBtn_date = new System.Windows.Forms.RadioButton();
            this.tb_search_bill = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_search_wd = new WeddingManagementApplication.CustomeBorderTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataWedding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataWedding
            // 
            this.dataWedding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWedding.Location = new System.Drawing.Point(12, 145);
            this.dataWedding.Name = "dataWedding";
            this.dataWedding.RowHeadersWidth = 51;
            this.dataWedding.RowTemplate.Height = 24;
            this.dataWedding.Size = new System.Drawing.Size(537, 324);
            this.dataWedding.TabIndex = 1;
            // 
            // label_search
            // 
            this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.Crimson;
            this.label_search.Location = new System.Drawing.Point(127, 19);
            this.label_search.Margin = new System.Windows.Forms.Padding(0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(318, 54);
            this.label_search.TabIndex = 16;
            this.label_search.Text = "SEARCH WEDDING";
            // 
            // dataBill
            // 
            this.dataBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBill.Location = new System.Drawing.Point(574, 145);
            this.dataBill.Name = "dataBill";
            this.dataBill.RowHeadersWidth = 51;
            this.dataBill.RowTemplate.Height = 24;
            this.dataBill.Size = new System.Drawing.Size(537, 324);
            this.dataBill.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(726, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "SEARCH BILL";
            // 
            // rBtn_name
            // 
            this.rBtn_name.AutoSize = true;
            this.rBtn_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_name.Location = new System.Drawing.Point(240, 112);
            this.rBtn_name.Name = "rBtn_name";
            this.rBtn_name.Size = new System.Drawing.Size(345, 27);
            this.rBtn_name.TabIndex = 20;
            this.rBtn_name.TabStop = true;
            this.rBtn_name.Text = "Groom name, bride name, representative";
            this.rBtn_name.UseVisualStyleBackColor = true;
            // 
            // rBtn_date
            // 
            this.rBtn_date.AutoSize = true;
            this.rBtn_date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_date.Location = new System.Drawing.Point(633, 112);
            this.rBtn_date.Name = "rBtn_date";
            this.rBtn_date.Size = new System.Drawing.Size(138, 27);
            this.rBtn_date.TabIndex = 21;
            this.rBtn_date.TabStop = true;
            this.rBtn_date.Text = "Wedding date";
            this.rBtn_date.UseVisualStyleBackColor = true;
            // 
            // tb_search_bill
            // 
            this.tb_search_bill.Location = new System.Drawing.Point(671, 80);
            this.tb_search_bill.Name = "tb_search_bill";
            this.tb_search_bill.Size = new System.Drawing.Size(342, 22);
            this.tb_search_bill.TabIndex = 18;
            this.tb_search_bill.TextChanged += new System.EventHandler(this.tb_search_bill_textChange);
            // 
            // tb_search_wd
            // 
            this.tb_search_wd.Location = new System.Drawing.Point(103, 80);
            this.tb_search_wd.Name = "tb_search_wd";
            this.tb_search_wd.Size = new System.Drawing.Size(342, 22);
            this.tb_search_wd.TabIndex = 0;
            this.tb_search_wd.TextChanged += new System.EventHandler(this.tb_search_wd_textChange);
            // 
            // searchWedding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1129, 488);
            this.Controls.Add(this.rBtn_date);
            this.Controls.Add(this.rBtn_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search_bill);
            this.Controls.Add(this.dataBill);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.dataWedding);
            this.Controls.Add(this.tb_search_wd);
            this.Name = "searchWedding";
            this.Text = "searchWedding";
            ((System.ComponentModel.ISupportInitialize)(this.dataWedding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomeBorderTextbox tb_search_wd;
        private System.Windows.Forms.DataGridView dataWedding;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.DataGridView dataBill;
        private CustomeBorderTextbox tb_search_bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn_name;
        private System.Windows.Forms.RadioButton rBtn_date;
    }
}