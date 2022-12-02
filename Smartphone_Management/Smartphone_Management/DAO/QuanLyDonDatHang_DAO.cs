using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smartphone_Management.DAO
{
    internal class QuanLyDonDatHang_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();
        internal DataTable getChiTietDonHang_DAO(int madh)
        {
            DataTable data = new DataTable();

            string query = "select chitietdonhang.Masp,sanpham.Tensp,chitietdonhang.Soluong,chitietdonhang.giaban,khuyenmai.Ptkm as KhuyenMai,baohanh.Thoigianbaohanh as BaoHanh,(chitietdonhang.Soluong*chitietdonhang.giaban)*((100-khuyenmai.Ptkm)/100) as ThanhTien from chitietdonhang,sanpham,khuyenmai,baohanh,chitietbaohanh,chitietkhuyenmai where sanpham.Masp=chitietdonhang.Masp and chitietdonhang.Machitietkhuyenmai=chitietkhuyenmai.Machitietkhuyenmai and chitietbaohanh.Machitietbaohanh=chitietdonhang.Machitietbaohanh and khuyenmai.Makm=chitietkhuyenmai.Makm and baohanh.Mabaohanh=chitietbaohanh.Mabaohanh and chitietdonhang.Madh=@Madh";

            MySqlCommand MyCommand2 = new MySqlCommand(query, sqla.getConnection());
            MyCommand2.Parameters.AddWithValue("@Madh",madh);
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

        internal int getDiemDaDung(int madh)
        {
            sqla.openConnectToMySql();
            int diemapdung = 0;
            String query = "SELECT donhang.Diemapdung\n"
                    + "FROM donhang\n"
                    + "WHERE donhang.Madh =@madh";
            MySqlCommand command = sqla.getConnection().CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@madh",madh);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                diemapdung = reader.GetInt32("Diemapdung");
            }
            sqla.closeConnectToMySql();
            return diemapdung;
        }

        internal int getDiemHienTaiKhachHang(int makhachhang)
        {
            sqla.openConnectToMySql();
            int diemhientai = 0;
            String query = "SELECT khachhang.Diemso FROM khachhang WHERE khachhang.Makh =@makhachhang";
            MySqlCommand command = sqla.getConnection().CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@makhachhang",makhachhang);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                diemhientai = reader.GetInt32("Diemso");
            }
            sqla.closeConnectToMySql();
            return diemhientai;
        }

        internal string getImageSanPham(int masp)
        {
            sqla.openConnectToMySql();
            string ImageIcon = "";
            String query = "select Icon from sanpham where sanpham.Masp=@masp";
            MySqlCommand command = sqla.getConnection().CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@masp",masp);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               ImageIcon = (string)reader["Icon"].ToString();
            }
            sqla.closeConnectToMySql();
            return ImageIcon;
        }

        internal int getMaKhachHang(int madh)
        {
            sqla.openConnectToMySql();
            int makh = 0;
            String query = "SELECT donhang.Makh FROM donhang WHERE donhang.Madh =@madh ";
            MySqlCommand command = sqla.getConnection().CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@madh",madh);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                makh = reader.GetInt32("Makh");
            }
            sqla.closeConnectToMySql();
            return makh;
        }

        internal int getSoLuongHienTai(int masp)
        {
            sqla.openConnectToMySql();
            int soluong = 0;
            String query = "SELECT sanpham.soluong FROM sanpham WHERE sanpham.Masp=@masp ";
            MySqlCommand command = sqla.getConnection().CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@masp", masp);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                soluong= reader.GetInt32("soluong");
            }
            sqla.closeConnectToMySql();
            return soluong;
        }

        internal DataTable getThongTinDonDatHang(string status)
        {
            DataTable data = new DataTable();

            string query = "select donhang.Ngayban as NgayDat,donhang.Madh,khachhang.Tenkh,donhang.SoLuong,donhang.Diemapdung,donhang.Diemthuong,donhang.Tongtien,nhanvien.Tennv from donhang,nhanvien,khachhang where donhang.Manv=nhanvien.Manv and donhang.Makh=khachhang.Makh and donhang.TrangThai=@Continent";

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
            sqla.getConnection().Close();

            return data;
        }
        internal DataTable getThongTinDonhang()
        {
            DataTable data = new DataTable();
            string query = "select * from donhang";

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

        internal void UpdateDiemKhachHang(int makhachhang, int v)
        {
            try
            {
                sqla.getConnection().Open();
                string query = "UPDATE khachhang SET khachhang.Diemso=@diem WHERE khachhang.Makh =@makhachhang";
                MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
                cmd.Parameters.AddWithValue("@makhachhang",makhachhang);
                cmd.Parameters.AddWithValue("@diem",v);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                //MessageBox.Show("Successfully Updated", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqla.getConnection().Close();


        }

        internal void UpdateSoluongSanPham(int masp, int soluong)
        {
            try
            {
                sqla.getConnection().Open();
                string query = "UPDATE sanpham SET sanpham.soluong =@soluong WHERE sanpham.Masp =@masp";
                MySqlCommand cmd = new MySqlCommand(query,sqla.getConnection());
                cmd.Parameters.AddWithValue("@masp",masp);
                cmd.Parameters.AddWithValue("@soluong",soluong);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                //MessageBox.Show("Successfully Updated", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqla.getConnection().Close();

        }

        internal void updateTrangThaiDonHang(int madh)
        {

            try
            {
                sqla.getConnection().Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE donhang SET Trangthai = \"Hoàn Thành\"\r WHERE donhang.Madh=@Madh", sqla.getConnection());
                cmd.Parameters.AddWithValue("@Madh", madh);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                //MessageBox.Show("Successfully Updated", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqla.getConnection().Close();

        }

        internal void updateTrangThaiDonHangHuy(int madh)
        {

            try
            {
                sqla.getConnection().Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE donhang SET Trangthai = \"Đã Hủy\"\r WHERE donhang.Madh=@Madh", sqla.getConnection());
                cmd.Parameters.AddWithValue("@Madh", madh);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                //MessageBox.Show("Successfully deleted", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqla.getConnection().Close();
        }
    }
}
