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
    public partial class QuanLyQuyenTaiKhoan : Form
    {
        QuanLyPhanQuyen_BUS qlpq = new QuanLyPhanQuyen_BUS();
        public QuanLyQuyenTaiKhoan()
        {
            InitializeComponent();
            init();
        }
        public void init()

        {
            DataTable data = new DataTable();
            data = qlpq.getInfor();
            dataGirdView1.DataSource = data;
        }
    }
}
