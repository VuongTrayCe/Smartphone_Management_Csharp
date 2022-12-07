using ClosedXML.Excel;
using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.Dialog;
using Smartphone_Management.GUI.GUI_SanPham.ValidateData;
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
            txtDiemSo.Text = "0";

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
            txtDiemSo.Text = "0";

        }
        public bool checkLoi()
        {
            ValidateData a = new ValidateData();
            bool flag = true;
            int diem = 0;
            if (int.TryParse(txtDiemSo.Text, out diem) == false)
            {
                MessageBox.Show("Điểm số không hợp lệ");
                flag = false;
            }
            if (txtTenKH.Equals(""))
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
            if (txtSDT.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                flag = false;
            }
            else
            {
                if (a.validatePhone(txtSDT.Text) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    flag = false;
                }
            }
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập email");
                flag = false;
            }
            else
            {
                if (a.validateEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Email không đúng định dạng");
                    flag = false;
                }
            }

            return flag;
        }
        private void bThem_Click(object sender, EventArgs e)
        {

            if (checkLoi())
            {
                    WarningDialog warningDialog = new WarningDialog("Bạn có muốn thêm khách hàng không ?");
                    DialogResult dialogResult = warningDialog.ShowDialog();
                    if (dialogResult == DialogResult.Cancel) { }
                    if (dialogResult == DialogResult.Yes)
                    {
                        txtMaKH.Focus();
                        model_kh model_KH = new model_kh();
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
                }
            }
        public void init()     
        {
            ConnectToMySQL conn = new ConnectToMySQL();
            data = qlkh_bus.getThongTinKhachHang();
            DSKhachHang.DataSource = data;
            DSKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            DSKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            DSKhachHang.Columns[2].HeaderText = "Số CMND";
            DSKhachHang.Columns[3].HeaderText = "Phone Number";
            DSKhachHang.Columns[4].HeaderText = "Địa chỉ";
            DSKhachHang.Columns[5].HeaderText = "Email";
            DSKhachHang.Columns[6].HeaderText = "Ngày Tạo";
            DSKhachHang.Columns[7].HeaderText = "Điểm Số";


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
            txtDiemSo.Enabled = true;
            btnThem.Visible = false;
            txtMaKH.Text = DSKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = DSKhachHang.CurrentRow.Cells[1].Value.ToString();
            NgayTao.Text = DSKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtCMND.Text = DSKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = DSKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = DSKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = DSKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtDiemSo.Text = DSKhachHang.CurrentRow.Cells[7].Value.ToString();


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
                    //view.RowFilter = txtTimKiem.Text;
                    //view.RowStateFilter = DataViewRowState.Unchanged;

                }

            }
            catch
            {

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Equals("")==false)
            {
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn xóa khách hàng không ?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { }
                if (dialogResult == DialogResult.Yes)
                {
                    int Makh = int.Parse(DSKhachHang.CurrentRow.Cells[0].Value.ToString());
                    qlkh_bus.updateTrangThaiKhachHangHuy(Makh);
                    resetForm();
                    init();
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkLoi())
            {
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn thêm khách hàng không ?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { }
                if (dialogResult == DialogResult.Yes)
                {
                    txtMaKH.Focus();
                    model_kh model_KH = new model_kh();
                    model_KH.Makh = Int32.Parse(txtMaKH.Text);
                    model_KH.Tenkh = txtTenKH.Text;
                    model_KH.Cmnd = txtCMND.Text;
                    model_KH.SDT = txtSDT.Text;
                    model_KH.DiaChi = txtDiaChi.Text;
                    model_KH.Email = txtEmail.Text;
                    model_KH.Ngaytao = NgayTao.Value;
                    model_KH.Diemso = int.Parse(txtDiemSo.Text);
                    model_KH.Trangthai = "T";

                    qlkh_bus.updateKhachHang(model_KH);
                    resetForm();
                    init();
                }
            }

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            txtDiemSo.Text = "0";
            btnThem.Visible = true;
            resetForm();
            txtDiemSo.Enabled=false;
        }
    }
}
