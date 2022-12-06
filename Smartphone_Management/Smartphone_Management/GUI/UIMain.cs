using FontAwesome.Sharp;
using Smartphone_Management.BUS;
using Smartphone_Management.GUI;
using Smartphone_Management.GUI.BaoHanh;
using Smartphone_Management.GUI.DonHang;
using Smartphone_Management.GUI.GUI_BanHang;
using Smartphone_Management.GUI.GUI_SanPham;
using Smartphone_Management.GUI.KhachHang;
using Smartphone_Management.GUI.Login;
using Smartphone_Management.GUI.Login.QuanLyQuyenTaiKhoan;
using Smartphone_Management.GUI.NhanVien;
using Smartphone_Management.GUI.ThongKe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace Smartphone_Management
{
    public partial class UIMain : Form
    {
        private IconButton currentBtn;
        public static int manv=1;
        private Color corlor = Color.FromArgb(0, 127, 0);
        private int FlagColor = 0;
        DangNhap formDangNhap;
        QuanLyTaiKhoan_BUS qltk = new QuanLyTaiKhoan_BUS();

       public int BanHang;
       public int PhieuNhap;
       public int SanPham;
       public  int DonHang;
       public  int ChinhSach;
       public int ConNguoi;
       public int ThongKe;
       public  int TaiKhoan;
        public void CheckQuyen(int manv1)
        {
            List<String> arrQuyen = new List<string>();
            this.BanHang = 0;
            this.SanPham = 0;
            this.DonHang = 0;
            this.PhieuNhap = 0;
            this.ConNguoi = 0;
            ThongKe = 0;
            TaiKhoan = 0;
            ChinhSach = 0;
            arrQuyen =  qltk.getALLQuyenTK(manv1);
            foreach(String s in arrQuyen)
            {
                if (s.Equals("Quản Lý"))
                {
                    BanHang = 1;
                    SanPham = 1;
                    DonHang = 1;
                    PhieuNhap = 1;
                    ConNguoi = 1;
                    ThongKe = 1;
                    TaiKhoan = 1;
                    ChinhSach = 1;
                }
                if (s.Equals("Bán Hàng"))
                {
                    BanHang = 1;
                }
                if (s.Equals("Đơn Hàng"))
                {
                    DonHang = 1;


                }
                if (s.Equals("Sản Phẩm"))
                {
                    SanPham = 1;
                }
                if (s.Equals("Phiếu Nhập"))
                {
                    PhieuNhap = 1;
                }
                if (s.Equals("Chính Sách"))
                {
                    ChinhSach = 1;

                }
                if (s.Equals("Con Người"))
                {
                    ConNguoi = 1;
                }
                if (s.Equals("Thống Kê"))
                {
                    ThongKe = 1;
                }
                if (s.Equals("Tài Khoản"))
                {
                    TaiKhoan = 1;
                }
            }
            if(SanPham==0 && PhieuNhap==0)
            {
                btnQuanLyHangHoa.Dispose();
            }
            if (BanHang == 0 && DonHang == 0)
            {
                btndatHang.Dispose();
            }

            if (SanPham == 0)
            {
                btnKhohang.Dispose();
            }
            if (PhieuNhap == 0)
            {
                btnTTPhieuNhap.Dispose();
            }
            if (BanHang==0)
            {
                btnTaoDonHang.Dispose();
            }
            if(DonHang==0)
            {
                btnQLDonDatHang.Dispose();
            }
            if (ConNguoi == 0)
            {
                btnConNguoi.Dispose();
            }
            if (ThongKe == 0)
            {
                btnThongKe.Dispose();
            }
            if (ChinhSach == 0)
            {
                btnChinhSach.Dispose();
            }
            if (TaiKhoan == 0)
            {
                btnHeThong.Dispose();
            }
        }

        public UIMain(int manv,string tennv,DangNhap formDangNhap)
        {
            InitializeComponent();
            UIMain.manv = manv;
            lbName.Text = tennv;
            CustomizeDising();
            this.formDangNhap = formDangNhap;
            CheckQuyen(manv);
            comboBox1.SelectedIndex = 0;
        }
        private void ActivateButton(Object sender,Color color)
        {
            if(sender!=null)
            {
                DisableButton();
                currentBtn=sender as IconButton;
                currentBtn.BackColor=Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign=ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

            }
        }
        private void DisableButton()
        {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11,7,17);
                currentBtn.ForeColor = Color.Gainsboro;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        private void CustomizeDising()
        {
            panelChinhSach_Sub.Visible = false;
            panelConNguoi_Sub.Visible = false;
            panelDatHang_Sub.Visible = false;
            panelHeThong_Sub.Visible = false;
            panelQuanLyHH_Sub.Visible = false;
            panelThongKe_Sub.Visible = false;
        }
        private void hidenSubMenu()
        {
            if (panelChinhSach_Sub.Visible == true)
            {
                panelChinhSach_Sub.Visible = false;
            }
            if (panelConNguoi_Sub.Visible == true)
            {
                panelConNguoi_Sub.Visible = false;
            }
            if (panelDatHang_Sub.Visible == true)
            {
                panelDatHang_Sub.Visible = false;
            }
            if (panelHeThong_Sub.Visible == true)
            {
                panelHeThong_Sub.Visible = false;
            }
            if (panelQuanLyHH_Sub.Visible == true)
            {
                panelQuanLyHH_Sub.Visible = false;
            }
            if (panelThongKe_Sub.Visible == true)
            {
                panelThongKe_Sub.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu == null)
            {
                hidenSubMenu();

            }
            else
            {
                if (subMenu.Visible == false)
                {
                    hidenSubMenu();
                    subMenu.Visible = true;
                }
                else
                {
                    subMenu.Visible = false;
                }
            }
        }
        private Form active = null;
        private void openChildForm(Form childForm)
        {
            if (active != null)
            {
                active.Close();
            }
            active = childForm;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelCenter.Controls.Add(childForm);
            childForm.BringToFront(); // Đưa panel lên đầu
            childForm.Show();
        }
        private void btnConNguoi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConNguoi_Sub);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, corlor);
            showSubMenu(null);
            //openChildForm(new Form1());

        }

        private void btndatHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDatHang_Sub);
            ActivateButton(sender, corlor);


        }

        private void btnQuanLyHangHoa_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanLyHH_Sub);
            ActivateButton(sender, corlor);
 

        }

        private void btnChinhSach_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChinhSach_Sub);
            ActivateButton(sender, corlor);


        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKe_Sub);
            ActivateButton(sender, corlor);

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHeThong_Sub);
            ActivateButton(sender, corlor);

        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            BanHang a = new BanHang();
            openChildForm(a);
        }

        private void btnQLDonDatHang_Click(object sender, EventArgs e)
        {
            QuanLyDonHang qldh = new QuanLyDonHang();
            openChildForm(qldh);
        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {
            SanPham1 a = new SanPham1();
            openChildForm(a);
            ////ChiTietDonHang a = new ChiTietDonHang();
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            themPhieuNhap a = new themPhieuNhap();
            openChildForm(a);
        }

        private void btnTTPhieuNhap_Click(object sender, EventArgs e)
        {
            thongTinPhieuNhap a = new thongTinPhieuNhap();
            openChildForm(a);
        }

        private void btnChinhSachKhuyenMai_Click(object sender, EventArgs e)
        {
            QuanLyKhuyenMai a = new QuanLyKhuyenMai();
            openChildForm(a);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==1)
            {
                this.Dispose();
                formDangNhap.Visible = true;

            }

        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan a = new QuanLyTaiKhoan();
            openChildForm(a);
        }

        private void btnPhanQuyenTaiKhoan_Click(object sender, EventArgs e)
        {
            QuanLyQuyenTaiKhoan1 a = new QuanLyQuyenTaiKhoan1();
            openChildForm(a);
        }

        private void btnChinhSachBaoHanh_Click(object sender, EventArgs e)
        {
            QuanLyBaoHanh a = new QuanLyBaoHanh();
            openChildForm(a);
        }

        private void btnDTBanHang_Click(object sender, EventArgs e)
        {
            ThongKeBaoCao_BanHang a = new ThongKeBaoCao_BanHang();
            openChildForm(a);
        }

        private void btnLNBanHang_Click(object sender, EventArgs e)
        {
            LoiNhuanBanHang a = new LoiNhuanBanHang();
            openChildForm(a);
        }

        private void btnDoanhThuNhapHang_Click(object sender, EventArgs e)
        {
            ThongKeBaoCao_NhapHang a = new ThongKeBaoCao_NhapHang();
            openChildForm(a);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien a = new QuanLyNhanVien();
            openChildForm(a);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang a = new QuanLyKhachHang();
            openChildForm(a);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            QuanLyNhaCungCap a = new QuanLyNhaCungCap();
            openChildForm(a);
        }
    }
}
