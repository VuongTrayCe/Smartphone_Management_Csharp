using MySql.Data.MySqlClient;
using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using SqlKata;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;

namespace Smartphone_Management.GUI.Login
{
    public partial class QuanLyTaiKhoan : Form
    {
        QuanLyTaiKhoan_BUS qltk_BUS = new QuanLyTaiKhoan_BUS();
        private string Trangthai = null;

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
           
        }

        public void LoadData()
        {
            //// clear the rows
            //dataGridView.Rows.Clear();

            DataTable data = new DataTable();

            if (Trangthai == "Tìm kiếm") {
                if (txtSearch.Text.Trim().Length > 0)
                {
                    //dataGridView.DataSource = null;
                        data = qltk_BUS.TimKiemTaiKhoan_BUS(txtSearch.Text.Trim());
                }
                else if(txtSearch.Text.Trim().Length == 0)
                {
                    data = qltk_BUS.getThongTinCacTaiKhoan_BUS();
                }
            }


            if (Trangthai == null) { data = qltk_BUS.getThongTinCacTaiKhoan_BUS(); }
            else if (Trangthai == "Tắt hoạt động") { data = qltk_BUS.getThongTinCacTaiKhoanTatHoatDong_BUS(); }
            else if (Trangthai == "Đang hoạt động") { data = qltk_BUS.getThongTinCacTaiKhoanDangHoatDong_BUS(); }


            dataGridView.DataSource = data;
          }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            //init.Start();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows[e.NewValue].Index;

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrollBar.Maximum = dataGridView.RowCount -1;

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrollBar.Maximum = dataGridView.RowCount - 1;

            }

            catch (Exception)
            {

            }
        }

        private void QuanLyTaiKhoan_Shown(object sender, EventArgs e)
        {
         
        }

        private void init_Tick(object sender, EventArgs e)
        {
            //init.Stop();
            // Load data
            //LoadData();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            Trangthai = "Tìm kiếm";
            LoadData();
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ThemTaiKhoan ttk = new ThemTaiKhoan(this);
            ttk.ShowDialog();
        }

        private void cbHoatDong_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbHoatDong.Text == "Tất cả")
            {
                Trangthai = null;
                LoadData();
            }else if(cbHoatDong.Text == "Đang hoạt động")
            {
                Trangthai = "Đang hoạt động";
                LoadData();
            }else if(cbHoatDong.Text == "Tắt hoạt động") 
            {
                Trangthai = "Tắt hoạt động";
                LoadData();
            }
        }



        private void btnQuanLyPhanQuyen_Click(object sender, EventArgs e)
        {
            //QuanLyPhanQuyen qlpq = new QuanLyPhanQuyen(this);
            //qlpq.ShowDialog();
            Thread newThread = new Thread(createForm);
            newThread.Start();
        }

        private void createForm()
        {
            QuanLyPhanQuyen qlpq = new QuanLyPhanQuyen(this);
            qlpq.ShowDialog();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            XoaTaiKhoan xoaTK = new XoaTaiKhoan(this);
            xoaTK.ShowDialog();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            Trangthai = "Tìm kiếm";
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
    }

