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
    public partial class frmForgotPassword : Form
    {
        BLL_Login login = new BLL_Login();
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void panelUpdatePassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSubmit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {

        }
        private void ClearTextBox()
        {
            txbUsername.Clear();
            txbPhoneNumber.Clear();
            txbNewPassword.Clear();
            txbSubmitPassword.Clear();
            txbTenDangNhap.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbUsername.Text == "" || txbPhoneNumber.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đủ các ô");
                }
                else
                {
                    DataTable table = login.ForgotPassword(txbUsername.Text, txbPhoneNumber.Text);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không thể thực hiện thao tác");
                    }
                    else
                    {
                        panelUpdatePassword.Visible = true;
                        panelSubmit.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            DataTable check = login.CheckUserNameExist(txbTenDangNhap.Text.Trim());
            try
            {
                if (txbNewPassword.Text == "" || txbSubmitPassword.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ các ô");
                }
                else
                {
                    if (txbNewPassword.Text != txbSubmitPassword.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                    }
                    else
                    {
                        try
                        {
                            if (check.Rows.Count == 0)
                            {
                                MessageBox.Show("Tên đăng nhập không tồn tại");
                            }
                            else
                            {
                                login.UpDatePassword(txbUsername.Text.Trim(), txbNewPassword.Text.Trim());
                                MessageBox.Show("Cập nhật thành công!");
                                ClearTextBox();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                panelUpdatePassword.Visible = false;
                panelSubmit.Visible = true;
                txbUsername.Clear();
                txbPhoneNumber.Clear();
            }
        }
    }
}
