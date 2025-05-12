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
    public partial class S_guideReportForm : Form
    {
        public S_guideReportForm()
        {
            InitializeComponent();
        }

        private void S_guideReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Basit Junaid\\Source\\Repos\\TravelEase\\TravelEase\\S_guideReport.rdlc";

            // Create and populate a data source
            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "guideRatingDataset"; // Name should match the dataset name in your report

            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand("SELECT ServiceID,SRATING FROM ServiceReviews", conn);
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
