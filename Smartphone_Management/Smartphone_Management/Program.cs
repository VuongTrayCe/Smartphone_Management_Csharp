using Smartphone_Management.GUI.DonHang;
using Smartphone_Management.GUI.GUI_SanPham;
using Smartphone_Management.GUI.GUI_SanPham.Dialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SanPham());
        }
    }
}
