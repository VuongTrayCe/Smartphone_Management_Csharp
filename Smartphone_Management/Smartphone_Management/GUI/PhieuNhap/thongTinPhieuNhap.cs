using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;


namespace Smartphone_Management.GUI
{
    public partial class thongTinPhieuNhap : Form
    {
        private DataTable data = new DataTable();
        public string MPN, date, ncc;
        thongTinPhieuNhap_BUS ttpn_BUS = new thongTinPhieuNhap_BUS();
        thongTinPhieuNhap_DAO ttpn_DAO = new thongTinPhieuNhap_DAO();
        public thongTinPhieuNhap()
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

            init();
            ttpn_BUS.setComboBoxData(comboBox1);
            comboBox1.SelectedIndex = 0;

        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {

        }

        public void init()
        {
            if(data.Rows.Count != 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            dateTimeFormat();
            data = ttpn_BUS.getThongTinPhieuNhap();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dataGridView1.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Mã Nhà Cung Cấp";
            dataGridView1.Columns[3].HeaderText = "Số Lượng";
            dataGridView1.Columns[4].HeaderText = "Ngày Nhập";
            dataGridView1.Columns[5].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[6].HeaderText = "Trạng Thái";

        }

        private void SetupDataGridView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            //addCol("Xem");
        }

        //private void addCol(string name)
        //{
        //    DataGridViewColumn newCol = new DataGridViewColumn();
        //    DataGridViewCell cell = new DataGridViewTextBoxCell();
        //    newCol.CellTemplate = cell;
        //    newCol.HeaderText = name;
        //    newCol.Name = name;
        //    newCol.Visible = true;
        //    newCol.Width = 75;

        //    dataGridView1.Columns.Add(newCol);
        //}

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox2.Text.ToString();
            ttpn_DAO.searchPhieuNhap(searchValue, dataGridView1);
        }

        private void dateTimeFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Value = new DateTime(2012, 05, 28);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ttpn_DAO.searchDate(dataGridView1, dateTimePicker1, dateTimePicker2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "ThongTinPhieuNhap.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ttpn_BUS.ToExcel(dataGridView1, sfd.FileName);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MPN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                date = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                ncc = ttpn_DAO.returnNcc(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                chiTietPhieuNhap formSub = new chiTietPhieuNhap(this,MPN, date, ncc);
                formSub.Show();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ttpn_DAO.searchDate(dataGridView1, dateTimePicker1, dateTimePicker2);

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            themPhieuNhap themPhieuNhap = new themPhieuNhap();
            themPhieuNhap.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ttpn_DAO.searchTrangthaiPhieuNhap(comboBox1.Text, dataGridView1);
        }

        internal DataTable getChiTietThongTinPhieuNhap(int maphieunnhap)
        {
            return ttpn_DAO.getChiTietThongTinPhieuNhap(maphieunnhap);
        }
    }
}

