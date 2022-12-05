using DocumentFormat.OpenXml.Drawing.Charts;
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
using DataTable = System.Data.DataTable;

namespace Smartphone_Management.GUI.GUI_SanPham.Dialog
{
    public partial class FullDataDialog : Form
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

        private SanPhamBUS sanphamBUS = new SanPhamBUS();
        private string getImageStorePath()
        {
            string startUpPath = Application.StartupPath;
            string imageStorePath = startUpPath.Remove(startUpPath.Length - 9) + @"\GUI\GUI_SanPham\HinhAnh\";
            return imageStorePath;
        }
        public FullDataDialog()
        {
            InitializeComponent();
            DataGridViewFullSanPham.RowTemplate.Height = 90;
            DataGridViewFullSanPham.ScrollBars = ScrollBars.Vertical;
            Padding newPadding = new Padding(0, 5, 0, 5);
            DataGridViewFullSanPham.RowTemplate.DefaultCellStyle.Padding = newPadding;
            DataGridViewFullSanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List<SanPhamDTO> sanphamDTOList = sanphamBUS.getFullDataSanPham();
            for (int i = 0; i < sanphamDTOList.Count; i++)
            {
                SanPhamDTO sanphamDTO = sanphamDTOList[i];
                DataGridViewFullSanPham.Rows.Add();
                DataGridViewFullSanPham.Rows[i].Cells[0].Value = sanphamDTO.Masp;
                DataGridViewFullSanPham.Rows[i].Cells[1].Value = sanphamDTO.Tensp;
                DataGridViewFullSanPham.Rows[i].Cells[2].Value = sanphamDTO.Loaisp;
                DataGridViewFullSanPham.Rows[i].Cells[3].Value = sanphamDTO.soluong;
                DataGridViewFullSanPham.Rows[i].Cells[4].Value = sanphamDTO.MauSac;
                DataGridViewFullSanPham.Rows[i].Cells[5].Value = sanphamDTO.Namsx;
                if (!sanphamDTO.Icon.Equals(""))
                {
                    Bitmap bitmap = (Bitmap)Bitmap.FromFile(getImageStorePath() + sanphamDTO.Icon);
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = bitmap;
                    DataGridViewFullSanPham.Rows[i].Cells[6] = imageCell;
                }
                else
                {
                    Bitmap bitmap = (Bitmap)Bitmap.FromFile(getImageStorePath() + "no_image.png");
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = bitmap;
                    DataGridViewFullSanPham.Rows[i].Cells[6] = imageCell;
                }
                DataGridViewFullSanPham.Rows[i].Cells[7].Value = sanphamDTO.ThongSo;
                DataGridViewFullSanPham.Rows[i].Cells[8].Value = sanphamDTO.Mancc;
                DataGridViewFullSanPham.Rows[i].Cells[9].Value = sanphamDTO.Gianhap;
                DataGridViewFullSanPham.Rows[i].Cells[10].Value = sanphamDTO.Giaban;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
