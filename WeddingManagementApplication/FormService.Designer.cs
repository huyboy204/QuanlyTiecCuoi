namespace WeddingManagementApplication
{
    partial class FormServices
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
            this.btn_delete_service = new System.Windows.Forms.Button();
            this.btn_add_service = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dataService = new System.Windows.Forms.DataGridView();
            this.img_close_service = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search_service = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_service_note = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_service_price = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_service_name = new WeddingManagementApplication.CustomeBorderTextbox();
            this.btn_search_service = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataService)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete_service
            // 
            this.btn_delete_service.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete_service.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_delete_service.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete_service.Location = new System.Drawing.Point(659, 372);
            this.btn_delete_service.Name = "btn_delete_service";
            this.btn_delete_service.Size = new System.Drawing.Size(85, 39);
            this.btn_delete_service.TabIndex = 86;
            this.btn_delete_service.Text = "DELETE";
            this.btn_delete_service.UseVisualStyleBackColor = false;
            this.btn_delete_service.Click += new System.EventHandler(this.btn_delete_service_Click);
            // 
            // btn_add_service
            // 
            this.btn_add_service.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_service.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_add_service.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_service.Location = new System.Drawing.Point(478, 372);
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.Size = new System.Drawing.Size(85, 39);
            this.btn_add_service.TabIndex = 85;
            this.btn_add_service.Text = "ADD";
            this.btn_add_service.UseVisualStyleBackColor = false;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Crimson;
            this.label.Location = new System.Drawing.Point(305, 3);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(155, 54);
            this.label.TabIndex = 77;
            this.label.Text = "SERVICE";
            // 
            // dataService
            // 
            this.dataService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataService.Location = new System.Drawing.Point(12, 60);
            this.dataService.Name = "dataService";
            this.dataService.RowHeadersWidth = 51;
            this.dataService.RowTemplate.Height = 24;
            this.dataService.Size = new System.Drawing.Size(454, 372);
            this.dataService.TabIndex = 76;
            this.dataService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataService_CellContentClick);
            // 
            // img_close_service
            // 
            this.img_close_service.AutoSize = true;
            this.img_close_service.BackColor = System.Drawing.Color.White;
            this.img_close_service.Location = new System.Drawing.Point(725, 9);
            this.img_close_service.Name = "img_close_service";
            this.img_close_service.Size = new System.Drawing.Size(15, 16);
            this.img_close_service.TabIndex = 87;
            this.img_close_service.Text = "X";
            this.img_close_service.Click += new System.EventHandler(this.img_close_service_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(570, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(510, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 93;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(511, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 91;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(511, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Name";
            // 
            // tb_search_service
            // 
            this.tb_search_service.Location = new System.Drawing.Point(493, 86);
            this.tb_search_service.Name = "tb_search_service";
            this.tb_search_service.Size = new System.Drawing.Size(238, 22);
            this.tb_search_service.TabIndex = 94;
            // 
            // tb_service_note
            // 
            this.tb_service_note.Location = new System.Drawing.Point(511, 319);
            this.tb_service_note.Name = "tb_service_note";
            this.tb_service_note.Size = new System.Drawing.Size(205, 22);
            this.tb_service_note.TabIndex = 92;
            // 
            // tb_service_price
            // 
            this.tb_service_price.Location = new System.Drawing.Point(511, 260);
            this.tb_service_price.Name = "tb_service_price";
            this.tb_service_price.Size = new System.Drawing.Size(205, 22);
            this.tb_service_price.TabIndex = 90;
            // 
            // tb_service_name
            // 
            this.tb_service_name.Location = new System.Drawing.Point(511, 197);
            this.tb_service_name.Name = "tb_service_name";
            this.tb_service_name.Size = new System.Drawing.Size(205, 22);
            this.tb_service_name.TabIndex = 88;
            // 
            // btn_search_service
            // 
            this.btn_search_service.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search_service.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_search_service.ForeColor = System.Drawing.Color.Crimson;
            this.btn_search_service.Location = new System.Drawing.Point(646, 114);
            this.btn_search_service.Name = "btn_search_service";
            this.btn_search_service.Size = new System.Drawing.Size(85, 39);
            this.btn_search_service.TabIndex = 96;
            this.btn_search_service.Text = "SEARCH";
            this.btn_search_service.UseVisualStyleBackColor = false;
            this.btn_search_service.Click += new System.EventHandler(this.btn_search_service_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(569, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 39);
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.BackgroundImage = global::WeddingManagementApplication.Properties.Resources._5XICE__1_;
            this.ClientSize = new System.Drawing.Size(754, 443);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btn_search_service);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_search_service);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_service_note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_service_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_service_name);
            this.Controls.Add(this.img_close_service);
            this.Controls.Add(this.btn_delete_service);
            this.Controls.Add(this.btn_add_service);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(754, 443);
            this.Name = "FormServices";
            this.Text = "FormServices";
            this.Load += new System.EventHandler(this.form_service_load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_service;
        private System.Windows.Forms.Button btn_add_service;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataService;
        private System.Windows.Forms.Label img_close_service;
        private System.Windows.Forms.Label label4;
        private CustomeBorderTextbox tb_search_service;
        private System.Windows.Forms.Label label3;
        private CustomeBorderTextbox tb_service_note;
        private System.Windows.Forms.Label label2;
        private CustomeBorderTextbox tb_service_price;
        private System.Windows.Forms.Label label1;
        private CustomeBorderTextbox tb_service_name;
        private System.Windows.Forms.Button btn_search_service;
        private System.Windows.Forms.Button btnUpdate;
    }
}