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

        internal DataTable getLoiNhuanBanHang_LaiLo()
        {
            throw new NotImplementedException();
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
