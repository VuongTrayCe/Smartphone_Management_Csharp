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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Application = System.Windows.Forms.Application;

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
            cbbTrangThai.SelectedIndex = 0;

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
            data = qldh_bus.getThongTinDonDatHang(cbbTrangThai.SelectedItem.ToString(),dateStart.Value,DateEnd.Value,txtTimKiem.Text);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
        // Bắt sự kiện khi người dùng click nút xem
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String value = (String)dataGridView1.CurrentRow.Cells[4].Value;
            String tenkh = (String)dataGridView1.CurrentRow.Cells[5].Value;
            DateTime ngaydat = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            String trangthai = cbbTrangThai.SelectedItem.ToString();
            //DateTime date = (DateTime)value;
            int madh = int.Parse(value);
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                openDetailForm(madh,tenkh,ngaydat,trangthai);

            }
        }

        // Mở form chi tiết đơn hàng
      public void openDetailForm(int Madh,String tenkhachhang,DateTime ngaydat,String trangthai)
        {
            Boolean isopen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text=="ChiTietDonHang")
                {
                    isopen = true;
                    f.BringToFront();
                }
            }
            if(isopen==false)
            {
                ChiTietDonHang detailForm = new ChiTietDonHang(Madh);
                detailForm.setInfo(tenkhachhang, ngaydat,trangthai);
                detailForm.Show();
            }

        }
        public void DoSomething(int row, int column)
        {
            System.Windows.MessageBox.Show(string.Format("Cell({0},{1}) Clicked", row, column));
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
            //MessageBox.Show(datetest);
            //MessageBox.Show(dateTime.ToString());
            CultureInfo provider = CultureInfo.InvariantCulture;
            bool isSuccess = DateTime.TryParseExact("2022-03-29", "yyyy-MM-dd", provider, DateTimeStyles.None, out dateTimeObj);
            //MessageBox.Show(dateTimeObj.ToString());
            //MessageBox.Show((dateTime>dateTimeObj).ToString());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            init();
            dataGridView1.DataSource = data;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            init();
            dataGridView1.DataSource = data;
        }
    }
}
