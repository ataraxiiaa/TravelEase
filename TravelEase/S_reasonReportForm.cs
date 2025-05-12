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
using Microsoft.Reporting.WinForms;

namespace TravelEase
{
    public partial class S_reasonReportForm : Form
    {
        public S_reasonReportForm()
        {
            InitializeComponent();
        }

        private void S_reasonReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Basit Junaid\\source\\repos\\TravelEase\\TravelEase\\S_reasonsReport.rdlc";

            // Create and populate a data source
            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "reasonReportDataset"; // Name should match the dataset name in your report

            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand("SELECT ABReason FROM AbandonedBookings", conn);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable salesData = new DataTable();
                adapter.Fill(salesData);

                dataSource.Value = salesData;
            }
            // Clear existing and add the data source
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            // Set any parameters if needed
            //ReportParameter[] parameters = new ReportParameter[1];
            //parameters[0] = new ReportParameter("ParameterName", "ParameterValue");
            //reportViewer1.LocalReport.SetParameters(parameters);

            // Refresh the report
            reportViewer1.RefreshReport();
        }
    }
}
