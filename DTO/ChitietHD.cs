using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChitietHD
    {
        private string id_hd; 
        private string id_thuoc; 
        private int sl_unit; 
        private long gia_unit;

        public ChitietHD()
        {
        }

        public ChitietHD(string id_hd, string id_thuoc, int sl_unit, long gia_unit)
        {
            this.id_hd = id_hd;
            this.id_thuoc = id_thuoc;
            this.sl_unit = sl_unit;
            this.gia_unit = gia_unit;
        }

        public string Id_hd { get => id_hd; set => id_hd = value; }
        public string Id_thuoc { get => id_thuoc; set => id_thuoc = value; }
        public int Sl_unit { get => sl_unit; set => sl_unit = value; }
        public long Gia_unit { get => gia_unit; set => gia_unit = value; }
    }
}
