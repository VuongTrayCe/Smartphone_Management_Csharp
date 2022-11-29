//using MySql.Data.MySqlClient;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySqlConnector;
using MySql.Data.MySqlClient;
using Smartphone_Management.DTO;
//using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Smartphone_Management.DAO
{
    internal class QuanLyTaiKhoan_DAO
    {

        ConnectToMySQL sqla = new ConnectToMySQL();
       

        public DataTable getThongTinCacTaiKhoan_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM taikhoan";
            MySqlCommand cmd = new MySqlCommand(query,sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();

            return dt;
        }

        public DataTable getThongTinCacTaiKhoanTatHoatDong_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM taikhoan WHERE Trangthai LIKE '%Tắt hoạt động%'";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();

            return dt;
        }

        public DataTable getThongTinCacTaiKhoanDangHoatDong_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM taikhoan WHERE Trangthai LIKE  '%Đang hoạt động%'";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();

            return dt;
        }

        public DataTable TimKiemTaiKhoan_DAO(string text)
        {
            sqla.getConnection().Open();
            //dataGridView.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM taikhoan WHERE CONCAT (`Matk`, `Manv`, `Tendangnhap`) LIKE '%" + text + "%' ", sqla.getConnection());
            //cmd.Parameters.AddWithValue("@Tendangnhap", text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.getConnection().Close();
            return dt;
        }

        public DataTable TimKiemTaiKhoanTheoTrangThai_DAO(string text, string trangthai)
        {
            sqla.openConnectToMySql();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM taikhoan WHERE CONCAT (`Matk`, `Manv`, `Tendangnhap`) LIKE '%" + text + "%' AND Trangthai LIKE @Trangthai ", sqla.getConnection());
            cmd.Parameters.AddWithValue("@Trangthai", trangthai);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.getConnection().Close();
            return dt;
        }


        internal void themMotNhanVien(nhanvien nv)
        {
            sqla.openConnectToMySql();
            String query = "Insert into nhanvien(Tennv, SoCCCD, Tuoi, Diachi, ChucDanh, TrangThai)"
                         + "values (@Tennv, @SoCCCD, @Tuoi, @DiaChi, @ChucDanh, @TrangThai)";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            cmd.Parameters.AddWithValue("@Tennv", nv.TenNv);
            cmd.Parameters.AddWithValue("@SoCCCD", nv.SoCCCD);
            cmd.Parameters.AddWithValue("@Tuoi", nv.Tuoi);
            cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("@ChucDanh", nv.ChucDanh);
            cmd.Parameters.AddWithValue("@TrangThai", "Đang hoạt động");
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            cmd.Dispose();
            sqla.closeConnectToMySql();
        }

        public void themMotTaiKhoan(string queryMaNV,string timeNow,taikhoan tk)
        {
            sqla.openConnectToMySql();
            string query = 
                            "Insert into taikhoan(Manv, Tendangnhap, Matkhau, Trangthai, Ngaythamgia)"
                         + "values (@Manv, @Tendangnhap, @Matkhau, @TrangThai, @Ngaythamgia)"
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
           
            cmd2.Parameters.AddWithValue("@Manv", queryMaNV);
            cmd2.Parameters.AddWithValue("@Tendangnhap", tk.Tendangnhap);
            cmd2.Parameters.AddWithValue("@Matkhau", tk.Matkhau);
            cmd2.Parameters.AddWithValue("@TrangThai", "Đang hoạt động");
            cmd2.Parameters.AddWithValue("@Ngaythamgia", timeNow);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Thêm tài khoản thành công");
         
            cmd2.Dispose();
            sqla.closeConnectToMySql();

        }
        

        public void DataProperty(String query, String property, ComboBox cb)
        {
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader mydr;
            try
            {
                sqla.getConnection().Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string ppty = mydr.GetString(property);
                    int maNv = mydr.GetInt32("Manv");                
                    cb.Items.Add(ppty +"-"+ maNv);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void DataProperty2(String query, String property, ComboBox cb)
        {
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader mydr;
            try
            {
                sqla.getConnection().Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string ppty = mydr.GetString(property);
                    cb.Items.Add(ppty);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void DataPropertyTaiKhoanDangHoatDong(String query, ComboBox cb)
        {
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader mydr;
            try
            {
                sqla.openConnectToMySql();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string ppty = mydr.GetString("Tendangnhap");
                    int maTk = mydr.GetInt32("Matk");
                    cb.Items.Add(ppty + "-" + maTk);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void XoaTaiKhoan_DAO (int Matk)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE taikhoan SET Trangthai = @Trangthai  WHERE Matk = @Matk "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@Trangthai", "Tắt hoạt động");
            cmd2.Parameters.AddWithValue("@Matk", Matk);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Thay đổi quyền tài khoản thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }




    }
}
