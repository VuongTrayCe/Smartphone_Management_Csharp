using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.GUI.DonHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI
{
    public partial class chiTietPhieuNhap : Form
    {
        thongTinPhieuNhap ttpn = new thongTinPhieuNhap();
        thongTinPhieuNhap_DAO ctpn_DAO = new thongTinPhieuNhap_DAO();
        thongTinPhieuNhap_BUS ctpn_BUS = new thongTinPhieuNhap_BUS();
        thongTinPhieuNhap formPhieuNhap;
        string ngaynhap;
        string tennhacungcap;
        int maphieunnhap=0;

        public chiTietPhieuNhap(thongTinPhieuNhap formPhieuNhap,string Maphieunhap, string date, string ncc)
        {
            InitializeComponent();
            setupLayout(Maphieunhap, date, ncc);
            this.formPhieuNhap = formPhieuNhap;
            this.ngaynhap = date;
            this.tennhacungcap = ncc;
            this.maphieunnhap= int.Parse(Maphieunhap);
            
        }
        internal void setupLayout(string Maphieunhap, string date, string ncc)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ctpn_DAO.getChitietPhieuNhap(dataGridView1, Maphieunhap);

            label3.Text = Maphieunhap;
            label5.Text = date;
            label7.Text = ncc;

            string trangThaiReturn = ctpn_DAO.returnTrangThaiPhieuNhap(int.Parse(Maphieunhap));
            if (!(trangThaiReturn=="Đang Xử Lý"))
            {
                button2.Enabled = false;
                button2.Visible = false;
                button3.Enabled = false;
                button3.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print a = new Print();
            DataTable data = new DataTable();
            data = ttpn.getChiTietThongTinPhieuNhap(maphieunnhap);
            ;
            string ngaynhap2 = String.Format("{0:yyyy-MM-dd}", DateTime.Parse(ngaynhap));
            a.inHoaDonPhieuNhap(data, tennhacungcap, ngaynhap2);
 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctpn_DAO.updateTrangThaiPhieuNhap("Hoàn Thành", label3.Text);
            ctpn_DAO.updateSoLuongSanPham(dataGridView1);
            for(int i=0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ctpn_DAO.updateGiaSP(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                ctpn_DAO.insertGiaSP(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));  
            }
            MessageBox.Show("Duyệt phiếu nhập thành công!");
            this.Close();
            formPhieuNhap.init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctpn_DAO.updateTrangThaiPhieuNhap("Đã Hủy", label3.Text);
            MessageBox.Show("Huỷ phiếu nhập thành công!");
            this.Close();
            formPhieuNhap.init();

        }
    }
}
