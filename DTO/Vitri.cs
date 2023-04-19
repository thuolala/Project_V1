using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vitri
    {
        private string id;
        private string name;

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Vitri() { } 

        public Vitri(string nid, string nname)
        {
            this.id = nid;
            this.name = nname;
        }
    }
}
