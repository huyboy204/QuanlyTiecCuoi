
using System;

namespace WeddingManagementApplication
{
    partial class NhanTiec
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
            this.label_bookdate = new System.Windows.Forms.Label();
            this.label_tittle_wedding_in4 = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_representative = new System.Windows.Forms.Label();
            this.label_bride = new System.Windows.Forms.Label();
            this.label_groom = new System.Windows.Forms.Label();
            this.label_weddingdate = new System.Windows.Forms.Label();
            this.label_deposit = new System.Windows.Forms.Label();
            this.label_contingency = new System.Windows.Forms.Label();
            this.label_table = new System.Windows.Forms.Label();
            this.wedding = new System.Windows.Forms.GroupBox();
            this.cbb_lobby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_shift = new System.Windows.Forms.ComboBox();
            this.label_shift = new System.Windows.Forms.Label();
            this.tb_deposit = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_representative = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_phone = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_contigency = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_table = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_groom = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_bride = new WeddingManagementApplication.CustomeBorderTextbox();
            this.date_booking = new System.Windows.Forms.DateTimePicker();
            this.date_wedding = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_wedding = new System.Windows.Forms.Button();
            this.btn_update_wedding = new System.Windows.Forms.Button();
            this.btn_delete_wedding = new System.Windows.Forms.Button();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.btn_detail_dishes = new System.Windows.Forms.Button();
            this.tb_dishes_price = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_price_dishes = new WeddingManagementApplication.CustomeBorderTextbox();
            this.btn_add_menu = new System.Windows.Forms.Button();
            this.label_dishes_price = new System.Windows.Forms.Label();
            this.label_amount_dishes = new System.Windows.Forms.Label();
            this.cbb_dishes = new System.Windows.Forms.ComboBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_detail_service = new System.Windows.Forms.Button();
            this.tb_service_price = new WeddingManagementApplication.CustomeBorderTextbox();
            this.tb_price_service = new WeddingManagementApplication.CustomeBorderTextbox();
            this.btn_add_service = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_service = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataWedding = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.wedding.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWedding)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bookdate
            // 
            this.label_bookdate.AutoSize = true;
            this.label_bookdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookdate.ForeColor = System.Drawing.Color.Crimson;
            this.label_bookdate.Location = new System.Drawing.Point(16, 20);
            this.label_bookdate.Name = "label_bookdate";
            this.label_bookdate.Size = new System.Drawing.Size(116, 23);
            this.label_bookdate.TabIndex = 16;
            this.label_bookdate.Text = "Booking date:";
            // 
            // label_tittle_wedding_in4
            // 
            this.label_tittle_wedding_in4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tittle_wedding_in4.AutoSize = true;
            this.label_tittle_wedding_in4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tittle_wedding_in4.ForeColor = System.Drawing.Color.Crimson;
            this.label_tittle_wedding_in4.Location = new System.Drawing.Point(309, 15);
            this.label_tittle_wedding_in4.Margin = new System.Windows.Forms.Padding(0);
            this.label_tittle_wedding_in4.Name = "label_tittle_wedding_in4";
            this.label_tittle_wedding_in4.Size = new System.Drawing.Size(414, 54);
            this.label_tittle_wedding_in4.TabIndex = 15;
            this.label_tittle_wedding_in4.Text = "WEDDING INFORMATION";
            this.label_tittle_wedding_in4.Click += new System.EventHandler(this.label_tittle_wedding_in4_Click);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.Crimson;
            this.label_phone.Location = new System.Drawing.Point(17, 73);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(129, 23);
            this.label_phone.TabIndex = 14;
            this.label_phone.Text = "Phone number:";
            // 
            // label_representative
            // 
            this.label_representative.AutoSize = true;
            this.label_representative.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_representative.ForeColor = System.Drawing.Color.Crimson;
            this.label_representative.Location = new System.Drawing.Point(15, 28);
            this.label_representative.Name = "label_representative";
            this.label_representative.Size = new System.Drawing.Size(128, 23);
            this.label_representative.TabIndex = 13;
            this.label_representative.Text = "Representative:";
            // 
            // label_bride
            // 
            this.label_bride.AutoSize = true;
            this.label_bride.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bride.ForeColor = System.Drawing.Color.Crimson;
            this.label_bride.Location = new System.Drawing.Point(308, 71);
            this.label_bride.Name = "label_bride";
            this.label_bride.Size = new System.Drawing.Size(101, 23);
            this.label_bride.TabIndex = 22;
            this.label_bride.Text = "Bride name:";
            // 
            // label_groom
            // 
            this.label_groom.AutoSize = true;
            this.label_groom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_groom.ForeColor = System.Drawing.Color.Crimson;
            this.label_groom.Location = new System.Drawing.Point(308, 30);
            this.label_groom.Name = "label_groom";
            this.label_groom.Size = new System.Drawing.Size(115, 23);
            this.label_groom.TabIndex = 21;
            this.label_groom.Text = "Groom name:";
            // 
            // label_weddingdate
            // 
            this.label_weddingdate.AutoSize = true;
            this.label_weddingdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weddingdate.ForeColor = System.Drawing.Color.Crimson;
            this.label_weddingdate.Location = new System.Drawing.Point(291, 20);
            this.label_weddingdate.Name = "label_weddingdate";
            this.label_weddingdate.Size = new System.Drawing.Size(122, 23);
            this.label_weddingdate.TabIndex = 20;
            this.label_weddingdate.Text = "Wedding date:";
            // 
            // label_deposit
            // 
            this.label_deposit.AutoSize = true;
            this.label_deposit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deposit.ForeColor = System.Drawing.Color.Crimson;
            this.label_deposit.Location = new System.Drawing.Point(308, 113);
            this.label_deposit.Name = "label_deposit";
            this.label_deposit.Size = new System.Drawing.Size(72, 23);
            this.label_deposit.TabIndex = 30;
            this.label_deposit.Text = "Deposit:";
            // 
            // label_contingency
            // 
            this.label_contingency.AutoSize = true;
            this.label_contingency.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contingency.ForeColor = System.Drawing.Color.Crimson;
            this.label_contingency.Location = new System.Drawing.Point(17, 153);
            this.label_contingency.Name = "label_contingency";
            this.label_contingency.Size = new System.Drawing.Size(111, 23);
            this.label_contingency.TabIndex = 28;
            this.label_contingency.Text = "Contingency:";
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table.ForeColor = System.Drawing.Color.Crimson;
            this.label_table.Location = new System.Drawing.Point(17, 113);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(53, 23);
            this.label_table.TabIndex = 26;
            this.label_table.Text = "Table:";
            // 
            // wedding
            // 
            this.wedding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wedding.Controls.Add(this.cbb_lobby);
            this.wedding.Controls.Add(this.label1);
            this.wedding.Controls.Add(this.cbb_shift);
            this.wedding.Controls.Add(this.label_shift);
            this.wedding.Controls.Add(this.label_groom);
            this.wedding.Controls.Add(this.label_representative);
            this.wedding.Controls.Add(this.label_phone);
            this.wedding.Controls.Add(this.tb_deposit);
            this.wedding.Controls.Add(this.tb_representative);
            this.wedding.Controls.Add(this.tb_phone);
            this.wedding.Controls.Add(this.tb_contigency);
            this.wedding.Controls.Add(this.label_deposit);
            this.wedding.Controls.Add(this.label_bride);
            this.wedding.Controls.Add(this.label_contingency);
            this.wedding.Controls.Add(this.tb_table);
            this.wedding.Controls.Add(this.tb_groom);
            this.wedding.Controls.Add(this.label_table);
            this.wedding.Controls.Add(this.tb_bride);
            this.wedding.ForeColor = System.Drawing.Color.Black;
            this.wedding.Location = new System.Drawing.Point(12, 112);
            this.wedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wedding.Name = "wedding";
            this.wedding.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wedding.Size = new System.Drawing.Size(616, 192);
            this.wedding.TabIndex = 42;
            this.wedding.TabStop = false;
            this.wedding.Text = "WEDDING";
            this.wedding.Enter += new System.EventHandler(this.wedding_Enter);
            // 
            // cbb_lobby
            // 
            this.cbb_lobby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_lobby.FormattingEnabled = true;
            this.cbb_lobby.Location = new System.Drawing.Point(512, 151);
            this.cbb_lobby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_lobby.Name = "cbb_lobby";
            this.cbb_lobby.Size = new System.Drawing.Size(104, 24);
            this.cbb_lobby.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(445, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lobby:";
            // 
            // cbb_shift
            // 
            this.cbb_shift.FormattingEnabled = true;
            this.cbb_shift.Location = new System.Drawing.Point(363, 153);
            this.cbb_shift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_shift.Name = "cbb_shift";
            this.cbb_shift.Size = new System.Drawing.Size(76, 24);
            this.cbb_shift.TabIndex = 35;
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shift.ForeColor = System.Drawing.Color.Crimson;
            this.label_shift.Location = new System.Drawing.Point(308, 153);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(49, 23);
            this.label_shift.TabIndex = 34;
            this.label_shift.Text = "Shift:";
            // 
            // tb_deposit
            // 
            this.tb_deposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_deposit.Location = new System.Drawing.Point(472, 114);
            this.tb_deposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_deposit.Name = "tb_deposit";
            this.tb_deposit.Size = new System.Drawing.Size(144, 22);
            this.tb_deposit.TabIndex = 33;
            // 
            // tb_representative
            // 
            this.tb_representative.Location = new System.Drawing.Point(152, 33);
            this.tb_representative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_representative.Name = "tb_representative";
            this.tb_representative.Size = new System.Drawing.Size(139, 22);
            this.tb_representative.TabIndex = 17;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(151, 75);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(139, 22);
            this.tb_phone.TabIndex = 18;
            // 
            // tb_contigency
            // 
            this.tb_contigency.Location = new System.Drawing.Point(151, 153);
            this.tb_contigency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_contigency.Name = "tb_contigency";
            this.tb_contigency.Size = new System.Drawing.Size(140, 22);
            this.tb_contigency.TabIndex = 31;
            // 
            // tb_table
            // 
            this.tb_table.Location = new System.Drawing.Point(152, 114);
            this.tb_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_table.Name = "tb_table";
            this.tb_table.Size = new System.Drawing.Size(137, 22);
            this.tb_table.TabIndex = 27;
            // 
            // tb_groom
            // 
            this.tb_groom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_groom.Location = new System.Drawing.Point(472, 30);
            this.tb_groom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_groom.Name = "tb_groom";
            this.tb_groom.Size = new System.Drawing.Size(144, 22);
            this.tb_groom.TabIndex = 24;
            // 
            // tb_bride
            // 
            this.tb_bride.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_bride.Location = new System.Drawing.Point(472, 71);
            this.tb_bride.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_bride.Name = "tb_bride";
            this.tb_bride.Size = new System.Drawing.Size(144, 22);
            this.tb_bride.TabIndex = 25;
            // 
            // date_booking
            // 
            this.date_booking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_booking.Location = new System.Drawing.Point(155, 22);
            this.date_booking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_booking.Name = "date_booking";
            this.date_booking.Size = new System.Drawing.Size(113, 22);
            this.date_booking.TabIndex = 34;
            this.date_booking.ValueChanged += new System.EventHandler(this.date_booking_ValueChanged);
            // 
            // date_wedding
            // 
            this.date_wedding.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_wedding.Location = new System.Drawing.Point(429, 21);
            this.date_wedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_wedding.Name = "date_wedding";
            this.date_wedding.Size = new System.Drawing.Size(111, 22);
            this.date_wedding.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.date_booking);
            this.groupBox1.Controls.Add(this.label_weddingdate);
            this.groupBox1.Controls.Add(this.date_wedding);
            this.groupBox1.Controls.Add(this.label_bookdate);
            this.groupBox1.Location = new System.Drawing.Point(461, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(543, 48);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // btn_add_wedding
            // 
            this.btn_add_wedding.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_wedding.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_add_wedding.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_wedding.Location = new System.Drawing.Point(347, 514);
            this.btn_add_wedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_wedding.Name = "btn_add_wedding";
            this.btn_add_wedding.Size = new System.Drawing.Size(85, 39);
            this.btn_add_wedding.TabIndex = 49;
            this.btn_add_wedding.Text = "ADD";
            this.btn_add_wedding.UseVisualStyleBackColor = false;
            this.btn_add_wedding.Click += new System.EventHandler(this.btn_add_wedding_Click);
            // 
            // btn_update_wedding
            // 
            this.btn_update_wedding.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update_wedding.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_update_wedding.ForeColor = System.Drawing.Color.Crimson;
            this.btn_update_wedding.Location = new System.Drawing.Point(437, 514);
            this.btn_update_wedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_wedding.Name = "btn_update_wedding";
            this.btn_update_wedding.Size = new System.Drawing.Size(85, 39);
            this.btn_update_wedding.TabIndex = 55;
            this.btn_update_wedding.Text = "UPDATE";
            this.btn_update_wedding.UseVisualStyleBackColor = false;
            // 
            // btn_delete_wedding
            // 
            this.btn_delete_wedding.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete_wedding.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_delete_wedding.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete_wedding.Location = new System.Drawing.Point(529, 514);
            this.btn_delete_wedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete_wedding.Name = "btn_delete_wedding";
            this.btn_delete_wedding.Size = new System.Drawing.Size(85, 39);
            this.btn_delete_wedding.TabIndex = 56;
            this.btn_delete_wedding.Text = "DELETE";
            this.btn_delete_wedding.UseVisualStyleBackColor = false;
            this.btn_delete_wedding.Click += new System.EventHandler(this.btn_delete_wedding_Click);
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_menu.Controls.Add(this.btn_detail_dishes);
            this.groupBox_menu.Controls.Add(this.tb_dishes_price);
            this.groupBox_menu.Controls.Add(this.tb_price_dishes);
            this.groupBox_menu.Controls.Add(this.btn_add_menu);
            this.groupBox_menu.Controls.Add(this.label_dishes_price);
            this.groupBox_menu.Controls.Add(this.label_amount_dishes);
            this.groupBox_menu.Controls.Add(this.cbb_dishes);
            this.groupBox_menu.Controls.Add(this.label_menu);
            this.groupBox_menu.Location = new System.Drawing.Point(653, 140);
            this.groupBox_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_menu.Size = new System.Drawing.Size(349, 176);
            this.groupBox_menu.TabIndex = 58;
            this.groupBox_menu.TabStop = false;
            this.groupBox_menu.Text = "MENU";
            this.groupBox_menu.Enter += new System.EventHandler(this.groupBox_menu_Enter);
            // 
            // btn_detail_dishes
            // 
            this.btn_detail_dishes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_detail_dishes.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_detail_dishes.ForeColor = System.Drawing.Color.Crimson;
            this.btn_detail_dishes.Location = new System.Drawing.Point(244, 98);
            this.btn_detail_dishes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_detail_dishes.Name = "btn_detail_dishes";
            this.btn_detail_dishes.Size = new System.Drawing.Size(85, 32);
            this.btn_detail_dishes.TabIndex = 61;
            this.btn_detail_dishes.Text = "DETAIL";
            this.btn_detail_dishes.UseVisualStyleBackColor = false;
            this.btn_detail_dishes.Click += new System.EventHandler(this.btn_detail_dishes_Click);
            // 
            // tb_dishes_price
            // 
            this.tb_dishes_price.BackColor = System.Drawing.Color.LightSalmon;
            this.tb_dishes_price.Location = new System.Drawing.Point(101, 71);
            this.tb_dishes_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dishes_price.Name = "tb_dishes_price";
            this.tb_dishes_price.Size = new System.Drawing.Size(127, 22);
            this.tb_dishes_price.TabIndex = 60;
            // 
            // tb_price_dishes
            // 
            this.tb_price_dishes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_price_dishes.Location = new System.Drawing.Point(101, 112);
            this.tb_price_dishes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_price_dishes.Name = "tb_price_dishes";
            this.tb_price_dishes.ReadOnly = true;
            this.tb_price_dishes.Size = new System.Drawing.Size(127, 22);
            this.tb_price_dishes.TabIndex = 38;
            // 
            // btn_add_menu
            // 
            this.btn_add_menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_add_menu.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_menu.Location = new System.Drawing.Point(244, 137);
            this.btn_add_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_menu.Name = "btn_add_menu";
            this.btn_add_menu.Size = new System.Drawing.Size(85, 32);
            this.btn_add_menu.TabIndex = 59;
            this.btn_add_menu.Text = "ADD";
            this.btn_add_menu.UseVisualStyleBackColor = false;
            this.btn_add_menu.Click += new System.EventHandler(this.btn_add_menu_Click);
            // 
            // label_dishes_price
            // 
            this.label_dishes_price.AutoSize = true;
            this.label_dishes_price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dishes_price.ForeColor = System.Drawing.Color.Crimson;
            this.label_dishes_price.Location = new System.Drawing.Point(19, 110);
            this.label_dishes_price.Name = "label_dishes_price";
            this.label_dishes_price.Size = new System.Drawing.Size(51, 23);
            this.label_dishes_price.TabIndex = 40;
            this.label_dishes_price.Text = "Price:";
            // 
            // label_amount_dishes
            // 
            this.label_amount_dishes.AutoSize = true;
            this.label_amount_dishes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount_dishes.ForeColor = System.Drawing.Color.Crimson;
            this.label_amount_dishes.Location = new System.Drawing.Point(19, 69);
            this.label_amount_dishes.Name = "label_amount_dishes";
            this.label_amount_dishes.Size = new System.Drawing.Size(76, 23);
            this.label_amount_dishes.TabIndex = 38;
            this.label_amount_dishes.Text = "Amount:";
            // 
            // cbb_dishes
            // 
            this.cbb_dishes.FormattingEnabled = true;
            this.cbb_dishes.Location = new System.Drawing.Point(101, 26);
            this.cbb_dishes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_dishes.Name = "cbb_dishes";
            this.cbb_dishes.Size = new System.Drawing.Size(233, 24);
            this.cbb_dishes.TabIndex = 37;
            this.cbb_dishes.SelectedIndexChanged += new System.EventHandler(this.cbb_dishes_SelectedIndexChanged);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.Color.Crimson;
            this.label_menu.Location = new System.Drawing.Point(19, 26);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(63, 23);
            this.label_menu.TabIndex = 36;
            this.label_menu.Text = "Dishes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.btn_detail_service);
            this.groupBox2.Controls.Add(this.tb_service_price);
            this.groupBox2.Controls.Add(this.tb_price_service);
            this.groupBox2.Controls.Add(this.btn_add_service);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbb_service);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(653, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(349, 182);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVICE";
            // 
            // btn_detail_service
            // 
            this.btn_detail_service.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_detail_service.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_detail_service.ForeColor = System.Drawing.Color.Crimson;
            this.btn_detail_service.Location = new System.Drawing.Point(244, 98);
            this.btn_detail_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_detail_service.Name = "btn_detail_service";
            this.btn_detail_service.Size = new System.Drawing.Size(85, 32);
            this.btn_detail_service.TabIndex = 62;
            this.btn_detail_service.Text = "DETAIL";
            this.btn_detail_service.UseVisualStyleBackColor = false;
            this.btn_detail_service.Click += new System.EventHandler(this.btn_detail_service_Click);
            // 
            // tb_service_price
            // 
            this.tb_service_price.BackColor = System.Drawing.Color.LightSalmon;
            this.tb_service_price.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_service_price.Location = new System.Drawing.Point(101, 70);
            this.tb_service_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_service_price.Name = "tb_service_price";
            this.tb_service_price.Size = new System.Drawing.Size(127, 22);
            this.tb_service_price.TabIndex = 61;
            // 
            // tb_price_service
            // 
            this.tb_price_service.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_price_service.Location = new System.Drawing.Point(101, 112);
            this.tb_price_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_price_service.Name = "tb_price_service";
            this.tb_price_service.ReadOnly = true;
            this.tb_price_service.Size = new System.Drawing.Size(127, 22);
            this.tb_price_service.TabIndex = 60;
            // 
            // btn_add_service
            // 
            this.btn_add_service.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_service.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_add_service.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_service.Location = new System.Drawing.Point(244, 135);
            this.btn_add_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.Size = new System.Drawing.Size(85, 32);
            this.btn_add_service.TabIndex = 59;
            this.btn_add_service.Text = "ADD";
            this.btn_add_service.UseVisualStyleBackColor = false;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Amount:";
            // 
            // cbb_service
            // 
            this.cbb_service.FormattingEnabled = true;
            this.cbb_service.Location = new System.Drawing.Point(101, 27);
            this.cbb_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_service.Name = "cbb_service";
            this.cbb_service.Size = new System.Drawing.Size(233, 24);
            this.cbb_service.TabIndex = 37;
            this.cbb_service.SelectedIndexChanged += new System.EventHandler(this.cbb_service_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Serivce";
            // 
            // dataWedding
            // 
            this.dataWedding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataWedding.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataWedding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWedding.Location = new System.Drawing.Point(12, 310);
            this.dataWedding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataWedding.Name = "dataWedding";
            this.dataWedding.RowHeadersWidth = 51;
            this.dataWedding.RowTemplate.Height = 24;
            this.dataWedding.Size = new System.Drawing.Size(616, 199);
            this.dataWedding.TabIndex = 57;
            this.dataWedding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataWedding_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(984, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NhanTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1013, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.dataWedding);
            this.Controls.Add(this.btn_delete_wedding);
            this.Controls.Add(this.btn_update_wedding);
            this.Controls.Add(this.btn_add_wedding);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wedding);
            this.Controls.Add(this.label_tittle_wedding_in4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1013, 562);
            this.Name = "NhanTiec";
            this.Text = "NhanTiec";
            this.Load += new System.EventHandler(this.NhanTiec_Load);
            this.wedding.ResumeLayout(false);
            this.wedding.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWedding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomeBorderTextbox tb_phone;
        private CustomeBorderTextbox tb_representative;
        private System.Windows.Forms.Label label_bookdate;
        private System.Windows.Forms.Label label_tittle_wedding_in4;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_representative;
        private CustomeBorderTextbox tb_bride;
        private CustomeBorderTextbox tb_groom;
        private System.Windows.Forms.Label label_bride;
        private System.Windows.Forms.Label label_groom;
        private System.Windows.Forms.Label label_weddingdate;
        private CustomeBorderTextbox tb_deposit;
        private CustomeBorderTextbox tb_contigency;
        private System.Windows.Forms.Label label_deposit;
        private System.Windows.Forms.Label label_contingency;
        private CustomeBorderTextbox tb_table;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.GroupBox wedding;
        private System.Windows.Forms.DateTimePicker date_booking;
        private System.Windows.Forms.DateTimePicker date_wedding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_wedding;
        private System.Windows.Forms.Button btn_update_wedding;
        private System.Windows.Forms.Button btn_delete_wedding;
        private System.Windows.Forms.ComboBox cbb_lobby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_shift;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private CustomeBorderTextbox tb_price_dishes;
        private System.Windows.Forms.Button btn_add_menu;
        private System.Windows.Forms.Label label_dishes_price;
        private System.Windows.Forms.Label label_amount_dishes;
        private System.Windows.Forms.ComboBox cbb_dishes;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomeBorderTextbox tb_price_service;
        private System.Windows.Forms.Button btn_add_service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_service;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataWedding;
        private CustomeBorderTextbox tb_dishes_price;
        private CustomeBorderTextbox tb_service_price;
        private System.Windows.Forms.Button btn_detail_dishes;
        private System.Windows.Forms.Button btn_detail_service;
        private System.Windows.Forms.Label label6;
    }
}