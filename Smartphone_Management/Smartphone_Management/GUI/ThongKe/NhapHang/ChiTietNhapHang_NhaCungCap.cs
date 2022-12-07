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
    public partial class ChiTietNhapHang_NhaCungCap : Form
    {
        int mancc;
        string tenncc;
        DataTable data = new DataTable();
        ThongKeBaoCao_NhapHang_BUS tkbc = new ThongKeBaoCao_NhapHang_BUS();
        public ChiTietNhapHang_NhaCungCap(int mancc, string tenncc)
        {
            InitializeComponent();
            this.mancc = mancc;
            this.tenncc = tenncc;
            lbMancc.Text = mancc.ToString();
            lbTenNhaCungCap.Text = tenncc;
            init();
        }
        public void init()
        {
            data = tkbc.getThongKeNhaphang_NhaCungCap_ChiTiet(mancc);
            dataGridView1.DataSource = data;
        }
    }
}
