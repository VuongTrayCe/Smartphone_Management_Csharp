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

namespace Smartphone_Management.GUI.Login
{
    public partial class DangNhap : Form
    {
        QuanLyTaiKhoan_BUS qltk_BUS = new QuanLyTaiKhoan_BUS();


        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
            qltk_BUS.DangNhap_BUS(tk);  
        }
    }
}
