using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuocnhap
    {
        private string _id;
        private string _id_ncc; //nha cung cap
        private DateTime _ngaynhap;
        private int _slnhap; //so luong nhap 
        private int _gianhap; //import 
        private string _ghichu;

        public Thuocnhap(string id_ncc, DateTime ngaynhap, int slnhap, int gianhap, string ghichu)
        {
            _id_ncc = id_ncc;
            _ngaynhap = ngaynhap;
            _slnhap = slnhap;
            _gianhap = gianhap;
            _ghichu = ghichu;
        }

        public Thuocnhap(string id, string id_ncc, DateTime ngaynhap, int slnhap, int gianhap, string ghichu)
        {
            _id = id;
            _id_ncc = id_ncc;
            _ngaynhap = ngaynhap;
            _slnhap = slnhap;
            _gianhap = gianhap;
            _ghichu = ghichu;
        }

        public string Id { get => _id; set => _id = value; }
        public string Id_ncc { get => _id_ncc; set => _id_ncc = value; }
        public DateTime Ngaynhap { get => _ngaynhap; set => _ngaynhap = value; }
        public int Slnhap { get => _slnhap; set => _slnhap = value; }
        public int Gianhap { get => _gianhap; set => _gianhap = value; }
        public string Ghichu { get => _ghichu; set => _ghichu = value; }
    }
}
