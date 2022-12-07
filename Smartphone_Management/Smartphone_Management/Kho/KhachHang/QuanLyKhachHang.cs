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

namespace Smartphone_Management.GUI.KhachHang
{
    public partial class QuanLyKhachHang : Form
    {
        
        DataTable data = new DataTable();
        QuanLyKhachHang_BUS qlkh_bus = new QuanLyKhachHang_BUS();
        public QuanLyKhachHang()
        {
            InitializeComponent();
            init();
            
        }
        private void resetForm()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtEmail.Text = "";
            NgayTao.Text = "";
            txtMaKH.Focus();
        }

        private void bThem_Click(object sender, EventArgs e)
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

                    txtMaKH.Focus();
                    model_kh model_KH = new model_kh();
                    model_KH.Makh = Int32.Parse(txtMaKH.Text);
                    model_KH.Tenkh = txtTenKH.Text;
                    model_KH.Cmnd = txtCMND.Text;
                    model_KH.SDT = txtSDT.Text;
                    model_KH.DiaChi = txtDiaChi.Text;
                    model_KH.Email = txtEmail.Text;
                    model_KH.Ngaytao = NgayTao.Value;
                    model_KH.Diemso = 0;
                    model_KH.Trangthai = "T";
                    qlkh_bus.addKhachHang(model_KH);
                    resetForm();
                    init();
                    

              /*  }
                else
                {
                    Console.WriteLine("Không thể thêm kh");
                }

            }*/
        }
        public void init()     
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            data = qlkh_bus.getThongTinKhachHang();
            DSKhachHang.DataSource = data;
            
           
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
           
            //data = new DataTable();
            init();
            

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DSKhachHang.Rows[i].Cells[1].Value = i + 1;
            }
            

        }
       

        private void DSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaKH.Text = DSKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = DSKhachHang.CurrentRow.Cells[1].Value.ToString();
            NgayTao.Text = DSKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtCMND.Text = DSKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = DSKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = DSKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = DSKhachHang.CurrentRow.Cells[5].Value.ToString();


        }

       
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //init();
            try
            {
                DataView view = DSKhachHang.DataSource as DataView;
                if (view != null)
                {
                    DSKhachHang.DataSource = data;
                    view.RowFilter = txtTimKiem.Text;
                    view.RowStateFilter = DataViewRowState.Unchanged;

                }

            }
            catch
            {

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Makh = int.Parse(DSKhachHang.CurrentRow.Cells[0].Value.ToString());
            qlkh_bus.updateTrangThaiKhachHangHuy(Makh);
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
                    txtMaKH.Focus();
                    model_kh model_KH = new model_kh();
                    model_KH.Makh = Int32.Parse(txtMaKH.Text);
                    model_KH.Tenkh = txtTenKH.Text;
                    model_KH.Cmnd = txtCMND.Text;
                    model_KH.SDT = txtSDT.Text;
                    model_KH.DiaChi = txtDiaChi.Text;
                    model_KH.Email = txtEmail.Text;
                    model_KH.Ngaytao = NgayTao.Value;
                    
                    model_KH.Trangthai = "T";

                    qlkh_bus.updateKhachHang(model_KH);
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
