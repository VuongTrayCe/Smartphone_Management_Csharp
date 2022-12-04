﻿using Smartphone_Management.BUS;
using Smartphone_Management.GUI.BaoHanh;
using Smartphone_Management.GUI.DonHang;
using Smartphone_Management.GUI.GUI_SanPham;
using Smartphone_Management.GUI.Login;
using Smartphone_Management.GUI.Login.QuanLyQuyenTaiKhoan;
//using Smartphone_Management.GUI.Login;
using Smartphone_Management.GUI.ThongKe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UIMain());
        }
    }
}
