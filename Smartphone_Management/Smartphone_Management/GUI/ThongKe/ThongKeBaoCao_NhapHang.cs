using DocumentFormat.OpenXml.Drawing.Charts;
using Smartphone_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Smartphone_Management.GUI.ThongKe
{
    public partial class ThongKeBaoCao_NhapHang : Form
    {
        DataTable data = new DataTable();
        ThongKeBaoCao_NhapHang_BUS tknh = new ThongKeBaoCao_NhapHang_BUS();
        public ThongKeBaoCao_NhapHang()
        {
            InitializeComponent();
        }
        public void init()
        {

            int i = cbbLoai.SelectedIndex;
            if (i == 0)
            {
                data = tknh.getThongKeNhapHang_HangHoa();

            }
            else if (i == 1)
            {

                data = tknh.getThongKeNhaphang_NhaCungCap();

            }
            else
            {
                data = tknh.getThongKeNhapHang_NgayThang(dateStart.Value, dateEnd.Value);

            }
            dataGridView1.DataSource = data;

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongKeNhapHang_Load(object sender, EventArgs e)
        {
            cbbLoai.SelectedIndex = 0;
            init();
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            init();

        }
    }
}
