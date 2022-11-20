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

        internal void searchPhieuNhap(string sql, string col, DataGridView gridView) 
        {
            MySqlConnection sqlNhap = data.getConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from phieunhap where " + col + " like '" + sql + "%'", sqlNhap);
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
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from chitietphieunhap where Maphieunhap = " + Maphieunhap + "", sqlNhap);
            dataAdapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }
    }
}
