using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ngansach
    {
        private string id_ns;
        private long tien_ns;
        private DateTime ngay_capnhat;
        private string id_nv;
        private long doanhthu;
        private long loinhuan;

        public Ngansach()
        {
        }

        public Ngansach(long tien_ns, DateTime ngay_capnhat, string id_nv, long doanhthu, long loinhuan)
        {
            this.tien_ns = tien_ns;
            this.ngay_capnhat = ngay_capnhat;
            this.id_nv = id_nv;
            this.doanhthu = doanhthu;
            this.loinhuan = loinhuan;
        }

        public Ngansach(string id_ns, long tien_ns, DateTime ngay_capnhat, string id_nv, long doanhthu, long loinhuan)
        {
            this.id_ns = id_ns;
            this.tien_ns = tien_ns;
            this.ngay_capnhat = ngay_capnhat;
            this.id_nv = id_nv;
            this.doanhthu = doanhthu;
            this.loinhuan = loinhuan;
        }

        public string Id_ns { get => id_ns; set => id_ns = value; }
        public long Tien_ns { get => tien_ns; set => tien_ns = value; }
        public DateTime Ngay_capnhat { get => ngay_capnhat; set => ngay_capnhat = value; }
        public string Id_nv { get => id_nv; set => id_nv = value; }
        public long Doanhthu { get => doanhthu; set => doanhthu = value; }
        public long Loinhuan { get => loinhuan; set => loinhuan = value; }
    }
}
