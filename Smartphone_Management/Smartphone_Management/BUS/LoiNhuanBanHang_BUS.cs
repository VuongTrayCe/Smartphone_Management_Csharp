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



            return dt;
        }

        internal DataTable getLoiNhuanBanHang_LaiLo()
        {
            dt = lnbh.getLoiNhuanBanHang_LaiLo();
            return dt;
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
