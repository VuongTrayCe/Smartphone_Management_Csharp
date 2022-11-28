using DocumentFormat.OpenXml.Drawing.Charts;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using DataTable = System.Data.DataTable;

namespace Smartphone_Management.BUS
{
    internal class ThongKeBaoCao_BUS
    {
        DataTable data2 = new DataTable();

        ThongKeBaoCao_DAO tkbc = new ThongKeBaoCao_DAO();
        internal DataTable getDooanhThuBanHang_HangHoa()
        {
            data2 = tkbc.getDoanhThuBanHang_HangHoa();
            DataTable data = new DataTable();

            data.Columns.Add("STT");
            //data.Columns.Add("NgayDat", Type.GetType("System.DateTime"));
            data.Columns.Add("Tên Sản Phẩm");
            data.Columns.Add("Mã Sản Phẩm");
            data.Columns.Add("Số Lượng");
            data.Columns.Add("Tổng Tiền");

            // Kiểm tra đơn hàng có đúng với từ khóa/ngày/ trạng thái tìm kiếm hay không 
            int stt = 1;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                //dataGridView1.Rows.Add(1) ;
                DataRow row = data.NewRow();
                row["STT"] = stt;

                row["Tên Sản Phẩm"] = data2.Rows[i][0];
                row["Mã Sản Phẩm"] = data2.Rows[i][1];
                row["Số Lượng"] = data2.Rows[i][2];
                row["Tổng Tiền"] = data2.Rows[i][3];

                stt += 1;
                //int soluong = int.Parse(data2.Rows[i][2].ToString());
                //Double thanhtien = Double.Parse(data2.Rows[i][6].ToString())
                data.Rows.Add(row);
            }
            return data;
        }

        internal DataTable getDooanhThuBanHang_KhachHang()
        {
            data2 = tkbc.getDoanhThuBanHang_KhachHang();
            data2.Columns.Add("STT").SetOrdinal(0);
            int stt = 1;
            int tongsl = 0;
            Double tongtien = 0;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                data2.Rows[i][0] = stt;
                stt += 1;
                int soluong = int.Parse(data2.Rows[i][3].ToString());
                Double thanhtien = Double.Parse(data2.Rows[i][4].ToString());
                tongsl = tongsl + soluong;
                tongtien += thanhtien;

            }
            DataRow row2 = data2.NewRow();
            row2[3]=tongsl;
            row2[4] = tongtien;
            data2.Rows.Add(row2);
            return data2;

        }

        internal DataTable getDooanhThuBanHang_NgayThang(DateTime dateStart, DateTime DateEnd)
        {
            data2 = tkbc.getDoanhThuBanHang_NgayThang();


            DataTable data = new DataTable();

            data.Columns.Add("STT");
            data.Columns.Add("Ngayban", Type.GetType("System.DateTime"));
            data.Columns.Add("Soluongdon");
            data.Columns.Add("Soluong");
            data.Columns.Add("Tongtien");
            int stt = 1;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                DateTime dateDat = (DateTime)data2.Rows[i][0];
                if (dateDat > dateStart && dateDat < DateEnd)
                {

                    //dataGridView1.Rows.Add(1) ;
                    DataRow row = data.NewRow();
                    row["STT"] = stt;
                    foreach (DataColumn col in data2.Columns)
                    {
                        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    }
                    data.Rows.Add(row);
                    stt++;
                }

            }


            return data;

        }

        public Boolean CompareDate(DateTime dateTiem1, DateTime dateTime2)
        {
            return dateTiem1 > dateTime2;
        }
        public DateTime ConvertStringtoDateTime(String date)
        {
            //MessageBox.Show(dateTime.ToString());
            DateTime dateTimeObj;

            CultureInfo provider = CultureInfo.InvariantCulture;
            bool isSuccess = DateTime.TryParseExact(date, "yyyy-MM-dd", provider, DateTimeStyles.None, out dateTimeObj);
            return dateTimeObj;
        }
    }
}
