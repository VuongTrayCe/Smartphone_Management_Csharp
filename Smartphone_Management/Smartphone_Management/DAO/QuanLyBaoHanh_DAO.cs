using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Numerics;

namespace Smartphone_Management.DAO
{
    internal class QuanLyBaoHanh_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();

        internal void AddBaoHanh(string thoigianbaohanh, string trangthai)
        {
            sqla.openConnectToMySql();
            string query = "INSERT INTO baohanh(Thoigianbaohanh,Trangthai) VALUES (@thoigian,@trangthai)";
                           
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@thoigian",thoigianbaohanh);
            cmd2.Parameters.AddWithValue("@trangthai",trangthai);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            cmd2.Dispose();
            sqla.closeConnectToMySql();

        }

        internal void AddChiTietBaoHanh(int mabh, int masp)
        {
            sqla.openConnectToMySql();
            string query = "INSERT INTO chitietbaohanh(chitietbaohanh.Mabaohanh,chitietbaohanh.Masp,chitietbaohanh.TrangThai) VALUES (@mabh,@masp,'T')";

            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@mabh",mabh);
            cmd2.Parameters.AddWithValue("@masp",masp);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        internal void deleteBaoHanh(int mabh)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE baohanh SET baohanh.Trangthai ='F' WHERE baohanh.Mabaohanh =@mabaohanh";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@mabaohanh", mabh);

            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        internal void deleteChiTietBaoHanh(int mactbh)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE chitietbaohanh SET chitietbaohanh.TrangThai ='F' WHERE chitietbaohanh.Machitietbaohanh =@mactbh";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@mactbh", mactbh);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        internal List<int> getALLMaBaoHanh()
        {
            List<int> list = new List<int>();
            sqla.openConnectToMySql();
            string query = "select  baohanh.Mabaohanh from baohanh where baohanh.Trangthai='T'";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {

                list.Add(MyReader2.GetInt32("Mabaohanh"));
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal List<List<String>> getAllMaSanPham()
        {
            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select  sanpham.Masp,sanpham.Tensp from sanpham where sanpham.TrangThai='T'";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> a = new List<string>();
                a.Add(MyReader2.GetInt32("Masp").ToString());
                a.Add(MyReader2.GetString("Tensp"));
                list.Add((a));

            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal DataTable getInForBaoHanh()
        {
            sqla.openConnectToMySql();
            string query = "SELECT baohanh.Mabaohanh, baohanh.Thoigianbaohanh, baohanh.Trangthai FROM baohanh";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        internal DataTable getInForChiTietBaoHanh()
        {
            sqla.openConnectToMySql();
            string query = "SELECT chitietbaohanh.Machitietbaohanh, chitietbaohanh.Mabaohanh, chitietbaohanh.Masp,chitietbaohanh.TrangThai FROM chitietbaohanh WHERE chitietbaohanh.TrangThai ='T'";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        internal DataTable getThongTinBaoHanh()
        {
            sqla.openConnectToMySql();
            string query = "select donhang.Madh,chitietdonhang.Masp, donhang.Makh, sanpham.Tensp,khachhang.Tenkh,donhang.Ngayban,baohanh.Thoigianbaohanh from baohanh,chitietbaohanh,sanpham,chitietdonhang,donhang,khachhang where chitietdonhang.Madh=donhang.Madh and chitietdonhang.Masp=sanpham.Masp and donhang.Makh=khachhang.Makh and chitietdonhang.Machitietbaohanh=chitietbaohanh.Machitietbaohanh and chitietbaohanh.Mabaohanh=baohanh.Mabaohanh and donhang.Trangthai='Hoàn Thành'";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        internal void UpdateBaoHanh(int mabh, string text1, string text2)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE baohanh SET baohanh.Thoigianbaohanh =@thoigian ,baohanh.Trangthai =@trangthai WHERE baohanh.Mabaohanh =@mabaohanh" ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@thoigian",text1);
            cmd2.Parameters.AddWithValue("@trangthai",text2);
            cmd2.Parameters.AddWithValue("@mabaohanh",mabh);

            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();

            cmd2.Dispose();
            sqla.closeConnectToMySql();


        }

        internal void UpdateTrangThaiChiTietCu(int masp)
        {
            sqla.openConnectToMySql();
            string query = "update chitietbaohanh set chitietbaohanh.TrangThai=\"F\" where chitietbaohanh.Masp=@masp";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@masp",masp);

            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();

            cmd2.Dispose();
            sqla.closeConnectToMySql();

        }
    }
}
