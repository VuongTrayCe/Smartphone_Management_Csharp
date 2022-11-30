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
    class themPhieuNhap_BUS
    {
        public float returnTongTien(DataGridView dataGridView1)
        {
            float tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tong += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            return tong;
        }
        public int returnSoLuong(DataGridView dataGridView1)
        {
            int tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tong += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            return tong;
        }
    }
}
