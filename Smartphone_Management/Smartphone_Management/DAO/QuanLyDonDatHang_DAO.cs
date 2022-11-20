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
                MessageBox.Show("Successfully Updated", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Successfully deleted", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqla.getConnection().Close();
        }
    }
}
