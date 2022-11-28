using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.ValidateData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.BUS
{
    internal class GiaSanPhamBUS
    {
        private static GiaSanPhamDAO giaSanPhamDAO = new GiaSanPhamDAO();
        private static ValidateData validateData = new ValidateData();
        public void insertGiaSanPham(GiaSanPhamDTO giaSanPhamDTO)
        {
            giaSanPhamDAO.insertGiaSanPham(giaSanPhamDTO);
        }

        public List<GiaSanPhamDTO> getGiaByMaSanPham(int Masp)
        {
            return giaSanPhamDAO.getGiaByMaSanPham(Masp);
        }

        public void cancelGiaSanPham(int Masp)
        {
            giaSanPhamDAO.cancelGiaSanPham(Masp);
        }

        public string checkInputGiaSanPham(string Gianhap, string Giaban)
        {
            string errorMessage = "";
            /*-*-*-*-*-*-*-*-* Kiểm tra nhập đầy đủ thông tin hay không *-*-*-*-*-*-*-*-*/
            if (Gianhap.Equals("")) { errorMessage = "Giá nhập sản phẩm không được để rỗng!"; return errorMessage; }
            if (Giaban.Equals("")) { errorMessage = "Giá bán sản phẩm không được để rỗng!"; return errorMessage; }
            /*-*-*-*-*-*-*-*-* Kiểm tra thông tin hợp lệ hay không *-*-*-*-*-*-*-*-*/
            if (!validateData.validatePrice(Gianhap)) { errorMessage = "Giá nhập sản phẩm không hợp lệ!"; return errorMessage; }
            if (!validateData.validatePrice(Giaban)) { errorMessage = "Giá bán sản phẩm không hợp lệ!"; return errorMessage; }
            return errorMessage;
        }
    }
}
