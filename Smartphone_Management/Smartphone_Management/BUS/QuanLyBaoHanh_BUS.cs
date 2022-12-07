using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        internal DataTable getThongTinBaoHanh()
        {
            DataTable data = qlbh.getThongTinBaoHanh();
            data.Columns.Add("Thời gian còn lại");
            for(int i=0;i<data.Rows.Count;i++)
            {
                DateTime ngayban = (DateTime)data.Rows[i][5];
                var today = DateTime.Today.ToString("yyyy-MM-dd");
                int sothangbaohanh = int.Parse(data.Rows[i][6].ToString().Split(' ')[0]);
                DateTime ngayhientai = DateTime.Parse(today);
                DateTime ngaycuoibaohanh =  ngayban.AddMonths(sothangbaohanh);
                //ngaynhap2.AddDays()
                //lbNgayNhap.Text = String.Format("{0:yyyy-MM-dd}", ngaynhap2);
                int day = ngaycuoibaohanh.Subtract(ngayhientai).Days;
                //MessageBox.Show(day.ToString());
                if(day > 0)
                {
                    data.Rows[i][7] = day;

                }
                else
                {
                    data.Rows[i][7] = 0;
                }
            }
            return data;
        }

        internal void UpdateBaoHanh(int mabh, string text1, string text2)
        {
            qlbh.UpdateBaoHanh(mabh, text1, text2);
        }
    }
}
