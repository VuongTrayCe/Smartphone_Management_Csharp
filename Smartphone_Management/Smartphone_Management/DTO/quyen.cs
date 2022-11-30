using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DTO
{
    public class quyen
    {
        private int maQuyen;
        private string tenQuyen;

        public quyen(string tenQuyen)
        {
            this.TenQuyen = tenQuyen;
        }

        public int MaQuyen { get => maQuyen; set => maQuyen = value; }

        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }



    }
}
