using DocumentFormat.OpenXml.Drawing.Charts;
using Smartphone_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Smartphone_Management.GUI.ThongKe
{
    public partial class LoiNhuanBanHang : Form
    {
        LoiNhuanBanHang_BUS lnbh = new LoiNhuanBanHang_BUS();
        DataTable data = new DataTable();
        public LoiNhuanBanHang()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoiNhuanBanHang_Load(object sender, EventArgs e)
        {
            cbbLoiNhuan.SelectedIndex = 0;
            init();

        }
        public void init()
        {

            int i = cbbLoiNhuan.SelectedIndex;
            if (i == 0)
            {
                data = lnbh.getLoiNhuanBanHang_TheoThang(dateStart.Value,dateEnd.Value);
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].Width = (dataGridView1.Width * 5) / 100;
                dataGridView1.Columns[1].Width = (dataGridView1.Width * 20) / 100;
                dataGridView1.Columns[2].Width = (dataGridView1.Width * 10) / 100;
                dataGridView1.Columns[3].Width = (dataGridView1.Width * 10) / 100;
                dataGridView1.Columns[4].Width = (dataGridView1.Width * 10) / 100;
            }
            else if (i == 1)
            {

                data = lnbh.getLoiNhuanBanHang_HangHoa();
                dataGridView1.DataSource = data;

            }
            else
            {
                data = lnbh.getLoiNhuanBanHang_LaiLo();
                dataGridView1.DataSource = data;

            }

            //dataGridView1.Columns[5].Width = (dataGridView1.Width * 20) / 100;
            //dataGridView1.Columns[6].Width = (dataGridView1.Width * 10) / 100;

        }
        private void cbbLoiNhuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            init();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
