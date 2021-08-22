using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class BLL_Login
    {
        Connection connn = new Connection();
        public DataTable GetData()
        {
            string query = "select * from TaiKhoan";
            DataTable table = connn.GetTable(query);
            return table;
        }
        public DataTable CheckAccountExist(string username, string password)
        {
            string query = "select * from TaiKhoan where TenDangNhap = '" + username + "' and MatKhau = '" + password + "'";
            DataTable table = connn.GetTable(query);
            return table;
        }
        public DataTable Authorization(string username, string password)
        {
            string query = "select Quyen from TaiKhoan where TenDangNhap = '" + username + "' and MatKhau = '" + password + "'";
            DataTable table = connn.GetTable(query);
            return table;
        }
        public DataTable ForgotPassword(string username, string dienthoai)
        {
            string query = "select TaiKhoan.TenDangNhap, TaiKhoan.SoDTDKy from TaiKhoan where TenDangNhap = '" + username + "' and SoDTDKy = '" + dienthoai + "'";
            DataTable table = connn.GetTable(query);
            return table;
        }
        public void UpDatePassword(string tendangnhap, string matkhau)
        {
            string query = "UPDATE TaiKhoan SET MatKhau = '" + matkhau + "' WHERE  TenDangNhap = '" + tendangnhap + "'";
            connn.ExecuteNonQuery(query);
        }
        public DataTable CheckUserNameExist(string username)
        {
            string query = "select * from TaiKhoan where TenDangNhap = '" + username + "'";
            DataTable table = connn.GetTable(query);
            return table;
        }
    }
}
