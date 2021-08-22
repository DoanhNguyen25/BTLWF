using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWF
{
    public partial class TimKiemCBDoan : Form
    {
        public TimKiemCBDoan()
        {
            InitializeComponent();
        }

        private void btnMaCB_Click(object sender, EventArgs e)
        {
            TimKiemCBDoanTheoMaCB timkiem = new TimKiemCBDoanTheoMaCB();
            timkiem.ShowDialog();
        }

        private void btnMaHD_Click(object sender, EventArgs e)
        {
            TimKiemCBDoanTheoMaHD timkiem = new TimKiemCBDoanTheoMaHD();
            timkiem.ShowDialog();
        }
    }
}
