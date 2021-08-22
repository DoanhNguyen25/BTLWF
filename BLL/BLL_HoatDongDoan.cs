using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
  public  class BLL_HoatDongDoan
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinHoatDongDoan()
        {
            String sql = "Select * from HoatDongDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTin()
        {
            String sql = "Select * from CanBoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }

        public void ThemHoatDongDoan(string mahd,string macb,string tenhd,string diadiem,string thoigian)
        {
            string sql = "insert into HoatDongDoan values('" + mahd + "','"+macb+"',N'" + tenhd + "',N'" + diadiem + "',N'" + thoigian + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaHoatDongDoan(string mahd, string macb, string tenhd, string diadiem, string thoigian)
        {
            string sql = "Update HoatDongDoan set MaHD='" + mahd + "',MaCB='" + macb + "',TenHoatDong=N'" + tenhd + "',DiaDiem=N'" + diadiem + "',ThoiGian='" + thoigian + "' where MaHD='" + mahd + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimKiem(string mahd)
        {
            string sql= "select * from HoatDongDoan where MaHD='"+mahd+"'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from HoatDongDoan";
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
            sheet.Name = "ThongTinHoatDongDoan";

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
            workbook.SaveAs("thongtinhoatdongdoan", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
