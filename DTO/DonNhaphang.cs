using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonNhaphang
    {
        private string id;
        private DateTime ngaynhap; 
        private string id_nv; 
        private string ncc;
        private long total_nhap;

        public DonNhaphang()
        {
        }

        public DonNhaphang(DateTime ngaynhap, string id_nv, string ncc, long total_nhap)
        {
            this.ngaynhap = ngaynhap;
            this.id_nv = id_nv;
            this.ncc = ncc;
            this.total_nhap = total_nhap;
        }

        public DonNhaphang(string id, DateTime ngaynhap, string id_nv, string ncc, long total_nhap)
        {
            this.id = id;
            this.ngaynhap = ngaynhap;
            this.id_nv = id_nv;
            this.ncc = ncc;
            this.total_nhap = total_nhap;
        }

        public string Id { get => id; set => id = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Id_nv { get => id_nv; set => id_nv = value; }
        public string Ncc { get => ncc; set => ncc = value; }
        public long Total_nhap { get => total_nhap; set => total_nhap = value; }
    }
}
