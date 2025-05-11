using System.Windows.Forms;

namespace TravelEase
{
    partial class TO_ManageTrips
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteTripbtn = new System.Windows.Forms.Button();
            this.AddTripbtn = new System.Windows.Forms.Button();
            this.TripsDataGridView = new System.Windows.Forms.DataGridView();
            this.trips_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TripsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(13, 68);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 20);
            this.searchTextBox.TabIndex = 29;
            this.searchTextBox.Text = "Search for Trips...";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.ItemHeight = 13;
            this.filterComboBox.Items.AddRange(new object[] {
            "TripID",
            "Group Size",
            "Destination",
            "Price",
            "Duration"});
            this.filterComboBox.Location = new System.Drawing.Point(241, 66);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(112, 21);
            this.filterComboBox.TabIndex = 28;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(359, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(106, 24);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(1005, 241);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(173, 45);
            this.refreshButton.TabIndex = 26;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteTripbtn
            // 
            this.deleteTripbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.deleteTripbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTripbtn.ForeColor = System.Drawing.Color.White;
            this.deleteTripbtn.Location = new System.Drawing.Point(1005, 179);
            this.deleteTripbtn.Name = "deleteTripbtn";
            this.deleteTripbtn.Size = new System.Drawing.Size(172, 45);
            this.deleteTripbtn.TabIndex = 25;
            this.deleteTripbtn.Text = "Delete Trip";
            this.deleteTripbtn.UseVisualStyleBackColor = false;
            this.deleteTripbtn.Click += new System.EventHandler(this.deleteTripbtn_Click);
            // 
            // AddTripbtn
            // 
            this.AddTripbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddTripbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTripbtn.ForeColor = System.Drawing.Color.White;
            this.AddTripbtn.Location = new System.Drawing.Point(1005, 118);
            this.AddTripbtn.Name = "AddTripbtn";
            this.AddTripbtn.Size = new System.Drawing.Size(172, 43);
            this.AddTripbtn.TabIndex = 24;
            this.AddTripbtn.Text = "Add Trip";
            this.AddTripbtn.UseVisualStyleBackColor = false;
            this.AddTripbtn.Click += new System.EventHandler(this.AddTripbtn_Click);
            // 
            // TripsDataGridView
            // 
            this.TripsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TripsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TripsDataGridView.Location = new System.Drawing.Point(13, 118);
            this.TripsDataGridView.Name = "TripsDataGridView";
            this.TripsDataGridView.RowHeadersWidth = 51;
            this.TripsDataGridView.Size = new System.Drawing.Size(966, 400);
            this.TripsDataGridView.TabIndex = 23;
            // 
            // trips_lbl
            // 
            this.trips_lbl.AutoSize = true;
            this.trips_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.trips_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trips_lbl.ForeColor = System.Drawing.Color.White;
            this.trips_lbl.Location = new System.Drawing.Point(0, 0);
            this.trips_lbl.Name = "trips_lbl";
            this.trips_lbl.Size = new System.Drawing.Size(181, 37);
            this.trips_lbl.TabIndex = 22;
            this.trips_lbl.Text = "Manage Trips";
            // 
            // TO_ManageTrips
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteTripbtn);
            this.Controls.Add(this.AddTripbtn);
            this.Controls.Add(this.TripsDataGridView);
            this.Controls.Add(this.trips_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TO_ManageTrips";
            this.Size = new System.Drawing.Size(1187, 588);
            this.Load += new System.EventHandler(this.TO_ManageTrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TripsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button deleteTripbtn;
        private System.Windows.Forms.Button AddTripbtn;
        private System.Windows.Forms.DataGridView TripsDataGridView;
        private System.Windows.Forms.Label trips_lbl;
    }
}
