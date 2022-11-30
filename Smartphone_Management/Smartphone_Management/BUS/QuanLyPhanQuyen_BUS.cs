using MySql.Data.MySqlClient;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.BUS
{
    internal class QuanLyPhanQuyen_BUS
    {
        ConnectToMySQL sqla = new ConnectToMySQL();
        QuanLyPhanQuyen_DAO qlpq_DAO = new QuanLyPhanQuyen_DAO();

        public DataTable getQuyen_BUS()
        {
            return qlpq_DAO.getQuyen_DAO();
        }

        public DataTable getQuyen_Taikhoan_BUS()
        {
            return qlpq_DAO.getQuyen_TaiKhoan_DAO();
        }

        public DataTable TimKiemQuyen_BUS(string text)
        {
            return qlpq_DAO.TimKiemQuyen_DAO(text);
        }


        public DataTable TimKiemQuyen_TaiKhoan_BUS(string text)
        {
            return qlpq_DAO.TimKiemQuyen_TaiKhoan_DAO(text);
        }

        public void ThemQuyen_BUS(quyen q)
        {
            qlpq_DAO.ThemQuyen_DAO(q);
        }

        public void showThuocTinhMaTaiKhoan(ComboBox cb)
        {
            String query = "SELECT taikhoan.Matk, taikhoan.Tendangnhap FROM taikhoan WHERE taikhoan.Matk NOT IN (SELECT Matk FROM quyen_tk) ";

            qlpq_DAO.DataPropertyMaTaiKhoan(query, cb);
        }

        public void showThuocTinhMaTaiKhoan2(ComboBox cb)
        {
            String query = "SELECT taikhoan.Matk, taikhoan.Tendangnhap, taikhoan.Manv FROM taikhoan WHERE taikhoan.Matk IN (SELECT Matk FROM quyen_tk) ";

            qlpq_DAO.DataPropertyMaTaiKhoan(query, cb);
        }

        public void showThuocTinhMaQuyen(ComboBox cb)
        {
            String query = "SELECT quyen.Maquyen, quyen.Tenquyen FROM quyen ";

            qlpq_DAO.DataPropertyMaQuyen(query, cb);
        }


        public void ThemQuyen_TK_BUS(quyen_taikhoan q_tk)
        {
  
            qlpq_DAO.ThemQuyen_TK_DAO(q_tk);
        }

        public void ThaydoiQuyen_Taikhoan_BUS(quyen_taikhoan q_tk)
        {

            qlpq_DAO.ThaydoiQuyen_Taikhoan_DAO(q_tk);
        }

        public void ThaydoiChucVu_BUS(int maNV, string tenQuyen)
        {
            qlpq_DAO.ThaydoiChucVu_DAO(maNV, tenQuyen);
        }
    }
}
