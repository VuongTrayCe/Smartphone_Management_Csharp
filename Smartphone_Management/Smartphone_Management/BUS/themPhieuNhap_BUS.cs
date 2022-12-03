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
using Smartphone_Management.DTO;

namespace Smartphone_Management.BUS
{
    class themPhieuNhap_BUS
    {
        themPhieuNhap_DAO tpn = new themPhieuNhap_DAO();

        public float returnTongTien(DataGridView dataGridView1)
        {
            float tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tong += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            return tong;
        }
        public int returnSoLuong(DataGridView dataGridView1)
        {
            int tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tong += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            return tong;
        }

        internal List<List<string>> getDataNhaCungCap()
        {
            return tpn.getDataNhaCungCap();
        }

        internal int AddPhieuNhap(Model_PhieuNhap dataPhieuNhap)
        {
         return tpn.addPhieuNhap(dataPhieuNhap);
        }

        internal void AddChitietPhieuNhap(List<Model_ChiTietPhieuNhap> dataChiTiet, int madh)
        {
          foreach(Model_ChiTietPhieuNhap ph in dataChiTiet)
            {
                tpn.AddChiTietPhieuNhap2(ph, madh);
          }
        }
    }
}
