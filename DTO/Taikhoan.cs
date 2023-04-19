using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Taikhoan
    {
        private string _id;
        private string _username;
        private string _password;
        private int _permission;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Userame
        {
            get { return _username; }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }

        public int Permission
        {
            get { return _permission; }
            set
            {
                _permission = value;
            }
        }

        public Taikhoan()
        {
        }

        public Taikhoan(string nid, string nusername, string npassword, int npermission)
        {
            this._id = nid;
            this._username = nusername;
            this._password = npassword;
            this._permission = npermission;
        }
    }
}
