using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLL_ThongTinSV
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinSinhVien()
        {
            String sql = "SELECT * from  SinhVien";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinComboBox()
        {
            String sql = "SELECT * from  ThongTin_HoatDongDoan";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinMaSV()
        {
            String sql = "SELECT * from  LopSinhHoat";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ThemSV(string masv, string hotensv, string ngaysinh, string diachi, string sdt, string malop, string trangthai)
        {
            string sql = "insert into SinhVien values('" + masv + "','" + hotensv + "','" + ngaysinh + "','" + diachi + "','" + sdt + "','" + malop + "','" + trangthai + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaSV(string masv, string hotensv, string ngaysinh, string diachi, string sdt, string malop, string trangthai)
        {
          
            string sql = "update SinhVien set MaSV='" + masv + "',HoTenSV='" + hotensv + "',NgaySinh='" + ngaysinh + "',DiaChi='" + diachi + "',DienThoai='" + sdt + "',MaLop='" + malop + "',TrangThai='" + trangthai + "'where MaSV='" + masv + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable TimTheoMaSV(string masv)
        {
            string sql = "select *from SinhVien where MaSV='" + masv + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable TimTheoMaLop(string malop)
        {
            string sql = "select *from SinhVien where MaLop='" + malop + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from SinhVien";
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
            sheet.Name = "ThongTinSinhVien";
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
            workbook.SaveAs("thongtinsinhvien", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

    }
}
