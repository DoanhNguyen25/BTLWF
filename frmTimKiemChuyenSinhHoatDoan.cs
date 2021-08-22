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
    public partial class frmTimKiemChuyenSinhHoatDoan : Form
    {
        public frmTimKiemChuyenSinhHoatDoan()
        {
            InitializeComponent();
        }

        private void frmTimKiemChuyenSinhHoatDoan_Load(object sender, EventArgs e)
        {
            BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();
            DataTable dt = new DataTable();
            dt = data.HienThiThongTinChuyenSinhHoat();
            DataTable dt2 = new DataTable();
            dt2 = data.HienThiThongTinSinhVien();
            DataTable dt3 = new DataTable();
            dt3 = data.HienThiThongTinCanBo();
          
            cbbMaSV.DataSource = dt2;
            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.ValueMember = "MaSV";
            cbbMaCB.DataSource = dt3;
            cbbMaCB.DisplayMember = "MaCB";
            cbbMaCB.ValueMember = "MaCB";
        }

        private void btnMasv_Click(object sender, EventArgs e)
        {
            BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();
            DataTable dataTable = new DataTable();
            dataTable = data.TimChuyenSinhHoatDoan(cbbMaSV.Text);
            lblheader.Text = "THÔNG TIN BẢNG SINH VIÊN CHUYỂN SINH HOẠT ĐOÀN THEO MÃ SINH VIÊN";
            dgvTimChuyenSinhHoatDoan.DataSource = dataTable;
        }

        private void btnMacb_Click(object sender, EventArgs e)
        {
            BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();
            DataTable dataTable = new DataTable();
            dataTable = data.TimChuyenSinhHoatDoanTheoMaCB(cbbMaCB.Text);
            lblheader.Text = "THÔNG TIN BẢNG SINH VIÊN CHUYỂN SINH HOẠT ĐOÀN THEO MÃ CÁN BỘ";
            dgvTimChuyenSinhHoatDoan.DataSource = dataTable;
        }

        private void btnMasv_MaCB_Click(object sender, EventArgs e)
        {
            BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();
            DataTable dataTable = new DataTable();
            dataTable = data.TimTheoMasv_Macb(cbbMaSV.Text,cbbMaCB.Text);
            lblheader.Text = "THÔNG TIN BẢNG SINH VIÊN CHUYỂN SINH HOẠT ĐOÀN THEO MÃ SINH VIÊN VÀ MÃ CÁN BỘ";
            dgvTimChuyenSinhHoatDoan.DataSource = dataTable;
        }
    }
}
