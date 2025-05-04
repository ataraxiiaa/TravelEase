namespace TravelEase
{
    partial class Hotel
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.manageReservationsButton = new System.Windows.Forms.Button();
            this.serviceListingButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1221, 693);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.manageReservationsButton);
            this.panel2.Controls.Add(this.serviceListingButton);
            this.panel2.Controls.Add(this.analysisButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 693);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 148);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi, Welcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelEase.Properties.Resources.icons8_male_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::TravelEase.Properties.Resources.icons8_settings_30;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(-7, 648);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "Settings";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // manageReservationsButton
            // 
            this.manageReservationsButton.FlatAppearance.BorderSize = 0;
            this.manageReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageReservationsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageReservationsButton.ForeColor = System.Drawing.Color.White;
            this.manageReservationsButton.Image = global::TravelEase.Properties.Resources.icons8_airplane_landing_30;
            this.manageReservationsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageReservationsButton.Location = new System.Drawing.Point(4, 154);
            this.manageReservationsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.manageReservationsButton.Name = "manageReservationsButton";
            this.manageReservationsButton.Size = new System.Drawing.Size(220, 42);
            this.manageReservationsButton.TabIndex = 2;
            this.manageReservationsButton.Text = "Reservations";
            this.manageReservationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.manageReservationsButton.UseVisualStyleBackColor = true;
            this.manageReservationsButton.Click += new System.EventHandler(this.manageReservationsButton_Click);
            // 
            // serviceListingButton
            // 
            this.serviceListingButton.FlatAppearance.BorderSize = 0;
            this.serviceListingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceListingButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceListingButton.ForeColor = System.Drawing.Color.White;
            this.serviceListingButton.Image = global::TravelEase.Properties.Resources.icons8_seo_text_30__1_;
            this.serviceListingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serviceListingButton.Location = new System.Drawing.Point(0, 202);
            this.serviceListingButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serviceListingButton.Name = "serviceListingButton";
            this.serviceListingButton.Size = new System.Drawing.Size(220, 42);
            this.serviceListingButton.TabIndex = 2;
            this.serviceListingButton.Text = "Service Listing";
            this.serviceListingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.serviceListingButton.UseVisualStyleBackColor = true;
            this.serviceListingButton.Click += new System.EventHandler(this.serviceListingButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.FlatAppearance.BorderSize = 0;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisButton.ForeColor = System.Drawing.Color.White;
            this.analysisButton.Image = global::TravelEase.Properties.Resources.icons8_home_501;
            this.analysisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analysisButton.Location = new System.Drawing.Point(0, 250);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(220, 42);
            this.analysisButton.TabIndex = 2;
            this.analysisButton.Text = "Service Analysis";
            this.analysisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // Hotel
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1441, 693);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Hotel_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button manageReservationsButton;
        private System.Windows.Forms.Button serviceListingButton;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.Panel panelMain;
    }
}