//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySqlConnector;
//using MySql.Data.MySqlClient;
using MySqlConnector;
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
            string query = "SELECT * FROM taikhoan WHERE Trangthai LIKE '%F%'";
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
            string query = "SELECT * FROM taikhoan WHERE Trangthai LIKE  '%T%'";
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
            cmd.Parameters.AddWithValue("@TrangThai", "T");
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
            cmd2.Parameters.AddWithValue("@TrangThai", "T");
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
            cmd2.Parameters.AddWithValue("@Trangthai", "F");
            cmd2.Parameters.AddWithValue("@Matk", Matk);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Xóa tài khoản thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }


        public void DangNhapTaiKhoan(taikhoan tk)
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM taikhoan  WHERE Tendangnhap = @MTendangnhap AND Matkhau = @Matkhau AND Trangthai = @Trangthai ";
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@Tendangnhap", tk.Tendangnhap);
            cmd2.Parameters.AddWithValue("@Matkhau", tk.Matkhau);
            cmd2.Parameters.AddWithValue("@Trangthai", "T");
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();

            cmd2.Dispose();
            sqla.closeConnectToMySql();

        }

        internal List<List<string>> getALLAccount2()
        {

            List<List<String>> list = new List<List<String>>();
            sqla.openConnectToMySql();
            string query = "select taikhoan.Manv,taikhoan.Tendangnhap, taikhoan.Matkhau from taikhoan where taikhoan.TrangThai='T'";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetInt32("Manv").ToString());
                list2.Add(MyReader2.GetString("Tendangnhap"));
                list2.Add(MyReader2.GetString("Matkhau"));

                list.Add(list2);
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }

        internal string getTenNv(int l)
        {
            sqla.openConnectToMySql();
            string tennv = "";
            String query = "select nhanvien.Tennv from nhanvien where nhanvien.Manv=@manv";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            cmd.Parameters.AddWithValue("@manv",l);
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            while(MyReader2.Read())
            {
                tennv = MyReader2.GetString("Tennv");
            }
            cmd.Dispose();
            sqla.closeConnectToMySql();
            return tennv;
        }

        internal List<string> getALLQuyenTK(int manv1)
        {

            List<String> list = new List<String>();
            sqla.openConnectToMySql();
            String query = "select quyen.Tenquyen from quyen,taikhoan,quyen_tk,nhanvien where taikhoan.Matk = quyen_tk.Matk and quyen_tk.Maquyen=quyen.Maquyen and taikhoan.Manv=nhanvien.Manv and nhanvien.Manv=@manv";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@manv", manv1);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                list.Add(MyReader2.GetString("Tenquyen"));
            }
            cmd2.Dispose();
            sqla.closeConnectToMySql();
            return list;
        }
    }
}
