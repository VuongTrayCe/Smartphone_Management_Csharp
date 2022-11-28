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

namespace Smartphone_Management.GUI.ThongKe
{
    public partial class ThongKeBaoCao_BanHang : Form
    {
        ThongKeBaoCao_BUS tkbc = new ThongKeBaoCao_BUS();
        DataTable data = new DataTable();
        public ThongKeBaoCao_BanHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            init();
        }

        private void ThongKeBaoCao_BanHang_Load(object sender, EventArgs e)
        {
            cbbLoai.SelectedIndex = 0;
            init();
        }

     
        public void init()
        {

            int i = cbbLoai.SelectedIndex;
            if(i==0)
            {
                data = tkbc.getDooanhThuBanHang_HangHoa();

            }
            else if (i==1)
            {

                data = tkbc.getDooanhThuBanHang_KhachHang();

            }
           else
            {
                data = tkbc.getDooanhThuBanHang_NgayThang(dateTimePicker1.Value,dateTimePicker2.Value);

            }
            dataGridView1.DataSource = data;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
