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
