using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;
using System.Windows.Forms;

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
    }
}

