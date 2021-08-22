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
    public partial class frmTimKiemSV : Form
    {
        public frmTimKiemSV()
        {
            InitializeComponent();
        }

        private void frmTimKiemSV_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTimKiemSVTheoMaSV frmTimKiemSVTheoMaSV = new frmTimKiemSVTheoMaSV();
            frmTimKiemSVTheoMaSV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimKiemSvTheoMaLop timKiemSvTheoMaLop = new TimKiemSvTheoMaLop();
            timKiemSvTheoMaLop.ShowDialog();
        }
    }
}
