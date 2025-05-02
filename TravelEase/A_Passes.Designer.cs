namespace TravelEase
{
    partial class A_Passes
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
            this.ActivityPasses = new System.Windows.Forms.Button();
            this.hotelVoucher = new System.Windows.Forms.Button();
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.ETickets = new System.Windows.Forms.Button();
            this.queriesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.queriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityPasses
            // 
            this.ActivityPasses.BackColor = System.Drawing.Color.White;
            this.ActivityPasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivityPasses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityPasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ActivityPasses.Location = new System.Drawing.Point(46, 300);
            this.ActivityPasses.Name = "ActivityPasses";
            this.ActivityPasses.Size = new System.Drawing.Size(170, 47);
            this.ActivityPasses.TabIndex = 17;
            this.ActivityPasses.Text = "Activity Passes";
            this.ActivityPasses.UseVisualStyleBackColor = false;
            // 
            // hotelVoucher
            // 
            this.hotelVoucher.BackColor = System.Drawing.Color.White;
            this.hotelVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotelVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.hotelVoucher.Location = new System.Drawing.Point(46, 236);
            this.hotelVoucher.Name = "hotelVoucher";
            this.hotelVoucher.Size = new System.Drawing.Size(170, 47);
            this.hotelVoucher.TabIndex = 15;
            this.hotelVoucher.Text = "Hotel Vouchers";
            this.hotelVoucher.UseVisualStyleBackColor = false;
            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(378, 26);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(205, 41);
            this.Reviews_lbl.TabIndex = 13;
            this.Reviews_lbl.Text = "Digital Passes";
            // 
            // ETickets
            // 
            this.ETickets.BackColor = System.Drawing.Color.White;
            this.ETickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ETickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ETickets.Location = new System.Drawing.Point(46, 174);
            this.ETickets.Name = "ETickets";
            this.ETickets.Size = new System.Drawing.Size(170, 47);
            this.ETickets.TabIndex = 14;
            this.ETickets.Text = "E-Tickets";
            this.ETickets.UseVisualStyleBackColor = false;
            // 
            // queriesDataGridView
            // 
            this.queriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queriesDataGridView.Location = new System.Drawing.Point(326, 110);
            this.queriesDataGridView.Name = "queriesDataGridView";
            this.queriesDataGridView.RowHeadersWidth = 51;
            this.queriesDataGridView.Size = new System.Drawing.Size(545, 357);
            this.queriesDataGridView.TabIndex = 18;
            // 
            // A_Passes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.queriesDataGridView);
            this.Controls.Add(this.ActivityPasses);
            this.Controls.Add(this.hotelVoucher);
            this.Controls.Add(this.Reviews_lbl);
            this.Controls.Add(this.ETickets);
            this.Name = "A_Passes";
            this.Size = new System.Drawing.Size(1023, 499);
            ((System.ComponentModel.ISupportInitialize)(this.queriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActivityPasses;
        private System.Windows.Forms.Button hotelVoucher;
        private System.Windows.Forms.Label Reviews_lbl;
        private System.Windows.Forms.Button ETickets;
        private System.Windows.Forms.DataGridView queriesDataGridView;
    }
}
