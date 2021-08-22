using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BLL
{
    public class BLL_ThongTinNguoiDung
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinNguoiDung()
        {
            String sql = "Select * from TaiKhoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ThemTaiKhoan(string tendn,string matkhau,string sdt,string quyen)
        {
            string sql = "insert into TaiKhoan values('" + tendn + "','" + matkhau + "',N'" + sdt + "',N'" + quyen + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaTaiKhoan(string tendn, string matkhau, string sdt, string quyen)
        {
            string sql = "Update TaiKhoan set TenDangNhap='" + tendn + "',MatKhau='" +matkhau  + "',SoDTDKy=N'" + sdt + "',Quyen=N'" + quyen + "' where TenDangNhap='" + tendn + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public void XoaTaiKhoan(string tendn)
        {
            string sql = "Delete from TaiKhoan where TenDangNhap='" + tendn+"' ";
            dataConn.ExecuteNonQuery(sql);
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from TaiKhoan";
            DataTable tableTaiKhoan = dataConn.GetTable(sql);
            /// tạo một file excel mới 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //tạo một workbook mới cho application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //khởi tạo một đối tượng sheet
            Microsoft.Office.Interop.Excel._Worksheet sheet = null;
            app.Visible = true;
            //truy xuất đến sheet1 để thực hiện thao tác
            sheet = workbook.Sheets["Sheet1"];
            sheet = workbook.ActiveSheet;
            sheet.Name = "QLTaiKhoan";
            //lưu tiêu đề 
            for (int i = 1; i < tableTaiKhoan.Columns.Count + 1; i++)
            {
                sheet.Cells[1, i] = tableTaiKhoan.Columns[i - 1].ColumnName;
            }
            //lưu dữ liệu
            for (int i = 0; i < tableTaiKhoan.Rows.Count; i++)
            {
                for (int j = 0; j < tableTaiKhoan.Columns.Count; j++)
                {
                    sheet.Cells[i + 2, j + 1] = tableTaiKhoan.Rows[i][j].ToString();
                }
            }
            //save dữ liệu
            workbook.SaveAs("quanlitaikhoan", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
