using ClosedXML.Excel;
using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Smartphone_Management.GUI.NhanVien
{
    public partial class QuanLyNhanVien : Form
    {
        DataTable data = new DataTable();
        QuanLyNhanVien_BUS qlnv_bus = new QuanLyNhanVien_BUS();
        public QuanLyNhanVien()
        {
            InitializeComponent();

            init();
        }


        private void resetForm()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtTuoi.Text = "";
            txtChucDanh.Text = "";
            txtMaNV.Focus();
        }

        public void init()
        {
            //btnThem.Visible = false;
            ConnectToMySQL conn = new ConnectToMySQL();
            data = qlnv_bus.getThongTinNhanVien();
            DSNhanVien.DataSource = data;
            DSNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            DSNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            DSNhanVien.Columns[2].HeaderText = "Số CCCD";
            DSNhanVien.Columns[3].HeaderText = "Tuổi";
            DSNhanVien.Columns[4].HeaderText = "Địa Chỉ";
            DSNhanVien.Columns[5].HeaderText = "Chức Danh";


        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            //data = new DataTable();
            init();


            for (int i = 0; i < data.Rows.Count; i++)
            {
                DSNhanVien.Rows[i].Cells[1].Value = i + 1;
            }

        }
        public bool checkLoi()
        {
            bool flag = true;
            if (txtTenNV.Equals(""))
            {
                MessageBox.Show(" Vui lòng nhập tên nhân viên");
                flag = false;
            }
            if (txtDiaChi.Equals(""))
            {
                MessageBox.Show(" Vui lòng địa chỉ nhân viên");
                flag = false;
            }
            if (txtCMND.Equals(""))
            {
                MessageBox.Show(" Vui lòng nhập số chứng minh nhân dân");
                flag = false;
            }
            int result = 0;
            if (int.TryParse(txtTuoi.Text, out result) == false)
            {
                MessageBox.Show("Số tuổi không chính xác");
                flag=false;
            }
            if (txtChucDanh.Equals(""))
            {
                MessageBox.Show(" Vui lòng chức danh");
                flag = false;
            }
            if (txtTuoi.Equals(""))
            {
                MessageBox.Show(" Vui lòng số tuổi");
                flag = false;
            }

            return flag;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            
            /*if (!txtMaKH.Text.Equals(""))
            {
                Console.WriteLine("Vui lòng \"Xóa Trắng\" để thêm sản phẩm mới!");
            }
            else
            {

                string errorMessage = qlkh_bus.checkInputKH(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text);
                if (errorMessage.Equals(""))
                {*/
            if(checkLoi())
            {
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn thêm nhân viên không ?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { }
                if (dialogResult == DialogResult.Yes)
                {

                    txtMaNV.Focus();
                    model_nv model_nv = new model_nv();
                    model_nv.Tennv = txtTenNV.Text;
                    model_nv.Cmnd = txtCMND.Text;
                    model_nv.Tuoi = Int32.Parse(txtTuoi.Text);
                    model_nv.DiaChi = txtDiaChi.Text;
                    model_nv.Chucdanh = txtChucDanh.Text;
                    model_nv.Trangthai = "T";
                    qlnv_bus.addNhanVien(model_nv);
                    resetForm();
                    init();
                }
            }
           


            /*  }
              else
              {
                  Console.WriteLine("Không thể thêm kh");
              }

          }*/
        }
        private void DSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Visible = false;
            txtMaNV.Text = DSNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = DSNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtCMND.Text = DSNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtTuoi.Text = DSNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = DSNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtChucDanh.Text = DSNhanVien.CurrentRow.Cells[5].Value.ToString();


        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            WarningDialog warningDialog = new WarningDialog("Bạn có muốn xóa nhân viên không ?");
            DialogResult dialogResult = warningDialog.ShowDialog();
            if (dialogResult == DialogResult.Cancel) { }
            if (dialogResult == DialogResult.Yes)
            {
                int Makh = int.Parse(DSNhanVien.CurrentRow.Cells[0].Value.ToString());
                qlnv_bus.updateTrangThaiKhachHangHuy(Makh);
                resetForm();
                init();
            }


        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkLoi())
            {
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn thêm nhân viên không ?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { }
                if (dialogResult == DialogResult.Yes)
                {
                    txtMaNV.Focus();
                    model_nv model_nv = new model_nv();
                    model_nv.Manv = int.Parse(txtMaNV.Text);
                    model_nv.Tennv = txtTenNV.Text;
                    model_nv.Cmnd = txtCMND.Text;
                    model_nv.DiaChi = txtDiaChi.Text;
                    model_nv.Tuoi = Int32.Parse(txtTuoi.Text);
                    model_nv.Chucdanh = txtChucDanh.Text;
                    model_nv.Trangthai = "T";

                    qlnv_bus.updateNhanVien(model_nv);
                    resetForm();
                    init();

                }
            }
            
            /*     }

             }
             else
             {
                 PanelLoiSanPham.Show();
                 LabelLoiSanPham.Text = "Vui lòng chọn sản phẩm để sửa!";
             }*/
        }

        private void DSNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyNhanVien_Load_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            txtChucDanh.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTuoi.Text = "";
              
        }
    }
}
