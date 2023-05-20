using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ThuocLoBLL
    {
        ThuocLoDAL thuocLoDAL = new ThuocLoDAL();
        //get all 
        public DataTable getAllThuocHop()
        {
            return thuocLoDAL.getAllThuocLo();
        }

        //get all  by type
        public Thuoc_Lo getThuocLoById(string id)
        {
            return thuocLoDAL.getThuocLoById(id);
        }

        //them thuoc
        public bool addThuocLo(Thuoc_Lo thuoc)
        {
            return thuocLoDAL.addThuocLo(thuoc);
        }

        public bool updateThuocLo(Thuoc_Lo thuoc)
        {
            return thuocLoDAL.updateThuocLo(thuoc);
        }

        //delete 
        public bool deleteThuocLo(string id)
        {
            return thuocLoDAL.deleteThuocLo(id);
        }
    }
}
