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
        private string _email;
        private DateTime _created;

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

        public string Email { get => _email; set => _email = value; }
        public DateTime Created { get => _created; set => _created = value; }

        public Khachhang()
        {

        }

        public Khachhang(string name, string address, string phone, string email, DateTime ceated)
        {
            this._name = name;
            this._address = address;
            this._phone = phone;
            this._email = email;
            this._created = ceated;
        }

        public Khachhang(string id, string name, string address, string phone, string email, DateTime ceated)
        {
            this._id = id;
            this._name = name;
            this._address = address;
            this._phone = phone;
            this._email = email;
            this._created = ceated;
        }
    }
}
