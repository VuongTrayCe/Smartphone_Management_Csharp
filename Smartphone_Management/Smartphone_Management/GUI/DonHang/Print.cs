using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace Smartphone_Management.GUI.DonHang
{
    internal class Print
    {
        public void inHoaDonPhieuNhap(DataTable data, string tennhacungcap, string ngaynhap)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(data.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach(DataColumn col in data.Columns)
            {
                PdfPCell cell6 = new PdfPCell(new Phrase(col.ColumnName, text));
                cell6.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell6);
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {

                    pdftable.AddCell(new Phrase(data.Rows[i][j].ToString(), text));

                }
            }

            int tongsl = 0;
            Double tongtien = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {

                int soluong = int.Parse(data.Rows[i][3].ToString());
                Double thanhtien = Double.Parse(data.Rows[i][4].ToString());

                tongsl = tongsl + soluong;
                tongtien += thanhtien;
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "tet";
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 20f, 20f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();

                    Font titleFont = FontFactory.GetFont("Microsoft Sans Serif", 40);
                    Font titleFont2 = FontFactory.GetFont("Microsoft Sans Serif", 20);
                    Paragraph tenkhachhang1;
                    Paragraph ngaydat1;
                    Paragraph tongsoluong1;
                    Paragraph tongtien1;
                    Paragraph thank;



                    Paragraph title;
                    Paragraph text1;
                    title = new Paragraph("Hoa Don Phieu Nhap", titleFont);
                    text1 = new Paragraph("  ", titleFont2);

                    tenkhachhang1 = new Paragraph("Name: " + tennhacungcap, titleFont2);
                    ngaydat1 = new Paragraph("Date: " + ngaynhap, titleFont2);
                    tongsoluong1 = new Paragraph("TSL: " + tongsl, titleFont2);
                    tongtien1 = new Paragraph("Thanh Toan: " + tongtien + " VND", titleFont2);
                    thank = new Paragraph("----------------Thanks!---------------", titleFont2);


                    title.Alignment = Element.ALIGN_CENTER;
                    tenkhachhang1.Alignment = Element.ALIGN_LEFT;
                    ngaydat1.Alignment = Element.ALIGN_LEFT;
                    thank.Alignment = Element.ALIGN_CENTER;



                    pdfdoc.Add(title);
                    pdfdoc.Add(text1);

                    pdfdoc.Add(tenkhachhang1);
                    pdfdoc.Add(ngaydat1);
                    pdfdoc.Add(text1);


                    pdfdoc.Add(pdftable);
                    pdfdoc.Add(text1);
                    pdfdoc.Add(tongsoluong1);
                    pdfdoc.Add(tongtien1);

                    pdfdoc.Add(text1);
                    pdfdoc.Add(thank);


                    pdfdoc.Close();
                }
            }
        }

        public void inHoaDon(DataTable data,string tenkhachang,string ngayban)
        {
            data.Rows.RemoveAt(0);
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD,BaseFont.CP1250,BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(data.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,10,iTextSharp.text.Font.NORMAL);
            PdfPCell cell = new PdfPCell(new Phrase("STT", text));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell11 = new PdfPCell(new Phrase("Masp", text));
            cell11.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell1 = new PdfPCell(new Phrase("Name", text));
            cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell2 = new PdfPCell(new Phrase("SL", text));
            cell2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell3 = new PdfPCell(new Phrase("Gia", text));
            cell3.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell4 = new PdfPCell(new Phrase("KhuyenMai", text));
            cell4.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell5 = new PdfPCell(new Phrase("BaoHanh", text));
            cell5.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell6 = new PdfPCell(new Phrase("ThanhTien", text));
            cell6.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdftable.AddCell(cell);
            pdftable.AddCell(cell11);
            pdftable.AddCell(cell1);
            pdftable.AddCell(cell2);
            pdftable.AddCell(cell3);
            pdftable.AddCell(cell4);
            pdftable.AddCell(cell5);
            pdftable.AddCell(cell6);

            for (int i=0;i<data.Rows.Count;i++)
            {
                for(int j=0;j<data.Columns.Count;j++)
                {

                        pdftable.AddCell(new Phrase(data.Rows[i][j].ToString(), text));

                }
            }

            int tongsl = 0;
            Double tongtien = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {

                int soluong = int.Parse(data.Rows[i][3].ToString());
                Double thanhtien = Double.Parse(data.Rows[i][7].ToString());

                tongsl = tongsl + soluong;
                tongtien += thanhtien;
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "tet";
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 20f, 20f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();

                    Font titleFont = FontFactory.GetFont("Microsoft Sans Serif", 40);
                    Font titleFont2 = FontFactory.GetFont("Microsoft Sans Serif",20);
                    Paragraph tenkhachhang1;
                    Paragraph ngaydat1;
                    Paragraph tongsoluong1;
                    Paragraph tongtien1;
                    Paragraph thank;



                    Paragraph title;
                    Paragraph text1;
                    title = new Paragraph("BIll", titleFont);
                    text1 = new Paragraph("  ", titleFont2);

                    tenkhachhang1 = new Paragraph("Name: "+tenkhachang, titleFont2);
                    ngaydat1 = new Paragraph("Date: "+ngayban, titleFont2);
                   tongsoluong1 = new Paragraph("TSL: " + tongsl, titleFont2);
                   tongtien1 = new Paragraph("Thanh Toan: " +tongtien+" VND", titleFont2);
                    thank = new Paragraph("Thanks!", titleFont2);


                    title.Alignment = Element.ALIGN_CENTER;
                    tenkhachhang1.Alignment = Element.ALIGN_LEFT;
                    ngaydat1.Alignment = Element.ALIGN_LEFT;
                    thank.Alignment = Element.ALIGN_CENTER;



                    pdfdoc.Add(title);
                    pdfdoc.Add(text1);

                    pdfdoc.Add(tenkhachhang1);
                    pdfdoc.Add(ngaydat1);
                    pdfdoc.Add(text1);


                    pdfdoc.Add(pdftable);
                    pdfdoc.Add(text1);
                    pdfdoc.Add(tongsoluong1);
                    pdfdoc.Add(tongtien1);

                    pdfdoc.Add(text1);
                    pdfdoc.Add(thank);


                    pdfdoc.Close();
                }
            }
        }
    }
}
