using DocumentFormat.OpenXml.Drawing.Charts;
using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using DataTable = System.Data.DataTable;

namespace Smartphone_Management.GUI.DonHang
{
    public partial class FormExport_PreView : Form
    {
        //QuanLyDonDatHang_BUS qldh_bus = new QuanLyDonDatHang_BUS();
        QuanLyDonDatHang_DAO qldh_dao = new QuanLyDonDatHang_DAO();
        DataTable data;
        public FormExport_PreView(DataTable data)
        {
            InitializeComponent();
            init();
            this.data = data;

            ThietLap();
     

        }

        public void ThietLap()
        {
            textBox1.AppendText("\t\t\tHoa Don Ban Hang \r\n");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                foreach (DataColumn col in data.Columns)
                {
                    textBox1.AppendText(data.Rows[i][col.ColumnName].ToString());
                    textBox1.AppendText("    ");
                }
                textBox1.AppendText("\t \r\n");


            }
        }
        public void init()
        {
            DataTable data = new DataTable();
            data = qldh_dao.getThongTinDonhang();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Printer(this.panel2);
        }
        private Panel panelPrint;
        private void Printer(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getPrintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_Printpage);
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument_Printpage(object sender,PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawString("/tHóa Đơn\n Tran Quoc Vuong", new Font("Times New Roman", 12.0f), Brushes.Black, 100, 100);
            //e.Graphics.DrawImage(memory, (pageArea.Width / 2)-(this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private Bitmap memory;
       private void getPrintarea(Panel pnl)
        {
            memory = new Bitmap(pnl.Width,pnl.Height);
            pnl.DrawToBitmap(memory,new Rectangle(0,0,pnl.Width,pnl.Height));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormExport_PreView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartphonemanagementDataSet1.donhang' table. You can move, or remove it, as needed.

        }
    }
}
