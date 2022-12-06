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
    internal class QuanLyKhachHang_BUS
    {

        QuanLyKhachHang_DAO qlkh_dao = new QuanLyKhachHang_DAO();
        

     
        internal void updateTrangThaiKhachHangHuy(int makh)
        {
            qlkh_dao.updateTrangThaiKhachHangHuy(makh);
        }

        public DataTable getThongTinKhachHang()
        {
            
            DataTable data = new DataTable();
            data = qlkh_dao.getThongTinKhachhang();
            return data;
        }

       

        internal void updateKhachHang(model_kh model_kh)
        {
            qlkh_dao.updateKhachHang(model_kh);


        }


       /* internal string checkInputKH(string Makh, string Tenkh, string Cmnd, string SDT, string Diachi, string Email)
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

        internal void addKhachHang(model_kh model_KH)
        {
            qlkh_dao.addKhachHang(model_KH);
        }
    }
}
