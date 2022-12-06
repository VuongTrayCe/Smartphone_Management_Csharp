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
    public partial class QuanLyKhuyenMai : Form
    {
        List<List<String>> arrmasp = new List<List<String>>();
        QuanLyBaoHanh_BUS qlbh = new QuanLyBaoHanh_BUS();

        QuanLyKhuyenMai_BUS qlkm_BUS = new QuanLyKhuyenMai_BUS();
        int? val = null;
        int maChiTietKM = -1;
        int maKM = -1;
        string tenKM = "";
        int PTKM = -1;
        string trangThai = "";

        public QuanLyKhuyenMai()
        {
            InitializeComponent();
        }

        public void LoadDataKM()
        {
            //// clear the rows
            //dataGridView.Rows.Clear();

            DataTable dataKM = new DataTable();

            switch (val)
            {
                case 1:
                    dataKM = qlkm_BUS.TimKiemKM_BUS(txtSearchKM.Text.Trim());
                    break;
                default:

                    dataKM = qlkm_BUS.getThongTinCacKhuyenMai_BUS();
                    break;
            }

            dtgKhuyenMai.DataSource = dataKM;
            dtgKhuyenMai.Columns[0].HeaderText = "Mã Khuyến Mãi";
            dtgKhuyenMai.Columns[1].HeaderText = "Tên Khuyến Mãi";
            dtgKhuyenMai.Columns[2].HeaderText = "Phần Trăm";
            dtgKhuyenMai.Columns[3].HeaderText = "Trạng Thái";

        }

        public void LoadDataChiTietKM()
        {
            DataTable dataChiTietKM = new DataTable();

            switch (val)
            {
                case 1:
                    dataChiTietKM = qlkm_BUS.TimKiemChiTietKM_BUS(txtSearchChiTietKM.Text.Trim());
                    break;
                default:

                    dataChiTietKM = qlkm_BUS.getThongTinCacChiTietKhuyenMai_BUS();
                    break;
            }

            dtgChiTietKM.DataSource = dataChiTietKM;

            dtgChiTietKM.Columns[0].HeaderText = "Mã Chi Tiết Khuyến Mãi";
            dtgChiTietKM.Columns[1].HeaderText = "Mã Sản Phẩm";
            dtgChiTietKM.Columns[2].HeaderText = "Mã Khuyến Mãi";
            dtgChiTietKM.Columns[3].HeaderText = "Trạng Thái";

            cbSanPham.Items.Clear();

            arrmasp = qlbh.getAllMaSanPham();
            foreach (List<String> i in arrmasp)
            {
                cbSanPham.Items.Add(i.ElementAt(1));
            }
            cbSanPham.SelectedIndex = 0;
            qlkm_BUS.showThuocTinhMaKM_BUS(cbMaKM);
            cbMaKM.SelectedIndex = 0;

        }


        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDataKM();
            LoadDataChiTietKM();
 
            //qlkm_BUS.showThuocTinhSanPham_BUS(cbSanPham);
        }

        private void txtSearchChiTietKM_TextChange(object sender, EventArgs e)
        {
            val = 1;
            LoadDataChiTietKM();
        }

        private void txtSearchKM_TextChange(object sender, EventArgs e)
        {
            val = 1;
            LoadDataKM();
        }

        private void btnThemChiTietKM_Click(object sender, EventArgs e)
        {
            string queryMaKM = cbMaKM.Text;
            string querySanPham = cbSanPham.Text;


            string[] MaKm = queryMaKM.Split('-');
            //string[] Masp = querySanPham.Split('-');

            int MaKM = Int32.Parse(MaKm[1]);
            //int MaSP = Int32.Parse(Masp[1]);
            int index = cbSanPham.SelectedIndex;
            int masp =int.Parse(arrmasp.ElementAt(index).ElementAt(0).ToString());

            chitietkhuyenmai ctkm = new chitietkhuyenmai(MaKM,masp);
            qlkm_BUS.UpdateChitietKhuyenMaiCu(masp);
            qlkm_BUS.ThemChiTietKM_BUS(ctkm);
            LoadDataChiTietKM();




        }

        private void dtgChiTietKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dtgChiTietKM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                 maChiTietKM = Convert.ToInt32(dtgChiTietKM.Rows[e.RowIndex].Cells[0].Value);
              
            }
        }
        private void dtgKhuyenMai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThemKhuyenMai.Visible = false;
            if (e.RowIndex != -1)
            {
                maKM = Convert.ToInt32(dtgKhuyenMai.Rows[e.RowIndex].Cells[0].Value);
                tenKM = Convert.ToString( dtgKhuyenMai.Rows[e.RowIndex].Cells[1].Value);
                txtTenKM.Text = tenKM;
                PTKM = Convert.ToInt32(dtgKhuyenMai.Rows[e.RowIndex].Cells[2].Value);
                txtPTKM.Text = PTKM.ToString();
                trangThai = Convert.ToString(dtgKhuyenMai.Rows[e.RowIndex].Cells[3].Value);
                cbTrangThai.Text = trangThai;
            }
        }

        private void btnXoaChiTietKM_Click(object sender, EventArgs e)
        {


            qlkm_BUS.XoaChiTietKMSP_BUS(maChiTietKM);
            LoadDataKM();
            LoadDataChiTietKM();
        }

        private void btnThemKhuyenMai_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(txtTenKM.Text=="")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Khuyến Mãi");
                flag=false;
            }
            if (txtPTKM.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Phần Trăm Khuyến Mãi");
                flag = false;
            }
            int ptkm = 0;
            if(int.TryParse(txtPTKM.Text,out ptkm)==false)
            {
                MessageBox.Show("Phần Trăm Khuyến Mãi Không Được Có Ký tự chữ");
                flag = false;
            }
            if(flag==true)
            {
                khuyenmai km = new khuyenmai(txtTenKM.Text.Trim(), Convert.ToInt32(txtPTKM.Text.Trim()), cbTrangThai.Text);
                qlkm_BUS.ThemKM_BUS(km);
                LoadDataKM();
                LoadDataChiTietKM();
            }

        }

        private void btnXoaKhuyenMai_Click(object sender, EventArgs e)
        {
            qlkm_BUS.XoaKM_BUS(maKM);
            LoadDataKM();
            LoadDataChiTietKM();
        }

        private void btnSuaKhuyenMai_Click(object sender, EventArgs e)
        {
            khuyenmai km = new khuyenmai(txtTenKM.Text.Trim(), Convert.ToInt32(txtPTKM.Text.Trim()), cbTrangThai.Text);
            qlkm_BUS.CapNhatKM_BUS(km, maKM);
            LoadDataKM();
            LoadDataChiTietKM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPTKM.Text = "";
            txtTenKM.Text = "";
            btnThemKhuyenMai.Visible = true;

        }
    }
}
