using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class Model_ChiTietPhieuNhap
    {
        public int Maphieunhap { set; get; }
        public int Masp { set; get; }
        public string tensanpham { set; get; }
        public int Magiasanpham { set; get; }
        public int soluong { set; get; }
        public int gianhap { set; get; }
        public int tongtien
        {
            set
            {
            }
            get
            {
                return soluong* gianhap;
            }
        }

    }
}
