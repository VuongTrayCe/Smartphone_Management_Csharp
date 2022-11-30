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

namespace Smartphone_Management.GUI.Login
{
    public partial class XoaTaiKhoan : Form
    {
        QuanLyTaiKhoan frmqltk;
        QuanLyTaiKhoan_BUS qltk_BUS = new QuanLyTaiKhoan_BUS();
        public XoaTaiKhoan(QuanLyTaiKhoan frmqltk)
        {
            InitializeComponent();
            this.frmqltk = frmqltk;
            this.frmqltk.Visible = false;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.frmqltk.Visible = true;
            this.Dispose();
        }

        private void btnXacNhanXoa_Click(object sender, EventArgs e)
        {
            string queryTaiKhoan = cbTaiKhoanDangHoatDong.Text;
            string[] MaTK = queryTaiKhoan.Split('-');
            int Matk = Int32.Parse(MaTK[1]);

            qltk_BUS.XoaTaiKhoan_BUS(Matk);
        }

        private void XoaTaiKhoan_Load(object sender, EventArgs e)
        {
            qltk_BUS.getCacTaiKhoanDangHoatDong_BUS(cbTaiKhoanDangHoatDong);
        }
    }
}
