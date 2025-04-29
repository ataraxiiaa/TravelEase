using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TravelEase
{
    partial class A_Reviews
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.reviewsTabControl = new System.Windows.Forms.TabControl();
            this.tripReviewsTab = new System.Windows.Forms.TabPage();
            this.tripReviewsDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceReviewsTab = new System.Windows.Forms.TabPage();
            this.serviceReviewsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.approveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reviewsTabControl.SuspendLayout();
            this.tripReviewsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripReviewsDataGridView)).BeginInit();
            this.serviceReviewsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReviewsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(3, 0);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(309, 51);
            this.Reviews_lbl.TabIndex = 0;
            this.Reviews_lbl.Text = "Manage Reviews";
            // 
            // reviewsTabControl
            // 
            this.reviewsTabControl.Controls.Add(this.tripReviewsTab);
            this.reviewsTabControl.Controls.Add(this.serviceReviewsTab);
            this.reviewsTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reviewsTabControl.Location = new System.Drawing.Point(25, 110);
            this.reviewsTabControl.Name = "reviewsTabControl";
            this.reviewsTabControl.SelectedIndex = 0;
            this.reviewsTabControl.Size = new System.Drawing.Size(900, 360);
            this.reviewsTabControl.TabIndex = 4;
            // 
            // tripReviewsTab
            // 
            this.tripReviewsTab.Controls.Add(this.tripReviewsDataGridView);
            this.tripReviewsTab.Location = new System.Drawing.Point(4, 32);
            this.tripReviewsTab.Name = "tripReviewsTab";
            this.tripReviewsTab.Padding = new System.Windows.Forms.Padding(3);
            this.tripReviewsTab.Size = new System.Drawing.Size(892, 324);
            this.tripReviewsTab.TabIndex = 0;
            this.tripReviewsTab.Text = "Trip Reviews";
            // 
            // tripReviewsDataGridView
            // 
            this.tripReviewsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tripReviewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripReviewsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tripReviewsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tripReviewsDataGridView.Name = "tripReviewsDataGridView";
            this.tripReviewsDataGridView.RowHeadersWidth = 51;
            this.tripReviewsDataGridView.Size = new System.Drawing.Size(886, 318);
            this.tripReviewsDataGridView.TabIndex = 0;
            // 
            // serviceReviewsTab
            // 
            this.serviceReviewsTab.Controls.Add(this.serviceReviewsDataGridView);
            this.serviceReviewsTab.Location = new System.Drawing.Point(4, 32);
            this.serviceReviewsTab.Name = "serviceReviewsTab";
            this.serviceReviewsTab.Padding = new System.Windows.Forms.Padding(3);
            this.serviceReviewsTab.Size = new System.Drawing.Size(892, 324);
            this.serviceReviewsTab.TabIndex = 1;
            this.serviceReviewsTab.Text = "Service Reviews";
            // 
            // serviceReviewsDataGridView
            // 
            this.serviceReviewsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceReviewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceReviewsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceReviewsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.serviceReviewsDataGridView.Name = "serviceReviewsDataGridView";
            this.serviceReviewsDataGridView.RowHeadersWidth = 51;
            this.serviceReviewsDataGridView.Size = new System.Drawing.Size(886, 318);
            this.serviceReviewsDataGridView.TabIndex = 0;
            // 
            // searchTextbox
            // 
            this.searchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextbox.Location = new System.Drawing.Point(20, 70);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(300, 22);
            this.searchTextbox.TabIndex = 7;
            this.searchTextbox.Text = "Search for users...";
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextbox.GotFocus += new System.EventHandler(this.searchTextBox_GotFocus);
            this.searchTextbox.LostFocus += new System.EventHandler(this.searchTextBox_LostFocus);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(326, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(950, 142);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(150, 40);
            this.approveButton.TabIndex = 5;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(950, 191);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 40);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // A_Reviews
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.Reviews_lbl);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reviewsTabControl);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "A_Reviews";
            this.Size = new System.Drawing.Size(1150, 500);
            this.Load += new System.EventHandler(this.A_Reviews_Load);
            this.reviewsTabControl.ResumeLayout(false);
            this.tripReviewsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tripReviewsDataGridView)).EndInit();
            this.serviceReviewsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceReviewsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reviews_lbl;
        private System.Windows.Forms.TabControl reviewsTabControl;
        private System.Windows.Forms.TabPage tripReviewsTab;
        private System.Windows.Forms.TabPage serviceReviewsTab;
        private System.Windows.Forms.DataGridView tripReviewsDataGridView;
        private System.Windows.Forms.DataGridView serviceReviewsDataGridView;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
