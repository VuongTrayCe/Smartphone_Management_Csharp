using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;

namespace Smartphone_Management.GUI
{
    public partial class thongTinPhieuNhap : Form
    {
        private MySqlConnection sqlNhap;
        public thongTinPhieuNhap()
        {
            string nhapStr = "server=localhost;user=root;database=phoneSale;port=3306;password=dvsaigonese";
            this.sqlNhap = new MySqlConnection(nhapStr);

            this.Load += new EventHandler(Form1_Load);
        }

        private void thongTinPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            InitializeComponent();
            SetupDataGridView();
            getData();

        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {

        }

        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void getData()
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from chitietphieunhap", sqlNhap);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch 
            {
                MessageBox.Show("Không lấy dữ liệu thành công, thử lại!");
            }
        }
    }
}

