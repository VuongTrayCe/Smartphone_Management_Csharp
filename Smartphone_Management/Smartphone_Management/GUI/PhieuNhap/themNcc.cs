using Smartphone_Management.DAO;
using Smartphone_Management.GUI.GUI_SanPham.ValidateData;
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
    public partial class themNcc : Form
    {
        private themPhieuNhap themPhieuNhap;
        themPhieuNhap_DAO tpn_DAO = new themPhieuNhap_DAO();
        public bool isClose = false;
        public themNcc(themPhieuNhap themPhieuNhap)
        {
            InitializeComponent();
            setLayout();
            this.themPhieuNhap = themPhieuNhap;
        }
        public void setLayout()
        {
            ttxtMaNhaCungCap.Text = (tpn_DAO.getNccMax() + 1).ToString();
            ttxtMaNhaCungCap.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ValidateData a = new ValidateData();
            String Item = txtTenNhaCungCap.Text;
            bool flag = true;
            if(txtTenNhaCungCap.Text=="")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp");

                flag = false;
            }
            if(txtDiaChi.Text.Equals(""))
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ Nhà Cung Cấp");
                flag = false;
            }
            if (txtSDT.Text.Equals(""))
            {
                MessageBox.Show("Vui Lòng Nhập Số Điện Thoại Nhà Cung Cấp");
                flag = false;
            }
            if (a.validatePhone(txtSDT.Text) == false)
            {
                MessageBox.Show("Số Điện Thoại Không Đúng");
                flag = false;
            }
             if(flag)
            {

                tpn_DAO.insertNcc(txtTenNhaCungCap.Text, ttxtMaNhaCungCap.Text, txtSDT.Text, txtDiaChi.Text);
                this.Close();
                themPhieuNhap.loadDataNhaCungCap();
            }
        }
    }
}
