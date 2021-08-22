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
    public partial class frmReportChuyenSinhHoatDoan : Form
    {
        string connect = @"Data Source=DESKTOP-71L6BVI\SQLEXPRESS;Initial Catalog=BTL_Windows;Integrated Security=True";
        SqlConnection conn = null;
        public frmReportChuyenSinhHoatDoan()
        {
            InitializeComponent();
        }

        private void frmReportChuyenSinhHoatDoan_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(connect);
            }
            string query = "select * from ThongTin_ChuyenSinhHoatDoan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ThongTin_ChuyenSinhHoatDoan");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTLWF.ReportChuyenSinhHoatDoan.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ThongTin_ChuyenSinhHoatDoan";
            rds.Value = ds.Tables["ThongTin_ChuyenSinhHoatDoan"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
