using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    internal class SanPhamDTO
    {
        public SanPhamDTO() {}
        public SanPhamDTO(
            int Masp,
            string Tensp,
            string Loaisp,
            int soluong,
            string MauSac,
            string Namsx,
            string TrangThai,
            string Icon,
            string ThongSo,
            int Mancc,
            double Gianhap,
            double Giaban
            )
        {
            this.Masp = Masp;
            this.Tensp = Tensp;
            this.Loaisp = Loaisp;
            this.soluong = soluong;
            this.MauSac = MauSac;
            this.Namsx = Namsx;
            this.TrangThai = TrangThai;
            this.Icon = Icon;
            this.ThongSo = ThongSo;
            this.Mancc = Mancc;
            this.Gianhap = Gianhap;
            this.Giaban = Giaban;
        }

        public int Masp { set; get; }
        public string Tensp { set; get; }
        public string Loaisp { set; get; }
        public int soluong { set; get; }
        public string MauSac { set; get; }
        public string Namsx { set; get; }
        public string TrangThai { set; get; }
        public string Icon { set; get; }
        public string ThongSo { set; get; }
        public int Mancc { set; get; }
        public double Gianhap { set; get; }
        public double Giaban { set; get; }
    }
}
