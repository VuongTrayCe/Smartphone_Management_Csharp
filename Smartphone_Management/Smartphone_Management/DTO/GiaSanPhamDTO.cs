using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    internal class GiaSanPhamDTO
    {
        public int Magiasp { set; get; }
        public int Masp { set; get; }
        public double Gianhap { set; get; }
        public double Giaban { set; get; }
        public string Ngayupdate { set; get; }
        public string TrangThai { set; get; }

        public GiaSanPhamDTO(int masp, double gianhap, double giaban, string ngayupdate, string trangThai)
        {
            Masp = masp;
            Gianhap = gianhap;
            Giaban = giaban;
            Ngayupdate = ngayupdate;
            TrangThai = trangThai;
        }

        public GiaSanPhamDTO()
        {

        }
    }
}
