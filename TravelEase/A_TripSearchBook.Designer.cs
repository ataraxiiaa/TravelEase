// A_TripSearchBook.Designer.cs
using System.Windows.Forms;

namespace TravelEase
{
    partial class A_TripSearchBook
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewResults;

        private System.Windows.Forms.Label BookTrip;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.ComboBox comboBoxGroupSize;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.ComboBox comboBoxActivityType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.BookTrip = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.comboBoxGroupSize = new System.Windows.Forms.ComboBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.comboBoxActivityType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.TripIdBook = new System.Windows.Forms.TextBox();
            this.buttonBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // BookTrip
            // 
            this.BookTrip.AutoSize = true;
            this.BookTrip.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.BookTrip.ForeColor = System.Drawing.Color.White;
            this.BookTrip.Location = new System.Drawing.Point(400, 20);
            this.BookTrip.Name = "BookTrip";
            this.BookTrip.Size = new System.Drawing.Size(139, 31);
            this.BookTrip.TabIndex = 0;
            this.BookTrip.Text = "Book Trip";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(12, 84);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(120, 28);
            this.comboBoxDate.TabIndex = 1;
            this.comboBoxDate.Text = "Date";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(152, 84);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(120, 28);
            this.comboBoxDestination.TabIndex = 2;
            this.comboBoxDestination.Text = "Destination";
            // 
            // comboBoxGroupSize
            // 
            this.comboBoxGroupSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxGroupSize.FormattingEnabled = true;
            this.comboBoxGroupSize.Location = new System.Drawing.Point(292, 84);
            this.comboBoxGroupSize.Name = "comboBoxGroupSize";
            this.comboBoxGroupSize.Size = new System.Drawing.Size(120, 28);
            this.comboBoxGroupSize.TabIndex = 3;
            this.comboBoxGroupSize.Text = "Group Size";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Location = new System.Drawing.Point(432, 84);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(120, 28);
            this.comboBoxDuration.TabIndex = 4;
            this.comboBoxDuration.Text = "Duration";
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(572, 84);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(120, 28);
            this.comboBoxRating.TabIndex = 5;
            this.comboBoxRating.Text = "Rating";
            // 
            // comboBoxActivityType
            // 
            this.comboBoxActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxActivityType.FormattingEnabled = true;
            this.comboBoxActivityType.Location = new System.Drawing.Point(708, 84);
            this.comboBoxActivityType.Name = "comboBoxActivityType";
            this.comboBoxActivityType.Size = new System.Drawing.Size(120, 28);
            this.comboBoxActivityType.TabIndex = 6;
            this.comboBoxActivityType.Text = "Activity Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(362, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeight = 29;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 210);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.Size = new System.Drawing.Size(1100, 370);
            this.dataGridViewResults.TabIndex = 12;
            // 
            // TripIdBook
            // 
            this.TripIdBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TripIdBook.Font = this.comboBoxDate.Font;
            this.TripIdBook.Location = new System.Drawing.Point(940, 85);
            this.TripIdBook.Name = "TripIdBook";
            this.TripIdBook.Size = new System.Drawing.Size(150, 27);
            this.TripIdBook.TabIndex = 10;
            this.TripIdBook.Text = "Enter TripId";
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.White;
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonBook.Location = new System.Drawing.Point(873, 134);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(100, 35);
            this.buttonBook.TabIndex = 10;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            // 
            // A_TripSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.TripIdBook);
            this.Controls.Add(this.BookTrip);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.comboBoxGroupSize);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.comboBoxActivityType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "A_TripSearchBook";
            this.Size = new System.Drawing.Size(1100, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox TripIdBook;
        private System.Windows.Forms.Button buttonBook;
    }
}
