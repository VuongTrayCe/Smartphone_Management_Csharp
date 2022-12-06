using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace Smartphone_Management.GUI.GUI_BanHang
{
    public partial class BanHang : Form
    {
        private static SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private static BanHangBUS banHangBUS = new BanHangBUS();

        private static List<int> listMaSPGioHang = new List<int>();
        private static int selectedCartProductID;

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* FETCH SẢN PHẨM RA DATA GRID VIEW *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void fetchSanPham(List<SanPhamDTO> listSP)
        {
            BanHang_DanhSachSanPham.Rows.Clear();
            for (int i = 0; i < listSP.Count; i++)
            {
                BanHang_DanhSachSanPham.Rows.Add();
                BanHang_DanhSachSanPham.Rows[i].Cells[0].Value = listSP[i].Masp;
                BanHang_DanhSachSanPham.Rows[i].Cells[1].Value = listSP[i].Tensp;
                BanHang_DanhSachSanPham.Rows[i].Cells[2].Value = listSP[i].Loaisp;
                BanHang_DanhSachSanPham.Rows[i].Cells[3].Value = listSP[i].MauSac;
            }
        }

        private void selectedRowDGV(int rowIndex)
        {
            int maSPSelectd = Int32.Parse(BanHang_DanhSachSanPham.Rows[rowIndex].Cells[0].Value.ToString());
            SanPhamDTO sp = sanPhamBUS.getSanPhamByID(maSPSelectd);
            fetchChiTietSanPham(sp);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* FETCH CHI TIẾT SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void fetchChiTietSanPham(SanPhamDTO sp)
        {
            BanHang_Panel_ChiTietSanPham_GioHang.Controls.Clear();
            string Baohanh = banHangBUS.getTGBaoHanhByMaSP(sp.Masp);
            int Khuyenmai = banHangBUS.getPTKhuyenMaiByMaSP(sp.Masp);
            double Giaban = banHangBUS.getGiaBanByMaSP(sp.Masp); 
            string Nhacungcap = banHangBUS.getTenNhaCungCapMaSP(sp.Masp);
            ChiTietSanPham chiTietSanPham = new ChiTietSanPham(
                sp.Masp, 
                sp.Tensp, 
                sp.Loaisp, 
                sp.soluong, 
                sp.Namsx,
                Khuyenmai,
                Baohanh,
                Giaban,
                Nhacungcap, 
                sp.Icon, 
                sp.ThongSo);
            chiTietSanPham.BringToFront();
            chiTietSanPham.Dock = DockStyle.Fill;
            BanHang_Panel_ChiTietSanPham_GioHang.Controls.Add(chiTietSanPham);
            
            chiTietSanPham.addClick += new EventHandler(this.ThemSanPham_Click);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM SẢN PHẨM VÀO GIỎ HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ThemSanPham_Click(object sender, EventArgs e)
        {       
            int selectedIndex = BanHang_DanhSachSanPham.SelectedRows[0].Index;
            int selectedMaSP = (int) BanHang_DanhSachSanPham.Rows[selectedIndex].Cells[0].Value;
            int SLConLai = banHangBUS.getSoLuongSanPhamByMaSP(selectedMaSP);
            if(SLConLai > 0)
            {
                int count = 0;
                for(int i = 0; i < listMaSPGioHang.Count; i++)
                {
                    if(listMaSPGioHang[i] == selectedMaSP) count++;
                }
                if(count < SLConLai)
                {
                    listMaSPGioHang.Add(selectedMaSP);
                    BanHang_OpenGioHang.Text = listMaSPGioHang.Count.ToString();                  
                } else
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ! Vui lòng chọn sản phẩm khác");
                }
            } else
            {
                MessageBox.Show("Hết sản phẩm! Vui lòng chọn sản phẩm khác");
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* FETCH GIỎ HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void fetchGioHang(List<int> listMaSPGioHang)
        {
            BanHang_Panel_ChiTietSanPham_GioHang.Controls.Clear();
            GioHang gioHang = new GioHang(listMaSPGioHang);
            gioHang.BringToFront();
            gioHang.Dock = DockStyle.Fill;
            BanHang_Panel_ChiTietSanPham_GioHang.Controls.Add(gioHang);

            BanHang banHang = this;
            gioHang.deleteAllClick += new EventHandler(banHang.DeleteAllSanPham_Click);
            gioHang.deleteOneClick += new EventHandler(banHang.DeleteOneSanPham_Click);
            gioHang.selectedRowClick += new DataGridViewCellEventHandler(banHang.SelectedRowSanPhamClick);
            BanHang_OpenGioHang.Text = listMaSPGioHang.Count.ToString();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* XÓA SẢN PHẨM RA KHỎI GIỎ HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void SelectedRowSanPhamClick(object sender, DataGridViewCellEventArgs e)
        {
            BunifuDataGridView dgv = sender as BunifuDataGridView;
            selectedCartProductID = (int) dgv.SelectedCells[0].Value;
        }

        private void DeleteAllSanPham_Click(object sender, EventArgs e)
        {
            listMaSPGioHang.RemoveAll(item => item == selectedCartProductID);
            fetchGioHang(listMaSPGioHang);
        }
        private void DeleteOneSanPham_Click(object sender, EventArgs e)
        {
            listMaSPGioHang.Remove(selectedCartProductID);
            fetchGioHang(listMaSPGioHang);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* KHỞI TẠO FORM BÁN HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        public BanHang()
        {
            InitializeComponent();
            BanHang_DanhSachSanPham.Rows.Clear();
            listMaSPGioHang.Clear();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            List<SanPhamDTO> listSP = sanPhamBUS.getFullDataSanPham();
            fetchSanPham(listSP);
            fetchChiTietSanPham(listSP[0]);
            BanHang_OpenGioHang.Text = listMaSPGioHang.Count.ToString();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* SHOW GIỎ HÀNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void BanHang_OpenGioHang_Click(object sender, EventArgs e)
        {
            fetchGioHang(listMaSPGioHang);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* TÌM KIẾM SẢN PHẨM THEO MÃ VÀ TÊN *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void BanHang_Button_TimKiemSanPham_Click(object sender, EventArgs e)
        {
            string search = BanHang_TextBox_TimKiemSanPham.Text.Trim();
            if (!search.Equals(""))
            {
                List<SanPhamDTO> listSP = banHangBUS.searchSanPham(search);
                fetchSanPham(listSP);
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* TẢI LẠI SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void BanHang_Button_TaiLaiSanPham_Click(object sender, EventArgs e)
        {
            List<SanPhamDTO> listSP = sanPhamBUS.getFullDataSanPham();
            fetchSanPham(listSP);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* SELECTED ROW DATA GRID VIEW *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void BanHang_DanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selectedRowDGV(rowIndex);
        }
    }
}
