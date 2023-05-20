using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc_Kho
    {
        private string _id;
        private DateTime _ngaynhap;
        private string _quycach;
        private int _sl_donggoi; 
        private string dv_donggoi;
        private int _dongia_donggoi;
        private int _total_nhap;
        private string dv_ban;
        private int _dongia_dvban;

        public Thuoc_Kho()
        {
        }

        public Thuoc_Kho(string id, DateTime ngaynhap, string quycach, int sl_donggoi, string dv_donggoi, int dongia_donggoi, int total_nhap, string dv_ban, int dongia_dvban)
        {
            _id = id;
            _ngaynhap = ngaynhap;
            _quycach = quycach;
            _sl_donggoi = sl_donggoi;
            this.dv_donggoi = dv_donggoi;
            _dongia_donggoi = dongia_donggoi;
            _total_nhap = total_nhap;
            this.dv_ban = dv_ban;
            _dongia_dvban = dongia_dvban;
        }

        public string Id { get => _id; set => _id = value; }
        public DateTime Ngaynhap { get => _ngaynhap; set => _ngaynhap = value; }
        public string Quycach { get => _quycach; set => _quycach = value; }
        public int Sl_donggoi { get => _sl_donggoi; set => _sl_donggoi = value; }
        public string Dv_donggoi { get => dv_donggoi; set => dv_donggoi = value; }
        public int Dongia_donggoi { get => _dongia_donggoi; set => _dongia_donggoi = value; }
        public int Total_nhap { get => _total_nhap; set => _total_nhap = value; }
        public string Dv_ban { get => dv_ban; set => dv_ban = value; }
        public int Dongia_dvban { get => _dongia_dvban; set => _dongia_dvban = value; }
    }
}
