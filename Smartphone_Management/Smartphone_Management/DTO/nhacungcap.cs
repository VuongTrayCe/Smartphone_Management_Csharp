using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class nhacungcap
    {
        private int maNCC;
        private string tenNCC;
        private string sdt;
        private string diaChi;
        private string trangThai;


        public nhacungcap(string tenNCC, string sdt, string diaChi)
        {
            this.TenNCC = tenNCC;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
        }

        public nhacungcap(string tenNCC, string sdt, string diaChi, string trangThai)
        {
            this.TenNCC = tenNCC;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.TrangThai = trangThai;
        }

        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }


    }
}
