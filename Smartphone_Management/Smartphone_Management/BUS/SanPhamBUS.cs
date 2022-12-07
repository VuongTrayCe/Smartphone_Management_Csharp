
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.ValidateData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.BUS
{
    internal class SanPhamBUS
    {
        private static SanPhamDAO sanphamDAO = new SanPhamDAO();
        private static ValidateData validateData = new ValidateData();
        public DataTable getDataTableSanPham()
        {
            return sanphamDAO.getDataTableSanPham();
        }

        public List<SanPhamDTO> getFullDataSanPham()
        {
            return sanphamDAO.getFullDataSanPham();
        }

        public List<string> getAllLoaiSanPham()
        {
            return sanphamDAO.getAllLoaiSanPham();
        }

        public List<string> getAllMaNhaCungCap()
        {
            return sanphamDAO.getAllMaNhaCungCap();
        }

        public SanPhamDTO getSanPhamByID(int Masp)
        {
            return sanphamDAO.getSanPhamByID(Masp);
        }

        public void insertSanPham(SanPhamDTO sanphamDTO)
        {
            sanphamDAO.insertSanPham(sanphamDTO);
        }

        public void updateSanPham(SanPhamDTO sanphamDTO)
        {
            sanphamDAO.updateSanPham(sanphamDTO);
        }

        public void deleteSanPham(int Masp)
        {
            sanphamDAO.deleteSanPham(Masp);
        }

        public DataSet getDataSetSanPham()
        {
            return sanphamDAO.getDataSetSanPham();
        }

        public int getMaSanPhamCuoiCung()
        {
            return sanphamDAO.getMaSanPhamCuoiCung();
        }

        public bool checkMaNhaCungCapExists(int Mancc)
        {
            return sanphamDAO.checkMaNhaCungCapExists(Mancc);
        }

        public string checkInputSanPham(string Tensp, string Loaisp,string MauSac, string Namsx, string ThongSo, string Mancc)
        {
            string errorMessage = "";
            /*-*-*-*-*-*-*-*-* Kiểm tra nhập đầy đủ thông tin hay không *-*-*-*-*-*-*-*-*/
            if (Tensp.Equals("")) { errorMessage = "Tên sản phẩm không được để rỗng!"; return errorMessage; }
            if (Loaisp.Equals("")) { errorMessage = "Loại sản phẩm không được để rỗng!"; return errorMessage; }
            if (MauSac.Equals("")) { errorMessage = "Màu sắc sản phẩm không được để rỗng!"; return errorMessage; }
            if (Namsx.Equals("")) { errorMessage = "Năm sản xuất không được để rỗng!"; return errorMessage; }
            if (ThongSo.Equals("")) { errorMessage = "Thông số sản phẩm không được để rỗng!"; return errorMessage; }
            if (Mancc.Equals("")) { errorMessage = "Mã nhà cung cấp không được để rỗng!"; return errorMessage; }
            /*-*-*-*-*-*-*-*-* Kiểm tra thông tin hợp lệ hay không *-*-*-*-*-*-*-*-*/
            if (Tensp.Length <= 4) { errorMessage = "Tên sản phẩm phải nhiều hơn 4 ký tự!"; return errorMessage; }
            if(!validateData.validatePosiTntDifferentZero(Namsx)) { errorMessage = "Năm sản xuất không hợp lệ!"; return errorMessage; }
            if(!validateData.validatePosiTntDifferentZero(Mancc)) { errorMessage = "Mã nhà cung cấp không hợp lệ!"; return errorMessage; }
            if(!checkMaNhaCungCapExists(Int32.Parse(Mancc))) { errorMessage = "Mã nhà cung cấp không tồn tại!"; return errorMessage; }
            return errorMessage;
        }

        internal void insertKMBH(int v)
        {
            sanphamDAO.insertKM(v);
            sanphamDAO.insertBH(v);
        }
    }
}
