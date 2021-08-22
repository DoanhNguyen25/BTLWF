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
    public partial class frmThongTinCBDoan : Form
    {
        public frmThongTinCBDoan()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            txtMaCB.Clear();
            txtHoTen.Clear();
            txtChucVi.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();

        }
        private void frmThongTinCBDoan_Load(object sender, EventArgs e)
        {
            BLL_CanBoDoan data = new BLL_CanBoDoan();
            DataTable dataTable = new DataTable();
            dataTable = data.HienThongTinCanBo();
            dgvThongTinCB.DataSource = dataTable;

            DataTable gt = new DataTable();
            gt = data.HienThiMaHD();
            cbbMaDH.DataSource = gt;
            cbbMaDH.DisplayMember = "MaHD";
            cbbMaDH.ValueMember = "MaHD";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BLL_CanBoDoan data = new BLL_CanBoDoan();
            try
            {
                string gt = "";
                if (rdbNam.Checked)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                if (txtMaCB.Text == ""  )
                {
                    MessageBox.Show("Mã cán bộ không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Tên cán bộ không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!UInt32.TryParse(txtDienThoai.Text, out UInt32 o))
                {
                    MessageBox.Show(" Điện thoại phải nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Boolean trangthai = false;
                if (rdbHoatDong.Checked)
                {
                    trangthai = true;
                }
                if (rdbChuyenCongTac.Checked)
                {
                    trangthai = false;
                }
                data.ThemCanBo(txtMaCB.Text, txtHoTen.Text, gt, txtChucVi.Text, txtDiaChi.Text, txtDienThoai.Text, cbbMaDH.Text, trangthai.ToString());
                frmThongTinCBDoan_Load(sender, e);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BLL_CanBoDoan data = new BLL_CanBoDoan();
            try
            {
                string gt = "";
                if (rdbNam.Checked)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                if (txtMaCB.Text == "")
                {
                    MessageBox.Show("Mã cán bộ không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Tên cán bộ không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!UInt32.TryParse(txtDienThoai.Text, out UInt32 o))
                {
                    MessageBox.Show(" Điện thoại phải nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Boolean trangthai = false;
                if (rdbHoatDong.Checked)
                {
                    trangthai = true;
                }
                if (rdbChuyenCongTac.Checked)
                {
                    trangthai = false;
                }
                data.SuaCanBoDoan(txtMaCB.Text, txtHoTen.Text, gt, txtChucVi.Text, txtDiaChi.Text, txtDienThoai.Text, cbbMaDH.Text, trangthai.ToString());
                frmThongTinCBDoan_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaCB.Text = dgvThongTinCB.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dgvThongTinCB.Rows[row].Cells[1].Value.ToString();

            if (dgvThongTinCB.Rows[row].Cells[2].Value.Equals("Nam"))
            {
                rdbNam.Checked = true;
            }
            if(dgvThongTinCB.Rows[row].Cells[2].Value.Equals("Nữ"))
            {
                rdbNu.Checked = true;
            }
            txtChucVi.Text = dgvThongTinCB.Rows[row].Cells[3].Value.ToString();
            txtDiaChi.Text= dgvThongTinCB.Rows[row].Cells[4].Value.ToString();
            txtDienThoai.Text= dgvThongTinCB.Rows[row].Cells[5].Value.ToString(); 
            cbbMaDH.Text= dgvThongTinCB.Rows[row].Cells[6].Value.ToString();
            if (dgvThongTinCB.Rows[row].Cells[7].Value.Equals(true))
            {
                rdbHoatDong.Checked = true;
            }
            if (dgvThongTinCB.Rows[row].Cells[7].Value.Equals(false))
            {
                rdbChuyenCongTac.Checked = true;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemCBDoan cbdoan = new TimKiemCBDoan();
            cbdoan.ShowDialog();
        }
        private void btnXuat_Click_1(object sender, EventArgs e)
        {
            BLL_CanBoDoan data = new BLL_CanBoDoan();
            data.ExportDataToExcel();
        }
    }
}
