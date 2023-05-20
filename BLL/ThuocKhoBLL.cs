using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuocKhoBLL
    {
        ThuocKhoDAL thuockhoDAL = new ThuocKhoDAL();

        //get all 
        public DataTable getAllThuocKho()
        {
            return thuockhoDAL.getAllThuocKho();
        }

        public Thuoc_Kho getThuocKhoById(string ID)
        {
            return thuockhoDAL.getThuocKhoById(ID);
        }

        //them thuoc
        public bool addThuocKho(Thuoc_Kho thuockho)
        {
            return thuockhoDAL.addThuocKho(thuockho);
        }

        public bool updateThuocKho(Thuoc_Kho thuockho)
        {
            return thuockhoDAL.updateThuocKho(thuockho); 
        }

        public bool deleteThuocKho(String id)
        {
            return thuockhoDAL.deleteThuocKho(id);
        }
    }
}
