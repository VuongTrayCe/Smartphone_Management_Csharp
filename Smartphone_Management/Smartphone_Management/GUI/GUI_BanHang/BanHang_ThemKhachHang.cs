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

namespace Smartphone_Management.GUI.GUI_BanHang
{
    public partial class BanHang_ThemKhachHang : Form
    {
        private static BanHangBUS banHangBUS = new BanHangBUS();
        public BanHang_ThemKhachHang()
        {
            InitializeComponent();
        }

        private string getToday()
        {
            string date = DateTime.Now.ToString();
            string[] dateSplit = date.Split(' ');
            string month = dateSplit[0].Split('/')[0];
            string day = dateSplit[0].Split('/')[1];
            string year = dateSplit[0].Split('/')[2];
            return year + "-" + month + "-" + day;
        }

        private void Button_ThemKhachHang_Click(object sender, EventArgs e)
        {
            string errorMessage = banHangBUS.checkInputKhachHang(Tenkh.Text, Cmnd.Text, SDT.Text, Email.Text, DiaChi.Text);
            if(errorMessage.Equals(""))
            {
                string Ngaytao = getToday();
                int Diemso = 0;
                string TrangThai = "T";
                banHangBUS.insertKhachHang(Tenkh.Text, Cmnd.Text, SDT.Text, DiaChi.Text, Email.Text, Ngaytao, Diemso, TrangThai);
                MessageBox.Show("Thêm khách hàng thành công!");
            } else
            {
                MessageBox.Show(errorMessage);
            }

        }

        private void Button_CloseKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
