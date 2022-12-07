using DocumentFormat.OpenXml.Drawing.Diagrams;
using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.DonHang
{
    public partial class ChiTietDonHang : Form
    {
        QuanLyDonDatHang_BUS qldh = new QuanLyDonDatHang_BUS();
        private int Madh;
        private String tenKhachHang;
        private DateTime ngaydat;
       private String trangthai;
        QuanLyDonHang formqldh;
        DataTable data = new DataTable();

        public ChiTietDonHang(int Madh)
        {
            InitializeComponent();
            this.Madh = Madh;

        }
        public void setInfo(String tenKhachHang,DateTime ngaydat,String trangthai,QuanLyDonHang formQLDH )
        {
            this.tenKhachHang = tenKhachHang;
            this.ngaydat= ngaydat;
            this.trangthai = trangthai;
            this.formqldh = formQLDH;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiTietDonHang_Load(object sender, EventArgs e)
        {
            init();
        }
        public void init()
        {
            data = qldh.getChiTietDonHang(this.Madh);
            lbName.Text = tenKhachHang+"| ";
            String ngaydathang = String.Format("{0:yyyy-MM-dd}",ngaydat);
            lbNgayDat.Text = ngaydathang;
            lbMaDon.Text = Madh.ToString();
            if(trangthai.Equals("Đặt Hàng"))
                {
                btnHoanThanh.Visible = true;
                btnHuyDon.Visible = true;
            }
            if (trangthai.Equals("Hoàn Thành"))
            {
                btnHoanThanh.Visible =false;
                btnHuyDon.Visible = false;
            }
            if (trangthai.Equals("Đã Hủy"))
            {
                btnHoanThanh.Visible = false;
                btnHuyDon.Visible = false;
            }
            dataGridView1.DataSource = data;
            dataGridView1.Columns[1].HeaderText = "Mã Sản Phẩm";
            dataGridView1.Columns[2].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns[3].HeaderText = "Số Lượng";
            dataGridView1.Columns[4].HeaderText = "Giá Bán";
            dataGridView1.Columns[5].HeaderText = "Khuyễn Mãi";
            dataGridView1.Columns[6].HeaderText = "Bảo Hành";
            dataGridView1.Columns[7].HeaderText = "Thành Tiền";

            dataGridView1.ScrollBars = ScrollBars.Both;

        }

        private void lbNgayDat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Model_DonHang_ChiTietDonHang modelChiTietDonHang = new Model_DonHang_ChiTietDonHang();
            int Masp =int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            String tensp = (String)dataGridView1.CurrentRow.Cells[2].Value;
            int soluong = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            int giaban = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
           String km =  (String)dataGridView1.CurrentRow.Cells[5].Value;
            String baohanh = (String)dataGridView1.CurrentRow.Cells[6].Value;
            String thanhtien = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBaoHanh.Text = baohanh;
            txtGiaBan.Text = giaban.ToString();
            txtKhuyenMai.Text= km;
            txtMaSanPham.Text = Masp.ToString();
            txtSoLuong.Text = soluong.ToString();
            txtTenSanPham.Text = tensp;
            txtThanhTien.Text = tensp;
            String pathImage =  qldh.getImageSanPham(Masp);

            if (pathImage.Equals("") || pathImage == null)
            {
                imageSanPham.Image = new Bitmap(getImageStorePath() + "no_image.png");
                //AnhSanPhamUpdate.Text = "";
            }
            else
            {
                imageSanPham.Image = new Bitmap(getImageStorePath() + pathImage);
                //AnhSanPhamUpdate.Text = sanphamDTOSelected.Icon;
            }





        }
        private string getImageStorePath()
        {     
            string startUpPath = Application.StartupPath;
            string imageStorePath = startUpPath.Remove(startUpPath.Length - 9) + @"\GUI\GUI_SanPham\HinhAnh\";
            return imageStorePath;
        }

        private void btnHoanThanh_Click_1(object sender, EventArgs e)
        {
            qldh.updateDonHang(Madh);
            this.Dispose();
            formqldh.init();

        }

        private void btnHuyDon_Click_1(object sender, EventArgs e)
        {
            qldh.updateDonHangHuy(Madh);
            qldh.updateDiemKhachHang(Madh);
            for (int i=1;i<data.Rows.Count;i++)
            {
                if (data.Rows[i][1].ToString().Equals("")!=true)
                {
                    int masp = int.Parse(data.Rows[i][1].ToString());
                    int soluong = int.Parse(data.Rows[i][3].ToString());
                    qldh.UpdateSoLuongSanPham(masp, soluong);
                }
            }
            MessageBox.Show("Đã Hủy Đơn Hàng Thành Công"); 

            this.Dispose();
            formqldh.init();

        }
    }
}
