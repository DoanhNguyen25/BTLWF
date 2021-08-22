using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace BTLWF
{
    public partial class frmReportHoatDongDoan : Form
    {
        string connect = @"Data Source=DESKTOP-71L6BVI\SQLEXPRESS;Initial Catalog=BTL_Windows;Integrated Security=True";
        SqlConnection conn = null;
        public frmReportHoatDongDoan()
        {
            InitializeComponent();
        }

        private void frmReportHoatDongDoan_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(connect);
            }
            string query = "select * from HoatDongDoan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoatDongDoan");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTLWF.ReportHoatDongDoan.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "HoatDongDoan";
            rds.Value = ds.Tables["HoatDongDoan"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
