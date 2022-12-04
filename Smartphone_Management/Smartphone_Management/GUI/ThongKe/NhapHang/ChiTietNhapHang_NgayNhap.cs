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

namespace Smartphone_Management.GUI.ThongKe.NhapHang
{
    public partial class ChiTietNhapHang_NgayNhap : Form
    {
        string ngaynhap;
        DateTime ngaynhap2;
        DataTable data = new DataTable();
        ThongKeBaoCao_NhapHang_BUS tkbc = new ThongKeBaoCao_NhapHang_BUS();
        public ChiTietNhapHang_NgayNhap(string ngaynhap)
        {
            InitializeComponent();
            this.ngaynhap = ngaynhap;
            ngaynhap2 = DateTime.Parse(ngaynhap);
            lbNgayNhap.Text = String.Format("{0:yyyy-MM-dd}", ngaynhap2);
            init();
        }
        public void init()
        {
            data = tkbc.getThongKeNhapHang_NgayBan_ChiTiet(String.Format("{0:yyyy-MM-dd}", ngaynhap2));
            dataGridView1.DataSource = data;
        }
    }
}
