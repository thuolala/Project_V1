using DTO;
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
    public class NhomthuocBLL
    {
        Nhomthuoc nhomthuoc = new Nhomthuoc();
        NhomthuocDAL ntDAL = new NhomthuocDAL();
        //get all
        public DataTable getAllNhomthuoc()
        {
            return ntDAL.getAllNhomthuoc();
        }

        //get by id 
        public Nhomthuoc getNTById(string ID)
        {
            return ntDAL.getNTById(ID);
        }

        //get by id 
        public Nhomthuoc getNTByName(string tname)
        {
           return ntDAL.getNTByName(tname);
        }

        //them 
        public bool addNT(Nhomthuoc nt)
        {
            return ntDAL.addNT(nt);
        }

        //update 
        public bool updateNT(Nhomthuoc nt)
        {
           return ntDAL.updateNT(nt);
        }

        public string getAutoIDNT()
        {
            return ntDAL.getAutoIDNT();
        }
    }
}
