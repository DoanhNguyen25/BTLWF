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
    public partial class frmNopSoDoan : Form
    {
        BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();

        public frmNopSoDoan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmNopSoDoan_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        
        private void HienThi()
        {
            try
            {
                BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();
                DataTable dt = new DataTable();
                dt = data.HienThiThongTinNopSoDoan();
                DataTable dt3 = new DataTable();
                dt3 = data.HienThiThongTinCanBo();
                DataTable dt4 = new DataTable();
                dt4 = data.HienThiThongTinSoDoan();
                dgvNopSoDoan.DataSource = dt;
                cbbMaSV.DataSource = dt4;
                cbbMaSV.DisplayMember = "MaSV";
                cbbMaSV.ValueMember = "MaSV";
                cbbMaCB.DataSource = dt3;
                cbbMaCB.DisplayMember = "MaCB";
                cbbMaCB.ValueMember = "MaCB";
                cbbSoSD.DataSource = dt4;
                cbbSoSD.DisplayMember = "SoSD";
                cbbSoSD.ValueMember = "SoSD";

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
                DataTable table = data.CheckStudentCodeExist(cbbMaSV.Text);
                if(table.Rows.Count == 0)
                {
                    data.ThemNguoiNopSoDoan(cbbMaSV.SelectedValue.ToString(), cbbMaCB.SelectedValue.ToString(), cbbSoSD.SelectedValue.ToString(), dtNgayNop.Value.ToString("yyy-MM-dd"));
                }
                else
                {
                    if(table.Rows[0][0].ToString() == cbbMaSV.Text)
                    {
                        MessageBox.Show("mã sinh viên đã tồn tại");
                    }
                }
                HienThi();
                   
                
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
                try
                {
                    
                    BLL_TheoDoiNopSoDoan data = new BLL_TheoDoiNopSoDoan();
                    data.SuaThongTinSoDoan(cbbMaSV.SelectedValue.ToString(), cbbMaCB.SelectedValue.ToString(), cbbSoSD.SelectedValue.ToString(), dtNgayNop.Value.ToString("yyy-MM-dd"));
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                HienThi();
              
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

        private void dgvNopSoDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cbbMaSV.Text = dgvNopSoDoan.Rows[row].Cells[1].Value.ToString();
                cbbMaCB.Text = dgvNopSoDoan.Rows[row].Cells[0].Value.ToString();
                cbbSoSD.Text = dgvNopSoDoan.Rows[row].Cells[2].Value.ToString();
                dtNgayNop.Text = dgvNopSoDoan.Rows[row].Cells[3].Value.ToString();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemNopSoDoan TimKiemTheoMa = new frmTimKiemNopSoDoan();
            TimKiemTheoMa.ShowDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            data.ExportDataToExcel();
        }
    }
}
