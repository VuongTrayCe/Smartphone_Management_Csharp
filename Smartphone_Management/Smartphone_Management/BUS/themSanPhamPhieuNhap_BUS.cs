using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;
using Smartphone_Management.DAO;

namespace Smartphone_Management.BUS
{
    class themSanPhamPhieuNhap_BUS
    {
        themSanPhamPhieuNhap_DAO tsppn = new themSanPhamPhieuNhap_DAO();
        public void setTFCombobox(ComboBox comboBox1)
        {
            comboBox1.Items.Add("T");
            comboBox1.Items.Add("F");
        }

        internal List<List<string>> getDataSanPham(int mancc)
        {
            return tsppn.getDataSanPham(mancc);

        }
    }
}
