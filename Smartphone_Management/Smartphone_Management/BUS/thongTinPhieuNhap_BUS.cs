using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace Smartphone_Management.BUS
{
    internal class thongTinPhieuNhap_BUS
    {
        thongTinPhieuNhap_DAO ttpn_dao = new thongTinPhieuNhap_DAO();

        public DataTable getThongTinPhieuNhap()
        {
            DataTable data = new DataTable();
            DataTable data2 = ttpn_dao.getPhieuNhapData();

            foreach (DataColumn col in data2.Columns)
            {
                data.Columns.Add(col.ColumnName);

            }
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                DataRow row = data.NewRow();
                foreach (DataColumn col in data2.Columns)
                {
                    row[col.ColumnName] = data2.Rows[i][col.ColumnName];
                }
                data.Rows.Add(row);
            }
            return data;
        }

        public void setComboBoxData(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Tất Cả");
            comboBox1.Items.Add("Hoàn Thành");
            comboBox1.Items.Add("Đang Xử Lý");
            comboBox1.Items.Add("Đã Huỷ");
            comboBox1.Text = "Tất Cả";
        }

        internal void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Thông tin phiếu nhập ";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
