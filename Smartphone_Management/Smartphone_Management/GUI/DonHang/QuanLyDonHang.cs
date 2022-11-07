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
using System.Windows.Markup;

namespace Smartphone_Management.GUI.DonHang
{
    public partial class QuanLyDonHang : Form
    {
        private DataTable data;
        public QuanLyDonHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            DataTable data2 = new DataTable();
            data2 = conn.DisplayData("select donhang.Ngayban as NgayDat,donhang.Madh,khachhang.Tenkh,donhang.SoLuong,donhang.Soluongdadung,donhang.Soluongduoctang,donhang.Tongtien,nhanvien.Tennv from donhang,nhanvien,khachhang where donhang.Manv=nhanvien.Manv and donhang.Makh=khachhang.Makh");
            data = new DataTable();
            data.Columns.Add("STT");
            data.Columns.Add("NgayDat",Type.GetType("System.DateTime"));
            data.Columns.Add("Madh");
            data.Columns.Add("Tenkh");
            data.Columns.Add("SoLuong");
            data.Columns.Add("Soluongdadung");
            data.Columns.Add("Soluongduoctang");
            data.Columns.Add("TongTien");
            data.Columns.Add("Tennv");

            for (int i = 0; i < data2.Rows.Count; i++)
            {
                //dataGridView1.Rows.Add(1) ;
                DataRow row = data.NewRow();
                foreach (DataColumn col in data2.Columns)
                {
      
                   
                        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                }
                data.Rows.Add(row);
            }
            dataGridView1.DataSource = data;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
