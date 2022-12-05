using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.GUI_BanHang
{
    public partial class ChiTietSanPham : UserControl
    {
        public int MaSanPham { set; get; }
        public string TenSanPham { set; get; }
        public string LoaiSanPham { set; get; }
        public int SoLuongSanPham { set; get; }
        public string NamSanXuatSanPham { set; get; }
        public int KhuyenMaiSanPham { set; get; }
        public string BaoHanhSanPham { set; get; }
        public double GiaBanSanPham { set; get; }
        public string NhaCungCapSanPham { set; get; }
        public string HinhAnhSanPham { set; get; }
        public string ThongSoSanPham { set; get; }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LẤY ĐƯỜNG DẪN ẢNH SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private string getImageStorePath()
        {
            string startUpPath = Application.StartupPath;
            string imageStorePath = startUpPath.Remove(startUpPath.Length - 9) + @"\GUI\GUI_SanPham\HinhAnh\";
            return imageStorePath;
        }
        public ChiTietSanPham(int MaSanPham, string TenSanPham, string LoaiSanPham,
            int SoLuongSanPham, string NamSanXuatSanPham, int KhuyenMaiSanPham, string BaoHanhSanPham,
            double GiaBanSanPham, string NhaCungCapSanPham, string HinhAnhSanPham, string ThongSoSanPham)
        {
            InitializeComponent();
            CTSP_TenSanPham.Text = TenSanPham;
            CTSP_LoaiSanPham.Text = LoaiSanPham;
            CTSP_SoLuongSanPham.Text = SoLuongSanPham.ToString();
            CTSP_NamSanXuatSanPham.Text = NamSanXuatSanPham;
            CTSP_KhuyenMaiSanPham.Text = KhuyenMaiSanPham.ToString() + " %";
            if (BaoHanhSanPham.Equals(""))
            {
                CTSP_BaoHanhSanPham.Text = "Không có";
            }
            else
            {
                CTSP_BaoHanhSanPham.Text = BaoHanhSanPham;
            }
            CTSP_GiaBanSanPham.Text = GiaBanSanPham.ToString() + " VND";
            CTSP_NhaCungCapSanPham.Text = NhaCungCapSanPham;
            CTSP_ThongSoSanPham.Text = ThongSoSanPham;

            if (HinhAnhSanPham.Equals("") || HinhAnhSanPham == null)
            {
                CTSP_HinhAnhSanPham.Image = new Bitmap(getImageStorePath() + "no_image.png");
            }
            else
            {
                CTSP_HinhAnhSanPham.Image = new Bitmap(getImageStorePath() + HinhAnhSanPham);
            }
        }

        public event EventHandler addClick;

        private void CTSP_Button_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (addClick != null) addClick(sender, e);
        }
    }
}
