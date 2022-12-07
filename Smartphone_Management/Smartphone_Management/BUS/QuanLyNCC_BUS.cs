using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.BUS
{
    internal class QuanLyNCC_BUS
    {
        QuanLyNCC_DAO qlncc_DAO = new QuanLyNCC_DAO();

        public DataTable TimKiemNCC_BUS(string text)
        {
            return qlncc_DAO.TimKiemNCC_DAO(text);
        }

        public DataTable getNCC_BUS()
        {
            return qlncc_DAO.getNCC_DAO();
        }

        public void ThemNCC_BUS(nhacungcap ncc)
        {
            qlncc_DAO.ThemNCC_DAO(ncc);
        }

        public void XoaNCC_BUS(int maNCC)
        {
            qlncc_DAO.XoaNCC_DAO(maNCC);
        }

        public void CapNhatNCC_BUS(nhacungcap ncc, int maNCC)
        {
            qlncc_DAO.CapNhatNCC_DAO(ncc, maNCC);
        }
    }
}
