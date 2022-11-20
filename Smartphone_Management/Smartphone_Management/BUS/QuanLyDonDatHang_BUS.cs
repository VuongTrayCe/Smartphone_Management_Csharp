using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Smartphone_Management.BUS
{
    internal class QuanLyDonDatHang_BUS
    {
        QuanLyDonDatHang_DAO qlddh_dao = new QuanLyDonDatHang_DAO();
        public DataTable getThongTinDonDatHang(String status,DateTime dateStart,DateTime DateEnd)
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

            for (int i = 0; i < data2.Rows.Count; i++)
            {
                //dataGridView1.Rows.Add(1) ;
                DataRow row = data.NewRow();
                foreach (DataColumn col in data2.Columns)
                {


                    row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                }
                data.Rows.Add(row);
            }
            return data ;
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
