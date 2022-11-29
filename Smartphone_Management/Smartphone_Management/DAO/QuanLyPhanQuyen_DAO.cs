using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Smartphone_Management.DTO;

namespace Smartphone_Management.DAO
{
    internal class QuanLyPhanQuyen_DAO
    {
        ConnectToMySQL sqla = new ConnectToMySQL();


        public DataTable getQuyen_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM quyen";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        public DataTable getQuyen_TaiKhoan_DAO()
        {
            sqla.openConnectToMySql();
            string query = "SELECT * FROM quyen_tk";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        public DataTable TimKiemQuyen_DAO(string text)
        {
            sqla.openConnectToMySql();
            //dataGridView.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM quyen WHERE CONCAT (`Maquyen`, `Tenquyen`) LIKE '%" + text + "%' ", sqla.getConnection());
            //cmd.Parameters.AddWithValue("@Tendangnhap", text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }
        public DataTable TimKiemQuyen_TaiKhoan_DAO(string text)
        {
            sqla.openConnectToMySql();
            //dataGridView.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM quyen_tk WHERE CONCAT (`Maquyentk`, `Matk`, `Maquyen`) LIKE '%" + text + "%' ", sqla.getConnection());
            //cmd.Parameters.AddWithValue("@Tendangnhap", text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqla.closeConnectToMySql();
            return dt;
        }

        public void ThemQuyen_DAO(quyen q)
        {
            sqla.openConnectToMySql();
            String query = "Insert into quyen(Tenquyen)"
                         + "values (@Tenquyen)";
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            cmd.Parameters.AddWithValue("@Tenquyen", q.TenQuyen);
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            cmd.Dispose();
            sqla.closeConnectToMySql();
        }

        public void DataPropertyMaTaiKhoan(String query, ComboBox cb)
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
                    int maNv = mydr.GetInt32("Manv");
                    cb.Items.Add(ppty + "-" + maTk + "-" + maNv);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        public void DataPropertyMaQuyen(String query, ComboBox cb)
        {
            MySqlCommand cmd = new MySqlCommand(query, sqla.getConnection());
            MySqlDataReader mydr;
            try
            {
                sqla.openConnectToMySql();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string ppty = mydr.GetString("Tenquyen");
                    int maTk = mydr.GetInt32("Maquyen");
                    cb.Items.Add(ppty + "-" + maTk);
                }
                this.sqla.getConnection().Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void ThemQuyen_TK_DAO(quyen_taikhoan q_tk)
        {
            sqla.openConnectToMySql();
            string query =
                            "Insert into quyen_tk(Matk, Maquyen)"
                         + "values (@Matk, @Maquyen)"
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@Matk", q_tk.MaTk);
            cmd2.Parameters.AddWithValue("@Maquyen", q_tk.MaQuyen);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Thêm tài khoản - quyền thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }
        public void ThaydoiQuyen_Taikhoan_DAO(quyen_taikhoan q_tk)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE quyen_tk SET Maquyen = @Maquyen WHERE Matk = @Matk "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@Matk", q_tk.MaTk);
            cmd2.Parameters.AddWithValue("@Maquyen", q_tk.MaQuyen);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Thay đổi quyền tài khoản thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }

        public void ThaydoiChucVu_DAO(int maNV, string tenQuyen)
        {
            sqla.openConnectToMySql();
            string query = "UPDATE nhanvien SET ChucDanh = @ChucDanh WHERE Manv = @Manv "
                           ;
            MySqlCommand cmd2 = new MySqlCommand(query, sqla.getConnection());

            cmd2.Parameters.AddWithValue("@Manv", maNV);
            cmd2.Parameters.AddWithValue("@ChucDanh", tenQuyen);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            MessageBox.Show("Thay đổi quyền tài khoản thành công");

            cmd2.Dispose();
            sqla.closeConnectToMySql();
        }



    }
}
