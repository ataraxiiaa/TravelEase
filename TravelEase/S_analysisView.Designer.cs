namespace TravelEase
{
    partial class S_analysisView
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
            this.components = new System.ComponentModel.Container();
            this.analysisHeader = new System.Windows.Forms.Label();
            this.getFeedbackButton = new System.Windows.Forms.Button();
            this.getRevenueButton = new System.Windows.Forms.Button();
            this.getOccupanyButton = new System.Windows.Forms.Button();
            this.tourismDatabaseDataSet = new TravelEase.tourismDatabaseDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new TravelEase.tourismDatabaseDataSetTableAdapters.ServicesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.analysisPanel.SuspendLayout();
            this.SuspendLayout();
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
            // getFeedbackButton
            // 
            this.getFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.getFeedbackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getFeedbackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getFeedbackButton.Location = new System.Drawing.Point(89, 463);
            this.getFeedbackButton.Name = "getFeedbackButton";
            this.getFeedbackButton.Size = new System.Drawing.Size(128, 52);
            this.getFeedbackButton.TabIndex = 10;
            this.getFeedbackButton.Text = "Get Feedback";
            this.getFeedbackButton.UseVisualStyleBackColor = false;
            this.getFeedbackButton.Click += new System.EventHandler(this.getFeedbackButton_Click);
            // 
            // getRevenueButton
            // 
            this.getRevenueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.getRevenueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getRevenueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getRevenueButton.Location = new System.Drawing.Point(243, 463);
            this.getRevenueButton.Name = "getRevenueButton";
            this.getRevenueButton.Size = new System.Drawing.Size(128, 52);
            this.getRevenueButton.TabIndex = 11;
            this.getRevenueButton.Text = "Get Revenue";
            this.getRevenueButton.UseVisualStyleBackColor = false;
            this.getRevenueButton.Click += new System.EventHandler(this.getRevenueButton_Click);
            // 
            // getOccupanyButton
            // 
            this.getOccupanyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.getOccupanyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getOccupanyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getOccupanyButton.Location = new System.Drawing.Point(395, 463);
            this.getOccupanyButton.Name = "getOccupanyButton";
            this.getOccupanyButton.Size = new System.Drawing.Size(128, 52);
            this.getOccupanyButton.TabIndex = 12;
            this.getOccupanyButton.Text = "Get Occupany";
            this.getOccupanyButton.UseVisualStyleBackColor = false;
            this.getOccupanyButton.Click += new System.EventHandler(this.getOccupanyButton_Click);
            // 
            // tourismDatabaseDataSet
            // 
            this.tourismDatabaseDataSet.DataSetName = "tourismDatabaseDataSet";
            this.tourismDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.tourismDatabaseDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(618, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get Tourist Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(752, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Get Trip Analysis";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // analysisPanel
            // 
            this.analysisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.analysisPanel.Controls.Add(this.dataGridView1);
            this.analysisPanel.Location = new System.Drawing.Point(8, 108);
            this.analysisPanel.Name = "analysisPanel";
            this.analysisPanel.Size = new System.Drawing.Size(1113, 332);
            this.analysisPanel.TabIndex = 9;
            // 
            // S_analysisView
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getOccupanyButton);
            this.Controls.Add(this.getRevenueButton);
            this.Controls.Add(this.getFeedbackButton);
            this.Controls.Add(this.analysisPanel);
            this.Controls.Add(this.analysisHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "S_analysisView";
            this.Size = new System.Drawing.Size(1375, 693);
            this.Load += new System.EventHandler(this.H_analysisView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.analysisPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label analysisHeader;
        private System.Windows.Forms.Button getFeedbackButton;
        private System.Windows.Forms.Button getRevenueButton;
        private System.Windows.Forms.Button getOccupanyButton;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private tourismDatabaseDataSet tourismDatabaseDataSet;
        private tourismDatabaseDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel analysisPanel;
    }
}
