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
    public partial class frmNganh : Form
    {
        public frmNganh()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNganh_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void ClearTxt()
        {
            txtMaNganh.Clear();
            txtTenNganh.Clear();



        }
        private void HienThi()
        {
            try
            {
                BLL_ThongTinNganh data = new BLL_ThongTinNganh();
                DataTable dt = new DataTable();
                dt = data.HienThiThongTinNganh();
                dgvNganh.DataSource = dt;
               
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
                BLL_ThongTinNganh data = new BLL_ThongTinNganh();
                if (txtMaNganh.Text == "" || txtTenNganh.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    data.ThemNganh(txtMaNganh.Text,txtTenNganh.Text);

                    HienThi();
                    ClearTxt();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Trùng mã"))
                {
                    MessageBox.Show("Mã ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_ThongTinNganh data = new BLL_ThongTinNganh();
                if (txtMaNganh.Text == "")
                {
                    MessageBox.Show("Mã ngành không đươc để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtTenNganh.Text == "")
                {
                    MessageBox.Show("Tên ngành không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                data.SuaNganh(txtMaNganh.Text, txtTenNganh.Text);
                HienThi();
                ClearTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNganh.Text = dgvNganh.Rows[row].Cells[0].Value.ToString();
                txtTenNganh.Text = dgvNganh.Rows[row].Cells[1].Value.ToString();
              
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
           {
                if (txtMaNganh.Text == "")
                {
                   MessageBox.Show("Mã ngành không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
               
               
            BLL_ThongTinNganh data = new BLL_ThongTinNganh();
            DataTable dataTable = new DataTable();
            dataTable = data.TimNganh(txtMaNganh.Text);   
            dgvNganh.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_ThongTinNganh data = new BLL_ThongTinNganh();
            data.ExportDataToExcel();
        }
    }
}
