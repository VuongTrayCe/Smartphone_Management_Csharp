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
    public partial class chiTietPhieuNhap : Form
    {
        thongTinPhieuNhap ttpn = new thongTinPhieuNhap();
        thongTinPhieuNhap_DAO ctpn_DAO = new thongTinPhieuNhap_DAO();
        thongTinPhieuNhap_BUS ctpn_BUS = new thongTinPhieuNhap_BUS();
        public chiTietPhieuNhap(string Maphieunhap)
        {
            InitializeComponent();
            setupDataGridView(Maphieunhap);
            
        }
        internal void setupDataGridView(string Maphieunhap)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ctpn_DAO.getChitietPhieuNhap(dataGridView1, Maphieunhap);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "ChiTietPhieuNhap.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ctpn_BUS.ToExcel(dataGridView1, sfd.FileName);
            }
        }
    }
}
