using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.BUS
{
    internal class LoiNhuanBanHang_BUS
    {
        LoiNhuanBanHang_DAO lnbh = new LoiNhuanBanHang_DAO();
        DataTable dt = new DataTable();
        internal DataTable getLoiNhuanBanHang_HangHoa()
        {
            dt = lnbh.getLoiNhuanBanHang_HangHoa();
            int tongtien = 0;
            int tongso = 0;
            int tienhang = 0;
            int tiensaukm = 0;
            int tienvon = 0;
            int tienlai = 0;
            dt.Columns.Add("Tiền Lãi");

            for (int i=0;i<dt.Rows.Count;i++)
            {
               int tiensaukm1 = int.Parse(dt.Rows[i][4].ToString());
               int tienvon1 = int.Parse(dt.Rows[i][5].ToString());
                dt.Rows[i][6] = tiensaukm1 - tienvon1;
                tiensaukm += tiensaukm1;
                tienlai += tiensaukm1 - tienvon1;
                tienvon += tienvon1;
                tongso+= int.Parse(dt.Rows[i][2].ToString());
            }
            DataRow a = dt.NewRow();
            a["TongSo"] = tongso;
            a["TienSauKM"] = tiensaukm;
            a["TienVon"] = tienvon;
            a["Tiền Lãi"] = tienlai;
            dt.Rows.InsertAt(a,0);
            return dt;
        }

        internal List<List<string>> getLoiNhuanBanHang_HangHoa_BieuDo1()
        {
           return lnbh.getLoiNhuanBanHang_HangHoa_BieuDo1();
        }

        internal DataTable getLoiNhuanBanHang_LaiLo()
        {
            return dt;
        }

        internal List<List<string>> getLoiNhuanBanHang_NgayBan_BieuDo1(string ngaybatdau, string ngayketthuc)
        {
            return lnbh.getLoiNhuanBanHang_NgayBan_BieuDo1(ngaybatdau,ngayketthuc);
        }

        internal DataTable getLoiNhuanBanHang_TheoThang(DateTime dateStart,DateTime dateEnd)
        {
           dt =  lnbh.getLoiNhuanBanHang_TheoThang();

            DataTable data = new DataTable();

            data.Columns.Add("STT");
            data.Columns.Add("Ngayban", Type.GetType("System.DateTime"));
            data.Columns.Add("Soluongdon");
            data.Columns.Add("Soluong");
            data.Columns.Add("Tongtien");
            data.Columns.Add("Von");
            data.Columns.Add("Tien Lai");
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime dateDat = (DateTime)dt.Rows[i][0];
                if (dateDat > dateStart && dateDat < dateEnd)
                {

                    //dataGridView1.Rows.Add(1) ;
                    DataRow row = data.NewRow();
                    row["STT"] = stt;
                    Double tongtien = Double.Parse(dt.Rows[i][3].ToString());
                    int von = int.Parse(dt.Rows[i][4].ToString());

                    foreach (DataColumn col in dt.Columns)
                    {
                        row[col.ColumnName] = dt.Rows[i][col.ColumnName];

                    }
                    row[6] = tongtien - von;
                    data.Rows.Add(row);
                    stt++;
                }

            }


            return data;
        }
    }
}
