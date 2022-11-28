using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Smartphone_Management.DAO
{
    internal class ThongKeBaoCao_NhapHang_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();

        internal DataTable getThognKeNhapHang_NgayThang()
        {
            string query = "select phieunhap.NgayNhap,count(phieunhap.Maphieunhap) as SoPhieu, sum(phieunhap.SoLuong) as TongSoLuong, sum(TongTien) as TongTien from phieunhap group by (phieunhap.NgayNhap)";
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

        internal DataTable getThognKeNhapHang_NhaCungCap()
        {

           string query = "select phieunhap.Mancc,nhacungcap.Tenncc,count(phieunhap.Maphieunhap) as SoPhieu, sum(phieunhap.SoLuong) as SoLuong, sum(phieunhap.TongTien) as TongTien from phieunhap,nhacungcap where phieunhap.Mancc=nhacungcap.Mancc and phieunhap.Trangthai=\"T\" group by(phieunhap.Mancc)";

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

        internal DataTable getThongKeNhapHang_HangHoa()
        {
            string query= "select sanpham.Masp,sanpham.Tensp,count(chitietphieunhap.MaChiTietPhieuNhap)as SoLanNhap,sum(chitietphieunhap.Soluong) as SoLuong,sum(chitietphieunhap.GiaNhap*chitietphieunhap.Soluong) as TongTien from chitietphieunhap, sanpham,phieunhap where phieunhap.Trangthai=\"T\" and sanpham.Masp=chitietphieunhap.Masp and phieunhap.Maphieunhap=chitietphieunhap.Maphieunhap group by(chitietphieunhap.Masp)";

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
