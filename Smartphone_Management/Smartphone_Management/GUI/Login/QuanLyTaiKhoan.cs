using Smartphone_Management.DTO;
//using SqlKata;
//using SqlKata.Execution;
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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();

            //Test
            for (int i = 0; i < 20; i++)
            {
                dataGridView.Rows.Add(new object[]{
                imageList1.Images[0]
                });

            }
        }

        void LoadData()
        {
            // clear the rows
            dataGridView.Rows.Clear();


            //check for search
            //var db = DAO.ConnectToPhucMySQL.Db();
            //Query q = db.Query("taikhoan");

            if (txtSearch.Text.Trim().Length > 0)
            {

            }

            // load tat ca tai khoan in database 

            IEnumerable<taikhoan> result = q.Get<taikhoan>();

            foreach (var taikhoan in result)
            {
                dataGridView.Rows.Add(new object[]
                {
                    imageList1.Images[0],
                    taikhoan.Matk,
                    taikhoan.Manv,
                    taikhoan.Tendangnhap,
                    taikhoan.Matkhau,
                    taikhoan.Trangthai? imageList1.Images[1] : imageList1.Images[2],
                    taikhoan.Ngaythamgia

                });
            }
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

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
                ScrollBar.Maximum = dataGridView.RowCount - 1;

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
            init.Stop();
            // Load data
            LoadData();
        }
    }
}

