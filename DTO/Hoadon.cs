using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadon
    {
        private string id;
        private int hinhthuc; 
        private DateTime ngayxuat;
        private string idnv;
        private string idkh; 
        private long tongtien;
        private long tien_nhan;
        private long tien_tra;

        public Hoadon()
        {
        }

        public Hoadon(int hinhthuc, DateTime ngayxuat, string idnv, string idkh, long tongtien, long tien_nhan, long tien_tra)
        {
            this.hinhthuc = hinhthuc;
            this.ngayxuat = ngayxuat;
            this.idnv = idnv;
            this.idkh = idkh;
            this.tongtien = tongtien;
            this.tien_nhan = tien_nhan;
            this.tien_tra = tien_tra;
        }

        public Hoadon(string id, int hinhthuc, DateTime ngayxuat, string idnv, string idkh, long tongtien, long tien_nhan, long tien_tra)
        {
            this.id = id;
            this.hinhthuc = hinhthuc;
            this.ngayxuat = ngayxuat;
            this.idnv = idnv;
            this.idkh = idkh;
            this.tongtien = tongtien;
            this.tien_nhan = tien_nhan;
            this.tien_tra = tien_tra;
        }

        public string Id { get => id; set => id = value; }
        public int Hinhthuc { get => hinhthuc; set => hinhthuc = value; }
        public DateTime Ngayxuat { get => ngayxuat; set => ngayxuat = value; }
        public string Idnv { get => idnv; set => idnv = value; }
        public string Idkh { get => idkh; set => idkh = value; }
        public long Tongtien { get => tongtien; set => tongtien = value; }
        public long Tien_nhan { get => tien_nhan; set => tien_nhan = value; }
        public long Tien_tra { get => tien_tra; set => tien_tra = value; }
    }
}
