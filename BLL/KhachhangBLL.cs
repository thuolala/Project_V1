using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachhangBLL
    {
        KhachhangDAL khDAL = new KhachhangDAL();

        //get all kh 
        public DataTable getAllKH()
        {
            return khDAL.getAllKH();
        }

        //get all kh by id 
        public Khachhang getKHById(string id)
        {
            return khDAL.getKHById(id);
        }

        //them kh
        public bool addKH(Khachhang kh)
        {
            return khDAL.addKH(kh);
        }

        //cap nhat kh 
        public bool updateKH(Khachhang kh)
        {
            return khDAL.updateKH(kh);
        }
    }
}
