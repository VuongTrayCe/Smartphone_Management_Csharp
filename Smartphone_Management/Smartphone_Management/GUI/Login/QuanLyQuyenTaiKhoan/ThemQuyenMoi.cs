using Smartphone_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.Login.QuanLyQuyenTaiKhoan
{
    public partial class ThemQuyenMoi : Form
    {
        ThemQuyenTaiKhoan frame;
        List<List<String>> dataQuyenMoi;
        List<List<String>> dataQuyenChuaCo;
        int matk;

        QuanLyPhanQuyen_BUS qlpq = new QuanLyPhanQuyen_BUS();
        public ThemQuyenMoi(int matk,ThemQuyenTaiKhoan frame,List<List<String>> dataQuyenMoi)
        {
            InitializeComponent();
            this.frame=frame;
            this.matk = matk;
            this.dataQuyenMoi = dataQuyenMoi;
            init();
        }

        public void init()
        {
            dataQuyenChuaCo = qlpq.getQuyenChuaCo(this.matk);

            foreach (List<String> item in dataQuyenChuaCo)
            {
                List<String> strings = item as List<String>;
                bool flag = true;
                foreach(List<String> items in dataQuyenMoi)
                {
                    List<String> strings2 = items as List<String>;
                    if(strings2.ElementAt(1).ToString().Equals(strings.ElementAt(1).ToString()))
                    {
                        flag = false;
                    }
                }
                if(flag==true)
                {
                    CbbQuyenChuaCo.Items.Add(strings.ElementAt(1).ToString());

                }

            }
            //List<String> strings1 = datacbbmatk.ElementAt(0) as List<String>;
            if(CbbQuyenChuaCo.Items.Count!=0)
            {
                CbbQuyenChuaCo.SelectedIndex = 0;

            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frame.init();
            //frame.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String item = CbbQuyenChuaCo.SelectedItem.ToString();
            foreach (List<String> item2 in dataQuyenChuaCo)
            {
                if (item2.ElementAt(1).ToString().Equals(item))
                {
                    dataQuyenMoi.Add(item2);

                }
            }
            this.Dispose();
            frame.init();
        }
    }
}
