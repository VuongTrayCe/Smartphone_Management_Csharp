using MySqlConnector;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.DAO
{
    internal class BanHangDAO
    {

        private static ConnectToMySQL connectToMySQL = new ConnectToMySQL();

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* TÌM KIẾM SẢN PHẨM THEO MÃ VÀ TÊN *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal List<SanPhamDTO> searchSanPham(string search)
        {
            List<SanPhamDTO> listSP = new List<SanPhamDTO>(); 
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT * FROM sanpham WHERE (Masp LIKE '%" + search + "%' OR Tensp LIKE '%" + search + "%') AND TrangThai = 'T'";
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    SanPhamDTO sanphamDTO = new SanPhamDTO();
                    sanphamDTO.Masp = reader.GetInt32(0);
                    sanphamDTO.Tensp = reader.GetString(1);
                    sanphamDTO.Loaisp = reader.GetString(2);
                    sanphamDTO.soluong = reader.GetInt32(3);
                    sanphamDTO.MauSac = reader.GetString(4);
                    sanphamDTO.Namsx = reader.GetString(5);
                    sanphamDTO.TrangThai = reader.GetString(6);
                    sanphamDTO.Icon = reader.GetString(7);
                    sanphamDTO.ThongSo = reader.GetString(8);
                    sanphamDTO.Mancc = reader.GetInt32(9);
                    listSP.Add(sanphamDTO);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return listSP;
        }


        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY THỜI GIAN BẢO HÀNH DỰA VÀO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal string getTGBaoHanhByMaSP(int Masp)
        {
            string baoHanh = "";
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = 
                "SELECT Thoigianbaohanh FROM baohanh JOIN chitietbaohanh ON baohanh.Mabaohanh = chitietbaohanh.Mabaohanh " +
                "JOIN sanpham ON sanpham.Masp = chitietbaohanh.Masp WHERE sanpham.Masp = @Masp " +
                "AND sanpham.TrangThai = 'T' AND baohanh.TrangThai = 'T'AND chitietbaohanh.TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    baoHanh = reader.GetString(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return baoHanh;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY KHUYẾN MÃI DỰA VÀO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getPTKhuyenMaiByMaSP(int Masp)
        {
            int Khuyenmai = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText =
                "SELECT Ptkm FROM khuyenmai JOIN chitietkhuyenmai ON khuyenmai.Makm = chitietkhuyenmai.Makm " +
                "JOIN sanpham ON sanpham.Masp = chitietkhuyenmai.Masp WHERE sanpham.Masp = @Masp " +
                "AND sanpham.TrangThai = 'T' AND khuyenmai.TrangThai = 'T'\r\nAND chitietkhuyenmai.TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Khuyenmai = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return Khuyenmai;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY KHUYẾN MÃI DỰA VÀO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal string getTenNhaCungCapMaSP(int Masp)
        {
            string Nhacungcap = "";
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText =
               "SELECT Tenncc FROM sanpham JOIN nhacungcap ON sanpham.Mancc = nhacungcap.Mancc WHERE sanpham.Masp = @Masp " +
               "AND sanpham.TrangThai = 'T' AND nhacungcap.TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Nhacungcap = reader.GetString(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return Nhacungcap;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY GIÁ BÁN DỰA VÀO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal double getGiaBanByMaSP(int Masp)
        {
            double Giaban = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText =
               "SELECT giasanpham.giaban FROM sanpham JOIN giasanpham " +
               "ON sanpham.Masp = giasanpham.Masp WHERE sanpham.Masp = @Masp " +
               "AND giasanpham.TrangThai = 'T' AND sanpham.TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Giaban = reader.GetDouble(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return Giaban;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM MỚI KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void insertKhachHang(string Tenkh, string Cmnd, string SDT, string DiaChi, string Email,string Ngaytao, int Diemso, string TrangThai)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "INSERT INTO khachhang(Tenkh, Cmnd, SDT, DiaChi, Email, Ngaytao, Diemso, TrangThai) " +
                "VALUES(@Tenkh, @Cmnd, @SDT, @DiaChi, @Email, @Ngaytao, @Diemso, @TrangThai)";
            command.Parameters.AddWithValue("@Tenkh", Tenkh);
            command.Parameters.AddWithValue("@Cmnd", Cmnd);
            command.Parameters.AddWithValue("@SDT", SDT);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Ngaytao", Ngaytao);
            command.Parameters.AddWithValue("@Diemso", Diemso);
            command.Parameters.AddWithValue("@TrangThai", TrangThai);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY TẤT CẢ MÃ KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal List<int> getAllMaKhachHang()
        {
            List<int> list = new List<int>();
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Makh FROM khachhang WHERE TrangThai = 'T'";
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetInt32(0));
                }
            }
            connectToMySQL.closeConnectToMySql();
            return list;

        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY TÊN KHÁCH HÀNG THEO MÃ KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal string getTenKhachHangByMaKH(int Makh)
        {
            string Tenkh = "";
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Tenkh FROM khachhang WHERE Makh = @Makh AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Makh", Makh);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Tenkh = reader.GetString(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return Tenkh;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY ĐIỂM KHÁCH HÀNG THEO MÃ KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getDiemSoKhachHangByMaKH(int Makh)
        {
            int Diemso = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Diemso FROM khachhang WHERE Makh = @Makh AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Makh", Makh);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Diemso = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return Diemso;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* SỐ LƯỢNG SẢN PHẨM THEO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getSoLuongSanPhamByMaSP(int Masp)
        {
            int Soluong = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT soluong FROM sanpham WHERE Masp = @Masp AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Soluong = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return Soluong;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* MÃ CTKM SẢN PHẨM THEO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getMaCTKMByMaSP(int Masp)
        {
            int MaCTKM = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Machitietkhuyenmai FROM chitietkhuyenmai WHERE Masp = @Masp AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MaCTKM = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return MaCTKM;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* MÃ CTBH SẢN PHẨM THEO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getMaCTBHByMaSP(int Masp)
        {
            int MaCTBH = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Machitietbaohanh FROM chitietbaohanh WHERE Masp = @Masp AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MaCTBH = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return MaCTBH;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* MÃ GIÁ SẢN PHẨM THEO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getMaGiaSPByMaSP(int Masp)
        {
            int MaGiaSP = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Magiasp FROM giasanpham WHERE Masp = @Masp AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MaGiaSP = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return MaGiaSP;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY MÃ ĐƠN HÀNG VỪA THÊM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getMaDonHangVuaThem()
        {
            int MaDH = 0;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Madh FROM donhang ORDER BY Madh DESC LIMIT 1";
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MaDH = reader.GetInt32(0);
                }
            }
            connectToMySQL.closeConnectToMySql();
            return MaDH;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM MỚI ĐƠN HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void insertDonHang(int Makh, int Manv, string Ngayban, int SoLuong, double Tongtien, int Diemapdung, int Diemthuong, string Trangthai)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "INSERT INTO donhang(Makh, Manv, Ngayban, SoLuong, Tongtien, Diemapdung, Diemthuong, Trangthai) " +
                "VALUES(@Makh, @Manv, @Ngayban, @SoLuong, @Tongtien, @Diemapdung, @Diemthuong, @Trangthai)";
            command.Parameters.AddWithValue("@Makh", Makh);
            command.Parameters.AddWithValue("@Manv", Manv);
            command.Parameters.AddWithValue("@Ngayban", Ngayban);
            command.Parameters.AddWithValue("@SoLuong", SoLuong);
            command.Parameters.AddWithValue("@Tongtien", Tongtien);
            command.Parameters.AddWithValue("@Diemapdung", Diemapdung);
            command.Parameters.AddWithValue("@Diemthuong", Diemthuong);
            command.Parameters.AddWithValue("@Trangthai", Trangthai);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* CẬP NHẬT SỐ LƯỢNG SẢN PHẨM THEO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void updateSoLuongSPByMaSP(int soluong, int Masp)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "UPDATE sanpham SET soluong = @soluong WHERE Masp = @Masp AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            command.Parameters.AddWithValue("@soluong", soluong);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* CẬP NHẬT ĐIỂM SỐ THEO MÃ KHÁCH HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void updateDiemSoByMaKH(int Diemso, int Makh)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "UPDATE khachhang SET Diemso = @Diemso WHERE Makh = @Makh AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Makh", Makh);
            command.Parameters.AddWithValue("@Diemso", Diemso);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM MỚI CHI TIẾT ĐƠN HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void insertChiTietDonHang(int Masp, int Madh, int Machitietkhuyenmai, int Machitietbaohanh, int Magiasp, int Soluong, 
            double giaban, double giasaukm)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = 
                "INSERT INTO chitietdonhang(Masp, Madh, Machitietkhuyenmai, Machitietbaohanh, Magiasp, Soluong, giaban, giasaukm) " +
                "VALUES(@Masp, @Madh, @Machitietkhuyenmai, @Machitietbaohanh, @Magiasp, @Soluong, @giaban, @giasaukm)";
            command.Parameters.AddWithValue("@Masp", Masp);
            command.Parameters.AddWithValue("@Madh", Madh);
            command.Parameters.AddWithValue("@Machitietkhuyenmai", Machitietkhuyenmai);
            command.Parameters.AddWithValue("@Machitietbaohanh", Machitietbaohanh);
            command.Parameters.AddWithValue("@Magiasp", Magiasp);
            command.Parameters.AddWithValue("@Soluong", Soluong);
            command.Parameters.AddWithValue("@giaban", giaban);
            command.Parameters.AddWithValue("@giasaukm", giasaukm);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }
    }
}
