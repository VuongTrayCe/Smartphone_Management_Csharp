//using MySql.Data.MySqlClient;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Smartphone_Management.DAO
{
    internal class QuanLyNCC_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();

        public DataTable TimKiemNCC_DAO(string text)
        {
            sqla.openConnectToMySql();
            //dataGridView.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM nhacungcap WHERE CONCAT (`Mancc`, `Tenncc`,`SDT`, `DiaChi`, `TrangThai` ) LIKE '%" + text + "%' ", sqla.getConnection());
            //cmd.Parameters.AddWithValue("@Tendangnhap", text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        public DataTable getNCC_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM nhacungcap";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();

            return dt;
        }

        public void ThemNCC_DAO(nhacungcap ncc)
        {
            sqla.openConnectToMySql();
            String query = "Insert into nhacungcap(Tenncc, SDT, DiaChi, TrangThai)"
                         + "values (@Tenncc, @SDT, @DiaChi, @TrangThai)";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            
            cmd.Parameters.AddWithValue("@Tenncc", ncc.TenNCC);
            cmd.Parameters.AddWithValue("@SDT", ncc.Sdt);
            cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
            cmd.Parameters.AddWithValue("@TrangThai", "T");

            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            MessageBox.Show("Thêm nhà cung cấp thành công");

            cmd.Dispose();
            sqla.closeConnectToMySql();
        }


        public void XoaNCC_DAO(int maNCC)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE nhacungcap SET Trangthai = @Trangthai  WHERE Mancc = @Mancc "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());
            cmd2.Parameters.AddWithValue("@TrangThai", "F");
            cmd2.Parameters.AddWithValue("@Mancc", maNCC);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Xóa nhà cung cấp thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        public void CapNhatNCC_DAO(nhacungcap ncc, int maNCC)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE nhacungcap SET Tenncc = @Tenncc, SDT = @SDT, DiaChi = @DiaChi, TrangThai = @TrangThai WHERE Mancc = @Mancc "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@Mancc", maNCC);
            cmd2.Parameters.AddWithValue("@Tenncc", ncc.TenNCC);
            cmd2.Parameters.AddWithValue("@SDT", ncc.Sdt);
            cmd2.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
            cmd2.Parameters.AddWithValue("@TrangThai", ncc.TrangThai);


            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Cập nhật Khuyến Mãi thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }
    }
}
