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
    public partial class frmChuyenSinhHoatDoan : Form
    {
        BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();

        public frmChuyenSinhHoatDoan()
        {
            InitializeComponent();
        }

        private void frmChuyenSinhHoatDoan_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void ClearTxt()
        {
            txtDonVi.Clear();
           


        }
        private void HienThi()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = data.HienThiThongTinChuyenSinhHoat();
                DataTable dt2 = new DataTable();
                dt2 = data.HienThiThongTinSinhVien();
                DataTable dt3 = new DataTable();
                dt3 = data.HienThiThongTinCanBo();
                dgvChuyenSinhHoatDoan.DataSource = dt;
                cbbMaSV.DataSource = dt2;
                cbbMaSV.DisplayMember = "MaSV";
                cbbMaSV.ValueMember = "MaSV";
                cbbMaCB.DataSource = dt3;
                cbbMaCB.DisplayMember = "MaCB";
                cbbMaCB.ValueMember = "MaCB";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();
                if (txtDonVi.Text == "" )
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    data.ThemSinhVienChuyenSinhHoatDoan(cbbMaSV.SelectedValue.ToString(), cbbMaCB.SelectedValue.ToString(),dtNgayNop.Value.ToString("yyy-MM-dd"), txtDonVi.Text);

                    HienThi();
                    ClearTxt();
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_ThongTinChuyenSinhHoat data = new BLL_ThongTinChuyenSinhHoat();
                if (txtDonVi.Text == "")
                {
                    MessageBox.Show("Nơi chuyển đến không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                data.SuaThongTinSinhVienChuyenSinhHoatDoan(cbbMaSV.SelectedValue.ToString(), cbbMaCB.SelectedValue.ToString(), dtNgayNop.Value.ToString("yyy-MM-dd"), txtDonVi.Text);
                HienThi();
                ClearTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChuyenSinhHoatDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cbbMaSV.Text = dgvChuyenSinhHoatDoan.Rows[row].Cells[0].Value.ToString();
                cbbMaCB.Text = dgvChuyenSinhHoatDoan.Rows[row].Cells[1].Value.ToString();
                txtDonVi.Text = dgvChuyenSinhHoatDoan.Rows[row].Cells[3].Value.ToString();
                dtNgayNop.Text = dgvChuyenSinhHoatDoan.Rows[row].Cells[2].Value.ToString();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemChuyenSinhHoatDoan Tim = new frmTimKiemChuyenSinhHoatDoan();
            Tim.ShowDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            data.ExportDataToExcel();
        }
    }
}
