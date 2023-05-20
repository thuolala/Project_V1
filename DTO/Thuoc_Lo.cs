using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc_Lo
    {
        private string id_thuoc;
        private int sl_lo;
        private int dongia_lo;
        private int sl_vien;
        private int dongia_vien;

        public Thuoc_Lo()
        {
        }

        public Thuoc_Lo(string id_thuoc, int sl_lo, int dongia_lo, int sl_vien, int dongia_vien)
        {
            this.id_thuoc = id_thuoc;
            this.sl_lo = sl_lo;
            this.dongia_lo = dongia_lo;
            this.sl_vien = sl_vien;
            this.dongia_vien = dongia_vien;
        }

        public string Id_thuoc { get => id_thuoc; set => id_thuoc = value; }
        public int Sl_lo { get => sl_lo; set => sl_lo = value; }
        public int Dongia_lo { get => dongia_lo; set => dongia_lo = value; }
        public int Sl_vien { get => sl_vien; set => sl_vien = value; }
        public int Dongia_vien { get => dongia_vien; set => dongia_vien = value; }
    }
}
