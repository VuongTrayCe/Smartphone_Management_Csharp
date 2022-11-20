using FontAwesome.Sharp;
using Smartphone_Management.GUI;
using Smartphone_Management.GUI.DonHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace Smartphone_Management
{
    public partial class UIMain : Form
    {
        private IconButton currentBtn;

        private Color corlor = Color.FromArgb(0, 127, 0);
        private int FlagColor = 0;
        public UIMain()
        {
            InitializeComponent();
            CustomizeDising();
        }
        private void ActivateButton(Object sender,Color color)
        {
            if(sender!=null)
            {
                DisableButton();
                currentBtn=sender as IconButton;
                currentBtn.BackColor=Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign=ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

            }
        }
        private void DisableButton()
        {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11,7,17);
                currentBtn.ForeColor = Color.Gainsboro;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        private void CustomizeDising()
        {
            panelChinhSach_Sub.Visible = false;
            panelConNguoi_Sub.Visible = false;
            panelDatHang_Sub.Visible = false;
            panelHeThong_Sub.Visible = false;
            panelQuanLyHH_Sub.Visible = false;
            panelThongKe_Sub.Visible = false;
        }
        private void hidenSubMenu()
        {
            if (panelChinhSach_Sub.Visible == true)
            {
                panelChinhSach_Sub.Visible = false;
            }
            if (panelConNguoi_Sub.Visible == true)
            {
                panelConNguoi_Sub.Visible = false;
            }
            if (panelDatHang_Sub.Visible == true)
            {
                panelDatHang_Sub.Visible = false;
            }
            if (panelHeThong_Sub.Visible == true)
            {
                panelHeThong_Sub.Visible = false;
            }
            if (panelQuanLyHH_Sub.Visible == true)
            {
                panelQuanLyHH_Sub.Visible = false;
            }
            if (panelThongKe_Sub.Visible == true)
            {
                panelThongKe_Sub.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu == null)
            {
                hidenSubMenu();

            }
            else
            {
                if (subMenu.Visible == false)
                {
                    hidenSubMenu();
                    subMenu.Visible = true;
                }
                else
                {
                    subMenu.Visible = false;
                }
            }
        }
        private Form active = null;
        private void openChildForm(Form childForm)
        {
            if (active != null)
            {
                active.Close();
            }
            active = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelCenter.Controls.Add(childForm);
            childForm.BringToFront(); // Đưa panel lên đầu
            childForm.Show();
        }
        private void btnConNguoi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConNguoi_Sub);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, corlor);
            showSubMenu(null);
            //openChildForm(new Form1());

        }

        private void btndatHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDatHang_Sub);
            ActivateButton(sender, corlor);


        }

        private void btnQuanLyHangHoa_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanLyHH_Sub);
            ActivateButton(sender, corlor);
 

        }

        private void btnChinhSach_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChinhSach_Sub);
            ActivateButton(sender, corlor);


        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKe_Sub);
            ActivateButton(sender, corlor);

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHeThong_Sub);
            ActivateButton(sender, corlor);

        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnQLDonDatHang_Click(object sender, EventArgs e)
        {
            QuanLyDonHang qldh = new QuanLyDonHang();
            openChildForm(qldh);
        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {

            ////ChiTietDonHang a = new ChiTietDonHang();
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            themPhieuNhap a = new themPhieuNhap();
            openChildForm(a);
        }

        private void btnTTPhieuNhap_Click(object sender, EventArgs e)
        {
            thongTinPhieuNhap a = new thongTinPhieuNhap();
            openChildForm(a);
        }

        private void btnChinhSachKhuyenMai_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




      
    }
}
