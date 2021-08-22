using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
   public class BLL_SoDoan
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinSoDoan()
        {
            String sql = "Select * from SoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinSV()
        {
            String sql = "Select * from SinhVien";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ThemSoDoan(String soSD, String thongTin, string nhanXet, String maSV)
        {
            String sql = "Insert Into SoDoan Values('" + soSD + "', '" + thongTin + "', '" + nhanXet + "', '" + maSV + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaSoDoan(String soSD, String thongTin, string nhanXet, String maSV)
        {
            String sql = "Update SoDoan Set ThongTin='" + thongTin + "', NhanXet='" + nhanXet + "', MaSV='" + maSV+ "' Where SoSD='" + soSD + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimSoDoan(String SoSoDoan)
        {
            string sql = "select * from SoDoan where SoSD='" + SoSoDoan + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable CheckStudentCodeExist(string masv)
        {
            string sql = "select MaSV from SoDoan where MaSV = '" + masv + "'";
            DataTable table = dataConn.GetTable(sql);
            return table;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from SoDoan";
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
            sheet.Name = "ThongTinSoDoan";

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
            workbook.SaveAs("thongtinsodoan", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
