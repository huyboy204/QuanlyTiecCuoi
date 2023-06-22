namespace WeddingManagementApplication
{
    partial class LobbyDropDown
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
            this.btnLobbyType = new System.Windows.Forms.Button();
            this.btnLobby = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLobbyType
            // 
            this.btnLobbyType.BackColor = System.Drawing.Color.IndianRed;
            this.btnLobbyType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLobbyType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLobbyType.Location = new System.Drawing.Point(3, 3);
            this.btnLobbyType.Name = "btnLobbyType";
            this.btnLobbyType.Size = new System.Drawing.Size(144, 40);
            this.btnLobbyType.TabIndex = 0;
            this.btnLobbyType.Text = "Lobby Type";
            this.btnLobbyType.UseVisualStyleBackColor = false;
            this.btnLobbyType.Click += new System.EventHandler(this.btnLobbyType_Click);
            // 
            // btnLobby
            // 
            this.btnLobby.BackColor = System.Drawing.Color.IndianRed;
            this.btnLobby.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLobby.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLobby.Location = new System.Drawing.Point(3, 49);
            this.btnLobby.Name = "btnLobby";
            this.btnLobby.Size = new System.Drawing.Size(144, 40);
            this.btnLobby.TabIndex = 1;
            this.btnLobby.Text = "Lobby";
            this.btnLobby.UseVisualStyleBackColor = false;
            this.btnLobby.Click += new System.EventHandler(this.btnLobby_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLobbyType);
            this.flowLayoutPanel1.Controls.Add(this.btnLobby);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 97);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // LobbyDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(204)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(150, 97);
            this.Name = "LobbyDropDown";
            this.Size = new System.Drawing.Size(150, 97);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLobbyType;
        private System.Windows.Forms.Button btnLobby;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
