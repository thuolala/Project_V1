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

        //count all
        public int countAll()
        {
            return this.getAllNV().Rows.Count;
        }

        //get all nv by pos
        public DataTable getNVByPos(string idPos)
        {
            return nvDAL.getNVByPos(idPos);
        }

        //count each
        public int countEach(string idPos)
        {
            return this.getNVByPos(idPos).Rows.Count;
        }

        //get nv by id 
        public Nhanvien getNVById(string nID)
        {
            return nvDAL.getNVById(nID);
        }

        //get auto ql 
        public string getAutoIDQL()
        {
            return nvDAL.getAutoIDQL();
        }

        //get auto id 
        public string getAutoIDNV()
        {
            return nvDAL.getAutoIDNV();
        }

        //them ql 
        public bool addQL(Nhanvien nv)
        {
            return nvDAL.addQL(nv);
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
        public bool deleteNV(string id)
        {
            return nvDAL.deleteNV(id);
        }

        //get vi tri 
        public string getVitri(string id)
        {
            Nhanvien nv = new Nhanvien();
            nv = this.getNVById(id);
            return nv.Idpos;
        }

        //get nv by any name of id
        public DataTable getAllNVByNameId(string ID, string sname)
        {
            return nvDAL.getAllNVByNameId(ID, sname);   
        }

        //get nv name
        public DataTable getAllName()
        {
            return nvDAL.getAllName();
        }

        //get nv id
        public DataTable getAllId()
        {
            return nvDAL.getAllId();
        }
    }
}
