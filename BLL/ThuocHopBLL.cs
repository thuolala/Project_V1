using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuocHopBLL
    {
        ThuocHopDAL ThuocHopDAL = new ThuocHopDAL();
        //get all 
        public DataTable getAllThuocHop()
        {
            return ThuocHopDAL.getAllThuocHop();
        }

        //get all  by type
        public Thuoc_Hop getThuocHopById(string id)
        {
            return ThuocHopDAL.getThuocHopById(id);
        }

        //them thuoc
        public bool addThuocHop(Thuoc_Hop thuoc)
        {
            return ThuocHopDAL.addThuocHop(thuoc);
        }

        public bool updateThuocHop(Thuoc_Hop thuoc)
        {
            return ThuocHopDAL.updateThuocHop(thuoc);
        }

        //delete 
        public bool deleteThuocHop(string id)
        {
            return ThuocHopDAL.deleteThuocHop(id);
        }
    }
}
