namespace WeddingManagementApplication
{
    partial class FormDishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDishes));
            this.label6 = new System.Windows.Forms.Label();
            this.data_gv_dishes = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_dishes = new System.Windows.Forms.Button();
            this.btn_delete_dishes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update_dishes = new System.Windows.Forms.Button();
            this.tb_search_dishes = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_dishes_note = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_dishes_price = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_dishes_name = new WeddingManagementApplication.CustomeBorderTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_dishes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(731, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // data_gv_dishes
            // 
            this.data_gv_dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv_dishes.Location = new System.Drawing.Point(12, 66);
            this.data_gv_dishes.Name = "data_gv_dishes";
            this.data_gv_dishes.RowHeadersWidth = 51;
            this.data_gv_dishes.RowTemplate.Height = 24;
            this.data_gv_dishes.Size = new System.Drawing.Size(454, 372);
            this.data_gv_dishes.TabIndex = 13;
            this.data_gv_dishes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gv_dishes_CellClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Crimson;
            this.label.Location = new System.Drawing.Point(305, 9);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(138, 54);
            this.label.TabIndex = 20;
            this.label.Text = "DISHES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(513, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(512, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Note";
            // 
            // btn_add_dishes
            // 
            this.btn_add_dishes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_dishes.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_add_dishes.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_dishes.Location = new System.Drawing.Point(474, 372);
            this.btn_add_dishes.Name = "btn_add_dishes";
            this.btn_add_dishes.Size = new System.Drawing.Size(85, 39);
            this.btn_add_dishes.TabIndex = 74;
            this.btn_add_dishes.Text = "ADD";
            this.btn_add_dishes.UseVisualStyleBackColor = false;
            this.btn_add_dishes.Click += new System.EventHandler(this.btn_add_dishes_Click_1);
            // 
            // btn_delete_dishes
            // 
            this.btn_delete_dishes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete_dishes.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_dishes.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete_dishes.Location = new System.Drawing.Point(663, 372);
            this.btn_delete_dishes.Name = "btn_delete_dishes";
            this.btn_delete_dishes.Size = new System.Drawing.Size(85, 39);
            this.btn_delete_dishes.TabIndex = 75;
            this.btn_delete_dishes.Text = "DELETE";
            this.btn_delete_dishes.UseVisualStyleBackColor = false;
            this.btn_delete_dishes.Click += new System.EventHandler(this.btn_delete_dishes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(513, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(563, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.Crimson;
            this.btn_search.Location = new System.Drawing.Point(639, 117);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 39);
            this.btn_search.TabIndex = 78;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update_dishes
            // 
            this.btn_update_dishes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update_dishes.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_update_dishes.ForeColor = System.Drawing.Color.Crimson;
            this.btn_update_dishes.Location = new System.Drawing.Point(565, 372);
            this.btn_update_dishes.Name = "btn_update_dishes";
            this.btn_update_dishes.Size = new System.Drawing.Size(91, 38);
            this.btn_update_dishes.TabIndex = 79;
            this.btn_update_dishes.Text = "UPDATE";
            this.btn_update_dishes.UseVisualStyleBackColor = false;
            this.btn_update_dishes.Click += new System.EventHandler(this.btn_update_dishes_Click);
            // 
            // tb_search_dishes
            // 
            this.tb_search_dishes.Location = new System.Drawing.Point(486, 89);
            this.tb_search_dishes.Name = "tb_search_dishes";
            this.tb_search_dishes.Size = new System.Drawing.Size(238, 22);
            this.tb_search_dishes.TabIndex = 76;
            // 
            // tb_dishes_note
            // 
            this.tb_dishes_note.Location = new System.Drawing.Point(513, 323);
            this.tb_dishes_note.Name = "tb_dishes_note";
            this.tb_dishes_note.Size = new System.Drawing.Size(205, 22);
            this.tb_dishes_note.TabIndex = 71;
            // 
            // tb_dishes_price
            // 
            this.tb_dishes_price.Location = new System.Drawing.Point(513, 264);
            this.tb_dishes_price.Name = "tb_dishes_price";
            this.tb_dishes_price.Size = new System.Drawing.Size(205, 22);
            this.tb_dishes_price.TabIndex = 69;
            // 
            // tb_dishes_name
            // 
            this.tb_dishes_name.Location = new System.Drawing.Point(513, 201);
            this.tb_dishes_name.Name = "tb_dishes_name";
            this.tb_dishes_name.Size = new System.Drawing.Size(205, 22);
            this.tb_dishes_name.TabIndex = 67;
            // 
            // FormDishes
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 443);
            this.Controls.Add(this.btn_update_dishes);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_search_dishes);
            this.Controls.Add(this.btn_delete_dishes);
            this.Controls.Add(this.btn_add_dishes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_dishes_note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dishes_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dishes_name);
            this.Controls.Add(this.label);
            this.Controls.Add(this.data_gv_dishes);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(754, 443);
            this.Name = "FormDishes";
            this.Text = "FormDishes";
            this.Load += new System.EventHandler(this.form_dishes_load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_dishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data_gv_dishes;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private CustomeBorderTextbox tb_dishes_price;
        private System.Windows.Forms.Label label3;
        private CustomeBorderTextbox tb_dishes_note;
        private System.Windows.Forms.Button btn_add_dishes;
        private System.Windows.Forms.Button btn_delete_dishes;
        private CustomeBorderTextbox tb_dishes_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CustomeBorderTextbox tb_search_dishes;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update_dishes;
    }
}