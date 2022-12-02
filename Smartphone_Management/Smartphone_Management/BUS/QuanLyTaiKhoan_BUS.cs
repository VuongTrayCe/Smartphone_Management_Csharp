using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Smartphone_Management.BUS
{
    internal class QuanLyTaiKhoan_BUS
    {
        QuanLyTaiKhoan_DAO qltk_DAO = new QuanLyTaiKhoan_DAO();


        public DataTable TimKiemTaiKhoan_BUS(string text)
        {
            return qltk_DAO.TimKiemTaiKhoan_DAO(text);
        }

        public DataTable TimKiemTaiKhoanTheoTrangThai(string text, string trangthai)
        {
            return qltk_DAO.TimKiemTaiKhoanTheoTrangThai_DAO(text, trangthai);
        }



        public void ShowThuocTinhChucDanhCombobox(ComboBox cb)
        {

            String query = "SELECT Tenquyen FROM quyen ";
            String thuocTinh = "Tenquyen";

            qltk_DAO.DataProperty2(query, thuocTinh, cb);
        }

        public void ShowThuocTinhNhanVienConHoatDong(ComboBox cb)
        {
            String query = "SELECT nhanvien.Manv, nhanvien.Tennv FROM nhanvien WHERE nhanvien.Manv NOT IN (SELECT taikhoan.Manv FROM taikhoan) AND nhanvien.Trangthai LIKE '%T%' ";
            String thuocTinh = "Tennv";
            qltk_DAO.DataProperty(query, thuocTinh, cb);
        }

        public DataTable getThongTinCacTaiKhoan_BUS()
        {
            return qltk_DAO.getThongTinCacTaiKhoan_DAO();
        }

        public DataTable getThongTinCacTaiKhoanTatHoatDong_BUS()
        {
            return qltk_DAO.getThongTinCacTaiKhoanTatHoatDong_DAO();
        }

        public DataTable getThongTinCacTaiKhoanDangHoatDong_BUS()
        {
            return qltk_DAO.getThongTinCacTaiKhoanDangHoatDong_DAO();
        }

        public void getCacTaiKhoanDangHoatDong_BUS(ComboBox cb)
        {

            String query = "SELECT Matk, Tendangnhap FROM taikhoan WHERE Trangthai LIKE '%T%' ";
            qltk_DAO.DataPropertyTaiKhoanDangHoatDong(query, cb);
        }

        public void themNhanVien(nhanvien nv)
        {
            //if ((nv.checkTennv(nv.TenNv) && nv.checkSoCCCD(nv.SoCCCD) && nv.checkTuoi(nv.Tuoi) && nv.checkDiaChi(nv.DiaChi)) == true)
            //{
                qltk_DAO.themMotNhanVien(nv);

        //}
         }

        public void themTaiKhoan(string queryMaNV,string timeNow, taikhoan tk)
        {
            string[] Manv = queryMaNV.Split('-');
            qltk_DAO.themMotTaiKhoan(Manv[1],timeNow, tk);
        }

        public void XoaTaiKhoan_BUS(int Matk)
        {
            qltk_DAO.XoaTaiKhoan_DAO(Matk);
        }
        public void DangNhap_BUS(taikhoan tk)
        {
            qltk_DAO.DangNhapTaiKhoan(tk);
        }
    }
}
