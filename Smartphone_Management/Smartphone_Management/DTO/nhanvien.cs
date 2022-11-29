using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class nhanvien
    {

        private int maNv;
        private string tenNv;
        private int soCCCD;
        private int tuoi;
        private string diaChi;
        private string chucDanh;
        private string trangThai;

        //public nhanvien(int maNv, string tenNv, int soCCCD, int tuoi, string diaChi, string chucDanh, string trangThai)
        //{
        //    this.MaNv = maNv;
        //    this.TenNv = tenNv;
        //    this.SoCCCD = soCCCD;
        //    this.Tuoi = tuoi;
        //    this.DiaChi = diaChi;
        //    this.ChucDanh = chucDanh;
        //    this.trangThai = trangThai;

        //}

        public nhanvien(string tenNv, int soCCCD, int tuoi, string diaChi, string chucDanh)
        {
            this.TenNv = tenNv;
            this.SoCCCD = soCCCD;
            this.Tuoi = tuoi;
            this.DiaChi = diaChi;
            this.ChucDanh = chucDanh;
        }


        public int MaNv { get => maNv; set => maNv = value; }
        public string TenNv { get=> tenNv; set => tenNv = value; }
        public int SoCCCD { get => soCCCD; set => soCCCD = value; }
        public int Tuoi { get=> tuoi; set => tuoi = value; }
        public string DiaChi { get=> diaChi; set => diaChi = value; }
        public string ChucDanh { get=>chucDanh; set => chucDanh = value; }
        public string TrangThai { get => trangThai;set => trangThai = value; }

       

        public bool checkTennv(string Tennv)
        {
            if(Tennv.Length > 0)
            {
                return true;
            }
            return false;
        }

        public bool checkSoCCCD(int SoCCCD)
        {
            if(SoCCCD == 12)
            {
                return true;
            }
            return false;
        }

        public bool checkTuoi(int Tuoi)
        {
            if(Tuoi >= 18)
            {
                return true;
            }
            return false;
        }

        public bool checkDiaChi(string Diachi)
        {
            if(Diachi.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
