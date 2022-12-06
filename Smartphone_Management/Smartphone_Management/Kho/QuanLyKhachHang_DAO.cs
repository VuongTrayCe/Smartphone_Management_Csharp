using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using MySqlConnector;
using Smartphone_Management.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smartphone_Management.DAO
{
    internal class QuanLyKhachHang_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();
       

        

        internal void updateTrangThaiKhachHangHuy(int makh)
        {

            try
            {
                sqla.getConnection().Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE khachhang SET Trangthai = \"F\"\r WHERE khachhang.Makh=@Makh", sqla.getConnection());
                cmd.Parameters.AddWithValue("@Makh", makh);
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


        internal DataTable getThongTinKhachhang()
        {
            sqla.getConnection().Open();
            DataTable data = new DataTable();
            string query = "select Makh,Tenkh,Cmnd,SDT,DiaChi,Email,Ngaytao,Diemso from khachhang WHERE TrangThai=\"T\"\r ";
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

        internal void updateKhachHang(model_kh model_kh)
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            try
            {
                conn.getConnection().Open();
                String query = "UPDATE khachhang SET Tenkh=@tenkh,Cmnd=@cmnd,SDT=@sdt,Diachi=@diachi,Email=@email,Ngaytao=@ngaytao,Diemso=@diemso,TrangThai=@trangthai "  + "WHERE khachhang.Makh=@makh";

                MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
                cmd.Parameters.AddWithValue("@makh", model_kh.Makh);
                cmd.Parameters.AddWithValue("@tenkh", model_kh.Tenkh);
                cmd.Parameters.AddWithValue("@cmnd", model_kh.Cmnd);
                cmd.Parameters.AddWithValue("@sdt", model_kh.SDT);
                cmd.Parameters.AddWithValue("@diachi", model_kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", model_kh.Email);
                cmd.Parameters.AddWithValue("@ngaytao", model_kh.Ngaytao);
                cmd.Parameters.AddWithValue("@diemso", model_kh.Diemso);
                cmd.Parameters.AddWithValue("@trangthai", model_kh.Trangthai);


                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Successfully added", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.getConnection().Close();
        }

        internal void addKhachHang(model_kh model_kh)
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            try
            {
                conn.getConnection().Open();
                String query = "insert into khachhang(Makh,Tenkh,Cmnd,SDT,Diachi,Email,Ngaytao,Diemso,TrangThai) " + " values(@makh,@tenkh,@cmnd,@sdt,@diachi,@email,@ngaytao,@diemso,@trangthai)" ;

                MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
                cmd.Parameters.AddWithValue("@makh", model_kh.Makh);
                cmd.Parameters.AddWithValue("@tenkh", model_kh.Tenkh);
                cmd.Parameters.AddWithValue("@cmnd", model_kh.Cmnd);
                cmd.Parameters.AddWithValue("@sdt", model_kh.SDT);
                cmd.Parameters.AddWithValue("@diachi", model_kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", model_kh.Email);
                cmd.Parameters.AddWithValue("@ngaytao", model_kh.Ngaytao);
                cmd.Parameters.AddWithValue("@diemso", model_kh.Diemso);
                cmd.Parameters.AddWithValue("@trangthai", model_kh.Trangthai);


                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Successfully added", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.getConnection().Close();
        }

    }
}
