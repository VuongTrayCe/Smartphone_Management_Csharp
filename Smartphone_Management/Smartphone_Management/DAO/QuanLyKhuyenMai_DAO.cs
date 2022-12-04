//using MySql.Data.MySqlClient;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Humanizer.In;
using System.Windows.Shapes;
using MySqlConnector;
namespace Smartphone_Management.DAO
{
    internal class QuanLyKhuyenMai_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();


        public DataTable getThongTinCacKhuyenMai_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM khuyenmai";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();

            return dt;
        }

        public DataTable getThongTinCacChiTietKhuyenMai_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM chitietkhuyenmai";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();

            return dt;
        }

        public DataTable TimKiemKM_DAO(string text)
        {
            sqla.openConnectToMySql();
            //dataGridView.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM khuyenmai WHERE CONCAT (`Makm`, `Tenkm`,`Ptkm`, `Trangthai` ) LIKE '%" + text + "%' ", sqla.getConnection());
            //cmd.Parameters.AddWithValue("@Tendangnhap", text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }


        public DataTable TimKiemChiTietKM_DAO(string text)
        {
            sqla.openConnectToMySql();
            //dataGridView.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM chitietkhuyenmai WHERE CONCAT (`Machitietkhuyenmai`, `Masp`,`Makm`, `Trangthai` ) LIKE '%" + text + "%' ", sqla.getConnection());
            //cmd.Parameters.AddWithValue("@Tendangnhap", text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        public void showThuocTinhMaKM_DAO(String query, ComboBox cb)
        {
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader mydr;
            try
            {
                sqla.openConnectToMySql();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string ppty = mydr.GetString("Tenkm");
                    int maKM = mydr.GetInt32("Makm");
                    cb.Items.Add(ppty + "-" + maKM);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void showThuocTinhSanPham_DAO(String query, ComboBox cb)
        {
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader mydr;
            try
            {
                sqla.openConnectToMySql();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string ppty = mydr.GetString("Tensp");
                    int maSP = mydr.GetInt32("Masp");
                    cb.Items.Add(ppty + "-" + maSP);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void ThemChiTietKM_DAO(chitietkhuyenmai ctkm)
        {
            sqla.openConnectToMySql();
            string query =
                            "Insert into chitietkhuyenmai(Masp,Makm, TrangThai)"
                         + "values ( @Masp  ,@Makm, @TrangThai)"
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());


            cmd2.Parameters.AddWithValue("@Masp", ctkm.MaSP);
            cmd2.Parameters.AddWithValue("@Makm", ctkm.MaKM);
            cmd2.Parameters.AddWithValue("@TrangThai", "T");

            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Thêm chi tiết KM thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        //public void ThemChiTietKM_DAO(chitietkhuyenmai ctkm, string querySanPham)
        //{
        //    sqla.openConnectToMySql();
        //    string query =
        //                    "Insert into chitietkhuyenmai(Masp,Makm, TrangThai)"
        //                 + "values ( @Masp  ,@Makm, @TrangThai)"
        //                   ;
        //    MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());


        //    cmd2.Parameters.AddWithValue("@Masp", "SELECT sanpham.Masp FROM sanpham WHERE sanpham.Tensp LIKE '%" + querySanPham + "%'");
        //    cmd2.Parameters.AddWithValue("@Makm", ctkm.MaKM);
        //    cmd2.Parameters.AddWithValue("@TrangThai", "T");

        //    MySqlDataReader MyReader2;
        //    MyReader2 = cmd2.ExecuteReader();
        //    MessageBox.Show("Thêm chi tiết KM thành công");

        //    cmd2.Dispose();
        //    sqla.closeConnectToMySql();
        //}

        public void XoaChiTietKMSP_DAO(int maChiTietKM)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE chitietkhuyenmai SET Trangthai = @Trangthai  WHERE Machitietkhuyenmai = @Machitietkhuyenmai "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@Trangthai", "F");
            cmd2.Parameters.AddWithValue("@Machitietkhuyenmai", maChiTietKM);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Xóa chi tiết khuyến mãi của sản phẩm thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        public void XoaKM_DAO(int maKM)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE khuyenmai SET Trangthai = @Trangthai  WHERE Makm = @Makm "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@Trangthai", "F");
            cmd2.Parameters.AddWithValue("@Makm", maKM);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Xóa khuyến mãi thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        public void ThemKM_DAO(khuyenmai km)
        {
            sqla.openConnectToMySql();
            String query = "Insert into khuyenmai(Tenkm, Ptkm, Trangthai)"
                         + "values (@Tenkm, @Ptkm, @Trangthai)";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            cmd.Parameters.AddWithValue("@Tenkm", km.TenKM);
            cmd.Parameters.AddWithValue("@Ptkm", km.PTKM);
            cmd.Parameters.AddWithValue("@Trangthai", "T");
        
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            MessageBox.Show("Thêm Khuyến mãi thành công");

            cmd.Dispose();
            sqla.closeConnectToMySql();
        }

        public void CapNhatKM_DAO(khuyenmai km, int maKM)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE khuyenmai SET Tenkm = @Tenkm, Ptkm = @Ptkm, Trangthai = @Trangthai WHERE Makm = @Makm "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@Makm", maKM);
            cmd2.Parameters.AddWithValue("@Tenkm", km.TenKM);
            cmd2.Parameters.AddWithValue("@Ptkm", km.PTKM);
            cmd2.Parameters.AddWithValue("@Trangthai", km.TrangThai);


            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Cập nhật Khuyến Mãi thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        internal void updateChiTietKhuyenMaiCu(int masp)
        {
            sqla.openConnectToMySql();
            string query = "update chitietkhuyenmai set chitietkhuyenmai.TrangThai=\"F\" where chitietkhuyenmai.Masp=@masp";
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@masp", masp);

            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }
    }
}
