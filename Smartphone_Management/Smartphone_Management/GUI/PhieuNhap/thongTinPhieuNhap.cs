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
        private DataTable data;
        public string MPN;
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

        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {

        }

        public void init()
        {
            dateTimeFormat();
            data = ttpn_BUS.getThongTinPhieuNhap();
            dataGridView1.DataSource = data;
        }

        private void SetupDataGridView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addCol("Xem");
        }

        private void addCol(string name)
        {
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;
            newCol.HeaderText = name;
            newCol.Name = name;
            newCol.Visible = true;
            newCol.Width = 75;

            dataGridView1.Columns.Add(newCol);
        }

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.ToString();
            ttpn_DAO.searchPhieuNhap(searchValue, "Maphieunhap", dataGridView1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox2.Text.ToString();
            ttpn_DAO.searchPhieuNhap(searchValue, "Mancc", dataGridView1);
        }

        private void dateTimeFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
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
                ttpn_BUS.ToExcel(dataGridView1, sfd.FileName);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(0))
                {
                    MPN = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    chiTietPhieuNhap formSub = new chiTietPhieuNhap(MPN);
                    formSub.Show();
                }
                    
            }
        }
    }
}

