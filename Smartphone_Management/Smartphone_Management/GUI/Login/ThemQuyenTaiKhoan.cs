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

namespace Smartphone_Management.GUI.Login
{
    public partial class ThemQuyenTaiKhoan : Form
    {
        QuanLyPhanQuyen_BUS qlpq_BUS = new QuanLyPhanQuyen_BUS();

        public ThemQuyenTaiKhoan()
        {
            InitializeComponent();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ThemQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            qlpq_BUS.showThuocTinhMaQuyen(cbMaQuyen);
            qlpq_BUS.showThuocTinhMaTaiKhoan(cbMaTaiKhoan);

        }

        private void btnXacNhanNhanVien_Click(object sender, EventArgs e)
        {
            string queryMaTK = cbMaTaiKhoan.Text;
            string queryMaQuyen = cbMaQuyen.Text;

            string[] MaTK = queryMaTK.Split('-');
            string[] MaQuyen = queryMaQuyen.Split('-');

            int Matk = Int32.Parse(MaTK[1]);
            int Maquyen = Int32.Parse(MaQuyen[1]);

            quyen_taikhoan q_tk = new quyen_taikhoan(Matk, Maquyen);
          
            qlpq_BUS.ThemQuyen_TK_BUS(q_tk);

        }
    }
}
