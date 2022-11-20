using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Smartphone_Management.GUI.DonHang
{
    public partial class QuanLyDonHang : Form
    {
        private DataTable data;
        private QuanLyDonDatHang_BUS qldh_bus = new QuanLyDonDatHang_BUS();
        public QuanLyDonHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            cbbTrangThai.SelectedIndex = 3;

            //data = new DataTable();
            init();

            dataGridView1.DataSource = data;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = i + 1;
            }
        }
        public void init()
        { 
            ConnectToMySQL conn = new ConnectToMySQL();
            data = qldh_bus.getThongTinDonDatHang(cbbTrangThai.SelectedItem.ToString(),dateStart.Value,DateEnd.Value);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            object value = dataGridView1.CurrentRow.Cells[3].Value;
            DateTime date = (DateTime)value;
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                MessageBox.Show(date.ToString());

            }
        }
      
        public void DoSomething(int row, int column)
        {
            MessageBox.Show(string.Format("Cell({0},{1}) Clicked", row, column));
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            init();
            dataGridView1.DataSource = data;
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = (DateTime)dateStart.Value;
            DateTime dateTimeObj;
            String datetest = String.Format("{0:yyyy-MM-dd}", dateTime);
            MessageBox.Show(datetest);
            //MessageBox.Show(dateTime.ToString());
            CultureInfo provider = CultureInfo.InvariantCulture;
            bool isSuccess = DateTime.TryParseExact("2022-03-29", "yyyy-MM-dd", provider, DateTimeStyles.None, out dateTimeObj);
            //MessageBox.Show(dateTimeObj.ToString());
            //MessageBox.Show((dateTime>dateTimeObj).ToString());

        }
    }
}
