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
    public class NhanvienBLL
    {
        NhanvienDAL nvDAL = new NhanvienDAL();

        //get all nv 
        public DataTable getAllNV()
        {
            return nvDAL.getAllNV();
        }

        //get nv by id 
        public Nhanvien getNVById(string nID)
        {
            return nvDAL.getNVById(nID);
        }

        //them nv 
        public bool addNV(Nhanvien nv)
        {
            return nvDAL.addNV(nv);
        }

        //update nv 
        public bool updateNV(Nhanvien nv)
        {
            return nvDAL.updateNV(nv);
        }

        //delete nv 
        public bool deleteAccount(string id)
        {
            return nvDAL.deleteAccount(id);
        }

        //get vi tri 
        public string getVitri(string id)
        {
            Nhanvien nv = new Nhanvien();
            nv = this.getNVById(id);
            return nv.Idpos;
        }
    }
}
