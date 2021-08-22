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
    public partial class frmThongTinNopDoanPhi : Form
    {
        public frmThongTinNopDoanPhi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ClearText()
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_NopDoanPhi data = new BLL_NopDoanPhi();
                data.ThemNopDoanPhi(cbbMaSV.Text, cbbMaCB.Text,txtSoPhieu.Text, dtNgayNop.Value.ToString("yyyy/MM/dd"), txtSoTien.Text, txtNoiDung.Text );
                frmThongTinNopDoanPhi_Load(sender, e);
                ClearText();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void frmThongTinNopDoanPhi_Load(object sender, EventArgs e)
        {
            BLL_NopDoanPhi data = new BLL_NopDoanPhi();
            DataTable dataTable = new DataTable();
            dataTable = data.HienThongTinNopDoanPhi();
            gridviewNopDoanPhi.DataSource = dataTable;

            DataTable sv = new DataTable();
            sv = data.HienThiThongTinSinhVien();
            cbbMaSV.DataSource = sv;
            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.ValueMember = "MaSV";

            DataTable cb = new DataTable();
            cb = data.HienThiThongTinCanBo();
            cbbMaCB.DataSource = cb;
            cbbMaCB.DisplayMember = "MaCB";
            cbbMaCB.ValueMember = "MaCB";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoPhieu.Text == "")
                {
                    MessageBox.Show("Số phiếu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BLL_NopDoanPhi data = new BLL_NopDoanPhi();
                data.SuaNopDoanPhi(cbbMaSV.Text, cbbMaCB.Text, txtSoPhieu.Text, dtNgayNop.Value.ToString("yyyy/MM/dd"), txtSoTien.Text, txtNoiDung.Text);
                frmThongTinNopDoanPhi_Load(sender, e);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoPhieu.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               BLL_NopDoanPhi data = new BLL_NopDoanPhi();
                DataTable dataTable = new DataTable();
                dataTable = data.TimTheoSoPhieu(txtSoPhieu.Text);
                gridviewNopDoanPhi.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridviewNopDoanPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbbMaSV.Text = gridviewNopDoanPhi.Rows[row].Cells[0].Value.ToString();
            cbbMaCB.Text = gridviewNopDoanPhi.Rows[row].Cells[1].Value.ToString();
            txtSoPhieu.Text = gridviewNopDoanPhi.Rows[row].Cells[2].Value.ToString();
            txtSoTien.Text = gridviewNopDoanPhi.Rows[row].Cells[4].Value.ToString();
            txtNoiDung.Text = gridviewNopDoanPhi.Rows[row].Cells[5].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            BLL_NopDoanPhi data = new BLL_NopDoanPhi();
            data.ExportDataToExcel();
        }
    }
}
