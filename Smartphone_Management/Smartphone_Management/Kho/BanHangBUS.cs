using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.ValidateData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.BUS
{
    internal class BanHangBUS
    {
        private static BanHangDAO banHangDAO = new BanHangDAO();
        private static ValidateData validateData = new ValidateData();
        public List<SanPhamDTO> searchSanPham(string search)
        {
            return banHangDAO.searchSanPham(search);
        }

        public string getTGBaoHanhByMaSP(int Masp)
        {
            return banHangDAO.getTGBaoHanhByMaSP(Masp);
        }

        public int getPTKhuyenMaiByMaSP(int Masp)
        {
            return banHangDAO.getPTKhuyenMaiByMaSP(Masp);
        }

        public string getTenNhaCungCapMaSP(int Masp)
        {
            return banHangDAO.getTenNhaCungCapMaSP(Masp);
        }

        public double getGiaBanByMaSP(int Masp)
        {
            return banHangDAO.getGiaBanByMaSP(Masp);
        }

        public List<int> getAllMaKhachHang()
        {
            return banHangDAO.getAllMaKhachHang();
        }

        public string getTenKhachHangByMaKH(int Makh)
        {
            return banHangDAO.getTenKhachHangByMaKH(Makh);
        }

        public int getSoLuongSanPhamByMaSP(int Masp)
        {
            return banHangDAO.getSoLuongSanPhamByMaSP(Masp);
        }

        public int getDiemSoKhachHangByMaKH(int Makh)
        {
            return banHangDAO.getDiemSoKhachHangByMaKH(Makh);
        }

        public int getMaCTKMByMaSP(int Masp)
        {
            return banHangDAO.getMaCTKMByMaSP(Masp);
        }
        public int getMaCTBHByMaSP(int Masp)
        {
            return banHangDAO.getMaCTBHByMaSP(Masp);
        }

        public int getMaGiaSPByMaSP(int Masp)
        {
            return banHangDAO.getMaGiaSPByMaSP(Masp);
        }

        public int getMaDonHangVuaThem()
        {
            return banHangDAO.getMaDonHangVuaThem();
        }

        public void insertKhachHang(string Tenkh, string Cmnd, string SDT, string DiaChi, string Email, string Ngaytao, int Diemso, string TrangThai)
        {
            banHangDAO.insertKhachHang(Tenkh, Cmnd, SDT, DiaChi, Email, Ngaytao, Diemso, TrangThai);
        }

        public void insertDonHang(int Makh, int Manv, string Ngayban, int SoLuong, double Tongtien, int Diemapdung, int Diemthuong, string Trangthai)
        {
            banHangDAO.insertDonHang(Makh, Manv, Ngayban, SoLuong, Tongtien, Diemapdung, Diemthuong, Trangthai);
        }

        public void updateSoLuongSPByMaSP(int soluong, int Masp)
        {
            banHangDAO.updateSoLuongSPByMaSP(soluong, Masp);
        }

        public void updateDiemSoByMaKH(int Diemso, int Makh)
        {
            banHangDAO.updateDiemSoByMaKH(Diemso, Makh);
        }

        public void insertChiTietDonHang(int Masp, int Madh, int Machitietkhuyenmai, int Machitietbaohanh, int Magiasp, int Soluong, double giaban, double giasaukm)
        {
            banHangDAO.insertChiTietDonHang(Masp, Madh, Machitietkhuyenmai, Machitietbaohanh, Magiasp, Soluong, giaban, giasaukm);
        }

        public string checkInputKhachHang(string Tenkh, string Cmnd, string SDT, string Email, string DiaChi)
        {
            string errorMessage = "";
            /*-*-*-*-*-*-*-*-* Kiểm tra nhập đầy đủ thông tin hay không *-*-*-*-*-*-*-*-*/
            if (Tenkh.Equals("")) { errorMessage = "Tên khách hàng không được để rỗng!"; return errorMessage; }
            if (Cmnd.Equals("")) { errorMessage = "Số CMND không được để rỗng!"; return errorMessage; }
            if (SDT.Equals("")) { errorMessage = "Số điện thoại không được để rỗng!"; return errorMessage; }
            if (DiaChi.Equals("")) { errorMessage = "Địa chỉ không được để rỗng!"; return errorMessage; }
            /*-*-*-*-*-*-*-*-* Kiểm tra thông tin hợp lệ hay không *-*-*-*-*-*-*-*-*/
            if (Tenkh.Length <= 3) { errorMessage = "Tên khách hàng phải nhiều hơn 3 ký tự!"; return errorMessage; }
            if (!validateData.validateCMND(Cmnd)) { errorMessage = "Số CMND không hợp lệ!"; return errorMessage; }
            if (!validateData.validatePhone(SDT)) { errorMessage = "Số điện thoại không hợp lệ!"; return errorMessage; }
            if(!Email.Equals(""))
            {
                if (!validateData.validateEmail(Email)) { errorMessage = "Email không hợp lệ!"; return errorMessage; }
            } 
            if (DiaChi.Length <= 3) { errorMessage = "Địa chỉ phải nhiều hơn 3 ký tự!"; return errorMessage; }
             return errorMessage;
        }
    }
}
