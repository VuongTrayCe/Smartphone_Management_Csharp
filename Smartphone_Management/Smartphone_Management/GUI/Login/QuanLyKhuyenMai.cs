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
        }


        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDataKM();
            LoadDataChiTietKM();
            qlkm_BUS.showThuocTinhMaKM_BUS(cbMaKM);
            qlkm_BUS.showThuocTinhSanPham_BUS(cbSanPham);
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
            string[] Masp = querySanPham.Split('-');

            int MaKM = Int32.Parse(MaKm[1]);
            int MaSP = Int32.Parse(Masp[1]);

            chitietkhuyenmai ctkm = new chitietkhuyenmai(MaKM, MaSP);

            qlkm_BUS.ThemChiTietKM_BUS(ctkm);




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
            khuyenmai km = new khuyenmai(txtTenKM.Text.Trim(), Convert.ToInt32(txtPTKM.Text.Trim()), cbTrangThai.Text);
            qlkm_BUS.ThemKM_BUS(km);
            LoadDataKM();
            LoadDataChiTietKM();
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
    }
}
