using ClosedXML.Excel;
using Smartphone_Management.BUS;
using Smartphone_Management.GUI.DonHang;
using Smartphone_Management.GUI.ThongKe.BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            dataGridView1.EnableHeadersVisualStyles = false;
            int i = cbbLoai.SelectedIndex;
            if (i == 0)
            {
                data = tkbc.getDooanhThuBanHang_HangHoa();
                pnChonNgay.Visible = false;

            }
            else if (i == 1)
            {
                pnChonNgay.Visible = false;

                data = tkbc.getDooanhThuBanHang_KhachHang();

            }
            else
            {
                pnChonNgay.Visible = true;

                data = tkbc.getDooanhThuBanHang_NgayThang(dateTimePicker1.Value, dateTimePicker2.Value);

            }
            dataGridView1.DataSource = data;
            if (cbbLoai.SelectedIndex == 1)
            {
                dataGridView1.Columns[2].HeaderText = "Mã Khách Hàng";
                dataGridView1.Columns[3].HeaderText = "Tên Khách Hàng";
                dataGridView1.Columns[4].HeaderText = "Số Đơn";
                dataGridView1.Columns[5].HeaderText = "Số Lượng";
                dataGridView1.Columns[6].HeaderText = "Tổng Tiền";
                chart1.Series.Clear();
                chart1.Titles.Clear();

                // Data arrays
                //string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
                int[] pointsArray = { 2, 1, 7, 5 };
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = tkbc.getDanhThuBanHang_KhachHang_BieuDo1();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title
                this.chart1.Titles.Add("Top 5 khách hàng mua số lượng nhiều nhất");

                // Add series.
                foreach (List<String> item in seriesList)
                {
                    Series series = this.chart1.Series.Add(item.ElementAt(0));
                    series.Points.Add(int.Parse(item.ElementAt(1).ToString()));
                }

            }


            if (cbbLoai.SelectedIndex == 0)
            {
                chart1.Titles.Clear();
                chart1.Series.Clear();
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = tkbc.getDanhThuBanHang_HangHoa_BieuDo();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title
                this.chart1.Titles.Add("Top 10 sản phẩm bán ra số lượng nhiều nhất");

                // Add series.
                foreach (List<String> item in seriesList)
                {
                    Series series = this.chart1.Series.Add(item.ElementAt(0));
                    series.Points.Add(int.Parse(item.ElementAt(1).ToString()));
                }

            }

            if (cbbLoai.SelectedIndex == 2)
            {

                this.chart1.Titles.Clear();
                this.chart1.Series.Clear();
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = tkbc.getDanhThuBanHang_NgayBan_BieuDo1();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title
                this.chart1.Titles.Add("Top 10 ngày có số lượng mua nhiều nhất");

                // Add series.
                foreach (List<String> item in seriesList)
                {
                    Series series = this.chart1.Series.Add(item.ElementAt(0));
                    series.Points.Add(int.Parse(item.ElementAt(1).ToString()));
                }

            }




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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel wordbool |*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add((DataTable)dataGridView1.DataSource, "Thống Kê Bán Hàng");
                            workbook.SaveAs(sfd.FileName);
                        }
                        System.Windows.MessageBox.Show("Xuất thành công", "Message", MessageBoxButton.OK);
                    }
                    catch (Exception h)
                    {
                        System.Windows.MessageBox.Show(h.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index= cbbLoai.SelectedIndex;
            //DateTime date = (DateTime)value;
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
              if(index==1)
                {
                    int makh = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    string tenkh = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    ChiTietBanHang_KhachHang a = new ChiTietBanHang_KhachHang(makh,tenkh);
                    a.Show();
                }
                if (index == 2)
                {
                    string ngayban = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    ChiTietBanHang_NgayBan a = new ChiTietBanHang_NgayBan(ngayban);
                    a.Show();
                }

            }

            //DateTime date = (DateTime)value;
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                //openReportForm();

            }


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
