using DocumentFormat.OpenXml.Wordprocessing;
using MySqlConnector;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Smartphone_Management.DAO
{
    internal class SanPhamDAO
    {
        private static ConnectToMySQL connectToMySQL = new ConnectToMySQL();

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY DỮ LIỆU SẢN PHẨM DƯỚI DẠNG DATATABLE *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal DataTable getDataTableSanPham()
        {
            DataTable data = new DataTable();
            string query = "SELECT Masp, Tensp, Loaisp, soluong, MauSac, Namsx FROM sanpham WHERE TrangThai = 'T' ORDER BY Masp DESC";
            connectToMySQL.openConnectToMySql();
            MySqlCommand command = new MySqlCommand(query, connectToMySQL.getConnection());
            if (command == null)
            {
                return null;
            }
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = command;
            MyAdapter.Fill(data);
            connectToMySQL.closeConnectToMySql();
            return data;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY DỮ LIỆU SẢN PHẨM DƯỚI DẠNG LIST ĐẦY ĐỦ *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal List<SanPhamDTO> getFullDataSanPham()
        {
            List<SanPhamDTO> sanphamDTOList = new List<SanPhamDTO>();
            string query = "SELECT sanpham.Masp, sanpham.Tensp, sanpham.Loaisp, sanpham.soluong, sanpham.MauSac, sanpham.Namsx, " +
                "sanpham.Icon, sanpham.ThongSo, sanpham.Mancc, giasanpham.Gianhap, giasanpham.Giaban " +
                "FROM sanpham JOIN giasanpham ON sanpham.Masp = giasanpham.Masp WHERE sanpham.TrangThai = 'T' AND giasanpham.TrangThai = 'T' " +
                "ORDER BY sanpham.Masp DESC";
            connectToMySQL.openConnectToMySql();
            MySqlCommand command = new MySqlCommand(query, connectToMySQL.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SanPhamDTO sanphamDTO = new SanPhamDTO();
                sanphamDTO.Masp = reader.GetInt32(0);
                sanphamDTO.Tensp = reader.GetString(1);
                sanphamDTO.Loaisp = reader.GetString(2);
                sanphamDTO.soluong = reader.GetInt32(3);
                sanphamDTO.MauSac = reader.GetString(4);
                sanphamDTO.Namsx = reader.GetString(5);
                sanphamDTO.Icon = reader.GetString(6);
                sanphamDTO.ThongSo = reader.GetString(7);
                sanphamDTO.Mancc = reader.GetInt32(8);
                sanphamDTO.Gianhap = reader.GetDouble(9);
                sanphamDTO.Giaban = reader.GetDouble(10);
                sanphamDTOList.Add(sanphamDTO);
            }
            connectToMySQL.closeConnectToMySql();
            return sanphamDTOList;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY TẤT CẢ CÁC LOẠI SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal List<string> getAllLoaiSanPham ()
        {
            List<string> result = new List<string>();
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT DISTINCT Loaisp FROM sanpham";
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = (string) reader["Loaisp"].ToString();
                result.Add(item);
            }
            connectToMySQL.closeConnectToMySql();
            return result;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY TẤT CẢ CÁC MÃ NHÀ CUNG CẤP *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal List<string> getAllMaNhaCungCap()
        {
            List<string> result = new List<string>();
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Mancc FROM nhacungcap";
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = reader["Mancc"].ToString();
                result.Add(item);
            }
            connectToMySQL.closeConnectToMySql();
            return result;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* KIỂM TRA MÃ NHÀ CUNG CẤP CÓ TỒN TẠI *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal bool checkMaNhaCungCapExists(int Mancc)
        {
            bool isExists = false;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT * FROM nhacungcap WHERE Mancc = @Mancc";
            command.Parameters.AddWithValue("@Mancc", Mancc);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                isExists = true;
            } 
            connectToMySQL.closeConnectToMySql();
            return isExists;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY SẢN PHẨM THEO MÃ *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal SanPhamDTO getSanPhamByID(int Masp)
        {
            SanPhamDTO sanphamDTO = new SanPhamDTO();
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT * FROM sanpham WHERE Masp = @Masp AND TrangThai = 'T'";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
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
               
            }
            connectToMySQL.closeConnectToMySql();
            return sanphamDTO;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM MỚI 1 SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void insertSanPham(SanPhamDTO sanphamDTO)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "INSERT INTO sanpham(Tensp, Loaisp, soluong, MauSac, Namsx, TrangThai, Icon, ThongSo, Mancc) " +
                "VALUES(@Tensp, @Loaisp, @soluong, @MauSac, @Namsx, @TrangThai, @Icon, @ThongSo, @Mancc)";
            command.Parameters.AddWithValue("@Tensp", sanphamDTO.Tensp);
            command.Parameters.AddWithValue("@Loaisp", sanphamDTO.Loaisp);
            command.Parameters.AddWithValue("@soluong", sanphamDTO.soluong);
            command.Parameters.AddWithValue("@MauSac", sanphamDTO.MauSac);
            command.Parameters.AddWithValue("@Namsx", sanphamDTO.Namsx);
            command.Parameters.AddWithValue("@TrangThai", sanphamDTO.TrangThai);
            command.Parameters.AddWithValue("@Icon", sanphamDTO.Icon);
            command.Parameters.AddWithValue("@ThongSo", sanphamDTO.ThongSo);
            command.Parameters.AddWithValue("@Mancc", sanphamDTO.Mancc);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* SỬA THÔNG TIN SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void updateSanPham(SanPhamDTO sanphamDTO)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "UPDATE sanpham SET Tensp = @Tensp, Loaisp = @Loaisp, soluong = @soluong, MauSac = @MauSac, " +
                "Namsx = @Namsx, TrangThai = @TrangThai, Icon = @Icon, ThongSo = @ThongSo, Mancc = @Mancc " +
                "WHERE Masp = @Masp";
            command.Parameters.AddWithValue("@Masp", sanphamDTO.Masp);
            command.Parameters.AddWithValue("@Tensp", sanphamDTO.Tensp);
            command.Parameters.AddWithValue("@Loaisp", sanphamDTO.Loaisp);
            command.Parameters.AddWithValue("@soluong", sanphamDTO.soluong);
            command.Parameters.AddWithValue("@MauSac", sanphamDTO.MauSac);
            command.Parameters.AddWithValue("@Namsx", sanphamDTO.Namsx);
            command.Parameters.AddWithValue("@TrangThai", sanphamDTO.TrangThai);
            command.Parameters.AddWithValue("@Icon", sanphamDTO.Icon);
            command.Parameters.AddWithValue("@ThongSo", sanphamDTO.ThongSo);
            command.Parameters.AddWithValue("@Mancc", sanphamDTO.Mancc);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* XÓA 1 SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void deleteSanPham(int Masp)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "UPDATE sanpham SET TrangThai = 'F' WHERE Masp = @Masp";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY DATA SET SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal DataSet getDataSetSanPham ()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataSet.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dataSet.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT * FROM sanpham";
            connectToMySQL.openConnectToMySql();
            // TO DO
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            adapter.Dispose();
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY MÃ SẢN PHẨM CUỐI CÙNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal int getMaSanPhamCuoiCung()
        {
            int Masp = -1;
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT Masp FROM sanpham WHERE TrangThai = 'T' ORDER BY Masp DESC LIMIT 1";
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Masp = reader.GetInt32(0);
            }
            connectToMySQL.closeConnectToMySql();
            return Masp;
        }

        internal void insertKM(int v)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "INSERT INTO chitietkhuyenmai(Masp,Makm,TrangThai) values(@masp,9,'T')" ;

            connectToMySQL.openConnectToMySql();
            command.Parameters.AddWithValue("@masp", v);
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        internal void insertBH(int v)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "INSERT INTO chitietbaohanh(Mabaohanh,Masp,TrangThai) values(110,@masp,'T')";

            connectToMySQL.openConnectToMySql();
            command.Parameters.AddWithValue("@masp", v);
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }
    }
}
