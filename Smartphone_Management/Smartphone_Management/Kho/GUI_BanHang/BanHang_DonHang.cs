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
using static Smartphone_Management.UIMain;

namespace Smartphone_Management.GUI.GUI_BanHang
{
    public partial class BanHang_DonHang : Form
    {
        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* CLASS HỖ TRỢ *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private static BanHangBUS banHangBUS = new BanHangBUS();
        private static SanPhamBUS sanPhamBUS = new SanPhamBUS();

        public List<CartItem> cartItems { set; get; }

        public BanHang_DonHang(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;

            int TongSoLuong = 0;
            double TongTien = 0;
            double TongTienKM = 0;
            for (int i = 0; i < cartItems.Count; i++)
            {
                DonHang_DanhSachSanPham.Rows.Add();
                SanPhamDTO sp = sanPhamBUS.getSanPhamByID(cartItems[i].MaSP);
                int Khuyenmai = banHangBUS.getPTKhuyenMaiByMaSP(sp.Masp);
                string Baohanh = banHangBUS.getTGBaoHanhByMaSP(sp.Masp);
                double Giaban = banHangBUS.getGiaBanByMaSP(sp.Masp);                
                DonHang_DanhSachSanPham.Rows[i].Cells[0].Value = sp.Masp;
                DonHang_DanhSachSanPham.Rows[i].Cells[1].Value = sp.Tensp;
                DonHang_DanhSachSanPham.Rows[i].Cells[2].Value = Giaban;
                DonHang_DanhSachSanPham.Rows[i].Cells[3].Value = cartItems[i].SoLuong;
                DonHang_DanhSachSanPham.Rows[i].Cells[4].Value = Khuyenmai;
                if(Baohanh.Equals(""))
                {
                    DonHang_DanhSachSanPham.Rows[i].Cells[5].Value = "Không có";
                } else
                {
                    DonHang_DanhSachSanPham.Rows[i].Cells[5].Value = Baohanh;
                }

                TongSoLuong += cartItems[i].SoLuong;
                TongTien += cartItems[i].SoLuong * Giaban;
                if(Khuyenmai > 0)
                {
                    TongTienKM += cartItems[i].SoLuong * (Giaban - (Giaban * Khuyenmai / 100));
                } else
                {
                    TongTienKM += 0;
                }
            }
            DonHang_SoLuong.Text = TongSoLuong.ToString();
            DonHang_TongTien.Text = TongTien.ToString() + " VND";
            DonHang_GiaSauKM.Text = (TongTien - TongTienKM).ToString() + " VND";
            DonHang_ThanhToan.Text = (TongTien - TongTienKM).ToString() + " VND";
            DonHang_ThanhToan_Const.Text = (TongTien - TongTienKM).ToString();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* HÀM HỖ TRỢ *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private string getToday()
        {
            string date = DateTime.Now.ToString();
            string[] dateSplit = date.Split(' ');
            string month = dateSplit[0].Split('/')[0];
            string day = dateSplit[0].Split('/')[1];
            string year = dateSplit[0].Split('/')[2];
            return year + "-" + month + "-" + day;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LOAD FORM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void BanHang_DonHang_Load(object sender, EventArgs e)
        {
            DonHang_NgayBan.Text = getToday();

            List<int> listMaKH = banHangBUS.getAllMaKhachHang();
            DonHang_DropDown_TenKhachHang.Items.Clear();
            DonHang_DropDown_TenKhachHang.Text = listMaKH[0] + " - " + banHangBUS.getTenKhachHangByMaKH(listMaKH[0]);
            for (int i = 0; i < listMaKH.Count; i++)
            {
                string TenKH = banHangBUS.getTenKhachHangByMaKH(listMaKH[i]);
                DonHang_DropDown_TenKhachHang.Items.Add(listMaKH[i] + " - " + TenKH);
            }
            int DiemApDung = banHangBUS.getDiemSoKhachHangByMaKH(listMaKH[0]);
            DonHang_DiemApDung.Text = DiemApDung.ToString();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM ĐƠN HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void DonHang_Button_HoanThanh_Click(object sender, EventArgs e)
        {
            int MaKH = Int32.Parse(DonHang_DropDown_TenKhachHang.Text.Split('-')[0].Trim());
            int MaNV = manv;
            string NgayBan = getToday();
            int SoLuong = Int32.Parse(DonHang_SoLuong.Text);
            double TongTien = Double.Parse(DonHang_ThanhToan.Text.Split(' ')[0].Trim());
            int DiemApDung = Int32.Parse(DonHang_DiemApDungSuDung.Text);
            int DiemThuong = SoLuong * 200000;
            string TrangThai = "Đặt Hàng";

            /*-*-*-*-*-*-*-*-*-* UPDATE LẠI ĐIỂM SỐ KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*/
            if (DonHang_CheckBox_ApDungDiem.Checked)
            {
                int DiemSoKH = Int32.Parse(DonHang_DiemApDung.Text);
                int DiemConLai = (DiemSoKH + DiemThuong) - DiemApDung;
                banHangBUS.updateDiemSoByMaKH(DiemConLai, MaKH);
            } else
            {
                int DiemSoKH = Int32.Parse(DonHang_DiemApDung.Text);
                int DiemConLai = DiemSoKH + DiemThuong;
                banHangBUS.updateDiemSoByMaKH(DiemConLai, MaKH);
            }

            /*-*-*-*-*-*-*-*-*-* UPDATE LẠI SỐ LƯỢNG CÁC SẢN PHẨM *-*-*-*-*-*-*-*-*-*/
            for (int i = 0; i < cartItems.Count; i++)
            {
                int Masp = cartItems[i].MaSP;
                int SoLuongSP = banHangBUS.getSoLuongSanPhamByMaSP(Masp);
                banHangBUS.updateSoLuongSPByMaSP(SoLuongSP - cartItems[i].SoLuong, Masp);
            }

            /*-*-*-*-*-*-*-*-*-* LƯU THÔNG TIN ĐƠN HÀNG *-*-*-*-*-*-*-*-*-*/
            banHangBUS.insertDonHang(MaKH, MaNV, NgayBan, SoLuong, TongTien, DiemApDung, DiemThuong, TrangThai);

            /*-*-*-*-*-*-*-*-*-* LƯU CHI TIẾT ĐƠN HÀNG *-*-*-*-*-*-*-*-*-*/
            int Madh = banHangBUS.getMaDonHangVuaThem();
            for (int i = 0; i < cartItems.Count; i++)
            {
                int Masp = cartItems[i].MaSP;
                int SoLuongSP = cartItems[i].SoLuong;
                int Machitietkhuyenmai = banHangBUS.getMaCTKMByMaSP(Masp);
                int Machitietbaohanh = banHangBUS.getMaCTBHByMaSP(Masp);
                int Magiasp = banHangBUS.getMaGiaSPByMaSP(Masp);
                double Giaban = banHangBUS.getGiaBanByMaSP(Masp);
                int KhuyenMai = banHangBUS.getPTKhuyenMaiByMaSP(Masp);
                double GiaSauKM = Giaban - (Giaban * KhuyenMai / 100);
                banHangBUS.insertChiTietDonHang(Masp, Madh, Machitietkhuyenmai, Machitietbaohanh, Magiasp, SoLuongSP, Giaban, GiaSauKM);
            }
            MessageBox.Show("Tạo đơn hàng thành công!");
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* OPEN THÊM KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void DonHang_Button_ThemKhachHang_Click(object sender, EventArgs e)
        {
            new BanHang_ThemKhachHang().Show();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* ĐÓNG FORM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void DonHang_Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* TẢI LẠI ĐIỂM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void DonHang_DropDown_TenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenKH = DonHang_DropDown_TenKhachHang.Text;
            int MaKH = Int32.Parse(TenKH.Split('-')[0].Trim());

            int DiemApDungKH = banHangBUS.getDiemSoKhachHangByMaKH(MaKH);
            DonHang_DiemApDung.Text = DiemApDungKH.ToString();

            double ThanhToanConst = Double.Parse(DonHang_ThanhToan_Const.Text);
            int DiemApDung = Int32.Parse(DonHang_DiemApDung.Text);

            if (DonHang_CheckBox_ApDungDiem.Checked)
            {
                if (DiemApDung > ThanhToanConst)
                {
                    DonHang_ThanhToan.Text = 0 + " VND";
                    DonHang_DiemApDungSuDung.Text = ((int) ThanhToanConst).ToString();
                }
                if (DiemApDung < ThanhToanConst)
                {
                    DonHang_ThanhToan.Text = (ThanhToanConst - DiemApDung) + " VND";
                    DonHang_DiemApDungSuDung.Text = ((int) DiemApDung).ToString();
                }
                if (DiemApDung == ThanhToanConst)
                {
                    DonHang_ThanhToan.Text = 0 + " VND";
                    DonHang_DiemApDungSuDung.Text = ((int) DiemApDung).ToString();
                }
            }
            else
            {
                DonHang_ThanhToan.Text = ThanhToanConst.ToString() + " VND";
                DonHang_DiemApDungSuDung.Text = "0";
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* ÁP DỤNG ĐIỂM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void DonHang_CheckBox_ApDungDiem_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            /**
             Các trường hợp điểm áp dụng có thể gặp phải:
             (1) DiemApDung > ThanhToan (100 > 50) => DiemApDung = 50; ThanhToan = 0; DiemApDungSuDung = 50;
             (2) DiemApDung < ThanhToan (50 < 100) => DiemApDung = 50; ThanhToan = 50; DiemApDungSuDung = 50;
             (3) DiemApDung = ThanhToan (50 = 50) => DienApDung = 50; ThanhToan = 0; DiemApDungSuDung = 50;
             */

            double ThanhToanConst = Double.Parse(DonHang_ThanhToan_Const.Text);
            int DiemApDung = Int32.Parse(DonHang_DiemApDung.Text);

            if(DonHang_CheckBox_ApDungDiem.Checked)
            {
                if(DiemApDung > ThanhToanConst)
                {
                    DonHang_ThanhToan.Text = 0 + " VND";
                    DonHang_DiemApDungSuDung.Text = ((int) ThanhToanConst).ToString();
                }
                if(DiemApDung < ThanhToanConst)
                {
                    DonHang_ThanhToan.Text = (ThanhToanConst - DiemApDung) + " VND";
                    DonHang_DiemApDungSuDung.Text = ((int) DiemApDung).ToString();
                }
                if(DiemApDung == ThanhToanConst)
                {
                    DonHang_ThanhToan.Text = 0 + " VND";
                    DonHang_DiemApDungSuDung.Text = ((int) DiemApDung).ToString();
                }
            } else
            {
                DonHang_ThanhToan.Text = ThanhToanConst.ToString() + " VND";
                DonHang_DiemApDungSuDung.Text = "0";
            }
        }
    }
}
