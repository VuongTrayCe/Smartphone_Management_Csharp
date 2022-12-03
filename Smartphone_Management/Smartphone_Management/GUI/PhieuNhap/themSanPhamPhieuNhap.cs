using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Smartphone_Management.GUI
{
    public partial class themSanPhamPhieuNhap : Form
    {
        themPhieuNhap themPhieuNhap;
        public int mancc;
        themSanPhamPhieuNhap_BUS tsppn_BUS = new themSanPhamPhieuNhap_BUS();
        List<Model_ChiTietPhieuNhap> listSanPham;
        public object row;
        List<Model_ChiTietPhieuNhap> dataRowChiTiet;
        List<List<String>> dataSanPham = new List<List<string>>();
        public themSanPhamPhieuNhap(themPhieuNhap themPhieuNhap,List<Model_ChiTietPhieuNhap> dataRowChiTiet)
        {
            InitializeComponent();
            mancc = themPhieuNhap.getMaNhaCungCap();
            getComboBox();
            this.themPhieuNhap = themPhieuNhap;
            this.listSanPham = listSanPham;
            this.dataRowChiTiet = dataRowChiTiet;
        }
        public void getComboBox()
        {
            dataSanPham = tsppn_BUS.getDataSanPham(mancc);
            foreach (List<String> items in dataSanPham)
            {
                List<String> a = items;
                cbbSanPham.Items.Add(a.ElementAt(1));
            }
            cbbSanPham.SelectedIndex = 0;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gianhap = 0;
            int soluong = 0;
            if (String.IsNullOrEmpty(txtSoLuong.Text) || String.IsNullOrEmpty(txtGiaNhap.Text))
            {
                MessageBox.Show("Nhập đầy đủ các thông tin!");
            }
            else if (int.TryParse(txtGiaNhap.Text, out gianhap) == false || int.TryParse(txtSoLuong.Text, out gianhap) ==false)
            {
                MessageBox.Show("Dữ Liệu không chính xác");

            }
            else
            {
                Model_ChiTietPhieuNhap modelrow = new Model_ChiTietPhieuNhap();
                int indexSp = cbbSanPham.SelectedIndex;
                int masp = int.Parse(dataSanPham.ElementAt(indexSp).ElementAt(0).ToString());
                String tensp = dataSanPham.ElementAt(indexSp).ElementAt(1).ToString();
                gianhap = int.Parse(txtGiaNhap.Text);
                 soluong = int.Parse(txtSoLuong.Text);
                MessageBox.Show("Thêm sản phẩm thành công!");
                modelrow.Masp = masp;
                modelrow.tensanpham = tensp;
                modelrow.gianhap = gianhap;
                modelrow.soluong = soluong;
                bool flag = true;
                foreach(Model_ChiTietPhieuNhap items in dataRowChiTiet)
                {
                    if(items.Masp==masp)
                    {
                        items.soluong = items.soluong + soluong;
                        flag = false;
                    }
                }
                if(flag==true)
                {
                    dataRowChiTiet.Add(modelrow);
                }
                themPhieuNhap.loadDataChiTietPhieuNhap();

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
