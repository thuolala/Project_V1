using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Doanhthunam
    {
        private string id_dtt;
        private long tongtien_don_off;
        private long tongtien_don_onl;
        private long tongtien;

        private long tienhang_daban;
        private long tien_nhap;
        private long chi_phi;

        private long loi_nhuan;

        public Doanhthunam()
        {
        }

        public Doanhthunam(string id_dtt, long tongtien_don_off, long tongtien_don_onl, long tongtien, long tienhang_daban, long tien_nhap, long chi_phi, long loi_nhuan)
        {
            this.id_dtt = id_dtt;
            this.tongtien_don_off = tongtien_don_off;
            this.tongtien_don_onl = tongtien_don_onl;
            this.tongtien = tongtien;
            this.tienhang_daban = tienhang_daban;
            this.tien_nhap = tien_nhap;
            this.chi_phi = chi_phi;
            this.loi_nhuan = loi_nhuan;
        }

        public string Id_dtt { get => id_dtt; set => id_dtt = value; }
        public long Tongtien_don_off { get => tongtien_don_off; set => tongtien_don_off = value; }
        public long Tongtien_don_onl { get => tongtien_don_onl; set => tongtien_don_onl = value; }
        public long Tongtien { get => tongtien; set => tongtien = value; }
        public long Tienhang_daban { get => tienhang_daban; set => tienhang_daban = value; }
        public long Tien_nhap { get => tien_nhap; set => tien_nhap = value; }
        public long Chi_phi { get => chi_phi; set => chi_phi = value; }
        public long Loi_nhuan { get => loi_nhuan; set => loi_nhuan = value; }
    }
}
