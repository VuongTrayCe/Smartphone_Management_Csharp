using Smartphone_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.BaoHanh
{
    public partial class QuanLyBaoHanh : Form
    {
        DataTable dataChiTietbaohanh = new DataTable();
        DataTable dataBh = new DataTable();
        List<int> arrmabh = new List<int>();
        List<List<String>> arrmasp= new List<List<String>>();

        QuanLyBaoHanh_BUS qlbh = new QuanLyBaoHanh_BUS();
        public QuanLyBaoHanh()
        {
            InitializeComponent();
            btnbhThem.Visible = false;

        }

        private void QuanLyBaoHanh_Load(object sender, EventArgs e)
        {
            init();
        }
        public void init()
        {

            dataBh = qlbh.getInForBaoHanh();
            dataBaoHanh.DataSource = dataBh;
            dataBaoHanh.Columns[0].HeaderText = "Mã bảo hành";
            dataBaoHanh.Columns[1].HeaderText = "Thời gian bảo hành";
            dataBaoHanh.Columns[2].HeaderText = "Trạng Thái";

            dataChiTietbaohanh = qlbh.getInforChiTietBaoHanh();
            dataChiTiet.DataSource = dataChiTietbaohanh;
            dataChiTiet.Columns[0].HeaderText = "Mã Chi tiết bảo hành";
            dataChiTiet.Columns[1].HeaderText = "Mã Bảo Hànhh";
            dataChiTiet.Columns[2].HeaderText = "Mã sản phẩm";
            dataChiTiet.Columns[3].HeaderText = "Trạng Thái";

            string thoigianbaohanh = dataBaoHanh.CurrentRow.Cells[1].Value.ToString();
            string trangthai = dataBaoHanh.CurrentRow.Cells[2].Value.ToString();
            if (trangthai.Equals("T"))
            {
                txtTrangThai.SelectedIndex = 0;

            }
            else
            {
                txtTrangThai.SelectedIndex = 1;

            }
            txtThoiGianBaoHanh.Text = thoigianbaohanh;


            cbbMaBaoHanh.Items.Clear();
            arrmabh = qlbh.getAllMaBaoHanh();
            foreach(int i in arrmabh)
            {
                cbbMaBaoHanh.Items.Add(i);
            }
            cbbMaSP.Items.Clear();

            arrmasp = qlbh.getAllMaSanPham();
            foreach (List<String> i in arrmasp)
            {
                cbbMaSP.Items.Add(i.ElementAt(1));
            }
            cbbMaBaoHanh.SelectedIndex = 0;
            cbbMaSP.SelectedIndex = 0;

        }
        private void dataBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataBaoHanh_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string thoigianbaohanh = dataBaoHanh.CurrentRow.Cells[1].Value.ToString();
            string trangthai = dataBaoHanh.CurrentRow.Cells[2].Value.ToString();
            if (trangthai.Equals("T"))
            {
                txtTrangThai.SelectedIndex = 0;

            }
            else
            {
                txtTrangThai.SelectedIndex = 1;

            }
            txtThoiGianBaoHanh.Text = thoigianbaohanh;
        }

        private void dataBaoHanh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string thoigianbaohanh = dataBaoHanh.CurrentRow.Cells[1].Value.ToString();
            string trangthai = dataBaoHanh.CurrentRow.Cells[2].Value.ToString();
            if (trangthai.Equals("T"))
            {
                txtTrangThai.SelectedIndex = 0;

            }
            else
            {
                txtTrangThai.SelectedIndex = 1;

            }
            txtThoiGianBaoHanh.Text = thoigianbaohanh;
            btnbhThem.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtThoiGianBaoHanh.Text = "";
            btnbhThem.Visible = true;
        }

        private void btnBhSua_Click(object sender, EventArgs e)
        {
            if(btnbhThem.Visible==false && txtThoiGianBaoHanh.Text!="" && txtTrangThai.Text!="")
            {
                int mabh = int.Parse(dataBaoHanh.CurrentRow.Cells[0].Value.ToString());
                qlbh.UpdateBaoHanh(mabh,txtThoiGianBaoHanh.Text,txtTrangThai.Text);
                MessageBox.Show("Đã Sửa Thành Công");
                init();
            }
        }

        private void btnBhXoa_Click(object sender, EventArgs e)
        {
            if (dataBaoHanh.CurrentRow.Cells[0].Value!=null)
            {
                int mabh = int.Parse(dataBaoHanh.CurrentRow.Cells[0].Value.ToString());
                qlbh.deleteBaoHanh(mabh);
                MessageBox.Show("Đã Xoá Thành Công");
                init();
            }
        }

        private void btnbhThem_Click(object sender, EventArgs e)
        {
            if(txtThoiGianBaoHanh.Text!="" && txtTrangThai.Text!="")
            {
                string thoigianbaohanh = txtThoiGianBaoHanh.Text;
                string trangthai = txtTrangThai.Text;
                qlbh.AddBaoHanh(thoigianbaohanh,trangthai);
                MessageBox.Show("Đã Thêm Thành Công");
                init();

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Thông Tin");
            }
   
        }

        private void btnCtXoa_Click(object sender, EventArgs e)
        {
           
            int mactbh = int.Parse(dataChiTiet.CurrentRow.Cells[0].Value.ToString());
            if (mactbh != -1)
            {
                qlbh.deleteChiTietBaoHanh(mactbh);
                MessageBox.Show("Đã Xóa Thành Công");
                init();
            }
             


        }

        private void btnCtThem_Click(object sender, EventArgs e)
        {
            int mabh = int.Parse(cbbMaBaoHanh.SelectedItem.ToString());
            int indexsp = cbbMaSP.SelectedIndex;
            int masp = int.Parse(arrmasp.ElementAt(indexsp).ElementAt(0).ToString());
            qlbh.AddChiTietBaoHanh(mabh,masp);
            MessageBox.Show("Đã Thêm Thành Công");
            init();

        }
    }
}
