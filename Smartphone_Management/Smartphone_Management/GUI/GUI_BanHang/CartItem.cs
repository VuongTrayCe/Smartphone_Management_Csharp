using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.GUI.GUI_BanHang
{
    public class CartItem
    {
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public CartItem(int maSP, int soLuong)
        {
            MaSP = maSP;
            SoLuong = soLuong;
        }
    }
}
