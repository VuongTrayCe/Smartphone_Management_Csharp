using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using Smartphone_Management.BUS;
using Smartphone_Management.GUI.ThongKe.BanHang;
using Smartphone_Management.GUI.ThongKe.NhapHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            this.dataGirdView1.EnableHeadersVisualStyles = false;
            this.chart1.Titles.Clear();
            int i = cbbLoai.SelectedIndex;
            if (i == 0)
            {
                dataGirdView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data = tknh.getThongKeNhapHang_HangHoa();
                dataGirdView1.DataSource = data;
                dataGirdView1.Columns[1].Width = (dataGirdView1.Width * 10) / 100;
                dataGirdView1.Columns[2].Width = (dataGirdView1.Width * 10) / 100;
                dataGirdView1.Columns[3].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[4].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[5].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[6].Width = (dataGirdView1.Width * 20) / 100;

                this.chart1.Series.Clear();

                this.chart1.Titles.Add("Top 10 Mặt Hàng Nhập Về Nhiều Nhất");
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = tknh.getChiPhiNhapHang_HangHoa_BieuDo1();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title

                // Add series.
                Series series = this.chart1.Series.Add("Số Lượng");
                series.ChartType = SeriesChartType.Spline;

                foreach (List<String> item in seriesList)
                {
                    series.Points.AddXY(item.ElementAt(0),int.Parse(item.ElementAt(1).ToString()));
                }

                //series.Points.AddXY("Obtober", 300);
                //series.Points.AddXY("November", 800);
                //series.Points.AddXY("December", 200);
                //series.Points.AddXY("January", 600);
                //series.Points.AddXY("February", 400);
                label2.Visible =false;
                label4.Visible = false;
                dateStart.Visible = false;
                dateEnd.Visible = false;
                btnXem.Visible = false;

            }
            else if (i == 1)
            {
                btnXem.Visible = false;

                label2.Visible = false;
                label4.Visible = false;
                dateStart.Visible = false;
                dateEnd.Visible = false;
                data = tknh.getThongKeNhaphang_NhaCungCap();
                dataGirdView1.DataSource = data;


                dataGirdView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGirdView1.Columns[1].HeaderText = "STT";
                dataGirdView1.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
                dataGirdView1.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                dataGirdView1.Columns[4].HeaderText = "Số Phiếu";
                dataGirdView1.Columns[5].HeaderText = "Số Lượng";
                dataGirdView1.Columns[6].HeaderText = "Tổng Tiền";

                dataGirdView1.Columns[1].Width = (dataGirdView1.Width * 10) / 100;
                dataGirdView1.Columns[2].Width = (dataGirdView1.Width * 10) / 100;
                dataGirdView1.Columns[3].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[4].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[5].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[6].Width = (dataGirdView1.Width * 20) / 100;

                this.chart1.Series.Clear();

                this.chart1.Titles.Add("Top 10 Nhà Cung Cấp Nhầp Nhiều Nhất");
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = tknh.getChiPhiNhapHang_NhaCungCap_BieuDo();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title

                // Add series.
                Series series = this.chart1.Series.Add("Số Lượng");
                series.ChartType = SeriesChartType.Spline;

                foreach (List<String> item in seriesList)
                {
                    series.Points.AddXY(item.ElementAt(0), int.Parse(item.ElementAt(1).ToString()));
                }


            }
            else
            {
                btnXem.Visible = true;

                label2.Visible = true;
                label4.Visible = true;
                dateStart.Visible = true;
                dateEnd.Visible = true;
                data = tknh.getThongKeNhapHang_NgayThang(dateStart.Value, dateEnd.Value);
                dataGirdView1.DataSource = data;


                dataGirdView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGirdView1.Columns[1].HeaderText = "STT";
                dataGirdView1.Columns[2].HeaderText = "Ngày Nhập";
                dataGirdView1.Columns[3].HeaderText = "Số Phiếu Nhập";
                dataGirdView1.Columns[4].HeaderText = "Số Lượng";
                dataGirdView1.Columns[5].HeaderText = "Tổng Tiền";

                dataGirdView1.Columns[1].Width = (dataGirdView1.Width * 10) / 100;
                dataGirdView1.Columns[2].Width = (dataGirdView1.Width * 15) / 100;
                dataGirdView1.Columns[3].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[4].Width = (dataGirdView1.Width * 20) / 100;
                dataGirdView1.Columns[5].Width = (dataGirdView1.Width * 20) / 100;

                this.chart1.Series.Clear();

                this.chart1.Titles.Add("Top 10 Ngày Nhập Nhiều Nhất");
                List<List<String>> seriesList = new List<List<String>>();
                seriesList = tknh.getChiPhiNhapHang_NgayNhap_BieuDo();
                // Set palette
                this.chart1.Palette = ChartColorPalette.EarthTones;

                // Set title

                // Add series.
                Series series = this.chart1.Series.Add("Số Lượng");
                series.ChartType = SeriesChartType.Spline;

                foreach (List<String> item in seriesList)
                {
                    series.Points.AddXY(item.ElementAt(0), int.Parse(item.ElementAt(1).ToString()));
                }



            }


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            init();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel wordbool |*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add((DataTable)dataGirdView1.DataSource, "Thống Kê Nhập Hàng");
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

        private void dataGirdView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = cbbLoai.SelectedIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (index == 1)
                {
                    int mancc = int.Parse(dataGirdView1.CurrentRow.Cells[2].Value.ToString());
                    string tenncc = dataGirdView1.CurrentRow.Cells[3].Value.ToString();

                    ChiTietNhapHang_NhaCungCap a = new ChiTietNhapHang_NhaCungCap(mancc, tenncc);
                    a.Show();
                }
                if (index == 2)
                {
                    string ngaynhap = dataGirdView1.CurrentRow.Cells[2].Value.ToString();

                    ChiTietNhapHang_NgayNhap a = new ChiTietNhapHang_NgayNhap(ngaynhap);
                    a.Show();
                }

            }
        }
    }
}
