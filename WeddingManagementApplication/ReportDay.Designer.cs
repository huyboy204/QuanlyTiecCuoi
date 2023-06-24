namespace WeddingManagementApplication
{
    partial class ReportDay
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
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelmonth = new System.Windows.Forms.Label();
            this.textBoxAOW = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelAOW = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxDayRevenue = new System.Windows.Forms.TextBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.labelDayRevenue = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.dataRPD = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search_rpDay = new System.Windows.Forms.Button();
            this.tb_seacrh_rpDay = new System.Windows.Forms.TextBox();
            this.rBtn_amount = new System.Windows.Forms.RadioButton();
            this.rBtn_day = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataRPD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRReport
            // 
            this.labelRReport.AutoSize = true;
            this.labelRReport.BackColor = System.Drawing.Color.Transparent;
            this.labelRReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.labelRReport.ForeColor = System.Drawing.Color.Firebrick;
            this.labelRReport.Location = new System.Drawing.Point(198, 53);
            this.labelRReport.Name = "labelRReport";
            this.labelRReport.Size = new System.Drawing.Size(539, 51);
            this.labelRReport.TabIndex = 2;
            this.labelRReport.Text = "REVENUE REPORT DAY";
            // 
            // comboBoxMonth
            // 
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
            this.comboBoxMonth.Location = new System.Drawing.Point(412, 218);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(112, 28);
            this.comboBoxMonth.TabIndex = 10;
            // 
            // labelmonth
            // 
            this.labelmonth.AutoSize = true;
            this.labelmonth.BackColor = System.Drawing.Color.Transparent;
            this.labelmonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelmonth.ForeColor = System.Drawing.Color.Crimson;
            this.labelmonth.Location = new System.Drawing.Point(314, 218);
            this.labelmonth.Name = "labelmonth";
            this.labelmonth.Size = new System.Drawing.Size(80, 28);
            this.labelmonth.TabIndex = 9;
            this.labelmonth.Text = "Month:";
            // 
            // textBoxAOW
            // 
            this.textBoxAOW.Location = new System.Drawing.Point(627, 268);
            this.textBoxAOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAOW.Name = "textBoxAOW";
            this.textBoxAOW.Size = new System.Drawing.Size(111, 27);
            this.textBoxAOW.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(627, 218);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(110, 27);
            this.textBoxYear.TabIndex = 6;
            // 
            // labelAOW
            // 
            this.labelAOW.AutoSize = true;
            this.labelAOW.BackColor = System.Drawing.Color.Transparent;
            this.labelAOW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAOW.ForeColor = System.Drawing.Color.Crimson;
            this.labelAOW.Location = new System.Drawing.Point(407, 268);
            this.labelAOW.Name = "labelAOW";
            this.labelAOW.Size = new System.Drawing.Size(212, 28);
            this.labelAOW.TabIndex = 5;
            this.labelAOW.Text = "Amount Of Wedding:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelYear.ForeColor = System.Drawing.Color.Crimson;
            this.labelYear.Location = new System.Drawing.Point(552, 219);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(58, 28);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            // 
            // textBoxDayRevenue
            // 
            this.textBoxDayRevenue.Location = new System.Drawing.Point(200, 270);
            this.textBoxDayRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDayRevenue.Name = "textBoxDayRevenue";
            this.textBoxDayRevenue.ReadOnly = true;
            this.textBoxDayRevenue.Size = new System.Drawing.Size(194, 27);
            this.textBoxDayRevenue.TabIndex = 3;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(207, 219);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(91, 28);
            this.comboBoxDay.TabIndex = 8;
            // 
            // labelDayRevenue
            // 
            this.labelDayRevenue.AutoSize = true;
            this.labelDayRevenue.BackColor = System.Drawing.Color.Transparent;
            this.labelDayRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelDayRevenue.ForeColor = System.Drawing.Color.Crimson;
            this.labelDayRevenue.Location = new System.Drawing.Point(28, 269);
            this.labelDayRevenue.Name = "labelDayRevenue";
            this.labelDayRevenue.Size = new System.Drawing.Size(141, 28);
            this.labelDayRevenue.TabIndex = 1;
            this.labelDayRevenue.Text = "Day Revenue:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelDay.ForeColor = System.Drawing.Color.Crimson;
            this.labelDay.Location = new System.Drawing.Point(129, 217);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(54, 28);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day:";
            // 
            // dataRPD
            // 
            this.dataRPD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRPD.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataRPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRPD.Location = new System.Drawing.Point(13, 361);
            this.dataRPD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRPD.Name = "dataRPD";
            this.dataRPD.RowHeadersWidth = 51;
            this.dataRPD.Size = new System.Drawing.Size(832, 205);
            this.dataRPD.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Crimson;
            this.buttonAdd.Location = new System.Drawing.Point(767, 316);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 38);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(834, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_search_rpDay
            // 
            this.btn_search_rpDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search_rpDay.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_search_rpDay.ForeColor = System.Drawing.Color.Crimson;
            this.btn_search_rpDay.Location = new System.Drawing.Point(654, 127);
            this.btn_search_rpDay.Name = "btn_search_rpDay";
            this.btn_search_rpDay.Size = new System.Drawing.Size(75, 32);
            this.btn_search_rpDay.TabIndex = 76;
            this.btn_search_rpDay.Text = "SEARCH";
            this.btn_search_rpDay.UseVisualStyleBackColor = false;
            this.btn_search_rpDay.Click += new System.EventHandler(this.btn_search_rpDay_Click);
            // 
            // tb_seacrh_rpDay
            // 
            this.tb_seacrh_rpDay.Location = new System.Drawing.Point(433, 130);
            this.tb_seacrh_rpDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_seacrh_rpDay.Name = "tb_seacrh_rpDay";
            this.tb_seacrh_rpDay.Size = new System.Drawing.Size(215, 27);
            this.tb_seacrh_rpDay.TabIndex = 11;
            // 
            // rBtn_amount
            // 
            this.rBtn_amount.AutoSize = true;
            this.rBtn_amount.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_amount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_amount.Location = new System.Drawing.Point(519, 165);
            this.rBtn_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_amount.Name = "rBtn_amount";
            this.rBtn_amount.Size = new System.Drawing.Size(183, 27);
            this.rBtn_amount.TabIndex = 78;
            this.rBtn_amount.TabStop = true;
            this.rBtn_amount.Text = "Amount of wedding";
            this.rBtn_amount.UseVisualStyleBackColor = false;
            // 
            // rBtn_day
            // 
            this.rBtn_day.AutoSize = true;
            this.rBtn_day.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_day.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_day.Location = new System.Drawing.Point(453, 165);
            this.rBtn_day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_day.Name = "rBtn_day";
            this.rBtn_day.Size = new System.Drawing.Size(60, 27);
            this.rBtn_day.TabIndex = 80;
            this.rBtn_day.TabStop = true;
            this.rBtn_day.Text = "Day";
            this.rBtn_day.UseVisualStyleBackColor = false;
            // 
            // ReportDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::WeddingManagementApplication.Properties.Resources._5XICE__1_;
            this.ClientSize = new System.Drawing.Size(857, 577);
            this.Controls.Add(this.rBtn_day);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.rBtn_amount);
            this.Controls.Add(this.labelmonth);
            this.Controls.Add(this.textBoxAOW);
            this.Controls.Add(this.tb_seacrh_rpDay);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.btn_search_rpDay);
            this.Controls.Add(this.labelAOW);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxDayRevenue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.labelDayRevenue);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.dataRPD);
            this.Controls.Add(this.labelRReport);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(857, 577);
            this.Name = "ReportDay";
            this.Text = "ReportDay";
            this.Load += new System.EventHandler(this.ReportDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRReport;
        private System.Windows.Forms.TextBox textBoxAOW;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelAOW;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxDayRevenue;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Label labelDayRevenue;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DataGridView dataRPD;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelmonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search_rpDay;
        private System.Windows.Forms.TextBox tb_seacrh_rpDay;
        private System.Windows.Forms.RadioButton rBtn_amount;
        private System.Windows.Forms.RadioButton rBtn_day;
    }
}