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
    class themSanPhamPhieuNhap_DAO
    {
        ConnectToMySQL data = new ConnectToMySQL();

        internal void addPhieuNhap(DataGridView dataGridView1, ComboBox comboBox1, TextBox textBox1)
        {
            MySqlConnection sqlNhap = data.getConnection();
            sqlNhap.Open();
            MySqlCommand command;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                command = new MySqlCommand("INSERT INTO phieunhap VALUES(@Maphieunhap,@Manv,@Mancc,@SoLuong,@NgayNhap,@TongTien,@Trangthai)", sqlNhap);

                command.Parameters.Add("@Maphieunhap", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                command.Parameters.Add("@Manv", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                command.Parameters.Add("@Mancc", MySqlDbType.Int32).Value = int.Parse(comboBox1.SelectedValue.ToString());
                command.Parameters.Add("@SoLuong", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                command.Parameters.Add("@NgayNhap", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@TongTien", MySqlDbType.Double).Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                command.Parameters.Add("@Trangthai", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[4].Value.ToString();


                command.ExecuteNonQuery();

            }
            dataGridView1.Rows.Clear();
            MessageBox.Show("Thêm phiếu nhập thành công!");
            sqlNhap.Close();
        }

        internal void getSanPhamData(ComboBox comboBox1, int mancc)
        {
            MySqlConnection sqlNhap = data.getConnection();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select nhacungcap.Mancc, nhacungcap.Tenncc, sanpham.Masp, sanpham.Tensp from nhacungcap right join sanpham on sanpham.Loaisp = nhacungcap.Tenncc where sanpham.Mancc = " + mancc, sqlNhap);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Tensp");
            comboBox1.DisplayMember = "Tensp";
            comboBox1.ValueMember = "Masp";
            comboBox1.DataSource = dataSet.Tables["Tensp"];
        }
        internal int getMaNcc(string tenncc)
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT Mancc FROM nhacungcap where Tenncc = '" + tenncc + "'", sqlNhap);
            dataAdapter.Fill(dataTable);
            int myNum = int.Parse(dataTable.Rows[0][0].ToString());
            return myNum;
        }

        internal List<List<string>> getDataSanPham(int mancc)
        {
            List<List<String>> list = new List<List<String>>();
            data.openConnectToMySql();
            string query = "select sanpham.Masp,sanpham.Tensp from sanpham where sanpham.TrangThai='T' and sanpham.Mancc=@mancc";
            MySqlCommand cmd2 = new MySqlCommand(query,data.getConnection());
            cmd2.Parameters.AddWithValue("@mancc",mancc);
            MySqlDataReader MyReader2;
            MyReader2 = cmd2.ExecuteReader();
            while (MyReader2.Read())
            {
                List<String> list2 = new List<String>();
                list2.Add(MyReader2.GetInt32("Masp").ToString());
                list2.Add(MyReader2.GetString("Tensp"));
                list.Add(list2);
            }
            cmd2.Dispose();
            data.closeConnectToMySql();
            return list;
        }
    }
}
