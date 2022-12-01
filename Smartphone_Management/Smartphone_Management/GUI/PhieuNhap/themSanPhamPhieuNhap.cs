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
    public partial class themSanPhamPhieuNhap : Form
    {
        private themPhieuNhap themPhieuNhap;
        public int mancc;
        themSanPhamPhieuNhap_DAO tsppn_DAO = new themSanPhamPhieuNhap_DAO();
        themSanPhamPhieuNhap_BUS tsppn_BUS = new themSanPhamPhieuNhap_BUS();

        public object row;
        public themSanPhamPhieuNhap(themPhieuNhap themPhieuNhap)
        {
            InitializeComponent();
            mancc = tsppn_DAO.getMaNcc(themPhieuNhap.comboBox1.Text);
            getComboBox();
            this.themPhieuNhap = themPhieuNhap;
        }

        public void getComboBox()
        {
            tsppn_DAO.getSanPhamData(comboBox1, mancc);
            textBox3.ReadOnly = true;
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.GetItemText(comboBox1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Nhập đầy đủ các thông tin!");
            }
            else
            {
                themPhieuNhap.dataGridView1.Rows.Add(textBox3.Text, comboBox1.GetItemText(comboBox1.SelectedItem), textBox2.Text, textBox1.Text, (int.Parse(textBox2.Text)* int.Parse(textBox1.Text)).ToString());
                MessageBox.Show("Thêm sản phẩm thành công!");
                themPhieuNhap.dataGridView1.Update();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themSanPham themSP = new themSanPham(this);
            if (!themSP.isClose)
            {
                themSP.ShowDialog();
            }
        }
    }
}
