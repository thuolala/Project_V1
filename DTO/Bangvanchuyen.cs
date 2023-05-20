using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bangvanchuyen
    {
        private string id_hd; 
        private string id_kh;
        private int tinhtrang_vc;
        private string ghichu;
        private long tongtien;

        public Bangvanchuyen()
        {
        }

        public Bangvanchuyen(string id_hd, string id_kh, int tinhtrang_vc, string ghichu, long tongtien)
        {
            this.id_hd = id_hd;
            this.id_kh = id_kh;
            this.tinhtrang_vc = tinhtrang_vc;
            this.ghichu = ghichu;
            this.tongtien = tongtien;
        }

        public string Id_hd { get => id_hd; set => id_hd = value; }
        public string Id_kh { get => id_kh; set => id_kh = value; }
        public int Tinhtrang_vc { get => tinhtrang_vc; set => tinhtrang_vc = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public long Tongtien { get => tongtien; set => tongtien = value; }
    }
}
