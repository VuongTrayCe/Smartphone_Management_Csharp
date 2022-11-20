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
            DataTable data = new DataTable();
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

        }

        private void lbNgayDat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            qldh.updateDonHang(Madh);
            this.Dispose();
            formqldh.init();

        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            qldh.updateDonHangHuy(Madh);
            this.Dispose();
            formqldh.init();


        }
    }
}
