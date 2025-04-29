namespace TravelEase
{
    partial class A_ManageUsers
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
            this.Users_lbl = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_lbl
            // 
            this.Users_lbl.AutoSize = true;
            this.Users_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Users_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_lbl.ForeColor = System.Drawing.Color.White;
            this.Users_lbl.Location = new System.Drawing.Point(0, 0);
            this.Users_lbl.Name = "Users_lbl";
            this.Users_lbl.Size = new System.Drawing.Size(232, 45);
            this.Users_lbl.TabIndex = 1;
            this.Users_lbl.Text = "Manage Users";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(20, 120);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.Size = new System.Drawing.Size(966, 400);
            this.usersDataGridView.TabIndex = 2;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addUserButton.Location = new System.Drawing.Point(1012, 120);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(172, 42);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            // 
            // editUserButton
            // 
            this.editUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.ForeColor = System.Drawing.Color.White;
            this.editUserButton.Location = new System.Drawing.Point(1012, 181);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(172, 43);
            this.editUserButton.TabIndex = 4;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = false;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.Location = new System.Drawing.Point(1012, 240);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(172, 45);
            this.deleteUserButton.TabIndex = 5;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(1012, 305);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(173, 45);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.Location = new System.Drawing.Point(20, 70);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(300, 23);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.Text = "Search for users...";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.GotFocus += new System.EventHandler(this.searchTextBox_GotFocus);
            this.searchTextBox.LostFocus += new System.EventHandler(this.searchTextBox_LostFocus);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(326, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 25);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // A_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.Users_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "A_ManageUsers";
            this.Size = new System.Drawing.Size(1375, 693);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Users_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}
