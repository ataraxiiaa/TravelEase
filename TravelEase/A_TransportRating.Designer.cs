namespace TravelEase
{
    partial class A_TransportRating
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
            this.approveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(392, 466);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(150, 40);
            this.approveButton.TabIndex = 21;
            this.approveButton.Text = "Submit";
            this.approveButton.UseVisualStyleBackColor = false;
           // this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);

            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(282, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 298);
            this.textBox1.TabIndex = 20;
          //  this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);


            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(340, 21);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(254, 41);
            this.Reviews_lbl.TabIndex = 17;
            this.Reviews_lbl.Text = "Review Transport";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextbox.Location = new System.Drawing.Point(270, 97);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(300, 28);
            this.searchTextbox.TabIndex = 19;
            this.searchTextbox.Text = "Search for Reviews";
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(588, 97);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 30);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // A_TransportRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reviews_lbl);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchButton);
            this.Name = "A_TransportRating";
            this.Size = new System.Drawing.Size(924, 532);
            this.Load += new System.EventHandler(this.A_TransportRating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Reviews_lbl;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
    }
}
