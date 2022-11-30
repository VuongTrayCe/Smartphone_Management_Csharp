using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class taikhoan
    {

        private int maTK;
        private int maNv;
        private string tendangnhap;
        private string matkhau;
        private string trangthai;
        private DateTime ngaythamgia;

        public taikhoan( string tendangnhap, string matkhau)
        {
            this.Tendangnhap = tendangnhap;
            this.Matkhau = matkhau;
        }

        public int Matk { get=> maTK; set => maTK = value; }    
        public int Manv { get => maNv; set => maNv = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Trangthai { get => trangthai; set => trangthai = value;  }
        public DateTime Ngaythamgia { get => ngaythamgia; set => ngaythamgia = value;  }


    }
}
