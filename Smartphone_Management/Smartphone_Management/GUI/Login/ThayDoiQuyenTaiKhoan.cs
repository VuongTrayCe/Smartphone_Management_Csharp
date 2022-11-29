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
    public partial class ThayDoiQuyenTaiKhoan : Form
    {
        QuanLyPhanQuyen frmqlpq;
        QuanLyPhanQuyen_BUS qlpq_BUS = new QuanLyPhanQuyen_BUS();


        public ThayDoiQuyenTaiKhoan(QuanLyPhanQuyen frmqlpq)
        {
            InitializeComponent();
            this.frmqlpq = frmqlpq;
            this.frmqlpq.Visible = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.frmqlpq.Visible = true;
            this.Dispose();
        }

        private void ThayDoiQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            qlpq_BUS.showThuocTinhMaQuyen(cbMaQuyen);
            qlpq_BUS.showThuocTinhMaTaiKhoan2(cbMaTK);


        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string queryMaTK = cbMaTK.Text;
            string queryMaQuyen = cbMaQuyen.Text;

            string[] MaTK = queryMaTK.Split('-');
            string[] MaQuyen = queryMaQuyen.Split('-');

            int Matk = Int32.Parse(MaTK[1]);
            int Manv = Int32.Parse(MaTK[2]);

            int Maquyen = Int32.Parse(MaQuyen[1]);
            string Tenquyen = MaQuyen[0];
            

            quyen_taikhoan q_tk = new quyen_taikhoan(Matk, Maquyen);
            qlpq_BUS.ThaydoiQuyen_Taikhoan_BUS(q_tk);

            qlpq_BUS.ThaydoiChucVu_BUS(Manv, Tenquyen);
        }
    }
}
