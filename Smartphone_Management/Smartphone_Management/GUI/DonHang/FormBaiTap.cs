using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Markup;
using System.Windows.Controls;

namespace Smartphone_Management.GUI.DonHang
{
    public partial class FormBaiTap : Form
    {
        String Tenncc;
        String SDT;
        String Diachi;
        public FormBaiTap()
        {
            InitializeComponent();
            init();

        }
        public void init()
        {

            DataTable data2 = getInfor();
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                listBox1.Items.Add(data2.Rows[i][0] + "-" + data2.Rows[i][1]);
            }
                //     SDT = data2.Rows[i][1].ToString();
                //     Diachi = data2.Rows[i][2].ToString();

                //}
                //txtten.Text = Tenncc;
                //txtsdt.Text=SDT;
                //txtdiachi.Text = Diachi;
                //for (int i = 0; i < data2.Rows.Count; i++)
                //{
                //        foreach (DataColumn col in data2.Columns)
                //        {
                //        listView1.Columns.Add(col.ColumnName);


                //         }
                //    //data.Rows.Add(row);
                //    //}
                //    //else if (dateDat > dateStart && dateDat < DateEnd && madh.Equals(strKeyWord))
                //    //{
                //    //    DataRow row = data.NewRow();
                //    //    foreach (DataColumn col in data2.Columns)
                //    //    {
                //    //        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                //    //    }
                //    //    data.Rows.Add(row);
                //    //}
                //}

            }
        public DataTable getInfor()
        {
            ConnectToMySQL conn = new ConnectToMySQL();

            DataTable data = new DataTable();

            string query = "select nhacc.MANCC, nhacc.TenNCC from nhacc";
            MySqlCommand MyCommand2 = new MySqlCommand(query,conn.getConnection());
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
            return data;
        }

        public DataTable getInforNhaCungCap(String mancc)
        {
            ConnectToMySQL conn = new ConnectToMySQL();

            DataTable data = new DataTable();

            string query = "select dondh.SoDH,dondh.NgayDH from dondh,nhacc where dondh.MANCC=nhacc.MANCC and nhacc.MANCC=@mancc";
            MySqlCommand MyCommand2 = new MySqlCommand(query, conn.getConnection());
            MyCommand2.Parameters.AddWithValue("@mancc",mancc);

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
            return data;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBox1.Text;
            string[] text = selected.Split('-');
            dataGridView1.DataSource= getInforNhaCungCap(text[0]);
        }
    }
}
