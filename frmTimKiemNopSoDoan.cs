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
    public partial class frmTimKiemNopSoDoan : Form
    {
        public frmTimKiemNopSoDoan()
        {
            InitializeComponent();
        }

        private void frmTimKiemNopSoDoan_Load(object sender, EventArgs e)
        {
            BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();
            DataTable dt4 = new DataTable();
            dt4 = data.HienThiThongTinSoDoan();
           

            cbbMasv.DataSource = dt4;
            cbbMasv.DisplayMember = "MaSV";
            cbbMasv.ValueMember = "MaSV";
            DataTable dt3 = new DataTable();
            dt3 = data.HienThiThongTinCanBo();
            cbbMacb.DataSource = dt3;
            cbbMacb.DisplayMember = "MaCB";
            cbbMacb.ValueMember = "MaCB";
        }

        private void btnTimKiemTheoMa_Click(object sender, EventArgs e)
        {
            BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();
            DataTable dataTable = new DataTable();
            dataTable = data.TimKiemTheoMa(cbbMasv.Text);
            txtHeader.Text = "BẢNG THÔNG TIN TÌM KIẾM THEO MÃ SINH VIÊN";
            dgvThongTinTimKiem.DataSource = dataTable;
        }

        private void btnMasvMacb_Click(object sender, EventArgs e)
        {
            BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();
            DataTable dataTable = new DataTable();
            dataTable = data.TimKiemMasvMacb(cbbMasv.Text,cbbMacb.Text);
            txtHeader.Text = "BẢNG THÔNG TIN TÌM KIẾM THEO MÃ SINH VIÊN VÀ MÃ CÁN BỘ";
            dgvThongTinTimKiem.DataSource = dataTable;
        }

        private void btnMaCB_Click(object sender, EventArgs e)
        {
            BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();
            DataTable dataTable = new DataTable();
            dataTable = data.TimKiemMacb(cbbMacb.Text);
            txtHeader.Text = "BẢNG THÔNG TIN TÌM KIẾM THEO MÃ CÁN BỘ";
            dgvThongTinTimKiem.DataSource = dataTable;
            
        }
    }
}
