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
        themPhieuNhap_DAO tpn_DAO = new themPhieuNhap_DAO();
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
            SetupDataGridView();
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

        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.ColumnCount = 5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "Mã Phiếu Nhập";
            dataGridView1.Columns[1].Name = "Mã Nhân Viên";
            dataGridView1.Columns[2].Name = "Số Lượng";
            dataGridView1.Columns[3].Name = "Tổng Tiền";
            dataGridView1.Columns[4].Name = "Trạng Thái";

        }

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void addRowbtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
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
            tpn_DAO.addPhieuNhap(dataGridView1, comboBox1, ngayNhapTxt);
            diaChiTxt.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
