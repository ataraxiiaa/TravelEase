namespace TravelEase
{
    partial class StartScreen
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tourOperatorPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.to_lbl = new System.Windows.Forms.Label();
            this.serviceProviderPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sp_lbl = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.admin_lbl = new System.Windows.Forms.Label();
            this.touristPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tourist_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.tourOperatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.serviceProviderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.touristPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(351, 25);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(477, 46);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Welcome to TravelEase!";
            this.title_lbl.Click += new System.EventHandler(this.title_lbl_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.mainPanel.Controls.Add(this.tourOperatorPanel);
            this.mainPanel.Controls.Add(this.serviceProviderPanel);
            this.mainPanel.Controls.Add(this.adminPanel);
            this.mainPanel.Controls.Add(this.touristPanel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Location = new System.Drawing.Point(119, 58);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1166, 567);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // tourOperatorPanel
            // 
            this.tourOperatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tourOperatorPanel.Controls.Add(this.pictureBox4);
            this.tourOperatorPanel.Controls.Add(this.to_lbl);
            this.tourOperatorPanel.Location = new System.Drawing.Point(185, 315);
            this.tourOperatorPanel.Name = "tourOperatorPanel";
            this.tourOperatorPanel.Size = new System.Drawing.Size(281, 152);
            this.tourOperatorPanel.TabIndex = 2;
            this.tourOperatorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.tourOperatorPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            this.tourOperatorPanel.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.tourOperatorPanel.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TravelEase.Properties.Resources.icons8_online_support_skin_type_3_100;
            this.pictureBox4.Location = new System.Drawing.Point(174, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 116);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // to_lbl
            // 
            this.to_lbl.AllowDrop = true;
            this.to_lbl.AutoSize = true;
            this.to_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_lbl.ForeColor = System.Drawing.Color.White;
            this.to_lbl.Location = new System.Drawing.Point(3, 29);
            this.to_lbl.Name = "to_lbl";
            this.to_lbl.Size = new System.Drawing.Size(139, 72);
            this.to_lbl.TabIndex = 0;
            this.to_lbl.Text = "Tour \r\nOperator\r\n";
            this.to_lbl.Click += new System.EventHandler(this.label1_Click);
            this.to_lbl.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.to_lbl.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // serviceProviderPanel
            // 
            this.serviceProviderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.serviceProviderPanel.Controls.Add(this.pictureBox3);
            this.serviceProviderPanel.Controls.Add(this.sp_lbl);
            this.serviceProviderPanel.Location = new System.Drawing.Point(645, 315);
            this.serviceProviderPanel.Name = "serviceProviderPanel";
            this.serviceProviderPanel.Size = new System.Drawing.Size(281, 152);
            this.serviceProviderPanel.TabIndex = 2;
            this.serviceProviderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.serviceProviderPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            this.serviceProviderPanel.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.serviceProviderPanel.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TravelEase.Properties.Resources.icons8_5_star_hotel_100;
            this.pictureBox3.Location = new System.Drawing.Point(172, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 114);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // sp_lbl
            // 
            this.sp_lbl.AutoSize = true;
            this.sp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_lbl.ForeColor = System.Drawing.Color.White;
            this.sp_lbl.Location = new System.Drawing.Point(3, 29);
            this.sp_lbl.Name = "sp_lbl";
            this.sp_lbl.Size = new System.Drawing.Size(135, 72);
            this.sp_lbl.TabIndex = 0;
            this.sp_lbl.Text = "Service\r\nProvider\r\n";
            this.sp_lbl.Click += new System.EventHandler(this.label1_Click);
            this.sp_lbl.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.sp_lbl.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.adminPanel.Controls.Add(this.pictureBox2);
            this.adminPanel.Controls.Add(this.admin_lbl);
            this.adminPanel.Location = new System.Drawing.Point(645, 118);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(281, 152);
            this.adminPanel.TabIndex = 2;
            this.adminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.adminPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            this.adminPanel.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.adminPanel.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TravelEase.Properties.Resources.icons8_administrator_male_100;
            this.pictureBox2.Location = new System.Drawing.Point(167, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 119);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lbl.ForeColor = System.Drawing.Color.White;
            this.admin_lbl.Location = new System.Drawing.Point(3, 51);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(105, 36);
            this.admin_lbl.TabIndex = 0;
            this.admin_lbl.Text = "Admin";
            this.admin_lbl.Click += new System.EventHandler(this.label1_Click);
            this.admin_lbl.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.admin_lbl.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // touristPanel
            // 
            this.touristPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.touristPanel.Controls.Add(this.pictureBox1);
            this.touristPanel.Controls.Add(this.tourist_lbl);
            this.touristPanel.Location = new System.Drawing.Point(185, 119);
            this.touristPanel.Name = "touristPanel";
            this.touristPanel.Size = new System.Drawing.Size(281, 152);
            this.touristPanel.TabIndex = 2;
            this.touristPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.touristPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.touristPanel.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.touristPanel.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelEase.Properties.Resources.adventurer__2_;
            this.pictureBox1.Location = new System.Drawing.Point(167, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 146);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // tourist_lbl
            // 
            this.tourist_lbl.AutoSize = true;
            this.tourist_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourist_lbl.ForeColor = System.Drawing.Color.White;
            this.tourist_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tourist_lbl.Location = new System.Drawing.Point(3, 50);
            this.tourist_lbl.Name = "tourist_lbl";
            this.tourist_lbl.Size = new System.Drawing.Size(114, 36);
            this.tourist_lbl.TabIndex = 0;
            this.tourist_lbl.Text = "Tourist";
            this.tourist_lbl.Click += new System.EventHandler(this.label1_Click);
            this.tourist_lbl.MouseEnter += new System.EventHandler(this.panel_HoverEnter);
            this.tourist_lbl.MouseLeave += new System.EventHandler(this.panel_HoverLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.title_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 85);
            this.panel1.TabIndex = 1;
            // 
            // StartScreen
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1441, 693);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.mainPanel.ResumeLayout(false);
            this.tourOperatorPanel.ResumeLayout(false);
            this.tourOperatorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.serviceProviderPanel.ResumeLayout(false);
            this.serviceProviderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.touristPanel.ResumeLayout(false);
            this.touristPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel touristPanel;
        private System.Windows.Forms.Label tourist_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel tourOperatorPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label to_lbl;
        private System.Windows.Forms.Panel serviceProviderPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label sp_lbl;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label admin_lbl;
    }
}