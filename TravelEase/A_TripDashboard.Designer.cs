namespace TravelEase
{
    partial class A_TripDashboard
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
            this.canceltrip = new System.Windows.Forms.Button();
            this.bookConfirm = new System.Windows.Forms.Button();
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.upcomingtrip = new System.Windows.Forms.Button();
            this.queriesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.queriesDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // canceltrip
            // 
            this.canceltrip.BackColor = System.Drawing.Color.White;
            this.canceltrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canceltrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceltrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.canceltrip.Location = new System.Drawing.Point(28, 293);
            this.canceltrip.Name = "canceltrip";
            this.canceltrip.Size = new System.Drawing.Size(269, 47);
            this.canceltrip.TabIndex = 17;
            this.canceltrip.Text = "Cancel Trip";
            this.canceltrip.UseVisualStyleBackColor = false;
            this.canceltrip.Click += new System.EventHandler(this.canceltrip_Click);
            // 
            // bookConfirm
            // 
            this.bookConfirm.BackColor = System.Drawing.Color.White;
            this.bookConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bookConfirm.Location = new System.Drawing.Point(28, 217);
            this.bookConfirm.Name = "bookConfirm";
            this.bookConfirm.Size = new System.Drawing.Size(269, 47);
            this.bookConfirm.TabIndex = 15;
            this.bookConfirm.Text = "Booking Confirmation";
            this.bookConfirm.UseVisualStyleBackColor = false;
            this.bookConfirm.Click += new System.EventHandler(this.booktrip_Click);
            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(21, 25);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(227, 41);
            this.Reviews_lbl.TabIndex = 13;
            this.Reviews_lbl.Text = "Trip Dashboard";
            // 
            // upcomingtrip
            // 
            this.upcomingtrip.BackColor = System.Drawing.Color.White;
            this.upcomingtrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upcomingtrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingtrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.upcomingtrip.Location = new System.Drawing.Point(28, 139);
            this.upcomingtrip.Name = "upcomingtrip";
            this.upcomingtrip.Size = new System.Drawing.Size(269, 47);
            this.upcomingtrip.TabIndex = 14;
            this.upcomingtrip.Text = "Upcoming Trip";
            this.upcomingtrip.UseVisualStyleBackColor = false;
            this.upcomingtrip.Click += new System.EventHandler(this.upcomingtrip_Click);
            // 
            // queriesDataGridView
            // 
            this.queriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queriesDataGridView.Location = new System.Drawing.Point(351, 139);
            this.queriesDataGridView.Name = "queriesDataGridView";
            this.queriesDataGridView.RowHeadersWidth = 51;
            this.queriesDataGridView.Size = new System.Drawing.Size(545, 357);
            this.queriesDataGridView.TabIndex = 19;
            // 
            // A_TripDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.queriesDataGridView);
            this.Controls.Add(this.canceltrip);
            this.Controls.Add(this.bookConfirm);
            this.Controls.Add(this.Reviews_lbl);
            this.Controls.Add(this.upcomingtrip);
            this.Name = "A_TripDashboard";
            this.Size = new System.Drawing.Size(951, 518);
            ((System.ComponentModel.ISupportInitialize)(this.queriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button canceltrip;
        private System.Windows.Forms.Button bookConfirm;
        private System.Windows.Forms.Label Reviews_lbl;
        private System.Windows.Forms.Button upcomingtrip;
        private System.Windows.Forms.DataGridView queriesDataGridView;
    }
}
