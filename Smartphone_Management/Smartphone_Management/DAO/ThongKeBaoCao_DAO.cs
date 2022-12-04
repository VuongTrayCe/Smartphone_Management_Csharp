using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;

namespace Smartphone_Management.DAO
{
    internal class ThongKeBaoCao_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();

        internal List<List<string>> getDanhThuBanHang_HangHoa_BieuDo()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select a.Tensp,a.SoLuong from (select sanpham.Tensp,sum(chitietdonhang.Soluong)as SoLuong from chitietdonhang, sanpham,donhang where sanpham.Masp=chitietdonhang.Masp and donhang.Madh=chitietdonhang.Madh and donhang.Trangthai=\"Hoàn Thành\" group by(chitietdonhang.Masp)) as a order by a.SoLuong desc limit 10;";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetString("Tensp"));
                list2.Add(MyReader2.GetInt32("SoLuong").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal List<List<string>> getDanhThuBanHang_KhachHang_BieuDo1()
        {

            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select khachhang.Tenkh,sum(SoLuong)as SL from donhang,khachhang where donhang.Trangthai=\"Hoàn Thành\" and khachhang.Makh=donhang.Makh group by(donhang.Makh) order by SL desc limit 5;";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetString("Tenkh"));
                list2.Add(MyReader2.GetInt32("SL").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal List<List<string>> getDanhThuBanHang_NgayBan_BieuDo1()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select a.Ngayban,a.Soluong from (select donhang.Ngayban,count(Madh) as Soluongdon,sum(donhang.SoLuong) as Soluong,sum(donhang.Tongtien) as Tongtien from donhang where donhang.Trangthai=\"Hoàn Thành\" group by(Ngayban))as a order by Soluong desc limit 5;\r\n";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetDateTime("Ngayban").ToShortDateString());
                list2.Add(MyReader2.GetInt32("Soluong").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal DataTable getDoanhThuBanHang_HangHoa()
        {
            string query = "select sanpham.Tensp , chitietdonhang.Masp, sum(chitietdonhang.Soluong) as Tongso,sum(chitietdonhang.Soluong*chitietdonhang.giaban)as TongTien from sanpham,chitietdonhang,donhang where sanpham.Masp=chitietdonhang.Masp and  chitietdonhang.Madh=donhang.Madh and donhang.Trangthai='Hoàn Thành' group by(Masp)";
            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
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
            sqla.getConnection().Close();

            return data;

        }

        internal DataTable getDoanhThuBanHang_KhachHang()
        {
            string query = "select khachhang.Makh,khachhang.Tenkh , count(donhang.Madh) as Sodon,sum(donhang.SoLuong) as Soluong,sum(donhang.Tongtien) as TongTien from khachhang, donhang where donhang.Trangthai=\"Hoàn Thành\" and khachhang.Makh=donhang.Makh group by(donhang.Makh)";
            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
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
            sqla.getConnection().Close();

            return data;

        }

        internal DataTable getDoanhThuBanHang_KhachHang_ChiTiet(int makh)
        {
            string query = "select donhang.Madh,donhang.Ngayban,donhang.Diemapdung,donhang.Diemthuong,donhang.Tongtien from donhang where donhang.Makh=@makh and donhang.Trangthai=\"Hoàn Thành\"";
            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
            MyCommand2.Parameters.AddWithValue("@makh", makh);
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
            sqla.getConnection().Close();

            return data;
        }

        internal DataTable getDoanhThuBanHang_NgayBan_ChiTiet(string ngayban)
        {
            string query = "select khachhang.Tenkh,donhang.SoLuong,donhang.Diemapdung,donhang.Diemthuong, donhang.Tongtien from donhang,khachhang where khachhang.Makh=donhang.Makh and donhang.Ngayban=@ngayban and donhang.Trangthai='Hoàn Thành'";
            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
            MyCommand2.Parameters.AddWithValue("@ngayban",ngayban);
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
            sqla.getConnection().Close();

            return data;
        }

        internal DataTable getDoanhThuBanHang_NgayThang()
        {
            string query ="select donhang.Ngayban,count(Madh) as Soluongdon,sum(donhang.SoLuong) as Soluong,sum(donhang.Tongtien) as Tongtien from donhang where donhang.Trangthai=\"Hoàn Thành\" group by(Ngayban)";
            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
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
            sqla.getConnection().Close();

            return data;
        }
    }
}
