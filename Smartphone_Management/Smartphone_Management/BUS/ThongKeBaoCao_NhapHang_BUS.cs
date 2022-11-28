using Smartphone_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.BUS
{
    internal class ThongKeBaoCao_NhapHang_BUS
    {
        DataTable data2 = new DataTable();

        ThongKeBaoCao_NhapHang_DAO tkbc = new ThongKeBaoCao_NhapHang_DAO();
        internal DataTable getThongKeNhapHang_HangHoa()
        {
            data2 = tkbc.getThongKeNhapHang_HangHoa();
            data2.Columns.Add("STT").SetOrdinal(0);
            for(int i = 0; i < data2.Rows.Count; i++)
            {
                data2.Rows[i][0] = i + 1;
            }
            DataTable data = new DataTable();

            //data.Columns.Add("STT");
            ////data.Columns.Add("NgayDat", Type.GetType("System.DateTime"));
            //data.Columns.Add("Tên Sản Phẩm");
            //data.Columns.Add("Mã Sản Phẩm");
            //data.Columns.Add("Số Lượng");
            //// Kiểm tra đơn hàng có đúng với từ khóa/ngày/ trạng thái tìm kiếm hay không 
            //int stt = 1;
            //for (int i = 0; i < data2.Rows.Count; i++)
            //{
            //    //dataGridView1.Rows.Add(1) ;
            //    DataRow row = data.NewRow();
            //    row["STT"] = stt;

            //    row["Tên Sản Phẩm"] = data2.Rows[i][0];
            //    row["Mã Sản Phẩm"] = data2.Rows[i][1];
            //    row["Số Lượng"] = data2.Rows[i][2];
            //    stt += 1;
            //    //int soluong = int.Parse(data2.Rows[i][2].ToString());
            //    //Double thanhtien = Double.Parse(data2.Rows[i][6].ToString())
            //    data.Rows.Add(row);
            //}
            return data2;
        }

        internal DataTable getThongKeNhapHang_NgayThang(DateTime dateStart, DateTime dateEnd)
        {

            data2 = tkbc.getThognKeNhapHang_NgayThang();
            data2.Columns.Add("STT").SetOrdinal(0);
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                data2.Rows[i][0] = i + 1;
            }



            DataTable data = new DataTable();
            foreach(DataColumn column in data2.Columns)
            {
                if(column.ColumnName.Equals("NgayNhap"))
                {
                    data.Columns.Add("NgayNhap", Type.GetType("System.DateTime"));

                }
                else
                {
                    data.Columns.Add(column.ColumnName);

                }
            }
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                DateTime dateDat = (DateTime)data2.Rows[i][1];
                if (dateDat > dateStart && dateDat < dateEnd)
                {

                    //dataGridView1.Rows.Add(1) ;
                    DataRow row = data.NewRow();
                    foreach (DataColumn col in data2.Columns)
                    {
                        row[col.ColumnName] = data2.Rows[i][col.ColumnName];

                    }
                    data.Rows.Add(row);
                }

            }



            return data;
        }
        internal DataTable getThongKeNhaphang_NhaCungCap()
        {

            data2 = tkbc.getThognKeNhapHang_NhaCungCap();
            data2.Columns.Add("STT").SetOrdinal(0);
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                data2.Rows[i][0] = i + 1;
            }
            return data2;
        }
    }
}
