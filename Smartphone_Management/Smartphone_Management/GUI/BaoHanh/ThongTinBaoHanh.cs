using Smartphone_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.BaoHanh
{
    public partial class ThongTinBaoHanh : Form
    {
        DataTable data = new DataTable();
        QuanLyBaoHanh_BUS qlbh = new QuanLyBaoHanh_BUS();
        public ThongTinBaoHanh()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            data = qlbh.getThongTinBaoHanh();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns[1].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[3].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[4].HeaderText = "Tên khách hàng ";
            dataGridView1.Columns[5].HeaderText = "Ngày bán";
            dataGridView1.Columns[6].HeaderText = "Thời gian bảo hành";


        }
    }
}
