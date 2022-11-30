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
    public partial class ThemQuyen : Form
    {
        QuanLyPhanQuyen_BUS qlpq_BUS = new QuanLyPhanQuyen_BUS();
        public ThemQuyen()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
            quyen q = new quyen(txtTenQuyen.Text);
            qlpq_BUS.ThemQuyen_BUS(q);
            MessageBox.Show("Đã thêm quyền thành công");
        }
    }
}
