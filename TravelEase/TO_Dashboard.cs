using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class TO_Dashboard : UserControl
    {
        private int id;
        public TO_Dashboard()
        {
            InitializeComponent();
        }

        private void TO_Dashboard_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT TOP 1 TourOperatorID, MUsername FROM Moderator"; // change later


            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, conn);

            
        }
    }
}
