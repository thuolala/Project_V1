using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhomthuoc
    {
        private string _id;
        private string _name;
        
        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Nhomthuoc()
        {
        }

        public Nhomthuoc(string name)
        {
            this._name = name;
        }

        public Nhomthuoc(string id, string name)
        {
            this._id = id;
            this._name = name;
        }
    }
}
