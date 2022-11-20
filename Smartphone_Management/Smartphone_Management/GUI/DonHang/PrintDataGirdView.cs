using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.DonHang
{
    internal class PrintDataGirdView
    {
        private DataGridView TheDataGridView;
        // The PrintDocument to be used for printing
        private PrintDocument ThePrintDocument;
        // Determine if the report will be
        // printed in the Top-Center of the page
        private bool IsCenterOnPage;
        // Determine if the page contain title text
        private bool IsWithTitle;
        // The title text to be printed
        // in each page (if IsWithTitle is set to true)
        private string TheTitleText;
        // The font to be used with the title
        // text (if IsWithTitle is set to true)
        private Font TheTitleFont;
        // The color to be used with the title
        // text (if IsWithTitle is set to true)
        private Color TheTitleColor;
        // Determine if paging is used
        private bool IsWithPaging;


    }
}
