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

namespace Smartphone_Management.GUI.DonHang
{
    public partial class ChiTietDonHang : Form
    {
        QuanLyDonDatHang_BUS qldh = new QuanLyDonDatHang_BUS();
        private int Madh;
        public ChiTietDonHang(int Madh)
        {
            InitializeComponent();
            this.Madh = Madh;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiTietDonHang_Load(object sender, EventArgs e)
        {
            init();
        }
        public void init()
        {
            DataTable data = new DataTable();
            data = qldh.getChiTietDonHang(this.Madh);
            dataGridView1.DataSource = data;

        }
    }
}
