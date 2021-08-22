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
    public partial class frmThongTinNgDung : Form
    {
        public frmThongTinNgDung()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            txtTen.Clear();
            txtSoDT.Clear();
            txtMatKhau.Clear();
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThongTinNgDung_Load(object sender, EventArgs e)
        {
            BLL_ThongTinNguoiDung data = new BLL_ThongTinNguoiDung();
            DataTable dataTable = new DataTable();
            dataTable = data.HienThiThongTinNguoiDung();
            dgvTTNguoiDung.DataSource = dataTable;
            cbbQuyen.Items.Add("user");
            cbbQuyen.Items.Add("admin");
            //DataTable dtQuyen = new DataTable();
            //dtQuyen = data.HienThiThongTinNguoiDung();
            //cbbQuyen.DataSource = dtQuyen;
            //cbbQuyen.DisplayMember = "Quyen";
            //cbbQuyen.ValueMember = "Quyen";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

            BLL_ThongTinNguoiDung data = new BLL_ThongTinNguoiDung();
                if (txtTen.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            data.ThemTaiKhoan(txtTen.Text,txtMatKhau.Text,txtSoDT.Text,cbbQuyen.Text);
            frmThongTinNgDung_Load(sender, e);
                ClearText();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_ThongTinNguoiDung data = new BLL_ThongTinNguoiDung();

                data.SuaTaiKhoan(txtTen.Text, txtMatKhau.Text, txtSoDT.Text, cbbQuyen.Text);
                frmThongTinNgDung_Load(sender, e);
                ClearText();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvTTNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtTen.Text = dgvTTNguoiDung.Rows[row].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTTNguoiDung.Rows[row].Cells[1].Value.ToString();
            txtSoDT.Text = dgvTTNguoiDung.Rows[row].Cells[2].Value.ToString(); 
            cbbQuyen.Text = dgvTTNguoiDung.Rows[row].Cells[3].Value.ToString(); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_ThongTinNguoiDung data = new BLL_ThongTinNguoiDung();
                data.XoaTaiKhoan(txtTen.Text);
                frmThongTinNgDung_Load(sender, e);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_ThongTinNguoiDung data = new BLL_ThongTinNguoiDung();
            data.ExportDataToExcel();
        }
    }
}

