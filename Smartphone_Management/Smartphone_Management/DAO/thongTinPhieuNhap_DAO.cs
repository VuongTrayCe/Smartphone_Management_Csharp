using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace Smartphone_Management.DAO
{
    internal class thongTinPhieuNhap_DAO
    {
        ConnectToMySQL data = new ConnectToMySQL();

        internal DataTable getPhieuNhapData()
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from phieunhap", sqlNhap);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        internal void searchPhieuNhap(string sql, DataGridView gridView) 
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM phieunhap WHERE(Maphieunhap LIKE '%" + sql + "%' OR Manv LIKE '%" + sql + "%' OR Mancc LIKE '%" + sql + "%' OR SoLuong LIKE '%" + sql + "%' OR NgayNhap LIKE '%" + sql + "%' OR TongTien LIKE '%" + sql + "%')", sqlNhap);
            dataAdapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }
        internal void searchTrangthaiPhieuNhap(string sql, DataGridView gridView)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter;
            if (sql == "Tất Cả")
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM phieunhap", sqlNhap);
            }
            else {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM phieunhap WHERE Trangthai LIKE '%" + sql + "%'", sqlNhap);
            }
            dataAdapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }

        internal void searchDate(DataGridView gridView, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("select * from phieunhap where NgayNhap between @FromDate and @ToDate", sqlNhap);
            command.Parameters.Add("@FromDate", MySqlDbType.VarChar).Value = dateTimePicker1.Value;
            command.Parameters.Add("@ToDate", MySqlDbType.VarChar).Value = dateTimePicker2.Value;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }

        internal void getChitietPhieuNhap(DataGridView gridView, string Maphieunhap)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select   MaChiTietPhieuNhap, Masp, GiaNhap, Soluong, GiaNhap*Soluong as TongTien from chitietphieunhap where Maphieunhap = " + Maphieunhap + "", sqlNhap);
            dataAdapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }

        internal string returnNcc(string mancc)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT Tenncc FROM nhacungcap where Mancc = " + mancc, sqlNhap);
            dataAdapter.Fill(dataTable);
            string myNum = dataTable.Rows[0][0].ToString();
            return myNum;
        }
        internal void updateTrangThaiPhieuNhap(string sql, string mpn)
        {
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;

            command = new MySqlCommand("UPDATE phieunhap SET Trangthai = '" + sql + "' WHERE phieunhap.Maphieunhap = " + mpn, sqlNhap);
            command.ExecuteNonQuery();
            sqlNhap.Close();
        }
        internal int getMaSPMax()
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT MAX(Masp) FROM sanpham", sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }
        internal void insertSP(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, int mancc)
        {
            int num = getMaSPMax();
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;
            command = new MySqlCommand("INSERT INTO sanpham VALUES (" + (num + 1).ToString() + ", '" + textBox1.Text + "' , '" + textBox2.Text + "', 0 , '" + textBox3.Text + "' , '" + textBox4.Text + "' , 'T' , 'imagePath', '" + textBox5.Text + "', " + mancc + ")", sqlNhap);
            command.ExecuteNonQuery();
            sqlNhap.Close();
        }
        internal string returnTensp(int masp)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT sanpham.Tensp FROM chitietphieunhap inner join sanpham on chitietphieunhap.Masp = sanpham.Masp where sanpham.Masp = "+masp, sqlNhap);
            dataAdapter.Fill(dataTable);
            string myNum = dataTable.Rows[0][0].ToString();
            return myNum;
        }
        internal int returnSLsp(int masp)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select soluong from sanpham where Masp = " + masp, sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }

        internal void updateSoLuongSanPham(DataGridView dataGridView1)
        {
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int soluong = returnSLsp(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString())) + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                string tensp = returnTensp(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                command = new MySqlCommand("UPDATE sanpham SET soluong = " + soluong + "  WHERE Tensp = '" + tensp + "'", sqlNhap);
                command.ExecuteNonQuery();
            }
            sqlNhap.Close();
        }

        internal int returnMaGiaSPMax()
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select max(Magiasp) from giasanpham", sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }
        internal void insertGiaSP(int masp, double giaNhap)
        {
            int num = returnMaGiaSPMax();
            double tongTien = giaNhap + (giaNhap * 0.3);
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;
            command = new MySqlCommand("INSERT INTO giasanpham VALUES (" + (num + 1).ToString() + ", " + masp + " , " + giaNhap + ", " + tongTien + " , '" + DateTime.Now.ToString("yyMMdd") + "' , 'T')", sqlNhap);
            command.ExecuteNonQuery();
            sqlNhap.Close();
        }
        internal void updateGiaSP(int masp)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from giasanpham", sqlNhap);
            dataAdapter.Fill(dataTable);
            sqlNhap.Open();
            MySqlCommand command;
            for(int i = dataTable.Rows.Count - 2; i >= 0; i--)
            {
                if (int.Parse(dataTable.Rows[i][1].ToString()) == masp)
                {
                    command = new MySqlCommand("update giasanpham set TrangThai = 'F' where Masp = "+ masp, sqlNhap);
                    command.ExecuteNonQuery();
                }
            }

            sqlNhap.Close();
        }
        
        internal string returnTrangThaiPhieuNhap(int Maphieunhap)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select Trangthai from phieunhap where Maphieunhap = " + Maphieunhap, sqlNhap);
            dataAdapter.Fill(dataTable);
            string myNum = dataTable.Rows[0][0].ToString();
            return myNum;
        }
    }
}
