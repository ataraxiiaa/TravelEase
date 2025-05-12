namespace TravelEase
{
    partial class A_TripRating
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
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.comboBoxTripID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(429, 29);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(174, 41);
            this.Reviews_lbl.TabIndex = 8;
            this.Reviews_lbl.Text = "Review Trip";
            this.Reviews_lbl.Click += new System.EventHandler(this.Reviews_lbl_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(118, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 298);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(436, 468);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(150, 40);
            this.approveButton.TabIndex = 16;
            this.approveButton.Text = "Submit";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // comboBoxTripID
            // 
            this.comboBoxTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTripID.FormattingEnabled = true;
            this.comboBoxTripID.Location = new System.Drawing.Point(301, 98);
            this.comboBoxTripID.Name = "comboBoxTripID";
            this.comboBoxTripID.Size = new System.Drawing.Size(184, 28);
            this.comboBoxTripID.TabIndex = 17;
            this.comboBoxTripID.SelectedIndexChanged += new System.EventHandler(this.comboBoxTripID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose TripID";
            // 
            // textBoxRating
            // 
            this.textBoxRating.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRating.Location = new System.Drawing.Point(697, 98);
            this.textBoxRating.Multiline = true;
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(121, 28);
            this.textBoxRating.TabIndex = 19;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rating (Out of 5)";
            // 
            // A_TripRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTripID);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reviews_lbl);
            this.Name = "A_TripRating";
            this.Size = new System.Drawing.Size(961, 536);
            this.Load += new System.EventHandler(this.A_TripRating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reviews_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.ComboBox comboBoxTripID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label label2;
    }
}
