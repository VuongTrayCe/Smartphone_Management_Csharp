using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham;
using System;
using System.Collections;
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
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            Boolean flag = true;
            if (username.Equals(""))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Đăng Nhập");
                flag = false;
            }
            if (password.Equals(""))
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
                flag = false;
            }
            if (flag == true)
            {
                int l = qltk_BUS.KiemTraDangNhap(username,password);
                if (l != 0)
                {
                   MessageBox.Show("đăng nhập thành công");
                    String tennv = qltk_BUS.getTenNv(l);
                    UIMain UIMain = new UIMain(l, tennv,this);
                    this.Visible = false;
                    UIMain.Show();
                }
                else
                {
                    //JOptionPane.showMessageDialog(this, "đăng nhập fail");

                }
            }
        }

    

    }
}
