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
    public partial class frmSoDoan : Form
    {
        public frmSoDoan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSoDoan_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void ClearTxt()
        {
            txtSoSD.Clear();
            txtNhanXet.Clear();
            txtThongTin.Clear();


        }
        private void HienThi()
        {
            try
            {
                BLL_SoDoan data = new BLL_SoDoan();
                DataTable dt = new DataTable();
                dt = data.HienThiThongTinSoDoan();
                DataTable dt2 = new DataTable();
                dt2 = data.HienThiThongTinSV();
                dgvSoDoan.DataSource = dt;
                cbbMaSV.DataSource = dt2;
                cbbMaSV.DisplayMember = "MaSV";
                cbbMaSV.ValueMember = "MaSV";
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
                BLL_SoDoan data = new BLL_SoDoan();

                if (txtSoSD.Text == "" || txtThongTin.Text == "" || txtNhanXet.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable table = data.CheckStudentCodeExist(cbbMaSV.Text.Trim());
                    if(table.Rows.Count == 0)
                    {
                        data.ThemSoDoan(txtSoSD.Text.Trim(), txtThongTin.Text.Trim(), txtNhanXet.Text.Trim(), cbbMaSV.Text);
                    }
                    else
                    {
                        if(table.Rows[0][0].ToString() == cbbMaSV.Text)
                        {
                            MessageBox.Show("mã sinh viên bị trùng");
                        }
                    }
                }
                HienThi();
                ClearTxt();

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Trùng mã"))
                {
                    MessageBox.Show("Số sổ đoàn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BLL_SoDoan data = new BLL_SoDoan();
                if (txtSoSD.Text == "")
                {
                    MessageBox.Show("Số sổ đoàn không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtThongTin.Text == "")
                {
                    MessageBox.Show("Thông tin không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNhanXet.Text == "")
                {
                    MessageBox.Show("Nhận xét không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                data.SuaSoDoan(txtSoSD.Text, txtThongTin.Text, txtNhanXet.Text, cbbMaSV.SelectedValue.ToString());
                HienThi();
                ClearTxt();
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

        private void dgvSoDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtSoSD.Text = dgvSoDoan.Rows[row].Cells[0].Value.ToString();
                txtThongTin.Text = dgvSoDoan.Rows[row].Cells[1].Value.ToString();
                txtNhanXet.Text = dgvSoDoan.Rows[row].Cells[2].Value.ToString();
                cbbMaSV.Text = dgvSoDoan.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoSD.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BLL_SoDoan data = new BLL_SoDoan();
                DataTable dataTable = new DataTable();
                dataTable = data.TimSoDoan(txtSoSD.Text);
                dgvSoDoan.DataSource = dataTable;
           }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_SoDoan data = new BLL_SoDoan();
            data.ExportDataToExcel();
        }
    }
}
