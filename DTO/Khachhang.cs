using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang
    {
        private string _id;
        private string _name;
        private string _address;
        private string _phone;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
            }
        }

        public Khachhang()
        {

        }

        public Khachhang(string name, string address, string phone)
        {
            this._name = name;
            this._address = address;
            this._phone = phone;
        }

        public Khachhang(string id, string name, string address, string phone)
        {
            this._id = id;
            this._name = name;
            this._address = address;
            this._phone = phone;
        }
    }
}
