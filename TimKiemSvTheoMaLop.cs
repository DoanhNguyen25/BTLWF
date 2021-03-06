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
    public partial class TimKiemSvTheoMaLop : Form
    {
        public TimKiemSvTheoMaLop()
        {
            InitializeComponent();
        }

        private void TimKiemSvTheoMaLop_Load(object sender, EventArgs e)
        {
            BLL_ThongTinSV bLL_ThongTinSV = new BLL_ThongTinSV();
            DataTable dataTable = new DataTable();
            dataTable = bLL_ThongTinSV.HienThiThongTinMaSV();
            cbbMaLop.DataSource = dataTable;
            cbbMaLop.DisplayMember = "MaLop";
            cbbMaLop.ValueMember = "MaLop";
        }

        private void btnmalop_Click(object sender, EventArgs e)
        {
            BLL_ThongTinSV bLL_ThongTinSV = new BLL_ThongTinSV();
            DataTable dataTable = new DataTable();
            dataTable = bLL_ThongTinSV.TimTheoMaLop(cbbMaLop.Text);
            dgvSinhvien.DataSource = dataTable;
        }
    }
}
