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
    public class VitriBLL
    {
        VitriDAL vitriDAL = new VitriDAL();

        //get all vi tri 
        public DataTable getAllVitri()
        {
            return vitriDAL.getAllVitri();
        }

        //get vitri by id 
        public Vitri getVTById(string ID)
        {
            return vitriDAL.getVTById(ID);
        }

        //get name
        public string getVTName(string ID)
        {
            return vitriDAL.getVTById(ID).Name;
        }

        //get vi tri by name 
        public Vitri getVTByName(string nname)
        {
           return vitriDAL.getVTByName(nname);
        }

        //them vi tri 
        public bool addVT(Vitri vt)
        {
            return vitriDAL.addVT(vt);
        }

        //update vi tri 
        public bool updateVT(Vitri vt)
        {
            return vitriDAL.updateVT(vt);
        }
    }
}
