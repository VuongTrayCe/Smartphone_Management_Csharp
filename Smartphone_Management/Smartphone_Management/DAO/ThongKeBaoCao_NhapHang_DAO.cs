using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySqlConnector;

namespace Smartphone_Management.DAO
{
    internal class ThongKeBaoCao_NhapHang_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();

        internal List<List<string>> getChiPhiNhapHang_HangHoa_BieuDo()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select a.Tensp,a.SoLuong from (select sanpham.Tensp,sum(chitietphieunhap.Soluong) as SoLuong from chitietphieunhap, sanpham,phieunhap where sanpham.Masp=chitietphieunhap.Masp and phieunhap.Maphieunhap=chitietphieunhap.Maphieunhap and phieunhap.Trangthai=\"Hoàn Thành\" group by(chitietphieunhap.Masp)) as a order by a.SoLuong desc limit 10;";
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

        internal List<List<string>> getChiPhiNhapHang_NgayNhap_BieuDo()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select a.NgayNhap,a.TongSoLuong from(select phieunhap.NgayNhap,count(phieunhap.Maphieunhap) as SoPhieu, sum(phieunhap.SoLuong) as TongSoLuong, sum(TongTien) as TongTien from phieunhap where phieunhap.Trangthai='Hoàn Thành' group by (phieunhap.NgayNhap))as a order by a.TongSoLuong desc limit 10;\r\n";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetDateTime("NgayNhap").ToShortDateString());
                list2.Add(MyReader2.GetInt32("TongSoLuong").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal List<List<string>> getChiPhiNhapHang_NhaCungCap_BieuDo()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = " select a.Tenncc,a.SoLuong from(select phieunhap.Mancc,nhacungcap.Tenncc,count(phieunhap.Maphieunhap) as SoPhieu, sum(phieunhap.SoLuong) as SoLuong, sum(phieunhap.TongTien) as TongTien from phieunhap,nhacungcap where phieunhap.Mancc=nhacungcap.Mancc and phieunhap.Trangthai=\"Hoàn Thành\" group by(phieunhap.Mancc))as a order by a.SoLuong desc limit 10";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetString("Tenncc"));
                list2.Add(MyReader2.GetInt32("SoLuong").ToString());
                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal DataTable getThognKeNhapHang_NgayThang()
        {
            string query = "select phieunhap.NgayNhap,count(phieunhap.Maphieunhap) as SoPhieu, sum(phieunhap.SoLuong) as TongSoLuong, sum(TongTien) as TongTien from phieunhap where phieunhap.Trangthai='Hoàn Thành' group by (phieunhap.NgayNhap)";
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

           string query = "select phieunhap.Mancc,nhacungcap.Tenncc,count(phieunhap.Maphieunhap) as SoPhieu, sum(phieunhap.SoLuong) as SoLuong, sum(phieunhap.TongTien) as TongTien from phieunhap,nhacungcap where phieunhap.Mancc=nhacungcap.Mancc and phieunhap.Trangthai=\"Hoàn Thành\" group by(phieunhap.Mancc)";

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
            string query= "select sanpham.Masp,sanpham.Tensp,count(chitietphieunhap.MaChiTietPhieuNhap)as SoLanNhap,sum(chitietphieunhap.Soluong) as SoLuong,sum(chitietphieunhap.GiaNhap*chitietphieunhap.Soluong) as TongTien from chitietphieunhap, sanpham,phieunhap where phieunhap.Trangthai=\"Hoàn Thành\" and sanpham.Masp=chitietphieunhap.Masp and phieunhap.Maphieunhap=chitietphieunhap.Maphieunhap group by(chitietphieunhap.Masp)";

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

        internal DataTable getThongKeNhapHang_NgayBan_ChiTiet(string v)
        {
            string query = "select phieunhap.Mancc,nhacungcap.Tenncc,phieunhap.SoLuong,phieunhap.TongTien,nhanvien.Tennv from phieunhap,nhacungcap,nhanvien where phieunhap.NgayNhap=@ngaynhap and phieunhap.Mancc=nhacungcap.Mancc and phieunhap.Manv=nhanvien.Manv and phieunhap.Trangthai='Hoàn Thành';";

            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
            MyCommand2.Parameters.AddWithValue("@Ngaynhap",v);

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

        internal DataTable getThongKeNhaphang_NhaCungCap_ChiTiet(int mancc)
        {
            string query = "select phieunhap.Maphieunhap, phieunhap.NgayNhap,phieunhap.SoLuong,phieunhap.TongTien from phieunhap where phieunhap.Mancc=@mancc and phieunhap.Trangthai='Hoàn Thành';";

            DataTable data = new DataTable();
            sqla.openConnectToMySql();
            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
            MyCommand2.Parameters.AddWithValue("@mancc", mancc);

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
