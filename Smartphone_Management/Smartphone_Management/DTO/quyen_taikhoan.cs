using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class quyen_taikhoan
    {
        private int maQuyenTk;
        private int maTk;
        private int maQuyen;

        public quyen_taikhoan(int maTk, int maQuyen )
        {
            this.MaTk = maTk;
            this.MaQuyen = maQuyen;
        }

        public int MaQuyenTk { get => maQuyenTk; set => maQuyenTk = value; }
        public int MaTk { get => maTk; set => maTk = value; }
        public int MaQuyen { get => maQuyen; set => maQuyen = value; }

    }
}
