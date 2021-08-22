using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;
namespace BLL
{
   public class BLL_NopDoanPhi
    {
        Connection dataConn = new Connection();
         public DataTable HienThongTinNopDoanPhi()
        {
            string sql = "select *from ThongTin_NopDoanPhi";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable HienThiThongTinCanBo()
        {
            String sql = "SELECT * from  CanBoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinSinhVien()
        {
            String sql = "SELECT * from  SoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ThemNopDoanPhi(string masv, string macb,string sophieu, string ngaynop, string sotien, string noidung )
        {
            string sql = "insert into ThongTin_NopDoanPhi values('" + masv + "','" + macb + "','" + sophieu + "','" +ngaynop + "','" + sotien + "','" + noidung + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaNopDoanPhi(string masv, string macb, string sophieu, string ngaynop, string sotien, string noidung)
        {
            string sql = "Update ThongTin_NopDoanPhi set MaSV='" + masv + "',MaCB='" + macb + "',SoPhieu='" + sophieu + "',NgayNop='" + ngaynop + "',SoTien= '" + sotien + "',NoiDung='" + noidung + "' where MaSV='"+masv+"'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimTheoSoPhieu(string sophieu)
        {
            string sql = "select *from ThongTin_NopDoanPhi where SoPhieu='" +sophieu + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from ThongTin_NopDoanPhi";
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
            sheet.Name = "ThongTinNopDoanPhi";
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
            workbook.SaveAs("thongtindoanphi", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
