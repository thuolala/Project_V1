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
    public class ThuocBLL
    {
        ThuocDAL thuocDAL= new ThuocDAL();

        //get all 
        public DataTable getAllThuoc()
        {
            return thuocDAL.getAllThuoc();
        }

        //get all  by type
        public DataTable getThuocByType(string id_nt)
        {
            return thuocDAL.getThuocByType(id_nt);
        }

        //by ncc
        public DataTable getThuocByNCC(string id_ncc)
        {
            return thuocDAL.getThuocByNCC(id_ncc);
        }

        //get all nv by name
        public DataTable getThuocByName(string name)
        {
            return thuocDAL.getThuocByName(name);
        }

        //get nv by id 
        public Thuoc getThuocById(string ID)
        {
            return thuocDAL.getThuocById(ID);
        }

        //get  name
        public DataTable getAllName()
        {
            return thuocDAL.getAllName();
        }

        //get nv id
        public DataTable getAllId()
        {
            return thuocDAL.getAllId();
        }

        //get auto id ql
        public string getAutoID()
        {
            return thuocDAL.getAutoID();
        }

        //them thuoc
        public bool addThuoc(Thuoc thuoc)
        {
            return thuocDAL.addThuoc(thuoc);
        }

        public bool updateThuoc(Thuoc thuoc)
        {
            return thuocDAL.updateThuoc(thuoc);
        }

        //delete 
        public bool deleteThuoc(string id)
        {
            return thuocDAL.deleteThuoc(id);
        }
    }
}
