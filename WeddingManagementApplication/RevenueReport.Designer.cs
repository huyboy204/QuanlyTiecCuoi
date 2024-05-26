using System.Threading;
namespace WeddingManagementApplication
{
    partial class RevenueReport
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
            this.labelRReport = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxRTotal = new System.Windows.Forms.TextBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelRTotal = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.dataRPMonth = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.img_close_service = new System.Windows.Forms.Label();
            this.rBtn_month = new System.Windows.Forms.RadioButton();
            this.rBtn_year = new System.Windows.Forms.RadioButton();
            this.tb_seacrh_rpMonth = new System.Windows.Forms.TextBox();
            this.btn_search_rpMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRPMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRReport
            // 
            this.labelRReport.AutoSize = true;
            this.labelRReport.BackColor = System.Drawing.Color.Transparent;
            this.labelRReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.labelRReport.ForeColor = System.Drawing.Color.Firebrick;
            this.labelRReport.Location = new System.Drawing.Point(176, 59);
            this.labelRReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRReport.Name = "labelRReport";
            this.labelRReport.Size = new System.Drawing.Size(609, 51);
            this.labelRReport.TabIndex = 0;
            this.labelRReport.Text = "REVENUE REPORT MONTH";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 27);
            this.textBox1.TabIndex = 7;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelYear.ForeColor = System.Drawing.Color.Crimson;
            this.labelYear.Location = new System.Drawing.Point(272, 230);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(58, 28);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            // 
            // textBoxRTotal
            // 
            this.textBoxRTotal.Location = new System.Drawing.Point(673, 229);
            this.textBoxRTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRTotal.Name = "textBoxRTotal";
            this.textBoxRTotal.ReadOnly = true;
            this.textBoxRTotal.Size = new System.Drawing.Size(157, 27);
            this.textBoxRTotal.TabIndex = 3;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.DropDownWidth = 133;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(113, 233);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(133, 28);
            this.comboBoxMonth.TabIndex = 6;
            // 
            // labelRTotal
            // 
            this.labelRTotal.AutoSize = true;
            this.labelRTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelRTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelRTotal.ForeColor = System.Drawing.Color.Crimson;
            this.labelRTotal.Location = new System.Drawing.Point(497, 228);
            this.labelRTotal.Name = "labelRTotal";
            this.labelRTotal.Size = new System.Drawing.Size(151, 28);
            this.labelRTotal.TabIndex = 1;
            this.labelRTotal.Text = "Revenue Total:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelMonth.ForeColor = System.Drawing.Color.Crimson;
            this.labelMonth.Location = new System.Drawing.Point(21, 230);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(80, 28);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "Month:";
            // 
            // dataRPMonth
            // 
            this.dataRPMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRPMonth.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataRPMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRPMonth.Location = new System.Drawing.Point(27, 329);
            this.dataRPMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRPMonth.Name = "dataRPMonth";
            this.dataRPMonth.RowHeadersWidth = 51;
            this.dataRPMonth.Size = new System.Drawing.Size(813, 163);
            this.dataRPMonth.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(760, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // img_close_service
            // 
            this.img_close_service.AutoSize = true;
            this.img_close_service.Location = new System.Drawing.Point(828, 5);
            this.img_close_service.Name = "img_close_service";
            this.img_close_service.Size = new System.Drawing.Size(18, 20);
            this.img_close_service.TabIndex = 88;
            this.img_close_service.Text = "X";
            this.img_close_service.Click += new System.EventHandler(this.img_close_service_Click);
            // 
            // rBtn_month
            // 
            this.rBtn_month.AutoSize = true;
            this.rBtn_month.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_month.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_month.Location = new System.Drawing.Point(476, 178);
            this.rBtn_month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_month.Name = "rBtn_month";
            this.rBtn_month.Size = new System.Drawing.Size(86, 29);
            this.rBtn_month.TabIndex = 93;
            this.rBtn_month.TabStop = true;
            this.rBtn_month.Text = "Month";
            this.rBtn_month.UseVisualStyleBackColor = false;
            // 
            // rBtn_year
            // 
            this.rBtn_year.AutoSize = true;
            this.rBtn_year.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_year.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_year.Location = new System.Drawing.Point(583, 178);
            this.rBtn_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_year.Name = "rBtn_year";
            this.rBtn_year.Size = new System.Drawing.Size(65, 29);
            this.rBtn_year.TabIndex = 92;
            this.rBtn_year.TabStop = true;
            this.rBtn_year.Text = "Year";
            this.rBtn_year.UseVisualStyleBackColor = false;
            // 
            // tb_seacrh_rpMonth
            // 
            this.tb_seacrh_rpMonth.Location = new System.Drawing.Point(452, 140);
            this.tb_seacrh_rpMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_seacrh_rpMonth.Name = "tb_seacrh_rpMonth";
            this.tb_seacrh_rpMonth.Size = new System.Drawing.Size(215, 27);
            this.tb_seacrh_rpMonth.TabIndex = 89;
            // 
            // btn_search_rpMonth
            // 
            this.btn_search_rpMonth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search_rpMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_search_rpMonth.ForeColor = System.Drawing.Color.Crimson;
            this.btn_search_rpMonth.Location = new System.Drawing.Point(673, 137);
            this.btn_search_rpMonth.Name = "btn_search_rpMonth";
            this.btn_search_rpMonth.Size = new System.Drawing.Size(75, 32);
            this.btn_search_rpMonth.TabIndex = 90;
            this.btn_search_rpMonth.Text = "SEARCH";
            this.btn_search_rpMonth.UseVisualStyleBackColor = false;
            this.btn_search_rpMonth.Click += new System.EventHandler(this.btn_search_rpMonth_Click);
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WeddingManagementApplication.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.rBtn_month);
            this.Controls.Add(this.rBtn_year);
            this.Controls.Add(this.tb_seacrh_rpMonth);
            this.Controls.Add(this.btn_search_rpMonth);
            this.Controls.Add(this.textBoxRTotal);
            this.Controls.Add(this.labelRTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.img_close_service);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataRPMonth);
            this.Controls.Add(this.labelRReport);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(852, 503);
            this.Name = "RevenueReport";
            this.Text = "RevenueReport";
            this.Load += new System.EventHandler(this.RevenueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRPMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxRTotal;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelRTotal;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.DataGridView dataRPMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label img_close_service;
        private System.Windows.Forms.RadioButton rBtn_month;
        private System.Windows.Forms.RadioButton rBtn_year;
        private System.Windows.Forms.TextBox tb_seacrh_rpMonth;
        private System.Windows.Forms.Button btn_search_rpMonth;
    }
}