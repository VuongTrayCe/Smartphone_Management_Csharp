using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI
{
    public partial class themSanPham : Form
    {
        public bool isClose;
        private themSanPhamPhieuNhap themSanPhamPhieuNhap;
        thongTinPhieuNhap_BUS ttpn_BUS = new thongTinPhieuNhap_BUS();
        thongTinPhieuNhap_DAO ttpn_DAO = new thongTinPhieuNhap_DAO();
        public themSanPham(themSanPhamPhieuNhap themSanPhamPhieuNhap)
        {
            InitializeComponent();
            this.themSanPhamPhieuNhap = themSanPhamPhieuNhap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mancc = themSanPhamPhieuNhap.mancc;
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Lỗi, vui lòng nhập chính xác tên sản phẩm!");
            }
            else
            {
                ttpn_DAO.insertSP(textBox1, textBox2, textBox3, textBox4, textBox5, mancc);
                MessageBox.Show("Thêm sản phẩm thành công!");
                isClose = true;
                this.Close();
            }
        }
    }
}
