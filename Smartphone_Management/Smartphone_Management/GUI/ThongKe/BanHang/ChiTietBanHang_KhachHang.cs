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

namespace Smartphone_Management.GUI.ThongKe.BanHang
{
    public partial class ChiTietBanHang_KhachHang : Form
    {
        int makh;
        string tenkh;
        DataTable data  = new DataTable();
        ThongKeBaoCao_BUS tkbc = new ThongKeBaoCao_BUS();
        public ChiTietBanHang_KhachHang(int makh,string tenkh)
        {
            InitializeComponent();
            this.makh = makh;
            this.tenkh = tenkh;
            init();
            lbMakh.Text = makh.ToString();
            lbNamekh.Text = tenkh;
        }
        public void init()
        {
            data = tkbc.getDoanhThuBanHang_KhachHang_ChiTiet(makh);
            dataGridView1.DataSource = data;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
