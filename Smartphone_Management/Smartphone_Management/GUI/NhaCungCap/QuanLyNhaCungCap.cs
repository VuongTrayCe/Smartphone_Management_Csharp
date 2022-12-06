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

namespace Smartphone_Management.GUI
{
    public partial class QuanLyNhaCungCap : Form
    {
        int? val = null;
        int maNCC = -1;
        int sdt = -1;
        string tenNCC = "";
        string diaChi = "";
        string trangThai = "";


        QuanLyNCC_BUS qlncc_BUS = new QuanLyNCC_BUS();


        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        public void LoadDataNCC()
        {
            //// clear the rows
            //dataGridView.Rows.Clear();

            DataTable dataKM = new DataTable();

            switch (val)
            {
                case 1:
                    dataKM = qlncc_BUS.TimKiemNCC_BUS(txtSearchNCC.Text.Trim());
                    break;
                default:

                    dataKM = qlncc_BUS.getNCC_BUS();
                    break;
            }

            dtgNCC.DataSource = dataKM;

        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataNCC();
        }

        private void txtSearchNCC_TextChange(object sender, EventArgs e)
        {
            val = 1;
            LoadDataNCC();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            nhacungcap ncc = new nhacungcap(txtTenNCC.Text.Trim(), Convert.ToInt32(txtDienThoai.Text.Trim()), txtDiaChi.Text.Trim());
            qlncc_BUS.ThemNCC_BUS(ncc);
            LoadDataNCC();
        }

        private void dtgNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maNCC = Convert.ToInt32(dtgNCC.Rows[e.RowIndex].Cells[0].Value);
                tenNCC = Convert.ToString(dtgNCC.Rows[e.RowIndex].Cells[1].Value);
                txtTenNCC.Text = tenNCC;
                sdt = Convert.ToInt32(dtgNCC.Rows[e.RowIndex].Cells[2].Value);
                txtDienThoai.Text = sdt.ToString();

                diaChi = Convert.ToString(dtgNCC.Rows[e.RowIndex].Cells[3].Value);
                txtDiaChi.Text = diaChi;

                trangThai = Convert.ToString(dtgNCC.Rows[e.RowIndex].Cells[4].Value);
                cbTrangThai.Text = trangThai;



            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            qlncc_BUS.XoaNCC_BUS(maNCC);
            LoadDataNCC();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            nhacungcap ncc = new nhacungcap(txtTenNCC.Text.Trim(), Convert.ToInt32(txtDienThoai.Text.Trim()), txtDiaChi.Text.Trim(), cbTrangThai.Text.Trim());
            qlncc_BUS.CapNhatNCC_BUS(ncc, maNCC);
            LoadDataNCC();

        }
    }
}
