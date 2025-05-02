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
            this.ActTypeText = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DestText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.NameEntryText = new System.Windows.Forms.TextBox();
            this.Bookbut = new System.Windows.Forms.Button();
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
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(27, 206);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.Size = new System.Drawing.Size(780, 327);
            this.usersDataGridView.TabIndex = 16;
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
            //this.DestText.TextChanged += new System.EventHandler(this.DestText_TextChanged);
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
           // this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
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
            //this.GroupText.TextChanged += new System.EventHandler(this.GroupText_TextChanged);
            // 
            // DateText
            // 
            this.DateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateText.Location = new System.Drawing.Point(277, 107);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(120, 28);
            this.DateText.TabIndex = 22;
            this.DateText.Text = "Date";
            this.DateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           // this.DateText.TextChanged += new System.EventHandler(this.DateText_TextChanged);
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
            //this.NameEntryText.TextChanged += new System.EventHandler(this.NameEntryText_TextChanged);
            // 
            this.DestText.Enter += new System.EventHandler(this.DestText_Enter);
            this.DateText.Enter += new System.EventHandler(this.DateText_Enter);
            this.GroupText.Enter += new System.EventHandler(this.GroupText_Enter);
            this.PriceText.Enter += new System.EventHandler(this.PriceText_Enter);
            this.NameEntryText.Enter += new System.EventHandler(this.NameEntryText_Enter);

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
            // A_TripSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
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
    }
}
