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
    public partial class frmHomepage : Form
    {
        public static string quyen;
        public static string username;
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void display()
        {
            if (quyen.Trim() == "user")
            {
                lblUserName.Text = " " + username;
                quảnLíNgườiDùngToolStripMenuItem.Enabled = false;
                quảnLíThôngTinCánBộToolStripMenuItem.Enabled = false;
                quảnLíThôngTinLớpSinhHoạtToolStripMenuItem.Enabled = false;
                quảnLíThôngTinNgànhToolStripMenuItem.Enabled = false;
            }
            if (quyen.Trim() == "admin")
            {
                lblUserName.Text = quyen;

            }
        }
        private void frmHomepage_Load(object sender, EventArgs e)
        {
            display();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportHoatDongDoan hoatdongdoan = new frmReportHoatDongDoan();
            hoatdongdoan.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thôngTInNhàPhátTriểnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNgDung nguoidung = new frmThongTinNgDung();
            nguoidung.ShowDialog();
        }

        private void quảnLíThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSV sinhvien = new frmThongTinSV();
            sinhvien.ShowDialog();
        }

        private void quảnLíThôngTinLớpSinhHoạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLopSinhHoat lop = new frmLopSinhHoat();
            lop.ShowDialog();
        }

        private void quảnLíThôngTinNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNganh nganh = new frmNganh();
            nganh.ShowDialog();
        }

        private void quảnLíThôngTinSổĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoDoan sodoan = new frmSoDoan();
            sodoan.ShowDialog();
        }

        private void theoDõiHoạtĐộngĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheoDoiHoatDongDoan theodoihoatdongdoan = new frmTheoDoiHoatDongDoan();
            theodoihoatdongdoan.ShowDialog();
        }

        private void quảnLíNộpSổĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNopSoDoan nopsodoan = new frmNopSoDoan();
            nopsodoan.ShowDialog();
        }

        private void thôngTinNộpĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNopDoanPhi doanphi = new frmThongTinNopDoanPhi();
            doanphi.ShowDialog();
        }

        private void quảnLíChuyểnSinhHoạtĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuyenSinhHoatDoan chuyensinhhoat = new frmChuyenSinhHoatDoan();
            chuyensinhhoat.ShowDialog();
        }

        private void thôngTinThamGiaHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinThamGiaHoatDong thamgiahoatdong = new frmThongTinThamGiaHoatDong();
            thamgiahoatdong.ShowDialog();
        }

        private void quảnLíThôngTinCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinCBDoan canbo = new frmThongTinCBDoan();
            canbo.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void báoCáoĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportDoanPhi doanphi = new frmReportDoanPhi();
            doanphi.ShowDialog();
        }

        private void báoCáoChuyểnSinhHoạtĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportChuyenSinhHoatDoan chuyensinhhoat = new frmReportChuyenSinhHoatDoan();
            chuyensinhhoat.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thangh.it12");

        }

        private void logoTruong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0919319071");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSMTSDvWGNbcdgxwQgXfqjHBPKljzfKRHwVMzgvfgDpkCPjLJdRMJSjNMgWZJlCsTLSSrFdB");

        }
    }
}
