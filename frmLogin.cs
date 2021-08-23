using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BLL;
namespace BTLWF
{
    public partial class frmLogin : Form
    {
        BLL_Login login = new BLL.BLL_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbUserName.Text == "" || txbPassword.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đủ các ô");
                }
                else
                {
                    DataTable account = login.CheckAccountExist(txbUserName.Text.Trim(), txbPassword.Text.Trim());

                    if (account.Rows.Count == 0)
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        this.Hide();
                        DataTable tb = login.Authorization(txbUserName.Text, txbPassword.Text);
                        string q = tb.Rows[0][0].ToString();
                        string name = account.Rows[0][0].ToString();
                        frmHomepage.username = name;
                        frmHomepage.quyen = q;
                        frmHomepage homepage = new frmHomepage();
                        homepage.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lnklableForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword forgotpassword = new frmForgotPassword();
            forgotpassword.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
