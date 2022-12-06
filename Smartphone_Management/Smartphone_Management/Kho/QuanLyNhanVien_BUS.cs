using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smartphone_Management.BUS
{
    internal class QuanLyNhanVien_BUS
    {

        QuanLyNhanVien_DAO qlnv_dao = new QuanLyNhanVien_DAO();


       
        internal void updateTrangThaiKhachHangHuy(int manv)
        {
            qlnv_dao.updateTrangThaiNhanVienHuy(manv);
        }

        public DataTable getThongTinNhanVien()
        {

            DataTable data = new DataTable();
            data = qlnv_dao.getThongTinNhanVien();
            return data;
        }



        internal void updateNhanVien(model_nv model_nv)
        {
            qlnv_dao.updateNhanVien(model_nv);


        }


        /*internal string checkInputKH(string Makh, string Tenkh, string Cmnd, string SDT, string Diachi, string Email)
        {

            string errorMessage = "";
            *//*-*-*-*-*-*-*-*-* Kiểm tra nhập đầy đủ thông tin hay không *-*-*-*-*-*-*-*-*//*
            if (Makh.Equals("")) { errorMessage = "Mã khách hàng không được để rỗng!"; return errorMessage; }
            if (Tenkh.Equals("")) { errorMessage = "Tên không được để rỗng!"; return errorMessage; }
            if (Cmnd.Equals("")) { errorMessage = "Số CMND không được để rỗng!"; return errorMessage; }
            if (SDT.Equals("")) { errorMessage = "Số điện thoại không được để rỗng!"; return errorMessage; }
            if (Diachi.Equals("")) { errorMessage = "Địa chỉ không được để rỗng!"; return errorMessage; }
            if (Email.Equals("")) { errorMessage = "Email không được để rỗng!"; return errorMessage; }

            *//*-*-*-*-*-*-*-*-* Kiểm tra thông tin hợp lệ hay không *-*-*-*-*-*-*-*-*//*
            if (Tenkh.Length <= 4) { errorMessage = "Tên khách hàng phải nhiều hơn 4 ký tự!"; return errorMessage; }

            return errorMessage;

        }*/

        internal void addNhanVien(model_nv model_nv)
        {
            qlnv_dao.addNhanVien(model_nv);
        }
    }
}
