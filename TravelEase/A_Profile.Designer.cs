namespace TravelEase
{
    partial class A_Profile
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
            this.approveButton = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.travelHistory = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BookTrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(671, 62);
            this.approveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(149, 39);
            this.approveButton.TabIndex = 16;
            this.approveButton.Text = "Submit";
            this.approveButton.UseVisualStyleBackColor = false;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Location = new System.Drawing.Point(420, 135);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(216, 39);
            this.history.TabIndex = 17;
            this.history.Text = " View Travel History";
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // travelHistory
            // 
            this.travelHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelHistory.Location = new System.Drawing.Point(97, 209);
            this.travelHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.travelHistory.Name = "travelHistory";
            this.travelHistory.RowHeadersWidth = 51;
            this.travelHistory.Size = new System.Drawing.Size(877, 281);
            this.travelHistory.TabIndex = 18;
            this.travelHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.travelHistory_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 37);
            this.comboBox1.TabIndex = 19;
            // 
            // BookTrip
            // 
            this.BookTrip.AutoSize = true;
            this.BookTrip.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.BookTrip.ForeColor = System.Drawing.Color.White;
            this.BookTrip.Location = new System.Drawing.Point(302, 19);
            this.BookTrip.Name = "BookTrip";
            this.BookTrip.Size = new System.Drawing.Size(258, 31);
            this.BookTrip.TabIndex = 20;
            this.BookTrip.Text = "Update Preference";
            // 
            // A_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.BookTrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.travelHistory);
            this.Controls.Add(this.history);
            this.Controls.Add(this.approveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_Profile";
            this.Size = new System.Drawing.Size(1033, 519);
            this.Load += new System.EventHandler(this.A_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.DataGridView travelHistory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BookTrip;
    }
}
