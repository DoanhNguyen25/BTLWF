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
    public partial class TimKiemCBDoanTheoMaHD : Form
    {
        public TimKiemCBDoanTheoMaHD()
        {
            InitializeComponent();
        }

        private void TimKiemCBDoanTheoMaHD_Load(object sender, EventArgs e)
        {
            BLL_CanBoDoan bLL_CanBoDoan = new BLL_CanBoDoan();
            DataTable dataTable = new DataTable();
            dataTable = bLL_CanBoDoan.HienThiMaHD();
            cbbMaHD.DataSource = dataTable;
            cbbMaHD.DisplayMember = "MaHD";
            cbbMaHD.ValueMember = "MaHD";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BLL_CanBoDoan bLL_CanBoDoan = new BLL_CanBoDoan();
            DataTable dataTable = new DataTable();
            dataTable = bLL_CanBoDoan.TimTheoMaHD(cbbMaHD.Text);
            dgvcanbo.DataSource = dataTable;
        }
    }
}
