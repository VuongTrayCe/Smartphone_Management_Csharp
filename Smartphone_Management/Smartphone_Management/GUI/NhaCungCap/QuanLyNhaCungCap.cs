using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.Dialog;
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
        private void resetForm()
        {
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTenNCC.Text = "";
        }
        public bool checkLoi()
        {
            bool flag = true;
            if (txtTenNCC.Text.Equals(""))
            {
                MessageBox.Show(" Vui lòng nhập tên nhân viên");
                flag = false;
            }
            if (txtDiaChi.Text.Equals("")==true)
            {
                MessageBox.Show(" Vui lòng địa chỉ nhân viên");
                flag = false;
            }

            if (txtDienThoai.Text.Equals("")==true)
            {
                MessageBox.Show(" Vui lòng số điện thoại");
                flag = false;
            }
            else
            {
                ValidateData a = new ValidateData();
                if(a.validatePhone(txtDienThoai.Text)==false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    flag = false;
                }
            }

            return flag;
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
            if (checkLoi()==true)
            {
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn thêm nhà cung cấp không ?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { }
                if (dialogResult == DialogResult.Yes)
                {
                    nhacungcap ncc = new nhacungcap(txtTenNCC.Text.Trim(),txtDienThoai.Text, txtDiaChi.Text.Trim());
                    qlncc_BUS.ThemNCC_BUS(ncc);
                    LoadDataNCC();
                    resetForm();
                }
            }
        }

        private void dtgNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThemNCC.Visible = false;
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



            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            WarningDialog warningDialog = new WarningDialog("Bạn có muốn xóa nhà cung cấp không ?");
            DialogResult dialogResult = warningDialog.ShowDialog();
            if (dialogResult == DialogResult.Cancel) { }
            if (dialogResult == DialogResult.Yes)
            {
                qlncc_BUS.XoaNCC_BUS(maNCC);
                LoadDataNCC();
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (checkLoi() == true)
            {
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn sửa nhà cung cấp không ?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { }
                if (dialogResult == DialogResult.Yes)
                {
                    nhacungcap ncc = new nhacungcap(txtTenNCC.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                    qlncc_BUS.CapNhatNCC_BUS(ncc, maNCC);
                    LoadDataNCC();
                }
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            btnThemNCC.Visible = true;
            resetForm();
        }

        private void dtgNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
