using TravelEase.Properties;

namespace TravelEase
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Reviews_btn = new System.Windows.Forms.Button();
            this.Trips_btn = new System.Windows.Forms.Button();
            this.Users_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Reviews_btn);
            this.panel1.Controls.Add(this.Trips_btn);
            this.panel1.Controls.Add(this.Users_btn);
            this.panel1.Controls.Add(this.Dashboard_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 704);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.username_lbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 148);
            this.panel2.TabIndex = 3;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.ForeColor = System.Drawing.Color.White;
            this.username_lbl.Location = new System.Drawing.Point(88, 125);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(79, 17);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(231, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1214, 704);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
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
            this.button5.Image = global::TravelEase.Properties.Resources.icons8_logout_30__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(0, 651);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "Sign Out";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Reviews_btn
            // 
            this.Reviews_btn.FlatAppearance.BorderSize = 0;
            this.Reviews_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reviews_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_btn.ForeColor = System.Drawing.Color.White;
            this.Reviews_btn.Image = global::TravelEase.Properties.Resources.icons8_filter_25;
            this.Reviews_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Reviews_btn.Location = new System.Drawing.Point(0, 298);
            this.Reviews_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Reviews_btn.Name = "Reviews_btn";
            this.Reviews_btn.Size = new System.Drawing.Size(220, 42);
            this.Reviews_btn.TabIndex = 2;
            this.Reviews_btn.Text = "Manage Reviews";
            this.Reviews_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Reviews_btn.UseVisualStyleBackColor = true;
            this.Reviews_btn.Click += new System.EventHandler(this.Reviews_btn_Click);
            this.Reviews_btn.MouseLeave += new System.EventHandler(this.Reviews_btn_MouseLeave);
            // 
            // Trips_btn
            // 
            this.Trips_btn.FlatAppearance.BorderSize = 0;
            this.Trips_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trips_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trips_btn.ForeColor = System.Drawing.Color.White;
            this.Trips_btn.Image = global::TravelEase.Properties.Resources.icons8_airplane_landing_30;
            this.Trips_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Trips_btn.Location = new System.Drawing.Point(0, 250);
            this.Trips_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trips_btn.Name = "Trips_btn";
            this.Trips_btn.Size = new System.Drawing.Size(220, 42);
            this.Trips_btn.TabIndex = 2;
            this.Trips_btn.Text = "Manage Trips";
            this.Trips_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Trips_btn.UseVisualStyleBackColor = true;
            this.Trips_btn.Click += new System.EventHandler(this.Trips_btn_Click);
            this.Trips_btn.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // Users_btn
            // 
            this.Users_btn.FlatAppearance.BorderSize = 0;
            this.Users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_btn.ForeColor = System.Drawing.Color.White;
            this.Users_btn.Image = global::TravelEase.Properties.Resources.icons8_user_30;
            this.Users_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Users_btn.Location = new System.Drawing.Point(0, 202);
            this.Users_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Users_btn.Name = "Users_btn";
            this.Users_btn.Size = new System.Drawing.Size(220, 42);
            this.Users_btn.TabIndex = 2;
            this.Users_btn.Text = "Manage Users";
            this.Users_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Users_btn.UseVisualStyleBackColor = true;
            this.Users_btn.Click += new System.EventHandler(this.Users_btn_Click);
            this.Users_btn.MouseLeave += new System.EventHandler(this.Users_btn_MouseLeave);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Image = global::TravelEase.Properties.Resources.icons8_home_501;
            this.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dashboard_btn.Location = new System.Drawing.Point(0, 154);
            this.Dashboard_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(220, 42);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "Dashboard";
            this.Dashboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            this.Dashboard_btn.MouseLeave += new System.EventHandler(this.Dashboard_btn_MouseLeave);
            // 
            // Admin
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1445, 704);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Reviews_btn;
        private System.Windows.Forms.Button Trips_btn;
        private System.Windows.Forms.Button Users_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label username_lbl;
    }
}