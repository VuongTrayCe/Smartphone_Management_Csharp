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

    public partial class ThemNhanVien : Form
    {
        QuanLyTaiKhoan_BUS qltk_BUS = new QuanLyTaiKhoan_BUS();
        ThemTaiKhoan ttk;
        

        public ThemNhanVien(ThemTaiKhoan ttk)
        {
            InitializeComponent();
            this.ttk = ttk;
            this.ttk.Visible = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.ttk.Visible = true;
            this.Dispose();
        }

        private void btnXacNhanNhanVien_Click(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien(txtNhanVien.Text, int.Parse(txtCccd.Text), int.Parse(txtTuoi.Text), txtDiaChi.Text, cbChucDanh.Text);
           
            qltk_BUS.themNhanVien(nv);
            MessageBox.Show("Đã thêm nhân viên thành công");
            

        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            qltk_BUS.ShowThuocTinhChucDanhCombobox(cbChucDanh);
        }
    }
}
