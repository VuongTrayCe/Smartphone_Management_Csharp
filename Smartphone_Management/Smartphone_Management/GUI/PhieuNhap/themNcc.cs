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
    public partial class themNcc : Form
    {
        private themPhieuNhap themPhieuNhap;
        themPhieuNhap_DAO tpn_DAO = new themPhieuNhap_DAO();
        public bool isClose = false;
        public themNcc(themPhieuNhap themPhieuNhap)
        {
            InitializeComponent();
            setLayout(comboBox1);
            this.themPhieuNhap = themPhieuNhap;
        }
        public void setLayout(ComboBox comboBox1)
        {
            textBox2.Text = (tpn_DAO.getNccMax() + 1).ToString();
            textBox2.ReadOnly = true;
            comboBox1.Items.Add("T");
            comboBox1.Items.Add("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Item = textBox1.Text;
            if (!comboBox1.Items.Contains(Item))
            {
                tpn_DAO.insertNcc(textBox1, textBox2, textBox3, textBox4, comboBox1);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi, vui lòng nhập chính xác tên nhà cung cấp!");
                isClose = true;
                this.Close();
            }
        }
    }
}
