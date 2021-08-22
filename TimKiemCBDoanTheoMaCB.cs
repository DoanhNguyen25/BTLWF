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
    public partial class TimKiemCBDoanTheoMaCB : Form
    {
        public TimKiemCBDoanTheoMaCB()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BLL_CanBoDoan bLL_CanBoDoan = new BLL_CanBoDoan();
            DataTable dataTable = new DataTable();
            dataTable = bLL_CanBoDoan.TimTheoMaCB(txtMaCB.Text);
            dgvCanBo.DataSource = dataTable;
        }
    }
}
