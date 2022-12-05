using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.GUI_BanHang
{
    public partial class GioHang : UserControl
    {
        private static SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private static BanHangBUS banHangBUS = new BanHangBUS();

        private string getImageStorePath()
        {
            string startUpPath = Application.StartupPath;
            string imageStorePath = startUpPath.Remove(startUpPath.Length - 9) + @"\GUI\GUI_SanPham\HinhAnh\";
            return imageStorePath;
        }

        private List<CartItem> getListCartItem(List<int> ListMaSPGioHang)
        {
            List<CartItem> cartItems = new List<CartItem>();
            int[] listCount = new int[100];

            for (int i = 0; i < ListMaSPGioHang.Count; i++)
            {
                listCount[i] = -1;
            }
            for (int i = 0; i < ListMaSPGioHang.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < ListMaSPGioHang.Count; j++)
                {
                    if (ListMaSPGioHang[i] == ListMaSPGioHang[j])
                    {
                        count++;
                        listCount[j] = 0;
                    }
                }

                if (listCount[i] != 0) listCount[i] = count;

                if (listCount[i] != 0)
                {
                    cartItems.Add(new CartItem(ListMaSPGioHang[i], listCount[i]));
                }
            }
            return cartItems;
        }

        public List<int> ListMaSPGioHang { set; get; }
        private void fetchGioHang (List<CartItem> cartItems)
        {
            GioHang_DanhSachSanPham.Rows.Clear();
            GioHang_DanhSachSanPham.RowTemplate.Height = 90;
            GioHang_DanhSachSanPham.ScrollBars = ScrollBars.Vertical;
            Padding newPadding = new Padding(0, 5, 0, 5);
            GioHang_DanhSachSanPham.RowTemplate.DefaultCellStyle.Padding = newPadding;
            GioHang_DanhSachSanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            double TongTien = 0;

            for (int i = 0; i < cartItems.Count; i++)
            {
                GioHang_DanhSachSanPham.Rows.Add();
                SanPhamDTO sanPhamDTO = sanPhamBUS.getSanPhamByID(cartItems[i].MaSP);

                GioHang_DanhSachSanPham.Rows[i].Cells[0].Value = cartItems[i].MaSP;

                if (!sanPhamDTO.Icon.Equals(""))
                {
                    Bitmap bitmap = (Bitmap)Bitmap.FromFile(getImageStorePath() + sanPhamDTO.Icon);
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = bitmap;
                    imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    GioHang_DanhSachSanPham.Rows[i].Cells[1] = imageCell;
                }
                else
                {
                    Bitmap bitmap = (Bitmap)Bitmap.FromFile(getImageStorePath() + "no_image.png");
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = bitmap;
                    imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    GioHang_DanhSachSanPham.Rows[i].Cells[0] = imageCell;
                }
                double Giaban = banHangBUS.getGiaBanByMaSP(cartItems[i].MaSP);
                GioHang_DanhSachSanPham.Rows[i].Cells[2].Value = sanPhamDTO.Tensp;
                GioHang_DanhSachSanPham.Rows[i].Cells[3].Value = cartItems[i].SoLuong;
                GioHang_DanhSachSanPham.Rows[i].Cells[4].Value = Giaban;

                TongTien += cartItems[i].SoLuong * Giaban;
            }

            GioHang_TongTienGioHang.Text = TongTien + " VND";
        }

        public GioHang(List<int> ListMaSPGioHang)
        {
            InitializeComponent();

            List<CartItem> cartItems = getListCartItem(ListMaSPGioHang);
            fetchGioHang(cartItems);

            this.ListMaSPGioHang = ListMaSPGioHang;
        }

        public event EventHandler deleteAllClick;
        public event EventHandler deleteOneClick;
        public event DataGridViewCellEventHandler selectedRowClick;

        private void GioHang_Button_DeleteAll_Click(object sender, EventArgs e)
        {
            if (deleteAllClick != null) deleteAllClick(sender, e);
        }

        private void GioHang_Button_DeleteOne_Click(object sender, EventArgs e)
        {
            if (deleteOneClick != null) deleteOneClick(sender, e);
        }

        private void GioHang_Button_TaoHoaDon_Click(object sender, EventArgs e)
        {
            if(getListCartItem(ListMaSPGioHang).Count > 0)
            {
                BanHang_DonHang banHang_DonHang = new BanHang_DonHang(getListCartItem(ListMaSPGioHang));
                banHang_DonHang.Show();
            }
        }

        private void GioHang_DanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedRowClick != null) selectedRowClick(sender, e);
        }
    }
}
