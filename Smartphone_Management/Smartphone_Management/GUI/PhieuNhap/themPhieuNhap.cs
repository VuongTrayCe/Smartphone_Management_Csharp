using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Smartphone_Management.DTO;
using DataTable = System.Data.DataTable;
using System.Windows.Markup;
using static Smartphone_Management.UIMain;

namespace Smartphone_Management.GUI
{
    public partial class themPhieuNhap : Form
    {
        public int soLuong = 0;
        public float tongTien = 0;
        themPhieuNhap_DAO tpn_DAO = new themPhieuNhap_DAO();
        themPhieuNhap_BUS tpn_BUS = new themPhieuNhap_BUS();
        DataTable dataChiTiet = new DataTable();
        List<List<String>> dataNhaCungCap = new List<List<string>>();
        List<Model_ChiTietPhieuNhap> dataRowChiTiet = new List<Model_ChiTietPhieuNhap>();
        thongTinPhieuNhap form;
        public themPhieuNhap()
        {
            this.Load += new EventHandler(Form1_Load);
            this.form = form;
        }

        private void thongTinPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            InitializeComponent();
            SetupLayout();
            SetupDateTime();
            loadDataNhaCungCap();
        }
        public void loadDataNhaCungCap()
        {
            dataNhaCungCap = tpn_BUS.getDataNhaCungCap();
            foreach (List<String> items in dataNhaCungCap)
            {
                List<String> a = items;
                cbbNhaCungCap.Items.Add(a.ElementAt(1));
            }
            cbbNhaCungCap.SelectedIndex = 0;
        }
        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SetupDateTime()
        {
            var today = DateTime.Today.ToString("yyyy-MM-dd");
            ngayNhapTxt.Text = today;
        }
        internal int getMaNhaCungCap()
        {
            int index = cbbNhaCungCap.SelectedIndex;
            return int.Parse(dataNhaCungCap.ElementAt(index).ElementAt(0).ToString());
        }
        public void loadDataChiTietPhieuNhap()
        {
            dataChiTiet.Rows.Clear();
            foreach (Model_ChiTietPhieuNhap items in dataRowChiTiet)
            {
                DataRow a = dataChiTiet.NewRow();
                a["Tên Sản Phẩm"] = items.tensanpham;
                a["Giá Tiền"] = items.gianhap;
                a["Số Lượng"] = items.soluong;
                a["Tổng Tiền"] = items.tongtien;
                dataChiTiet.Rows.Add(a);
                //}
            }

        }
        private void SetupLayout()
        {
            dataChiTiet.Columns.Add("Tên Sản Phẩm");
            dataChiTiet.Columns.Add("Giá Tiền");
            dataChiTiet.Columns.Add("Số Lượng");
            dataChiTiet.Columns.Add("Tổng Tiền");
            dataGridView1.DataSource = dataChiTiet;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            //dataGridView1.ColumnCount = 4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.Columns[0].Name = "Mã Sản Phẩm";
            //dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            //dataGridView1.Columns[1].Name = "Giá Tiền";
            //dataGridView1.Columns[2].Name = "Số Lượng";
            //dataGridView1.Columns[3].Name = "Tổng Tiền";

            //int maxPhieuNhap = tpn_DAO.getPhieuNhapMax();
            //textBox1.Text = (maxPhieuNhap + 1).ToString();
            //textBox1.ReadOnly = true;
            txtTongSoLuong.ReadOnly = true;
            txtTongTien.ReadOnly = true;

        }

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void addRowbtn_Click(object sender, EventArgs e)
        {

                
                themSanPhamPhieuNhap themSanPhamPhieuNhap = new themSanPhamPhieuNhap(this,dataRowChiTiet);
                themSanPhamPhieuNhap.Show();
        }

        private void deleteRowBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                int index = dataGridView1.CurrentRow.Index;
                dataChiTiet.Rows.RemoveAt(index);
                //this.dataGridView1.Rows.RemoveAt(
                //    this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataRowChiTiet.Count > 0)
            {
                Model_PhieuNhap dataPhieuNhap = new Model_PhieuNhap();
                dataPhieuNhap.Manhanvien = manv;
                int indexncc = cbbNhaCungCap.SelectedIndex;
                int mancc = int.Parse(dataNhaCungCap.ElementAt(indexncc).ElementAt(0).ToString());
                dataPhieuNhap.Manhacungcap = mancc;
                dataPhieuNhap.soluong = soLuong;
                dataPhieuNhap.tongtien = tongTien;
                dataPhieuNhap.ngaynhap = ngayNhapTxt.Text;
                int madh = tpn_BUS.AddPhieuNhap(dataPhieuNhap);
                //tpn_DAO.addChiTietPhieuNhap(dataGridView1, textBox1);
                tpn_BUS.AddChitietPhieuNhap(dataRowChiTiet, madh);
                MessageBox.Show("Tạo Phiếu Nhập Thành Công");
                this.Close();
            }
            //tpn_DAO.updatePhieuNhap(dataGridView1, soLuong, tongTien);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            soLuong = tpn_BUS.returnSoLuong(dataGridView1);
            tongTien = tpn_BUS.returnTongTien(dataGridView1);
            txtTongSoLuong.Text = soLuong.ToString();
            txtTongTien.Text = tongTien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themNcc themNcc = new themNcc(this);
            if (!themNcc.isClose)
            {
                themNcc.ShowDialog();
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            soLuong = tpn_BUS.returnSoLuong(dataGridView1);
            tongTien = tpn_BUS.returnTongTien(dataGridView1);
            txtTongSoLuong.Text = soLuong.ToString();
            txtTongTien.Text = tongTien.ToString();
        }
    }
}
