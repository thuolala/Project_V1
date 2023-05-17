using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc
    {
        private string _id;
        private string _name;
        private string _id_nt; //nhom thuoc 
        private DateTime _nsx;
        private DateTime _hsd;
        private int _sl;
        private int _dongia; //don gia = unit price 
        private int _hamluong; //ham luong 
        private string _thanhphan;
        private string _chidinh;
        private string _chongcd; //chong chi dinh 
        private byte[] _img1;
        private byte[] _img2;

        public Thuoc(string name, string id_nt, DateTime nsx, DateTime hsd, int sl, int dongia, int hamluong, string thanhphan, string chidinh, string chongcd, byte[] img1, byte[] img2)
        {
            _name = name;
            _id_nt = id_nt;
            _nsx = nsx;
            _hsd = hsd;
            _sl = sl;
            _dongia = dongia;
            _hamluong = hamluong;
            _thanhphan = thanhphan;
            _chidinh = chidinh;
            _chongcd = chongcd;
            _img1 = img1;
            _img2 = img2;
        }

        public Thuoc(string id, string name, string id_nt, DateTime nsx, DateTime hsd, int sl, int dongia, int hamluong, string thanhphan, string chidinh, string chongcd, byte[] img1, byte[] img2)
        {
            _id = id;
            _name = name;
            _id_nt = id_nt;
            _nsx = nsx;
            _hsd = hsd;
            _sl = sl;
            _dongia = dongia;
            _hamluong = hamluong;
            _thanhphan = thanhphan;
            _chidinh = chidinh;
            _chongcd = chongcd;
            _img1 = img1;
            _img2 = img2;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Id_nt { get => _id_nt; set => _id_nt = value; }
        public DateTime Nsx { get => _nsx; set => _nsx = value; }
        public DateTime Hsd { get => _hsd; set => _hsd = value; }
        public int Sl { get => _sl; set => _sl = value; }
        public int Dongia { get => _dongia; set => _dongia = value; }
        public int Hamluong { get => _hamluong; set => _hamluong = value; }
        public string Thanhphan { get => _thanhphan; set => _thanhphan = value; }
        public string Chidinh { get => _chidinh; set => _chidinh = value; }
        public string Chongcd { get => _chongcd; set => _chongcd = value; }
        public byte[] Img1 { get => _img1; set => _img1 = value; }
        public byte[] Img2 { get => _img2; set => _img2 = value; }
    }
}
