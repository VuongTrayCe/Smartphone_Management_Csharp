using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class chitietkhuyenmai
    {
        private int maChiTietKM;
        private int maSP;
        private int maKM;
        private string trangThai;


        public chitietkhuyenmai(int maKM, int maSP)
        {
            this.MaKM = maKM;
            this.MaSP = maSP;
        }

        public chitietkhuyenmai(int maKM)
        {
            this.MaKM = maKM;
          
        }

        public int MaChiTietKM { get => maChiTietKM; set => maChiTietKM = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int MaKM { get => maKM; set => maKM = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
