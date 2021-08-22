using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class BLL_LopSinhHoat
    {
        Connection dataConn = new Connection();
        public DataTable HienThiThongTinLopSH()
        {
            String sql = "Select * from LopSinhHoat";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable HienThiThongTinNganh()
        {
            String sql = "SELECT * from  Nganh";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ThemLopSH(String maLop, String maNganh, String tenLop, int siSo)
        {
            String sql = "Insert Into LopSinhHoat Values('" + maLop + "', '" + maNganh + "', '" + tenLop + "', '" + siSo + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void SuaLopSH(String maLop, String maNganh, String tenLop, int siSo)
        {
            String sql = "Update LopSinhHoat Set TenLop='" + tenLop + "', SiSo='" + siSo + "', MaNganh='" + maNganh + "' Where MaLop='" + maLop + "'";
            dataConn.ExecuteNonQuery(sql);
        }
       
        public DataTable TimLopSinhHoat(string maLop)
        {
            string sql = "Select * from LopSinhHoat where MaLop = '" + maLop + "'";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from LopSinhHoat";
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
            sheet.Name = "LopSinhHoat";

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
            workbook.SaveAs("lopsinhoat", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
