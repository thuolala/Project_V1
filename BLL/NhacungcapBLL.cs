using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class NhacungcapBLL
    {
        NhacungcapDAL nhacungcapDAL = new NhacungcapDAL();

        public DataTable getAllNCC()
        {
            return nhacungcapDAL.getAllNCC();
        }

        public string getAutoID()
        {
            return nhacungcapDAL.getAutoID();
        }


        public bool addNCC(Nhacungcap ncc)
        {
            return nhacungcapDAL.addNCC(ncc);
        }
    }
}
