using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smartphone_Management.BUS
{
    internal class QuanLyDonDatHang_BUS
    {
        QuanLyDonDatHang_DAO qlddh_dao = new QuanLyDonDatHang_DAO();
        // Hàm lấy thông tin đơn hàng 
        public DataTable getThongTinDonDatHang(String status,DateTime dateStart,DateTime DateEnd,String strKeyWord)
        {
            DataTable data = new DataTable();
            DataTable data2 = qlddh_dao.getThongTinDonDatHang(status);
            data.Columns.Add("STT");
            data.Columns.Add("NgayDat", Type.GetType("System.DateTime"));
            data.Columns.Add("Madh");
            data.Columns.Add("Tenkh");
            data.Columns.Add("SoLuong");
            data.Columns.Add("Soluongdadung");
            data.Columns.Add("Soluongduoctang");
            data.Columns.Add("TongTien");
            data.Columns.Add("Tennv");
            // Kiểm tra đơn hàng có đúng với từ khóa/ngày/ trạng thái tìm kiếm hay không 
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                String madh =  data2.Rows[i][1].ToString();
                DateTime dateDat = (DateTime)data2.Rows[i][0];
                if (dateDat > dateStart && dateDat < DateEnd && strKeyWord.Equals(""))
                {
                    //dataGridView1.Rows.Add(1) ;
                    DataRow row = data.NewRow();
                    foreach (DataColumn col in data2.Columns)
                    {
                        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    }
                    data.Rows.Add(row);
                }
               else if( dateDat > dateStart && dateDat < DateEnd && madh.Equals(strKeyWord))
                {
                    DataRow row = data.NewRow();
                    foreach (DataColumn col in data2.Columns)
                    {
                        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    }
                    data.Rows.Add(row);
                }
            }
            return data ;
        }



        // lấy thông tin chi tiết của một đơn hàng
        internal DataTable getChiTietDonHang(int madh)
        {
            DataTable data = new DataTable();
            DataTable data2 = qlddh_dao.getChiTietDonHang_DAO(madh);
            data.Columns.Add("STT");
            data.Columns.Add("Masp");
            data.Columns.Add("Ten");
            data.Columns.Add("Soluong");
            data.Columns.Add("gia");
            data.Columns.Add("KhuyenMai");
            data.Columns.Add("BaoHanh");
            data.Columns.Add("ThanhTien");
            return data;
        }



        public Boolean CompareDate(DateTime dateTiem1,DateTime dateTime2)
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
