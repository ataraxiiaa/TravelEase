namespace TravelEase
{
    partial class Touristcs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Trips_btn = new System.Windows.Forms.Button();
            this.Users_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.Trips_btn);
            this.panel2.Controls.Add(this.Users_btn);
            this.panel2.Controls.Add(this.Dashboard_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 537);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 534);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::TravelEase.Properties.Resources.ChatGPT_Image_May_3__2025__02_08_54_AM__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(-4, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Profile Management";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::TravelEase.Properties.Resources.ChatGPT_Image_May_3__2025__02_08_54_AM__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(-4, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trip Dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button5.Location = new System.Drawing.Point(0, 651);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "Settings";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Trips_btn
            // 
            this.Trips_btn.FlatAppearance.BorderSize = 0;
            this.Trips_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trips_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trips_btn.ForeColor = System.Drawing.Color.White;
            this.Trips_btn.Image = global::TravelEase.Properties.Resources.ChatGPT_Image_May_3__2025__02_08_54_AM__3___2_;
            this.Trips_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Trips_btn.Location = new System.Drawing.Point(-4, 298);
            this.Trips_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trips_btn.Name = "Trips_btn";
            this.Trips_btn.Size = new System.Drawing.Size(220, 42);
            this.Trips_btn.TabIndex = 2;
            this.Trips_btn.Text = "Review";
            this.Trips_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Trips_btn.UseVisualStyleBackColor = true;
            this.Trips_btn.Click += new System.EventHandler(this.Trips_btn_Click);
            // 
            // Users_btn
            // 
            this.Users_btn.FlatAppearance.BorderSize = 0;
            this.Users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_btn.ForeColor = System.Drawing.Color.White;
            this.Users_btn.Image = global::TravelEase.Properties.Resources.icons8_seo_text_30__1_;
            this.Users_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Users_btn.Location = new System.Drawing.Point(-4, 250);
            this.Users_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Users_btn.Name = "Users_btn";
            this.Users_btn.Size = new System.Drawing.Size(220, 42);
            this.Users_btn.TabIndex = 2;
            this.Users_btn.Text = "Digital Travel Pass";
            this.Users_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Users_btn.UseVisualStyleBackColor = true;
            this.Users_btn.Click += new System.EventHandler(this.Users_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Image = global::TravelEase.Properties.Resources.icons8_airplane_landing_30;
            this.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dashboard_btn.Location = new System.Drawing.Point(0, 154);
            this.Dashboard_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(220, 42);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "Trip Booking";
            this.Dashboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // Touristcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1231, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Touristcs";
            this.Text = "Touristcs";
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
        private System.Windows.Forms.Button Trips_btn;
        private System.Windows.Forms.Button Users_btn;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}