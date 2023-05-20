using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChitietDonnhap
    {
        private string id_donnhap; 
        private string id_thuoc;
        private long sl_nhap;

        public ChitietDonnhap()
        {
        }

        public ChitietDonnhap(string id_donnhap, string id_thuoc, long sl_nhap)
        {
            this.id_donnhap = id_donnhap;
            this.id_thuoc = id_thuoc;
            this.sl_nhap = sl_nhap;
        }

        public string Id_donnhap { get => id_donnhap; set => id_donnhap = value; }
        public string Id_thuoc { get => id_thuoc; set => id_thuoc = value; }
        public long Sl_nhap { get => sl_nhap; set => sl_nhap = value; }
    }
}
