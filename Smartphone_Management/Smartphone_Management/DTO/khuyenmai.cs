using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class khuyenmai
    {
        private int maKM;
        private string tenKM;
        private int pTKM;
        private string trangThai;

        public khuyenmai(string tenKM, int pTKM, string trangThai)
        {
            this.TenKM = tenKM;
            this.PTKM = pTKM;
            this.TrangThai = trangThai;
           
        }

        public int MaKM {get => maKM; set => maKM = value; }
        public string TenKM {get => tenKM; set => tenKM = value; }
        public int PTKM {get => pTKM; set => pTKM = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }


    }
}
