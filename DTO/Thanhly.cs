using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thanhly
    {
        private string id_tl;
        private string id_thuoc;
        private long gia_tl;
        private long sl_tl;
        private long tong_tl;

        public Thanhly()
        {
        }

        public Thanhly(string id_thuoc, long gia_tl, long sl_tl, long tong_tl)
        {
            this.id_thuoc = id_thuoc;
            this.gia_tl = gia_tl;
            this.sl_tl = sl_tl;
            this.tong_tl = tong_tl;
        }

        public Thanhly(string id_tl, string id_thuoc, long gia_tl, long sl_tl, long tong_tl)
        {
            this.id_tl = id_tl;
            this.id_thuoc = id_thuoc;
            this.gia_tl = gia_tl;
            this.sl_tl = sl_tl;
            this.tong_tl = tong_tl;
        }

        public string Id_tl { get => id_tl; set => id_tl = value; }
        public string Id_thuoc { get => id_thuoc; set => id_thuoc = value; }
        public long Gia_tl { get => gia_tl; set => gia_tl = value; }
        public long Sl_tl { get => sl_tl; set => sl_tl = value; }
        public long Tong_tl { get => tong_tl; set => tong_tl = value; }
    }
}
