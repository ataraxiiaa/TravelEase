using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class A_GuideRating : UserControl
    {
        private readonly int touristId;
        int serviceId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;

        public A_GuideRating(int userId)
        {
            InitializeComponent();
            touristId = userId;
            LoadTripIds(); // Load trips when control is initialized
        }

        private void A_GuideRating_Load(object sender, EventArgs e)
        {
            // You can keep this empty or add additional initialization
        }

        private void LoadTripIds()
        {
            comboBoxTripID.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT DISTINCT b.ServiceID 
                                   FROM ServiceReviews b
                                   Join Guide g on g.ServiceID = b.ServiceID
                                   WHERE b.TouristID = @TouristID
                                   AND NOT EXISTS (
                                       SELECT 1 FROM ServiceReviews r 
                                       WHERE r.TouristID = b.TouristID 
                                       AND r.ServiceID = b.ServiceID
                                   )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServiceID", serviceId);
                        command.Parameters.AddWithValue("@TouristID", touristId);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxTripID.Items.Add(reader["ServiceID"].ToString());
                            }
                        }
                    }
                }

                if (comboBoxTripID.Items.Count == 0)
                {
                    MessageBox.Show("No available guides to review or you've already reviewed all your trips");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guides: {ex.Message}");
            }
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            // Validate trip selection
            if (comboBoxTripID.SelectedItem == null)
            {
                MessageBox.Show("Please select a guide to review");
                return;
            }

            // Validate rating
            if (!int.TryParse(textBoxRating.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please enter a valid rating between 1 and 5");
                return;
            }

            // Get values from controls
            serviceId = int.Parse(comboBoxTripID.SelectedItem.ToString());
            string comment = textBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ServiceReviews 
                                   (SRATING, SComment, ServiceID,TouristID )
                                   VALUES 
                                   (@Rating, @Comment, @ServiceID, @TouristID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Rating", rating);
                        command.Parameters.AddWithValue("@Comment", comment);
                        command.Parameters.AddWithValue("@ServiceID", serviceId);
                        command.Parameters.AddWithValue("@TouristID", touristId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thank you for your review!");
                            // Clear form for next review
                            comboBoxTripID.Items.Remove(serviceId.ToString());
                            textBoxRating.Clear();
                            textBox1.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting review: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTripID = new System.Windows.Forms.ComboBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Reviews_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Rating (Out of 5)";
            // 
            // textBoxRating
            // 
            this.textBoxRating.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRating.Location = new System.Drawing.Point(551, 81);
            this.textBoxRating.Multiline = true;
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(121, 28);
            this.textBoxRating.TabIndex = 26;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose GuideID";
            // 
            // comboBoxTripID
            // 
            this.comboBoxTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTripID.FormattingEnabled = true;
            this.comboBoxTripID.Location = new System.Drawing.Point(155, 81);
            this.comboBoxTripID.Name = "comboBoxTripID";
            this.comboBoxTripID.Size = new System.Drawing.Size(184, 28);
            this.comboBoxTripID.TabIndex = 24;
            this.comboBoxTripID.SelectedIndexChanged += new System.EventHandler(this.comboBoxTripID_SelectedIndexChanged);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(279, 447);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(150, 40);
            this.approveButton.TabIndex = 23;
            this.approveButton.Text = "Submit";
            this.approveButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(0, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 298);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Reviews_lbl
            // 
            this.Reviews_lbl.AutoSize = true;
            this.Reviews_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reviews_lbl.ForeColor = System.Drawing.Color.White;
            this.Reviews_lbl.Location = new System.Drawing.Point(283, 12);
            this.Reviews_lbl.Name = "Reviews_lbl";
            this.Reviews_lbl.Size = new System.Drawing.Size(203, 41);
            this.Reviews_lbl.TabIndex = 21;
            this.Reviews_lbl.Text = "Review Guide";
            this.Reviews_lbl.Click += new System.EventHandler(this.Reviews_lbl_Click);
            // 
            // A_GuideRating
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTripID);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reviews_lbl);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "A_GuideRating";
            this.Size = new System.Drawing.Size(1131, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label2;
        private TextBox textBoxRating;
        private Label label1;
        private ComboBox comboBoxTripID;
        private Button approveButton;
        private TextBox textBox1;
        private Label Reviews_lbl;

        private void Reviews_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTripID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {

        }
    }
}