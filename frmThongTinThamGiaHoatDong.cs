using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace BTLWF
{
    public partial class frmThongTinThamGiaHoatDong : Form
    {
        BLL_ThongTinHoatDongDoan data = new BLL_ThongTinHoatDongDoan();
        public frmThongTinThamGiaHoatDong()
        {
            InitializeComponent();
        }

        private void frmThongTinThamGiaHoatDong_Load(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            dataTable = data.HienThongTinHD();
            dgvHD.DataSource = dataTable;

            DataTable masv= new DataTable();
            masv = data.HienThongTinSV();
            cbbMasv.DataSource = masv;
            cbbMasv.DisplayMember = "MaSV";
            cbbMasv.ValueMember = "MaSV";

            DataTable mahd = new DataTable();
            mahd = data.HienThongTinMaHD();
            cbbMaDH.DataSource = mahd;
            cbbMaDH.DisplayMember = "MaHD";
            cbbMaDH.ValueMember = "MaHD";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            data.ExportDataToExcel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
