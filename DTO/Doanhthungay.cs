using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Doanhthungay
    {
        private DateTime id_dtngay;
        private long tong_doanhthu_off;
        private int sl_donmua;
        private long tienhang;

        public Doanhthungay()
        {
        }

        public Doanhthungay(DateTime id_dtngay, long tong_doanhthu_off, int sl_donmua, long tienhang)
        {
            this.id_dtngay = id_dtngay;
            this.tong_doanhthu_off = tong_doanhthu_off;
            this.sl_donmua = sl_donmua;
            this.tienhang = tienhang;
        }

        public DateTime Id_dtngay { get => id_dtngay; set => id_dtngay = value; }
        public long Tong_doanhthu_off { get => tong_doanhthu_off; set => tong_doanhthu_off = value; }
        public int Sl_donmua { get => sl_donmua; set => sl_donmua = value; }
        public long Tienhang { get => tienhang; set => tienhang = value; }
    }
}
