using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
  public  class BLL_CanBoDoan
    {
        Connection dataConn = new Connection();
        public DataTable HienThongTinCanBo()
        {
            string sql = "select *from CanBoDoan";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable HienThiMaHD()
        {
            string sql = "select *from HoatDongDoan";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ThemCanBo(string macb,string hoten,string gioitinh,string chucvu,string diachi,string dienthoai,string mahd,string trangthai)
        {
            string sql= "insert into CanBoDoan values('" + macb + "','" + hoten + "','" + gioitinh + "','" + chucvu + "','" + diachi + "','" + dienthoai + "','" + mahd + "','" + trangthai + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaCanBoDoan(string macb, string hoten, string gioitinh, string chucvu, string diachi, string dienthoai, string mahd, string trangthai)
        {
            string sql = "update CanBoDoan set MaCB='" + macb + "',HoTenCB='" + hoten + "',GioiTinh='" + gioitinh + "',ChucVu='" + chucvu + "',DiaChi='" + diachi + "',DienThoai='" + dienthoai + "',MaHD='" + mahd + "',TrangThai='" + trangthai + "'where MaCB='" + macb + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimTheoMaCB(string macb)
        {
            string sql = "select *from CanBoDoan where MaCB='" + macb + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable TimTheoMaHD(string mahd)
        {
            string sql = "select *from CanBoDoan where MaHD='" + mahd + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from CanBoDoan";
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
            sheet.Name = "QLCanBoDoan";
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
            workbook.SaveAs("quanlicanbodoan", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
