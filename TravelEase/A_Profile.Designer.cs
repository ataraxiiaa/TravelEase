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
            this.searchPreference = new System.Windows.Forms.TextBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.travelHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.travelHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPreference
            // 
            this.searchPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPreference.ForeColor = System.Drawing.Color.Gray;
            this.searchPreference.Location = new System.Drawing.Point(195, 50);
            this.searchPreference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPreference.Name = "searchPreference";
            this.searchPreference.Size = new System.Drawing.Size(226, 28);
            this.searchPreference.TabIndex = 13;
            this.searchPreference.Text = "Update Preferences";
            this.searchPreference.Enter += new System.EventHandler(this.searchPreference_Enter);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(503, 50);
            this.approveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(112, 32);
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
            this.history.Location = new System.Drawing.Point(315, 110);
            this.history.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(162, 32);
            this.history.TabIndex = 17;
            this.history.Text = " View Travel History";
            this.history.UseVisualStyleBackColor = false;
            // 
            // travelHistory
            // 
            this.travelHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelHistory.Location = new System.Drawing.Point(73, 170);
            this.travelHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.travelHistory.Name = "travelHistory";
            this.travelHistory.RowHeadersWidth = 51;
            this.travelHistory.Size = new System.Drawing.Size(658, 228);
            this.travelHistory.TabIndex = 18;
            this.travelHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.travelHistory_CellContentClick);
            // 
            // A_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.travelHistory);
            this.Controls.Add(this.history);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.searchPreference);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "A_Profile";
            this.Size = new System.Drawing.Size(775, 422);
            ((System.ComponentModel.ISupportInitialize)(this.travelHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchPreference;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.DataGridView travelHistory;
    }
}
