using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class BLL_ThongTinChuyenSinhHoat
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinChuyenSinhHoat()
        {
            String sql = "Select * from ThongTin_ChuyenSinhHoatDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinSinhVien()
        {
            String sql = "SELECT * from  SinhVien";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinCanBo()
        {
            String sql = "SELECT * from  CanBoDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ThemSinhVienChuyenSinhHoatDoan(string maSV, string maCB, string ngayChuyen, String noiChuyenDen)
        {
            String sql = "Insert Into ThongTin_ChuyenSinhHoatDoan Values('" + maSV + "', '" + maCB + "','" + ngayChuyen + "', N'" + noiChuyenDen + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaThongTinSinhVienChuyenSinhHoatDoan(String maSV,string maCB, string ngayChuyen, String noiChuyenDen)
        {
            String sql = "Update ThongTin_ChuyenSinhHoatDoan Set NgayChuyen='" + ngayChuyen + "', NoiChuyenDen=N'" + noiChuyenDen + "', MaCB='" + maCB + "' Where MaSV='" + maSV + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimChuyenSinhHoatDoan(string masv)
        {
            string sql= "select *from ThongTin_ChuyenSinhHoatDoan where MaSV='"+masv+"'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable TimChuyenSinhHoatDoanTheoMaCB(string macb)
        {
            string sql = "select *from ThongTin_ChuyenSinhHoatDoan where MaCB='" + macb + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable TimTheoMasv_Macb(string masv, string macb)
        {
            string sql = "select *from ThongTin_ChuyenSinhHoatDoan where MaSV='" + masv + "'AND MaCB='" + macb + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from ThongTin_ChuyenSinhHoatDoan";
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
            sheet.Name = "ThongTinChuyenSinhHoat";

            //lưu tiêu đề 
            for (int i = 1; i < tableTaiKhoan.Columns.Count + 1; i++)
            {
                sheet.Cells[1, i] = tableTaiKhoan.Columns[i - 1].ColumnName;
            }

            //lưu dữ liệu
            for (int i = 0; i < tableTaiKhoan.Rows.Count - 1; i++)
            {
                for (int j = 0; j < tableTaiKhoan.Columns.Count; j++)
                {
                    sheet.Cells[i + 2, j + 1] = tableTaiKhoan.Rows[i][j].ToString();
                }
            }
            //save dữ liệu
            workbook.SaveAs("chuyensinhhoatdoan", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
