using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using System.Data;
namespace BLL
{
 public   class BLL_ThongTinHoatDongDoan
    {
        Connection dataConn = new Connection();
        public DataTable HienThongTinHD()
        {
            string sql = "select *from ThongTin_ThamGiaHoatDong";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable HienThongTinSV()
        {
            string sql = "select *from SinhVien";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public DataTable HienThongTinMaHD()
        {
            string sql = "select *from HoatDongDoan";
            DataTable dataTable = new DataTable();
            dataTable = dataConn.GetTable(sql);
            return dataTable;
        }
        public void ExportDataToExcel()
        {
            string sql = "select * from ThongTin_ThamGiaHoatDong";
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
            sheet.Name = "ThongTinThamGiaHoatDong";
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
            workbook.SaveAs("thongtinthamgiahoatdong", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
