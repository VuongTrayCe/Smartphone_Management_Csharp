using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    internal class Model_DonHang_ChiTietDonHang
    {
        public int Masp { set; get; }
        public int Madh { set; get; }
        public int Machitietdonhang { set; get; }
        public int Machitietkhuyenmai { set; get; }
        public int Machitietbaohanh { set; get; }
        public int Makm { set; get; }
        public int Mabh { set; get; }
        public int Magiasanpham { set; get; }

        public string Tensp { set; get; }

        public int soluong { set; get; }
        public int giaban { set; get; }
        public int giasaukm { set; get; }
        public int tongtien
        {
            set{ tongtien = giasaukm*soluong; }
            get{ return tongtien; }
        }


    }
}
