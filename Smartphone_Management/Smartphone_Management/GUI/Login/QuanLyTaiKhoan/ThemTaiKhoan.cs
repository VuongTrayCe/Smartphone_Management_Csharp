using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
using System;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.Login
{
    public partial class ThemTaiKhoan : Form
    {
        QuanLyTaiKhoan_BUS qltk_BUS = new QuanLyTaiKhoan_BUS();
        QuanLyTaiKhoan frmqltk; 

        public ThemTaiKhoan(QuanLyTaiKhoan frmqltk)
        {
            InitializeComponent();
            this.frmqltk = frmqltk;
            this.frmqltk.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.frmqltk.Visible = true;
            this.Dispose();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien(this);
            themNhanVien.ShowDialog();
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            qltk_BUS.ShowThuocTinhNhanVienConHoatDong(cbNhanVienCanChon);

        }

        private void cbNhanVienCanChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhanTaiKhoan_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan(txtTenDangNhap.Text, txtMatKhau.Text);
            DateTime dateTime = DateTime.Now;
            string timeNow = "" + dateTime.ToString("yyyy/MM/dd HH:mm:ss ");
            string queryMaNV = cbNhanVienCanChon.Text;
            qltk_BUS.themTaiKhoan(queryMaNV, timeNow, tk);
            this.frmqltk.LoadData();
            this.frmqltk.Visible = true;
            this.Dispose();
        }
    }
}
