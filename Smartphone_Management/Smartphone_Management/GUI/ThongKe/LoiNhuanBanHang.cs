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
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using System.Windows;

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
            this.chart1.Titles.Clear();
            if (i == 1)
            {
                panel3.Visible = true;

                data = lnbh.getLoiNhuanBanHang_TheoThang(dateStart.Value,dateEnd.Value);
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].Width = (dataGridView1.Width * 5) / 100;
                dataGridView1.Columns[1].Width = (dataGridView1.Width * 20) / 100;
                dataGridView1.Columns[2].Width = (dataGridView1.Width * 10) / 100;
                dataGridView1.Columns[3].Width = (dataGridView1.Width * 10) / 100;
                dataGridView1.Columns[4].Width = (dataGridView1.Width * 10) / 100;


                this.chart1.Series.Clear();

                this.chart1.Titles.Add("Top 10 Ngày Thu Lợi Nhuận Cao Nhất");
                List<List<String>> seriesList = new List<List<String>>();

                string ngaybatdau = String.Format("{0:yyyy-MM-dd}", dateStart.Value);
                string ngayketthuc = String.Format("{0:yyyy-MM-dd}", dateEnd.Value);
                seriesList = lnbh.getLoiNhuanBanHang_NgayBan_BieuDo1(ngaybatdau,ngayketthuc);
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title

                // Add series.
                Series series = this.chart1.Series.Add("Lợi Nhuận");
                series.ChartType = SeriesChartType.Spline;

                foreach (List<String> item in seriesList)
                {
                    series.Points.AddXY(item.ElementAt(0), int.Parse(item.ElementAt(1).ToString()));
                }

            }
            else if (i == 0)
            {

                panel3.Visible = false;
                data = lnbh.getLoiNhuanBanHang_HangHoa();
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].HeaderText = "Mã Sản Phẩm";
                dataGridView1.Columns[1].HeaderText = "Tên Sản Phẩm";
                dataGridView1.Columns[2].HeaderText = "Tổng Số Bán Ra";
                dataGridView1.Columns[3].HeaderText = "Thành Tiền";
                dataGridView1.Columns[4].HeaderText = "Tiền Sau Khuyến Mãi";
                dataGridView1.Columns[5].HeaderText = "Tiền Vốn";
                dataGridView1.Columns[6].HeaderText = "Tiền Lãi-Lổ";
                this.chart1.Series.Clear();

                this.chart1.Titles.Add("Top 10 Mặt Hàng Thu Lợi Nhuận Cao Nhất");
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = lnbh.getLoiNhuanBanHang_HangHoa_BieuDo1();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title

                // Add series.
                Series series = this.chart1.Series.Add("Lợi Nhuận");
                series.ChartType = SeriesChartType.Spline;

                foreach (List<String> item in seriesList)
                {
                    series.Points.AddXY(item.ElementAt(0), int.Parse(item.ElementAt(1).ToString()));
                }


               


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

        private void cbbLoiNhuan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            init();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel wordbool |*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add((DataTable)dataGridView1.DataSource, "Lợi Nhuận Bán Hàng");
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
    }
}
