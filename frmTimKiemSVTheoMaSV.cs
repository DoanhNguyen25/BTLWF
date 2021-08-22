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
    public partial class frmTimKiemSVTheoMaSV : Form
    {
        public frmTimKiemSVTheoMaSV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BLL_ThongTinSV data = new BLL_ThongTinSV();
            DataTable dataTable = new DataTable();
            dataTable = data.TimTheoMaSV(txtMaSV.Text);
            dgvSinhVien.DataSource = dataTable;
        }
    }
}
