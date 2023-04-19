using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien
    {
        private string _id;
        private string _name;
        private string _gender;
        private DateTime _birthday;
        private string _hometown;
        private string _phone;
        private string _email;
        private string _idpos;

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
            get { return _name;} 
            set 
            { 
                _name = value; 
            } 
        }
        
        public string Gender 
        { 
            get { return _gender;}
            set 
            { 
                _gender = value; 
            } 
        }  

        public DateTime Birthday
        {
            get { return _birthday;}
            set 
            { 
                _birthday = value; 
            }
        }

        public string Hometown
        {
            get { return _hometown;}
            set
            {
                _hometown = value;
            }
        }

        public string Phone
        {
            get { return _phone;}
            set
            {
                _phone = value;
            }
        }

        public string Email
        {
            get { return _email;}
            set
            {
                _email = value;
            }
        }

        public string Idpos
        {
            get { return _idpos;}
            set
            {
                _idpos = value;
            }
        }

        public Nhanvien()
        {
        }

        public Nhanvien(string nid, string nname, string ngender, DateTime nbirthday, string nhometown, string nphone, string nemail, string nidpos)
        {
            this._id = nid;
            this._name = nname;
            this._gender = ngender;
            this._birthday = nbirthday;
            this._hometown = nhometown;
            this._phone = nphone;
            this._email = nemail;
            this._idpos = nidpos;
        }
    }
}
