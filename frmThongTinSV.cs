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
    public partial class frmThongTinSV : Form
    {
        public frmThongTinSV()
        {
            InitializeComponent();
        }

        private void frmThongTinSV_Load(object sender, EventArgs e)
        {

            BLL_ThongTinSV data = new BLL_ThongTinSV();
            DataTable dt = new DataTable();
            dt = data.HienThiThongTinSinhVien();
            dgvSinhVien.DataSource = dt;

            DataTable dt3 = new DataTable();
            dt3 = data.HienThiThongTinMaSV();
            //DataTable dt4 = new DataTable();
            //dt4 = data.HienThiThongTinComboBox();
            
            cbbMaLop.DataSource = dt3;
            cbbMaLop.DisplayMember = "MaLop";
            cbbMaLop.ValueMember = "MaLop";
            //cbbMaDH.DataSource = dt4;
            //cbbMaDH.DisplayMember = "MaHD";
            //cbbMaDH.ValueMember = "MaHD";

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BLL_ThongTinSV data = new BLL_ThongTinSV();
            try
            {
                if (txtMaSV.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "")
                {
                    MessageBox.Show(" không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!UInt32.TryParse(txtDienThoai.Text, out UInt32 o))
                {
                    MessageBox.Show(" Điện thoại phải nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Boolean hd = false;
                if (rdbHoatDong.Checked)
                {
                    hd = true;
                }
                if (rdbChuyenCongTac.Checked)
                {
                    hd = false;
                }
                data.ThemSV(txtMaSV.Text, txtHoTen.Text, dtNgaySinh.Value.ToString("yyy-MM-dd"), txtDiaChi.Text, txtDienThoai.Text, cbbMaLop.Text, hd.ToString());
                frmThongTinSV_Load(sender, e);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_ThongTinSV data = new BLL_ThongTinSV();
                if (txtMaSV.Text == "" || txtHoTen.Text == ""||txtDiaChi.Text==""||txtDienThoai.Text=="")
                {
                    MessageBox.Show(" không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Boolean hd = false;
                if (rdbHoatDong.Checked)
                {
                    hd = true;
                }
                if (rdbChuyenCongTac.Checked)
                {
                    hd = false;
                }
                data.SuaSV(txtMaSV.Text, txtHoTen.Text, dtNgaySinh.Value.ToString("yyy-MM-dd"), txtDiaChi.Text, txtDienThoai.Text, cbbMaLop.Text, hd.ToString());
            frmThongTinSV_Load(sender, e);
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaSV.Text = dgvSinhVien.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[row].Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvSinhVien.Rows[row].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[row].Cells[3].Value.ToString();
            txtDienThoai.Text = dgvSinhVien.Rows[row].Cells[4].Value.ToString();
            cbbMaLop.Text = dgvSinhVien.Rows[row].Cells[5].Value.ToString();
            
            if (dgvSinhVien.Rows[row].Cells[7].Value.Equals(true))
            {
                rdbHoatDong.Checked=true;
            }
            if (dgvSinhVien.Rows[row].Cells[7].Value.Equals(false))
            {
                rdbChuyenCongTac.Checked = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemSV frmTimKiemSV = new frmTimKiemSV();
            frmTimKiemSV.ShowDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_ThongTinSV data = new BLL_ThongTinSV();
            data.ExportDataToExcel();
        }

        private void rdbChuyenCongTac_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
