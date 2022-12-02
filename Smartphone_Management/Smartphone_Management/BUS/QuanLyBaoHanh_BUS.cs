using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.BUS
{
    
    internal class QuanLyBaoHanh_BUS
    {
        QuanLyBaoHanh_DAO qlbh = new QuanLyBaoHanh_DAO();

        internal void AddBaoHanh(string thoigianbaohanh, string trangthai)
        {
            qlbh.AddBaoHanh(thoigianbaohanh, trangthai);
        }

        internal void AddChiTietBaoHanh(int mabh, int masp)
        {
            qlbh.UpdateTrangThaiChiTietCu(masp);
            qlbh.AddChiTietBaoHanh(mabh, masp);
        }

        internal void deleteBaoHanh(int mabh)
        {
            qlbh.deleteBaoHanh(mabh);
        }

        internal void deleteChiTietBaoHanh(int mactbh)
        {
            qlbh.deleteChiTietBaoHanh(mactbh);
        }

        internal List<int> getAllMaBaoHanh()
        {
            return qlbh.getALLMaBaoHanh();
        }

        internal List<List<String>> getAllMaSanPham()
        {
            return qlbh.getAllMaSanPham();
        }

        internal DataTable getInForBaoHanh()
        {
            return qlbh.getInForBaoHanh();
        }

        internal DataTable getInforChiTietBaoHanh()
        {
            return qlbh.getInForChiTietBaoHanh();
        }

        internal void UpdateBaoHanh(int mabh, string text1, string text2)
        {
            qlbh.UpdateBaoHanh(mabh, text1, text2);
        }
    }
}
