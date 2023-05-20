using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class Thuoc
    {
        private string _id;
        private string _name;
        private DateTime _nsx;
        private DateTime _hsd;
        private string id_ncc;
        private string id_nt;
        private string _nhasx;
        private string _chungnhan;
        private int _hamluong;
        private string _thanhphan;
        private string _chidinh;
        private string _chongcd;
        private byte[] img;

        public Thuoc()
        {
        }

        public Thuoc(string name, DateTime nsx, DateTime hsd, string ncc, string nt, string nhasx, string chungnhan, int hamluong, string thanhphan, string chidinh, string chongcd, byte[] img)
        {
            _name = name;
            _nsx = nsx;
            _hsd = hsd;
            id_ncc = ncc;
            id_nt = nt;
            _nhasx = nhasx;
            _chungnhan = chungnhan;
            _hamluong = hamluong;
            _thanhphan = thanhphan;
            _chidinh = chidinh;
            _chongcd = chongcd;
            this.img = img;
        }
        public Thuoc(string id, string name, DateTime nsx, DateTime hsd, string ncc, string nt, string nhasx, string chungnhan, int hamluong, string thanhphan, string chidinh, string chongcd, byte[] img)
        {
            _id = id;
            _name = name;
            _nsx = nsx;
            _hsd = hsd;
            id_ncc = ncc;
            id_nt = nt;
            _nhasx = nhasx;
            _chungnhan = chungnhan;
            _hamluong = hamluong;
            _thanhphan = thanhphan;
            _chidinh = chidinh;
            _chongcd = chongcd;
            this.img = img;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Nsx { get => _nsx; set => _nsx = value; }
        public DateTime Hsd { get => _hsd; set => _hsd = value; }
        public string Nhasx { get => _nhasx; set => _nhasx = value; }
        public string Chungnhan { get => _chungnhan; set => _chungnhan = value; }
        public int Hamluong { get => _hamluong; set => _hamluong = value; }
        public string Thanhphan { get => _thanhphan; set => _thanhphan = value; }
        public string Chidinh { get => _chidinh; set => _chidinh = value; }
        public string Chongcd { get => _chongcd; set => _chongcd = value; }
        public byte[] Img { get => img; set => img = value; }
        public string Id_ncc { get => id_ncc; set => id_ncc = value; }
        public string Id_nt { get => id_nt; set => id_nt = value; }
    }
}