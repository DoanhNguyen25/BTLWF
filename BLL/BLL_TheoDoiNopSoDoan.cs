using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class BLL_TheoDoiNopSoDoan
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinNopSoDoan()
        {
            String sql = "Select * from ThongTin_NopSoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }

        public DataTable HienThiThongTinCanBo()
        {
            String sql = "Select * from CanBoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinSoDoan()
        {
            String sql = "Select * from SoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }


        public void ThemNguoiNopSoDoan(String maSV, String maCB, String soSD, string ngagNop)
        {
            String sql = "Insert Into ThongTin_NopSoDoan Values('" + maSV + "', '" + maCB + "', '" + soSD + "', '" + ngagNop + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaThongTinSoDoan(String maSV, String maCB, String soSD, string ngagNop)
        {
            String sql = "Update ThongTin_NopSoDoan Set MaCB='" + maCB + "', SoSD='" + soSD + "', NgayNop='" + ngagNop+ "' Where MaSV='" + maSV + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimKiemTheoMa(string Masv)
        {
            string sql = "select *from ThongTin_NopSoDoan where MaSV='" + Masv + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable TimKiemMasvMacb(string masv, string macb)
        {
            string sql = "select *from ThongTin_NopSoDoan where MaSV='" + masv + "'AND MaCB='" +macb+ "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable TimKiemMacb(string macb)
        {
            string sql = "select *from ThongTin_NopSoDoan where MaCB='"  + macb + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable CheckStudentCodeExist(string masv)
        {
            string sql = "select MaSV from ThongTin_NopSoDoan where MaSV = '" + masv + "'";
            DataTable table = dataConn.GetTable(sql);
            return table;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from ThongTin_NopSoDoan";
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
            sheet.Name = "QLNopSoDoan";

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
            workbook.SaveAs("quanlinopsodoan", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }


    }
}
