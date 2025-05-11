using System;
using System.Collections;
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
    public partial class A_Passes : UserControl
    {
       // TODO: set your actual connection string here
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
        public A_Passes()
        {
            InitializeComponent();
        }

        private void ETickets_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT
                    DTPID
                FROM ETicket;
            ";
            FillGrid(sql);
        }

        private void A_Passes_Load(object sender, EventArgs e)
        {
           
        }
        private void FillGrid(string query)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var da = new SqlDataAdapter(query, conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    queriesDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error fetching data:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void queriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    using (var conn = new SqlConnection(connectionString))
            //    using (var da = new SqlDataAdapter(query, conn))
            //    {
            //        var dt = new DataTable();
            //        da.Fill(dt);
            //        queriesDataGridView.DataSource = dt;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(
            //        "Error fetching data:\n" + ex.Message,
            //        "Database Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }

        private void hotelVoucher_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT 
                    hv.DTPID,
                    hv.HotelID,
                    h.ServiceID,
                    h.HRoomCount
                FROM HotelVoucher AS hv
                INNER JOIN Hotels AS h
                    ON hv.HotelID = h.ServiceID;
            ";
            FillGrid(sql);
        }

        private void ActivityPasses_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT 
                    DTPID,
                    ADuration,
                    ADescription
                FROM ActivityPass;
            ";
            FillGrid(sql);
        }
    }
}
