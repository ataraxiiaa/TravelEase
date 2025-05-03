namespace TravelEase
{
    partial class A_TripSearchBook
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
            this.BookTripButton = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripGroupSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActTypeText = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DestText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.NameEntryText = new System.Windows.Forms.TextBox();
            this.Bookbut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookTripButton
            // 
            this.BookTripButton.AutoSize = true;
            this.BookTripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTripButton.ForeColor = System.Drawing.Color.White;
            this.BookTripButton.Location = new System.Drawing.Point(429, 0);
            this.BookTripButton.Name = "BookTripButton";
            this.BookTripButton.Size = new System.Drawing.Size(148, 41);
            this.BookTripButton.TabIndex = 15;
            this.BookTripButton.Text = "Book Trip";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.AllowUserToResizeColumns = false;
            this.usersDataGridView.AllowUserToResizeRows = false;
            this.usersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.ColumnHeadersVisible = false;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripID,
            this.TripPrice,
            this.TripDate,
            this.TripGroupSize,
            this.TripDuration,
            this.TripRating,
            this.TripDestination,
            this.TripCategory});
            this.usersDataGridView.Location = new System.Drawing.Point(26, 209);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.Size = new System.Drawing.Size(780, 327);
            this.usersDataGridView.TabIndex = 16;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellContentClick);
            // 
            // TripID
            // 
            this.TripID.HeaderText = "ID";
            this.TripID.MinimumWidth = 6;
            this.TripID.Name = "TripID";
            this.TripID.ReadOnly = true;
            this.TripID.Width = 125;
            // 
            // TripPrice
            // 
            this.TripPrice.HeaderText = "Price";
            this.TripPrice.MinimumWidth = 6;
            this.TripPrice.Name = "TripPrice";
            this.TripPrice.ReadOnly = true;
            this.TripPrice.Width = 125;
            // 
            // TripDate
            // 
            this.TripDate.HeaderText = "Date";
            this.TripDate.MinimumWidth = 6;
            this.TripDate.Name = "TripDate";
            this.TripDate.ReadOnly = true;
            this.TripDate.Width = 125;
            // 
            // TripGroupSize
            // 
            this.TripGroupSize.HeaderText = "Group Size";
            this.TripGroupSize.MinimumWidth = 6;
            this.TripGroupSize.Name = "TripGroupSize";
            this.TripGroupSize.ReadOnly = true;
            this.TripGroupSize.Width = 125;
            // 
            // TripDuration
            // 
            this.TripDuration.HeaderText = "Duration";
            this.TripDuration.MinimumWidth = 6;
            this.TripDuration.Name = "TripDuration";
            this.TripDuration.ReadOnly = true;
            this.TripDuration.Width = 125;
            // 
            // TripRating
            // 
            this.TripRating.HeaderText = "Rating";
            this.TripRating.MinimumWidth = 6;
            this.TripRating.Name = "TripRating";
            this.TripRating.ReadOnly = true;
            this.TripRating.Width = 125;
            // 
            // TripDestination
            // 
            this.TripDestination.HeaderText = "Destination";
            this.TripDestination.MinimumWidth = 6;
            this.TripDestination.Name = "TripDestination";
            this.TripDestination.ReadOnly = true;
            this.TripDestination.Width = 125;
            // 
            // TripCategory
            // 
            this.TripCategory.HeaderText = "Category";
            this.TripCategory.MinimumWidth = 6;
            this.TripCategory.Name = "TripCategory";
            this.TripCategory.ReadOnly = true;
            this.TripCategory.Width = 125;
            // 
            // ActTypeText
            // 
            this.ActTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActTypeText.Location = new System.Drawing.Point(277, 62);
            this.ActTypeText.Name = "ActTypeText";
            this.ActTypeText.Size = new System.Drawing.Size(197, 28);
            this.ActTypeText.TabIndex = 17;
            this.ActTypeText.Text = "Activity Type";
            this.ActTypeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ActTypeText.TextChanged += new System.EventHandler(this.ActTypeText_TextChanged);
            this.ActTypeText.Enter += new System.EventHandler(this.ActTypeText_Enter);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(458, 160);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(108, 29);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Filter";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // DestText
            // 
            this.DestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestText.Location = new System.Drawing.Point(539, 62);
            this.DestText.Name = "DestText";
            this.DestText.Size = new System.Drawing.Size(222, 28);
            this.DestText.TabIndex = 19;
            this.DestText.Text = "Destination";
            this.DestText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DestText.Enter += new System.EventHandler(this.DestText_Enter);
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(642, 107);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(119, 28);
            this.PriceText.TabIndex = 20;
            this.PriceText.Text = "Price Range";
            this.PriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceText.Enter += new System.EventHandler(this.PriceText_Enter);
            // 
            // GroupText
            // 
            this.GroupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupText.Location = new System.Drawing.Point(458, 107);
            this.GroupText.Name = "GroupText";
            this.GroupText.Size = new System.Drawing.Size(103, 28);
            this.GroupText.TabIndex = 21;
            this.GroupText.Text = "Group Size";
            this.GroupText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GroupText.Enter += new System.EventHandler(this.GroupText_Enter);
            // 
            // DateText
            // 
            this.DateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateText.Location = new System.Drawing.Point(294, 159);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(120, 28);
            this.DateText.TabIndex = 22;
            this.DateText.Text = "Date";
            this.DateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateText.Enter += new System.EventHandler(this.DateText_Enter);
            // 
            // NameEntryText
            // 
            this.NameEntryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEntryText.Location = new System.Drawing.Point(812, 319);
            this.NameEntryText.Name = "NameEntryText";
            this.NameEntryText.Size = new System.Drawing.Size(197, 28);
            this.NameEntryText.TabIndex = 23;
            this.NameEntryText.Text = "Enter Name Of Trip";
            this.NameEntryText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameEntryText.Enter += new System.EventHandler(this.NameEntryText_Enter);
            // 
            // Bookbut
            // 
            this.Bookbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Bookbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bookbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookbut.ForeColor = System.Drawing.Color.White;
            this.Bookbut.Location = new System.Drawing.Point(858, 371);
            this.Bookbut.Name = "Bookbut";
            this.Bookbut.Size = new System.Drawing.Size(108, 29);
            this.Bookbut.TabIndex = 24;
            this.Bookbut.Text = "Book";
            this.Bookbut.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // A_TripSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Bookbut);
            this.Controls.Add(this.NameEntryText);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.GroupText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.DestText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ActTypeText);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.BookTripButton);
            this.Name = "A_TripSearchBook";
            this.Size = new System.Drawing.Size(1009, 536);
            this.Load += new System.EventHandler(this.A_TripSearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookTripButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.TextBox ActTypeText;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox DestText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox GroupText;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.TextBox NameEntryText;
        private System.Windows.Forms.Button Bookbut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripGroupSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripCategory;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
