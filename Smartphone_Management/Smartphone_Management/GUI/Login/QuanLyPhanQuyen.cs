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

namespace Smartphone_Management.GUI.Login
{
    public partial class QuanLyPhanQuyen : Form
    {
        QuanLyPhanQuyen_BUS qlpq_BUS = new QuanLyPhanQuyen_BUS();
        string Trangthai = null;
        int? val = null;
        QuanLyTaiKhoan frmqltk;




        public QuanLyPhanQuyen(QuanLyTaiKhoan frmqltk)
        {
            InitializeComponent();
            this.frmqltk = frmqltk;
            this.frmqltk.Visible = false;
        }

        public void LoadDataQuyen()
        {

            DataTable dataQuyen = new DataTable();

            switch (val)
            {
                case 1:
                    dataQuyen = qlpq_BUS.TimKiemQuyen_BUS(txtSearchQuyen.Text.Trim());
                    break;
                default:
                    dataQuyen = qlpq_BUS.getQuyen_BUS();
                    break;
            }

            dtgQuyen.DataSource = dataQuyen;

        }

        public void LoadDataQuyen_TaiKhoan()
        {
            DataTable dataQuyen_TaiKhoan = new DataTable();

            switch (val)
            {
                case 1: dataQuyen_TaiKhoan = qlpq_BUS.TimKiemQuyen_TaiKhoan_BUS(txtSearchQuyen_TaiKhoan.Text.Trim());
                    break;
                default: dataQuyen_TaiKhoan = qlpq_BUS.getQuyen_Taikhoan_BUS();
                    break;
            }

            dtgQuyen_TaiKhoan.DataSource = dataQuyen_TaiKhoan;

        }

        private void dtgQuyen_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void init_Tick(object sender, EventArgs e)
        {
            LoadDataQuyen();
            LoadDataQuyen_TaiKhoan();
        }

        private void ScrollQuyen_TaiKhoan_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgQuyen_TaiKhoan.FirstDisplayedScrollingRowIndex = dtgQuyen_TaiKhoan.Rows[e.NewValue].Index;

            }
            catch (Exception)
            {

            }
        }

        private void ScrollQuyen_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgQuyen.FirstDisplayedScrollingRowIndex = dtgQuyen.Rows[e.NewValue].Index;

            }
            catch (Exception)
            {

            }
        }

        private void dtgQuyen_TaiKhoan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrollQuyen_TaiKhoan.Maximum = dtgQuyen_TaiKhoan.RowCount - 1;

            }
            catch (Exception)
            {

            }
        }

        private void dtgQuyen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrollQuyen.Maximum = dtgQuyen.RowCount - 1;

            }
            catch (Exception)
            {

            }
        }

        private void dtgQuyen_TaiKhoan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrollQuyen_TaiKhoan.Maximum = dtgQuyen_TaiKhoan.RowCount - 1;

            }

            catch (Exception)
            {

            }
        }

        private void dtgQuyen_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrollQuyen.Maximum = dtgQuyen.RowCount - 1;

            }

            catch (Exception)
            {

            }
        }

        private void btnSearchQuyen_TaiKhoan_Click(object sender, EventArgs e)
        {
            val = 1;
            LoadDataQuyen_TaiKhoan();
        }

        private void btnSearchQuyen_Click(object sender, EventArgs e)
        {
            val = 1;

            LoadDataQuyen();
        }

        private void QuanLyPhanQuyen_Load(object sender, EventArgs e)
        {
            init.Start();


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.frmqltk.Visible = true;
            this.Dispose();
        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
            ThemQuyen tq = new ThemQuyen(this);
            tq.ShowDialog();
        }

        private void btnThemQuyenTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemQuyenTaiKhoan tqtk = new ThemQuyenTaiKhoan(this);
            tqtk.ShowDialog();
        }

        private void btnThayDoiQuyenTaiKhoan_Click(object sender, EventArgs e)
        {
            ThayDoiQuyenTaiKhoan tdqtk = new ThayDoiQuyenTaiKhoan(this);
            tdqtk.ShowDialog();
        }
    }
}
