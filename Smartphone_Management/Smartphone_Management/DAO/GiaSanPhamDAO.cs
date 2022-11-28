using MySqlConnector;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DAO
{
    internal class GiaSanPhamDAO
    {
        private static ConnectToMySQL connectToMySQL = new ConnectToMySQL();

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM GIÁ MỚI SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void insertGiaSanPham (GiaSanPhamDTO giaSanPhamDTO)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "INSERT INTO giasanpham(Masp, Gianhap, Giaban, Ngayupdate, TrangThai) " +
                "VALUES(@Masp, @Gianhap, @Giaban, @Ngayupdate, @TrangThai)";
            command.Parameters.AddWithValue("@Masp", giaSanPhamDTO.Masp);
            command.Parameters.AddWithValue("@Gianhap", giaSanPhamDTO.Gianhap);
            command.Parameters.AddWithValue("@Giaban", giaSanPhamDTO.Giaban);
            command.Parameters.AddWithValue("@Ngayupdate", giaSanPhamDTO.Ngayupdate);
            command.Parameters.AddWithValue("@TrangThai", giaSanPhamDTO.TrangThai);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* HỦY GIÁ CŨ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal void cancelGiaSanPham(int Masp)
        {
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "UPDATE giasanpham SET TrangThai = 'F' WHERE Masp = @Masp";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            command.ExecuteNonQuery();
            connectToMySQL.closeConnectToMySql();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY DANH SÁCH GIÁ SẢN PHẨM THEO MÃ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        internal List<GiaSanPhamDTO> getGiaByMaSanPham(int Masp)
        {
            List<GiaSanPhamDTO> giaSanPhamDTOList = new List<GiaSanPhamDTO>();
            MySqlCommand command = connectToMySQL.getConnection().CreateCommand();
            command.CommandText = "SELECT * FROM giasanpham WHERE Masp = @Masp ORDER BY Magiasp DESC";
            command.Parameters.AddWithValue("@Masp", Masp);
            connectToMySQL.openConnectToMySql();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GiaSanPhamDTO giaSanPhamDTO = new GiaSanPhamDTO();
                giaSanPhamDTO.Magiasp = reader.GetInt32(0);
                giaSanPhamDTO.Masp = reader.GetInt32(1);
                giaSanPhamDTO.Gianhap = reader.GetDouble(2);
                giaSanPhamDTO.Giaban = reader.GetDouble(3);
                giaSanPhamDTO.Ngayupdate = reader.GetDateTime(4).ToString().Split(' ')[0];
                giaSanPhamDTO.TrangThai = reader.GetString(5);
                giaSanPhamDTOList.Add(giaSanPhamDTO);

            }
            connectToMySQL.closeConnectToMySql();
            return giaSanPhamDTOList;
        }
    }
}
