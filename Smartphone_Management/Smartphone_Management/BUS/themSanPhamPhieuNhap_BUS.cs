using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace Smartphone_Management.BUS
{
    class themSanPhamPhieuNhap_BUS
    {
        public void setTFCombobox(ComboBox comboBox1)
        {
            comboBox1.Items.Add("T");
            comboBox1.Items.Add("F");
        }
    }
}
