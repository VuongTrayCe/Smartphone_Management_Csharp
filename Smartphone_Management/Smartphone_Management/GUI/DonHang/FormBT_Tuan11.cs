using DocumentFormat.OpenXml.Wordprocessing;
using MySqlConnector;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.DonHang
{
    public partial class FormBT_Tuan11 : Form
    {
        public FormBT_Tuan11()
        {
            InitializeComponent();
            getInfor();
        }
        public void getInfor()
        {
            ConnectToMySQL conn = new ConnectToMySQL();

            DataTable data = new DataTable();

            string query = "select * from vattu";
            MySqlCommand MyCommand2 = new MySqlCommand(query, conn.getConnection());
            //  MyConn2.Open();
            //For offline connection we weill use  MySqlDataAdapter class.
            if (MyCommand2 == null)
            {
                //return null;
            }
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            MyAdapter.Fill(data);
            //MessageBox.Show("Completed");
            conn.getConnection().Close();
          vattuBindingSource.DataSource = data;
            //return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToMySQL conn = new ConnectToMySQL();
                conn.openConnectToMySql();
                string Query = "insert into vattu(MaVTu,TenVTu,DvTinh,PhanTram) values(@mavt,@tenvt,@dvt,@pt)";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query,conn.getConnection());
                MyCommand2.Parameters.AddWithValue("@mavt",txtMavt.Text);
                MyCommand2.Parameters.AddWithValue("@tenvt", txtTenvt.Text);
                MyCommand2.Parameters.AddWithValue("@dvt", txtDVT.Text);
                MyCommand2.Parameters.AddWithValue("@pt", txtPT.Text);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Saved Data");
                while (MyReader2.Read())
                {

                }
                getInfor();
                conn.closeConnectToMySql();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBT_Tuan11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlybanhangDataSet1.vattu' table. You can move, or remove it, as needed.

        }
    }
}
