using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Smartphone_Management.DAO
{
    internal class LoiNhuanBanHang_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();
        internal DataTable getLoiNhuanBanHang_HangHoa()
        {
            string query = "select  chitietdonhang.Masp,sanpham.Tensp, sum(chitietdonhang.Soluong) as Tongso,sum(chitietdonhang.Soluong*chitietdonhang.giaban)as TienHang,sum(chitietdonhang.giasaukm)as TienSauKM ,sum(giasanpham.Gianhap*chitietdonhang.Soluong)as TienVon from giasanpham,sanpham,chitietdonhang,donhang where sanpham.Masp=chitietdonhang.Masp and  chitietdonhang.Madh=donhang.Madh and giasanpham.Magiasp=chitietdonhang.Magiasp and donhang.Trangthai='Hoàn Thành' group by(Masp)";
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

        internal List<List<string>> getLoiNhuanBanHang_HangHoa_BieuDo1()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select a.Tensp,(a.TienSauKM - a.TienVon) as LoiNhuan from (select  chitietdonhang.Masp,sanpham.Tensp, sum(chitietdonhang.Soluong) as Tongso,sum(chitietdonhang.Soluong*chitietdonhang.giaban)as TienHang,sum(chitietdonhang.giasaukm)as TienSauKM ,sum(giasanpham.Gianhap*chitietdonhang.Soluong)as TienVon from giasanpham,sanpham,chitietdonhang,donhang where sanpham.Masp=chitietdonhang.Masp and  chitietdonhang.Madh=donhang.Madh and giasanpham.Magiasp=chitietdonhang.Magiasp and donhang.Trangthai='Hoàn Thành' group by(Masp)) as a order by LoiNhuan desc limit 10;";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetString("Tensp"));
                list2.Add(MyReader2.GetDouble("LoiNhuan").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal List<List<string>> getLoiNhuanBanHang_NgayBan_BieuDo1(string ngaybatdau, string ngayketthuc)
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select a.Ngayban,(a.Tongtien-a.Von) as LoiNhuan from (select donhang.Ngayban,count(donhang.Madh) as Soluongdon,sum(donhang.SoLuong) as Soluong,sum(donhang.Tongtien) as Tongtien,sum(Von.Gianhap) as Von  from donhang, (select chitietdonhang.Madh,giasanpham.Gianhap  from chitietdonhang,giasanpham where chitietdonhang.Magiasp=giasanpham.Magiasp) Von where  donhang.Madh=Von.Madh and donhang.Ngayban > @ngaybatdau and donhang.Ngayban < @ngayketthuc and donhang.Trangthai='Hoàn Thành' group by(Ngayban)) as a order by LoiNhuan desc limit 10;";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
            cmd2.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);

            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetDateTime("Ngayban").ToShortDateString());
                list2.Add(MyReader2.GetDouble("LoiNhuan").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal DataTable getLoiNhuanBanHang_TheoThang()
        {
            string query = "select donhang.Ngayban,count(donhang.Madh) as Soluongdon,sum(donhang.SoLuong) as Soluong,sum(donhang.Tongtien) as Tongtien,sum(Von.Gianhap) as Von  from donhang, (select chitietdonhang.Madh,giasanpham.Gianhap  from chitietdonhang,giasanpham where chitietdonhang.Magiasp=giasanpham.Magiasp) Von\r\n where  donhang.Madh=Von.Madh and donhang.Trangthai=\"Hoàn Thành\" group by(Ngayban)";
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
