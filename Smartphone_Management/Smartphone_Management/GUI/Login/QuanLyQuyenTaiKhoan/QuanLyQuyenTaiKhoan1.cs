using Smartphone_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.Login.QuanLyQuyenTaiKhoan
{
    public partial class QuanLyQuyenTaiKhoan1 : Form
    {
        QuanLyPhanQuyen_BUS qlpq = new QuanLyPhanQuyen_BUS();
        public QuanLyQuyenTaiKhoan1()
        {
            InitializeComponent();
            init();
        }
        public void init()

        {
            DataTable data = new DataTable();
            data = qlpq.getInfor();
            dataGirdView1.DataSource = data;
            dataGirdView1.Columns[0].HeaderText = "Mã Quyền Tài Khoản";
            dataGirdView1.Columns[1].HeaderText = " Mã Tài Khoản";
            dataGirdView1.Columns[2].HeaderText = "Mã Nhân Viên";
            dataGirdView1.Columns[3].HeaderText = "Tên Nhân Viên";
            dataGirdView1.Columns[4].HeaderText = "Tên Quyền";

        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
            ThemQuyenTaiKhoan a = new ThemQuyenTaiKhoan(this);
            a.Show();
        }

        private void btnXoaQuyen_Click(object sender, EventArgs e)
        {
            if(dataGirdView1.CurrentRow.Cells[0].Value!=null)
            {
                int maquyentk = int.Parse(dataGirdView1.CurrentRow.Cells[0].Value.ToString());
                qlpq.DeleteQuyenTaiKhoan(maquyentk);
                MessageBox.Show("Đã Xóa Thành Công");
                init();

            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Quyền Cần Xóa");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
