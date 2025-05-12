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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
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
            this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
            // 
            // TripIdBook
            // 
            this.TripIdBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TripIdBook.Font = this.comboBoxDate.Font;
            this.TripIdBook.Location = new System.Drawing.Point(940, 85);
            this.TripIdBook.Name = "TripIdBook";
            this.TripIdBook.Size = new System.Drawing.Size(150, 27);
            this.TripIdBook.TabIndex = 10;
            this.TripIdBook.TextChanged += new System.EventHandler(this.TripIdBook_TextChanged_1);
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
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(936, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Trip ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Group Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(430, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(568, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(704, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Activity Type";
            // 
            // A_TripSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.A_TripSearchBook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox TripIdBook;
        private System.Windows.Forms.Button buttonBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
