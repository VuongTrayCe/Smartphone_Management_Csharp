using Smartphone_Management.DAO;
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
    internal class QuanLyDonDatHang_BUS
    {
        QuanLyDonDatHang_DAO qlddh_dao = new QuanLyDonDatHang_DAO();
        // Hàm lấy thông tin đơn hàng 
        public DataTable getThongTinDonDatHang(String status,DateTime dateStart,DateTime DateEnd,String strKeyWord)
        {
            DataTable data = new DataTable();
            DataTable data2 = qlddh_dao.getThongTinDonDatHang(status);

            data.Columns.Add("STT");
            data.Columns.Add("Ngày Đặt", Type.GetType("System.DateTime"));
            data.Columns.Add("Mã đơn Hàng");
            data.Columns.Add("Tên Khách Hàng");
            data.Columns.Add("Số Lượng");
            data.Columns.Add("Điểm Áp Dụng");
            data.Columns.Add("Điểm Thưởng");
            data.Columns.Add("Tổng Tiền");
            data.Columns.Add("Tên Nhân Viên");
            // Kiểm tra đơn hàng có đúng với từ khóa/ngày/ trạng thái tìm kiếm hay không 
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                String madh =  data2.Rows[i][1].ToString();
                DateTime dateDat = (DateTime)data2.Rows[i][0];
                if (dateDat > dateStart && dateDat < DateEnd && strKeyWord.Equals(""))
                {
                    //dataGridView1.Rows.Add(1) ;
                    DataRow row = data.NewRow();
                    //foreach (DataColumn col in data2.Columns)
                    //{
                    //    row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    //}
                    for (int j = 0; j < data2.Columns.Count; j++)
                    {
                        row[j+1] = data2.Rows[i][j];
                    }
                    data.Rows.Add(row);
                }
               else if( dateDat > dateStart && dateDat < DateEnd && madh.Equals(strKeyWord))
                {
                    DataRow row = data.NewRow();
                    //foreach (DataColumn col in data2.Columns)
                    //{
                    //    row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    //}
                       for (int j = 0; j < data2.Columns.Count; j++)
                    {
                        row[j+1] = data2.Rows[i][j];
                    }
                    data.Rows.Add(row);
                }
            }
            return data ;
        }
        // update dơn hàng hủy
        internal void updateDonHangHuy(int madh)
        {
            qlddh_dao.updateTrangThaiDonHangHuy(madh);

        }
        // Update lại trạng thái đơn hàng
        internal void updateDonHang(int madh)
        {
            int diemthuong = qlddh_dao.getDiemThuongDonHang(madh);
            int makh = qlddh_dao.getMaKhachHang(madh);
            int diemhientai = qlddh_dao.getDiemHienTaiKhachHang(makh);
            qlddh_dao.UpdateDiemKhachHang(makh, diemhientai + diemthuong);
            qlddh_dao.updateTrangThaiDonHang(madh);
        }

        // lấy thông tin chi tiết của một đơn hàng
        internal DataTable getChiTietDonHang(int madh)
        {
            DataTable data = new DataTable();
            DataTable data2 = qlddh_dao.getChiTietDonHang_DAO(madh);
            data.Columns.Add("STT");
            data.Columns.Add("Masp");
            data.Columns.Add("Tensp");
            data.Columns.Add("Soluong");
            data.Columns.Add("giaban");
            data.Columns.Add("KhuyenMai");
            data.Columns.Add("BaoHanh");
            data.Columns.Add("ThanhTien");

            int tongsl = 0;
             Double tongtien = 0;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                    //dataGridView1.Rows.Add(1) ;
                    DataRow row = data.NewRow();
                    foreach (DataColumn col in data2.Columns)
                    {
                        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    }
                int soluong = int.Parse( data2.Rows[i][2].ToString());
                Double thanhtien = Double.Parse(data2.Rows[i][6].ToString());
                  
                tongsl = tongsl + soluong;
                tongtien += thanhtien;
                data.Rows.Add(row);
            }
            for(int i=0;i<data.Rows.Count;i++)
            {
                data.Rows[i][0] = i + 1;
            }
            DataRow row2 = data.NewRow();

            row2["Tensp"] = "Tổng Hàng";
            row2["Soluong"] = tongsl;
            row2["ThanhTien"] = tongtien;

            data.Rows.InsertAt(row2,0);

            return data;
        }



        public Boolean CompareDate(DateTime dateTiem1,DateTime dateTime2)
        { 
            return dateTiem1 > dateTime2;
        }
        public DateTime ConvertStringtoDateTime(String date)
        {
            //MessageBox.Show(dateTime.ToString());
            DateTime dateTimeObj;

            CultureInfo provider = CultureInfo.InvariantCulture;
            bool isSuccess = DateTime.TryParseExact(date, "yyyy-MM-dd", provider, DateTimeStyles.None, out dateTimeObj);
            return dateTimeObj;
        }

        internal string getImageSanPham(int masp)
        {
            return qlddh_dao.getImageSanPham(masp);
        }

        internal void UpdateSoLuongSanPham(int masp, int soluong)
        {
            int soluonghientai = qlddh_dao.getSoLuongHienTai(masp);
            qlddh_dao.UpdateSoluongSanPham(masp, soluong+soluonghientai);
        }

        internal void updateDiemKhachHang(int madh)
        {
            int makhachhang = qlddh_dao.getMaKhachHang(madh);
            int sodiemhientai = qlddh_dao.getDiemHienTaiKhachHang(makhachhang);
            int diemdadung = qlddh_dao.getDiemDaDung(madh);
            qlddh_dao.UpdateDiemKhachHang(makhachhang, diemdadung + sodiemhientai);
        }
    }
}
