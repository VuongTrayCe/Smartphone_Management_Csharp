using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using MySqlConnector;

namespace Smartphone_Management.DAO
{
    internal class QuanLyDonDatHang_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();

        internal DataTable getChiTietDonHang_DAO(int madh)
        {
            throw new NotImplementedException();
        }

        internal DataTable getThongTinDonDatHang(string status)
        {
            DataTable data = new DataTable();

            string query = "select donhang.Ngayban as NgayDat,donhang.Madh,khachhang.Tenkh,donhang.SoLuong,donhang.Soluongdadung,donhang.Soluongduoctang,donhang.Tongtien,nhanvien.Tennv from donhang,nhanvien,khachhang where donhang.Manv=nhanvien.Manv and donhang.Makh=khachhang.Makh and donhang.TrangThai=@Continent";

            MySqlCommand MyCommand2 = new MySqlCommand(query,sqla.getConnection());
            MyCommand2.Parameters.AddWithValue("@Continent",status);
            //  MyConn2.Open();
            //For offline connection we weill use  MySqlDataAdapter class.
            if (MyCommand2 == null)
            {
                return null;
            }
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            MyAdapter.Fill(data);
            //MessageBox.Show("Completed");

            return data;
        }


       
    }
}
