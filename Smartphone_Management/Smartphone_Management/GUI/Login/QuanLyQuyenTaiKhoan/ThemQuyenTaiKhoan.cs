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
using System.Windows.Documents;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.Login.QuanLyQuyenTaiKhoan
{
    public partial class ThemQuyenTaiKhoan : Form
    {
        QuanLyPhanQuyen_BUS qlpq_BUS = new QuanLyPhanQuyen_BUS();
        QuanLyQuyenTaiKhoan1 quanlyquyentk;
        List<List<String>> datacbbmatk;
        List<List<String>> datacbbQuyenTaiKhoan;
        List<List<String>> datacbbQuyenMoi =new List<List<string>>();
        int matk;


        public ThemQuyenTaiKhoan(QuanLyQuyenTaiKhoan1 quanlyquyentk)
        {
            InitializeComponent();
            this.quanlyquyentk = quanlyquyentk;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ThemQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            init();
            datacbbmatk = qlpq_BUS.getALLTaiKhoan();
            foreach (List<String> item in datacbbmatk)
            {
                List<String> strings = item as List<String>;
                cbMaTaiKhoan.Items.Add(strings.ElementAt(0).ToString());

            }
            List<String> strings1 = datacbbmatk.ElementAt(0) as List<String>;
            txtTenNhanvien.Text = strings1.ElementAt(1).ToString();
            matk = int.Parse(strings1.ElementAt(0).ToString());
            loadQuyenTaiKhoanHienTai(matk);
            cbMaTaiKhoan.SelectedIndex = 0;



        }
        public void init()
        {
            cbbQuyenMoi.Items.Clear();
            if (datacbbQuyenMoi.Count > 0)
            {
                foreach (List<String> item in datacbbQuyenMoi)
                {
                    List<String> strings = item as List<String>;
                    cbbQuyenMoi.Items.Add(strings.ElementAt(1).ToString());

                }
                cbbQuyenMoi.SelectedIndex = 0;
            }
            else
            {
                cbbQuyenMoi.Text = "";
            }

        }
        public void loadQuyenTaiKhoanHienTai(int matk)
        {
            cbbQuyenHienTai.Items.Clear();
            datacbbQuyenTaiKhoan = qlpq_BUS.getALLQuyenTaiKhoan(matk);
            foreach (List<String> item in datacbbQuyenTaiKhoan)
            {
                List<String> strings = item as List<String>;
                cbbQuyenHienTai.Items.Add(strings.ElementAt(1).ToString());

            }
            if(cbbQuyenHienTai.Items.Count!=0)
            {
                cbbQuyenHienTai.SelectedIndex = 0;

            }
            else
            {
                cbbQuyenHienTai.Text = "";

            }

        }
        private void btnXacNhanNhanVien_Click(object sender, EventArgs e)
        {
            if (datacbbQuyenMoi.Count != 0)
            {


                foreach (List<String> item in datacbbQuyenMoi)
                {
                    qlpq_BUS.AddQuyenTaiKhoan(matk,item);

                }
                MessageBox.Show("Đã Thêm Quyền Thành Công");
                quanlyquyentk.init();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Quyền Cần Thêm");
            }


        }

        private void cbMaTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCbbmatk = cbMaTaiKhoan.SelectedIndex;
            List<String> strings1 = datacbbmatk.ElementAt(indexCbbmatk) as List<String>;
            txtTenNhanvien.Text = strings1.ElementAt(1).ToString();
            matk = int.Parse(strings1.ElementAt(0).ToString());
            loadQuyenTaiKhoanHienTai(int.Parse(strings1.ElementAt(0).ToString()));
            List<List<String>> a = new List<List<string>>();
            datacbbQuyenMoi = a;
            init();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexCbbmatk = cbMaTaiKhoan.SelectedIndex;
            List<String> strings1 = datacbbmatk.ElementAt(indexCbbmatk) as List<String>;

            ThemQuyenMoi a = new ThemQuyenMoi(int.Parse(strings1.ElementAt(0).ToString()), this,datacbbQuyenMoi);
            a.Show();
            //this.Visible = false;
        }
    }
}
