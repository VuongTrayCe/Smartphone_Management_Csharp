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
    internal class QuanLyNhanVien_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();




        internal void updateTrangThaiNhanVienHuy(int manv)
        {

            try
            {
                sqla.getConnection().Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE khachhang SET Trangthai = \"F\"\r WHERE nhanvien.Manv=@Manv", sqla.getConnection());
                cmd.Parameters.AddWithValue("@Manv", manv);
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


        internal DataTable getThongTinNhanVien()
        {
            sqla.getConnection().Open();
            DataTable data = new DataTable();
            string query = "select Manv,Tennv,SoCCCD,Tuoi,Diachi,ChucDanh from nhanvien WHERE TrangThai=\"T\"\r ";
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

        internal void updateNhanVien(model_nv model_nv)
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            try
            {
                conn.getConnection().Open();
                String query = "UPDATE nhanvien SET @manv=Manv,@tennv=Tennv,@cccd=SoCCCD,@tuoi=Tuoi,@diachi=Diachi,@chucdanh=ChucDanh " + "WHERE nhanvien.Manv=@manv";

                MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
                cmd.Parameters.AddWithValue("@manv", model_nv.Manv);
                cmd.Parameters.AddWithValue("@tennv", model_nv.Tennv);
                cmd.Parameters.AddWithValue("@cccd", model_nv.Cmnd);
                cmd.Parameters.AddWithValue("@tuoi", model_nv.Tuoi);
                cmd.Parameters.AddWithValue("@diachi", model_nv.DiaChi);
                cmd.Parameters.AddWithValue("@chucdanh", model_nv.Chucdanh);
                cmd.Parameters.AddWithValue("@trangthai", model_nv.Trangthai);


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

        internal void addNhanVien(model_nv model_nv)
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            try
            {
                conn.getConnection().Open();
                String query = "insert into nhanvien(Manv,Tennv,SoCCCD,Tuoi,Diachi,ChucDanh,TrangThai) " + " values(@manv,@tennv,@cccd,@tuoi,@diachi,@chucdanh,@trangthai)";

                MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
                cmd.Parameters.AddWithValue("@manv", model_nv.Manv);
                cmd.Parameters.AddWithValue("@tennv", model_nv.Tennv);
                cmd.Parameters.AddWithValue("@cccd", model_nv.Cmnd);
                cmd.Parameters.AddWithValue("@tuoi", model_nv.Tuoi);
                cmd.Parameters.AddWithValue("@diachi", model_nv.DiaChi);
                cmd.Parameters.AddWithValue("@chucdanh", model_nv.Chucdanh);
                cmd.Parameters.AddWithValue("@trangthai", model_nv.Trangthai);


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
