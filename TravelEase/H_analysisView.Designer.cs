namespace TravelEase
{
    partial class H_analysisView
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
            this.analysisPanel = new System.Windows.Forms.Panel();
            this.analysisHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // analysisPanel
            // 
            this.analysisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.analysisPanel.Location = new System.Drawing.Point(8, 157);
            this.analysisPanel.Name = "analysisPanel";
            this.analysisPanel.Size = new System.Drawing.Size(1113, 226);
            this.analysisPanel.TabIndex = 9;
            // 
            // analysisHeader
            // 
            this.analysisHeader.AutoSize = true;
            this.analysisHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.analysisHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisHeader.ForeColor = System.Drawing.Color.White;
            this.analysisHeader.Location = new System.Drawing.Point(0, 0);
            this.analysisHeader.Name = "analysisHeader";
            this.analysisHeader.Size = new System.Drawing.Size(141, 45);
            this.analysisHeader.TabIndex = 8;
            this.analysisHeader.Text = "Analysis";
            // 
            // H_analysisView
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.analysisPanel);
            this.Controls.Add(this.analysisHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "H_analysisView";
            this.Size = new System.Drawing.Size(1152, 554);
            this.Load += new System.EventHandler(this.H_analysisView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel analysisPanel;
        private System.Windows.Forms.Label analysisHeader;
    }
}
