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
    internal class QuanLyKhuyenMai_BUS
    {
        QuanLyKhuyenMai_DAO qlkm_DAO = new QuanLyKhuyenMai_DAO();

        public DataTable getThongTinCacKhuyenMai_BUS()
        {
            return qlkm_DAO.getThongTinCacKhuyenMai_DAO();
        }
        public DataTable getThongTinCacChiTietKhuyenMai_BUS()
        {
            return qlkm_DAO.getThongTinCacChiTietKhuyenMai_DAO();
        }

        public DataTable TimKiemKM_BUS(string text)
        {
            return qlkm_DAO.TimKiemKM_DAO(text);
        }

        public DataTable TimKiemChiTietKM_BUS(string text)
        {
            return qlkm_DAO.TimKiemChiTietKM_DAO(text);
        }

        public void showThuocTinhMaKM_BUS(ComboBox cb)
        {
            String query = "SELECT khuyenmai.Makm, khuyenmai.Tenkm FROM khuyenmai ";

            qlkm_DAO.showThuocTinhMaKM_DAO(query, cb);
        }

        public void showThuocTinhSanPham_BUS(ComboBox cb)
        {
            String query = "SELECT  sanpham.Masp,sanpham.Tensp FROM sanpham WHERE sanpham.Masp NOT IN (SELECT chitietkhuyenmai.Masp FROM chitietkhuyenmai) ";

            qlkm_DAO.showThuocTinhSanPham_DAO(query, cb);

        }

        public void ThemChiTietKM_BUS(chitietkhuyenmai ctkm)
        {
            qlkm_DAO.ThemChiTietKM_DAO(ctkm);
        }



        //public void ThemChiTietKM_BUS(chitietkhuyenmai ctkm, string querySanPham)
        //{
        //    qlkm_DAO.ThemChiTietKM_DAO(ctkm, querySanPham);
        //}

        public void XoaChiTietKMSP_BUS(int MaChiTietKM)
        {
            qlkm_DAO.XoaChiTietKMSP_DAO(MaChiTietKM);
        }

        public void ThemKM_BUS(khuyenmai km)
        {
            qlkm_DAO.ThemKM_DAO(km);
        }

        public void XoaKM_BUS(int MaChiTietKM)
        {
            qlkm_DAO.XoaKM_DAO(MaChiTietKM);
        }

        public void CapNhatKM_BUS(khuyenmai km, int maKM)
        {
            qlkm_DAO.CapNhatKM_DAO(km, maKM);
        }
    }
}
