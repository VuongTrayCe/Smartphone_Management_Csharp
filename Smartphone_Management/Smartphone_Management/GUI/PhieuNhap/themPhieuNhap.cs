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

namespace Smartphone_Management.GUI
{
    public partial class themPhieuNhap : Form
    {
        public int soLuong = 0;
        public float tongTien = 0;
        themPhieuNhap_DAO tpn_DAO = new themPhieuNhap_DAO();
        themPhieuNhap_BUS tpn_BUS = new themPhieuNhap_BUS();
        public themPhieuNhap()
        {
            this.Load += new EventHandler(Form1_Load);
        }

        private void thongTinPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            InitializeComponent();
            SetupLayout();
            SetupDateTime();
            tpn_DAO.getComboBoxData(comboBox1);
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

        private void SetupLayout()
        {
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.ColumnCount = 5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "Mã Sản Phẩm";
            dataGridView1.Columns[1].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[2].Name = "Giá Tiền";
            dataGridView1.Columns[3].Name = "Số Lượng";
            dataGridView1.Columns[4].Name = "Tổng Tiền";

            int maxPhieuNhap = tpn_DAO.getPhieuNhapMax();
            textBox1.Text = (maxPhieuNhap + 1).ToString();
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

        }

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void addRowbtn_Click(object sender, EventArgs e)
        {
            themSanPhamPhieuNhap themSanPhamPhieuNhap = new themSanPhamPhieuNhap(this);
            themSanPhamPhieuNhap.Show();
        }

        private void deleteRowBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tpn_DAO.addPhieuNhap(dataGridView1, comboBox1, textBox1, textBox2, ngayNhapTxt);
            tpn_DAO.addChiTietPhieuNhap(dataGridView1, textBox1);
            tpn_DAO.updatePhieuNhap(dataGridView1, soLuong, tongTien);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            soLuong = tpn_BUS.returnSoLuong(dataGridView1);
            tongTien = tpn_BUS.returnTongTien(dataGridView1);
            textBox3.Text = soLuong.ToString();
            textBox4.Text = tongTien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themNcc themNcc = new themNcc(this);
            if (!themNcc.isClose)
            {
                themNcc.ShowDialog();
            }
        }
    }
}
