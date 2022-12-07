using ClosedXML.Excel;
using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
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
            ConnectToMySQL conn = new ConnectToMySQL();
            data = qlnv_bus.getThongTinNhanVien();
            DSNhanVien.DataSource = data;
           

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

            txtMaNV.Focus();
            model_nv model_nv = new model_nv();
            model_nv.Manv = Int32.Parse(txtMaNV.Text);
            model_nv.Tennv = txtTenNV.Text;
            model_nv.Cmnd = txtCMND.Text;
            model_nv.Tuoi = Int32.Parse(txtTuoi.Text);
            model_nv.DiaChi = txtDiaChi.Text;
            model_nv.Chucdanh = txtChucDanh.Text;
            model_nv.Trangthai = "T";
            qlnv_bus.addNhanVien(model_nv);
            resetForm();
            init();


            /*  }
              else
              {
                  Console.WriteLine("Không thể thêm kh");
              }

          }*/
        }
        private void DSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaNV.Text = DSNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = DSNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtCMND.Text = DSNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtTuoi.Text = DSNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = DSNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtChucDanh.Text = DSNhanVien.CurrentRow.Cells[5].Value.ToString();


        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Makh = int.Parse(DSNhanVien.CurrentRow.Cells[0].Value.ToString());
            qlnv_bus.updateTrangThaiKhachHangHuy(Makh);
            resetForm();
            init();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            /*if (!MaSanPham.Text.Equals(""))
            {
                PanelLoiSanPham.Hide();
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn sửa sản phẩm này?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { MaSanPham.Focus(); }
                if (dialogResult == DialogResult.Yes)
                {*/
            txtMaNV.Focus();
            model_nv model_nv = new model_nv();
            model_nv.Manv = Int32.Parse(txtMaNV.Text);
            model_nv.Tennv = txtTenNV.Text;
            model_nv.Cmnd = txtCMND.Text;
            model_nv.DiaChi = txtDiaChi.Text;
            model_nv.Tuoi = Int32.Parse(txtTuoi.Text);
            model_nv.Chucdanh = txtChucDanh.Text;

            model_nv.Trangthai = "T";

            qlnv_bus.updateNhanVien(model_nv);
            resetForm();
            init();

            /*     }

             }
             else
             {
                 PanelLoiSanPham.Show();
                 LabelLoiSanPham.Text = "Vui lòng chọn sản phẩm để sửa!";
             }*/
        }
    }
}
