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
using System.Data.SqlClient ;

namespace BTLWF
{
    public partial class frmTheoDoiHoatDongDoan : Form
    {
        public frmTheoDoiHoatDongDoan()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            txtMaHD.Clear();
            txtTenHoatDong.Clear();
            txtDiaDiem.Clear();
        }
        private void frmTheoDoiHoatDongDoan_Load(object sender, EventArgs e)
        {
            BLL_HoatDongDoan data = new BLL_HoatDongDoan();
            DataTable dataTable = new DataTable();
            dataTable = data.HienThiThongTinHoatDongDoan();
            dgvTheoDoiHoatDongDoan.DataSource = dataTable;
            DataTable macb = new DataTable();
            macb = data.HienThiThongTin();
            cbbMaCB.DataSource = macb;
            cbbMaCB.DisplayMember = "MaCB";
            cbbMaCB.ValueMember = "MaCB";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenHoatDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_HoatDongDoan data = new BLL_HoatDongDoan();
                data.ThemHoatDongDoan(txtMaHD.Text ,cbbMaCB.Text, txtTenHoatDong.Text, txtDiaDiem.Text, dtThoiGian.Value.ToString("yyyy-MM-dd"));
                frmTheoDoiHoatDongDoan_Load(sender, e);
                ClearText();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_HoatDongDoan data = new BLL_HoatDongDoan();
                data.SuaHoatDongDoan(txtMaHD.Text, cbbMaCB.Text, txtTenHoatDong.Text, txtDiaDiem.Text, dtThoiGian.Value.ToString("yyyy-MM-dd"));
                frmTheoDoiHoatDongDoan_Load(sender, e);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTheoDoiHoatDongDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
               
                    txtMaHD.Text = dgvTheoDoiHoatDongDoan.Rows[row].Cells[0].Value.ToString();
                    cbbMaCB.Text = dgvTheoDoiHoatDongDoan.Rows[row].Cells[1].Value.ToString();
                    txtTenHoatDong.Text = dgvTheoDoiHoatDongDoan.Rows[row].Cells[2].Value.ToString();
                txtDiaDiem.Text = dgvTheoDoiHoatDongDoan.Rows[row].Cells[3].Value.ToString();
                dtThoiGian.Text = dgvTheoDoiHoatDongDoan.Rows[row].Cells[4].Value.ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Mã hoạt động không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BLL_HoatDongDoan data = new BLL_HoatDongDoan();
                DataTable dataTable = new DataTable();
                dataTable = data.TimKiem(txtMaHD.Text);
            dgvTheoDoiHoatDongDoan.DataSource = dataTable;

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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_HoatDongDoan data = new BLL_HoatDongDoan();
            data.ExportDataToExcel();
        }
    }
}
