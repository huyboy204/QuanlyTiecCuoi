
namespace WeddingManagementApplication

{
    partial class RevenueReportDetail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWDRestaurant = new System.Windows.Forms.Label();
            this.labelRReport = new System.Windows.Forms.Label();
            this.comboBoxMadeBy = new System.Windows.Forms.ComboBox();
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxRTotal = new System.Windows.Forms.TextBox();
            this.labelRTotal = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.dataGridViewRReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWDRestaurant
            // 
            this.labelWDRestaurant.AutoSize = true;
            this.labelWDRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic);
            this.labelWDRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelWDRestaurant.Location = new System.Drawing.Point(547, 9);
            this.labelWDRestaurant.Name = "labelWDRestaurant";
            this.labelWDRestaurant.Size = new System.Drawing.Size(314, 29);
            this.labelWDRestaurant.TabIndex = 0;
            this.labelWDRestaurant.Text = "Wedding Restaurant HALTT";
            // 
            // labelRReport
            // 
            this.labelRReport.AutoSize = true;
            this.labelRReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.labelRReport.ForeColor = System.Drawing.Color.Firebrick;
            this.labelRReport.Location = new System.Drawing.Point(196, 46);
            this.labelRReport.Name = "labelRReport";
            this.labelRReport.Size = new System.Drawing.Size(435, 51);
            this.labelRReport.TabIndex = 1;
            this.labelRReport.Text = "REVENUE REPORT";
            // 
            // comboBoxMadeBy
            // 
            this.comboBoxMadeBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMadeBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMadeBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMadeBy.FormattingEnabled = true;
            this.comboBoxMadeBy.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun ",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxMadeBy.Location = new System.Drawing.Point(218, 14);
            this.comboBoxMadeBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMadeBy.Name = "comboBoxMadeBy";
            this.comboBoxMadeBy.Size = new System.Drawing.Size(151, 24);
            this.comboBoxMadeBy.TabIndex = 9;
            // 
            // labelMadeBy
            // 
            this.labelMadeBy.AutoSize = true;
            this.labelMadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelMadeBy.Location = new System.Drawing.Point(46, 14);
            this.labelMadeBy.Name = "labelMadeBy";
            this.labelMadeBy.Size = new System.Drawing.Size(111, 29);
            this.labelMadeBy.TabIndex = 8;
            this.labelMadeBy.Text = "Made by:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(537, 14);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(151, 22);
            this.textBoxYear.TabIndex = 7;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun ",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxMonth.Location = new System.Drawing.Point(537, 50);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(151, 24);
            this.comboBoxMonth.TabIndex = 6;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelYear.Location = new System.Drawing.Point(427, 9);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(70, 29);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            // 
            // textBoxRTotal
            // 
            this.textBoxRTotal.Location = new System.Drawing.Point(218, 53);
            this.textBoxRTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRTotal.Name = "textBoxRTotal";
            this.textBoxRTotal.ReadOnly = true;
            this.textBoxRTotal.Size = new System.Drawing.Size(151, 22);
            this.textBoxRTotal.TabIndex = 3;
            // 
            // labelRTotal
            // 
            this.labelRTotal.AutoSize = true;
            this.labelRTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelRTotal.Location = new System.Drawing.Point(5, 53);
            this.labelRTotal.Name = "labelRTotal";
            this.labelRTotal.Size = new System.Drawing.Size(176, 29);
            this.labelRTotal.TabIndex = 1;
            this.labelRTotal.Text = "Revenue Total:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelMonth.Location = new System.Drawing.Point(415, 50);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(85, 29);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "Month:";
            // 
            // dataGridViewRReport
            // 
            this.dataGridViewRReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRReport.Location = new System.Drawing.Point(12, 199);
            this.dataGridViewRReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRReport.Name = "dataGridViewRReport";
            this.dataGridViewRReport.RowHeadersWidth = 51;
            this.dataGridViewRReport.RowTemplate.Height = 29;
            this.dataGridViewRReport.Size = new System.Drawing.Size(739, 150);
            this.dataGridViewRReport.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMadeBy);
            this.groupBox1.Controls.Add(this.comboBoxMonth);
            this.groupBox1.Controls.Add(this.labelMadeBy);
            this.groupBox1.Controls.Add(this.labelMonth);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.labelRTotal);
            this.groupBox1.Controls.Add(this.textBoxRTotal);
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Location = new System.Drawing.Point(27, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Yellow;
            this.btn_create.Location = new System.Drawing.Point(759, 199);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(81, 33);
            this.btn_create.TabIndex = 10;
            this.btn_create.Text = "CREATE";
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Yellow;
            this.btn_delete.Location = new System.Drawing.Point(759, 277);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 33);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_update.Location = new System.Drawing.Point(759, 238);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 33);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Tomato;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(759, 316);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 33);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // RevenueReportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 358);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewRReport);
            this.Controls.Add(this.labelWDRestaurant);
            this.Controls.Add(this.labelRReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RevenueReportDetail";
            this.Text = "Revenue Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWDRestaurant;
        private System.Windows.Forms.Label labelRReport;
        private System.Windows.Forms.Label labelRTotal;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxRTotal;
        private System.Windows.Forms.DataGridView dataGridViewRReport;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMadeBy;
        private System.Windows.Forms.Label labelMadeBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_exit;
    }
}

