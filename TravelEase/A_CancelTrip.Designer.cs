namespace TravelEase
{
    partial class A_CancelTrip
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
            this.CancelSearchTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelSearchTextBox
            // 
            this.CancelSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSearchTextBox.Location = new System.Drawing.Point(266, 101);
            this.CancelSearchTextBox.Name = "CancelSearchTextBox";
            this.CancelSearchTextBox.Size = new System.Drawing.Size(222, 28);
            this.CancelSearchTextBox.TabIndex = 11;
            this.CancelSearchTextBox.Text = "Enter Trip To Cancel";
            this.CancelSearchTextBox.Enter += new System.EventHandler(this.CancelSearchTextBox_Enter);

            //this.CancelSearchTextBox.TextChanged += new System.EventHandler(this.CancelSearchTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(521, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(108, 29);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(357, 24);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(169, 41);
            this.Reviews_lbl.TabIndex = 14;
            this.Reviews_lbl.Text = "Cancel Trip";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(27, 154);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.Size = new System.Drawing.Size(803, 327);
            this.usersDataGridView.TabIndex = 15;
            // 
            // A_CancelTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.Reviews_lbl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CancelSearchTextBox);
            this.Name = "A_CancelTrip";
            this.Size = new System.Drawing.Size(861, 507);
            this.Load += new System.EventHandler(this.A_CancelTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CancelSearchTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Reviews_lbl;
        private System.Windows.Forms.DataGridView usersDataGridView;
    }
}
