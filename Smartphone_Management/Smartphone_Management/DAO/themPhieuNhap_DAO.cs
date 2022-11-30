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
    class themPhieuNhap_DAO
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
        internal int getPhieuNhapMax()
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT MAX(Maphieunhap) FROM phieunhap", sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }
        internal int getNccMax()
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT MAX(Mancc) FROM nhacungcap", sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }

        internal int getChiTietPhieuNhapMax()
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT MAX(MaChiTietPhieuNhap) FROM chitietphieunhap", sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }

        internal void getComboBoxData(ComboBox comboBox1)
        {
            MySqlConnection sqlNhap = data.getConnection();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select Tenncc, Mancc, DiaChi from nhacungcap", sqlNhap);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "TenNcc");
            comboBox1.DisplayMember = "Tenncc";
            comboBox1.ValueMember = "Mancc";
            comboBox1.DataSource = dataSet.Tables["TenNcc"];
        }
        internal void addChiTietPhieuNhap(DataGridView dataGridView1, TextBox textBox1)
        {
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;
            int num = getChiTietPhieuNhapMax();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                num += 1;

                command = new MySqlCommand("INSERT INTO chitietphieunhap VALUES(@MaChiTietPhieuNhap,@Masp,@Maphieunhap,@GiaNhap,@Soluong)", sqlNhap);

                command.Parameters.Add("@MaChiTietPhieuNhap", MySqlDbType.Int32).Value = num.ToString();
                command.Parameters.Add("@Masp", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                command.Parameters.Add("@Maphieunhap", MySqlDbType.Int32).Value = textBox1.Text;
                command.Parameters.Add("@GiaNhap", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                command.Parameters.Add("@Soluong", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[3].Value.ToString();


                command.ExecuteNonQuery();
            }
            MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
            sqlNhap.Close();
        }

        internal void addPhieuNhap(DataGridView dataGridView1, ComboBox comboBox1, TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;

            command = new MySqlCommand("INSERT INTO phieunhap VALUES(@Maphieunhap,@Manv,@Mancc,@SoLuong,@NgayNhap,@TongTien,@Trangthai)", sqlNhap);

            command.Parameters.Add("@Maphieunhap", MySqlDbType.Int32).Value = textBox1.Text;
            command.Parameters.Add("@Manv", MySqlDbType.Int32).Value = textBox2.Text;
            command.Parameters.Add("@Mancc", MySqlDbType.Int32).Value = int.Parse(comboBox1.SelectedValue.ToString());
            command.Parameters.Add("@SoLuong", MySqlDbType.Int32).Value = "0";
            command.Parameters.Add("@NgayNhap", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@TongTien", MySqlDbType.Double).Value = "0";
            command.Parameters.Add("@Trangthai", MySqlDbType.VarChar).Value = "Đang Xử Lý";

            command.ExecuteNonQuery();
            MessageBox.Show("Thêm phiếu nhập thành công!");
            sqlNhap.Close();
        }

        internal void updatePhieuNhap(DataGridView dataGridView1, int soLuong, float tongTien)
        {
            int phieuNhapMax = getPhieuNhapMax();
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;

            command = new MySqlCommand("UPDATE phieunhap SET SoLuong = " + soLuong.ToString() + ", TongTien = " + tongTien.ToString() +  " WHERE phieunhap.Maphieunhap = " + phieuNhapMax.ToString(), sqlNhap);
            command.ExecuteNonQuery();

            dataGridView1.Rows.Clear();
            sqlNhap.Close();
        }
        internal void insertNcc(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, ComboBox comboBox1)
        {
            int num = getNccMax();
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;

            command = new MySqlCommand("INSERT INTO nhacungcap VALUES (" + (num + 1).ToString() + ", ' " + textBox1.Text + " ' , " + textBox3.Text + ",'" + textBox4.Text + "' , '" + comboBox1.Text.ToString() + "')", sqlNhap);
            command.ExecuteNonQuery();
            sqlNhap.Close();
        }
    }
}

