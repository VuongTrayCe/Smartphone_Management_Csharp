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
using static ClosedXML.Excel.XLPredefinedFormat;
using DateTime = System.DateTime;

namespace Smartphone_Management.GUI.ThongKe.BanHang
{
    public partial class ChiTietBanHang_NgayBan : Form
    {
        string ngayban;
        DateTime ngayban2;
        DataTable data = new DataTable();
        ThongKeBaoCao_BUS tkbc = new ThongKeBaoCao_BUS();
        public ChiTietBanHang_NgayBan(string ngayban)
        {
            InitializeComponent();
            this.ngayban = ngayban;
            ngayban2 = DateTime.Parse(ngayban);
            lbNgayBan.Text = String.Format("{0:yyyy-MM-dd}", ngayban2);
            init();
        }
        public void init()
        {
            data = tkbc.getDoanhThuBanHang_NgayBan_ChiTiet(String.Format("{0:yyyy-MM-dd}", ngayban2));
            dataGridView1.DataSource = data;
        }
    }
}
