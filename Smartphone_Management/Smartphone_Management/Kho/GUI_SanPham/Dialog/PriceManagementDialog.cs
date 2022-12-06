using Smartphone_Management.BUS;
using Smartphone_Management.DTO;
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
using System.Windows.Input;

namespace Smartphone_Management.GUI.GUI_SanPham.Dialog
{
    public partial class PriceManagementDialog : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;

        }

        private static GiaSanPhamBUS giaSanPhamBUS = new GiaSanPhamBUS();
        private static SanPhamBUS sanphamBUS = new SanPhamBUS();
        public int maSPSelected { set; get; }
        public PriceManagementDialog()
        {
            InitializeComponent();
            PanelLoiSanPham.Hide();
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

        private void showGiaSanPham(int maSPSelected)
        {
            DataGridViewGiaSanPham.Rows.Clear();
            List<GiaSanPhamDTO> giaSanPhamDTOList = giaSanPhamBUS.getGiaByMaSanPham(maSPSelected);
            for (int i = 0; i < giaSanPhamDTOList.Count; i++)
            {
                GiaSanPhamDTO giaSanPhamDTO = giaSanPhamDTOList[i];
                DataGridViewGiaSanPham.Rows.Add();
                DataGridViewGiaSanPham.Rows[i].Cells[0].Value = giaSanPhamDTO.Magiasp;
                DataGridViewGiaSanPham.Rows[i].Cells[1].Value = giaSanPhamDTO.Masp;
                DataGridViewGiaSanPham.Rows[i].Cells[2].Value = giaSanPhamDTO.Gianhap;
                DataGridViewGiaSanPham.Rows[i].Cells[3].Value = giaSanPhamDTO.Giaban;
                DataGridViewGiaSanPham.Rows[i].Cells[4].Value = giaSanPhamDTO.Ngayupdate;
                if (giaSanPhamDTO.TrangThai == "T")
                {
                    DataGridViewGiaSanPham.Rows[i].Cells[5].Value = "Sử dụng";
                    GiaNhapSanPham.Text = giaSanPhamDTO.Gianhap.ToString();
                    GiaBanSanPham.Text = giaSanPhamDTO.Giaban.ToString();
                }
                else if (giaSanPhamDTO.TrangThai == "F")
                {
                    DataGridViewGiaSanPham.Rows[i].Cells[5].Value = "Hết hạn";
                }
            }
        }

        private void PriceManagementDialog_Load(object sender, EventArgs e)
        {
            LabelTitle.Text = "QUẢN LÝ GIÁ SẢN PHẨM [ MÃ " + maSPSelected.ToString() + " ]";
            TenSanPham.Text = sanphamBUS.getSanPhamByID(maSPSelected).Tensp;
            showGiaSanPham(maSPSelected);
            DataGridViewGiaSanPham.ScrollBars = ScrollBars.Vertical;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSuaGiaSanPham_Click(object sender, EventArgs e)
        {
            string errorMessage = giaSanPhamBUS.checkInputGiaSanPham(GiaNhapSanPham.Text, GiaBanSanPham.Text);
            if (errorMessage.Equals(""))
            {
                PanelLoiSanPham.Hide();
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn cập nhật giá cho sản phẩm này?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { TenSanPham.Focus(); }
                if (dialogResult == DialogResult.Yes)
                {
                    TenSanPham.Focus();
                    /*---------------------------- Cancel giá cũ sản phẩm ----------------------------*/
                    giaSanPhamBUS.cancelGiaSanPham(maSPSelected);
                    /*---------------------------- Insert giá mới sản phẩm ----------------------------*/
                    GiaSanPhamDTO giaSanPhamDTO = new GiaSanPhamDTO();
                    giaSanPhamDTO.Masp = maSPSelected;
                    giaSanPhamDTO.Gianhap = Int32.Parse(GiaNhapSanPham.Text);
                    giaSanPhamDTO.Giaban = Int32.Parse(GiaBanSanPham.Text);
                    giaSanPhamDTO.Ngayupdate = getToday();
                    giaSanPhamDTO.TrangThai = "T";
                    giaSanPhamBUS.insertGiaSanPham(giaSanPhamDTO);
                    showGiaSanPham(maSPSelected);
                }
            } else
            {
                PanelLoiSanPham.Show();
                LabelLoiSanPham.Text = errorMessage;
            }
        }
    }
}
