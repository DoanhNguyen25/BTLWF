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
    public partial class frmLopSinhHoat : Form
    {
        public frmLopSinhHoat()
        {
            InitializeComponent();
        }

        private void frmLopSinhHoat_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void ClearTxt()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();


        }
        private void HienThi()
        {
            try
            {
                BLL_LopSinhHoat data = new BLL_LopSinhHoat();
                DataTable dt = new DataTable();
                dt = data.HienThiThongTinLopSH();
                DataTable dt2 = new DataTable();
                dt2 = data.HienThiThongTinNganh();
                gridviewLopSinhHoat.DataSource = dt;
                cbbMaNganh.DataSource = dt2;
                cbbMaNganh.DisplayMember = "MaNganh";
                cbbMaNganh.ValueMember = "MaNganh";
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
                BLL_LopSinhHoat data = new BLL_LopSinhHoat();
                if (txtMaLop.Text == "" || txtTenLop.Text == "" || txtSiSo.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    data.ThemLopSH(txtMaLop.Text, cbbMaNganh.SelectedValue.ToString(), txtTenLop.Text, int.Parse(txtSiSo.Text));

                    HienThi();
                    ClearTxt();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Trùng mã"))
                {
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_LopSinhHoat data = new BLL_LopSinhHoat();
                if (txtMaLop.Text == "")
                {
                    MessageBox.Show("Mã Lớp không đươc để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtTenLop.Text == "")
                {
                    MessageBox.Show("Tên lớp không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!UInt32.TryParse(txtSiSo.Text, out UInt32 o))
                {
                    MessageBox.Show("Sĩ số phải là số nguyên dương", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                data.SuaLopSH(txtMaLop.Text, cbbMaNganh.SelectedValue.ToString(), txtTenLop.Text, int.Parse(txtSiSo.Text));
                HienThi();
                ClearTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text == "")
                {
                    MessageBox.Show("Mã lớp không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
                BLL_LopSinhHoat data = new BLL_LopSinhHoat();
                DataTable dataTable = new DataTable();
                dataTable = data.TimLopSinhHoat(txtMaLop.Text);
                gridviewLopSinhHoat.DataSource = dataTable;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridviewLopSinhHoat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaLop.Text = gridviewLopSinhHoat.Rows[row].Cells[0].Value.ToString();
                cbbMaNganh.Text = gridviewLopSinhHoat.Rows[row].Cells[1].Value.ToString();
                txtTenLop.Text = gridviewLopSinhHoat.Rows[row].Cells[2].Value.ToString();
                txtSiSo.Text = gridviewLopSinhHoat.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_LopSinhHoat data = new BLL_LopSinhHoat();
            data.ExportDataToExcel();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
