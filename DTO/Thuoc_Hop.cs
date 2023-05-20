using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc_Hop
    {
        private string id_thuoc;
        private int sl_hop;
        private int dongia_hop;
        private int sl_vi;
        private int dongia_vi;
        private int sl_vien;
        private int dongia_vien;

        public Thuoc_Hop()
        {
        }

        public Thuoc_Hop(string id_thuoc, int sl_hop, int dongia_hop, int sl_vi, int dongia_vi, int sl_vien, int dongia_vien)
        {
            this.id_thuoc = id_thuoc;
            this.sl_hop = sl_hop;
            this.dongia_hop = dongia_hop;
            this.sl_vi = sl_vi;
            this.dongia_vi = dongia_vi;
            this.sl_vien = sl_vien;
            this.dongia_vien = dongia_vien;
        }

        public string Id_thuoc { get => id_thuoc; set => id_thuoc = value; }
        public int Sl_hop { get => sl_hop; set => sl_hop = value; }
        public int Dongia_hop { get => dongia_hop; set => dongia_hop = value; }
        public int Sl_vi { get => sl_vi; set => sl_vi = value; }
        public int Dongia_vi { get => dongia_vi; set => dongia_vi = value; }
        public int Sl_vien { get => sl_vien; set => sl_vien = value; }
        public int Dongia_vien { get => dongia_vien; set => dongia_vien = value; }
    }
}
