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
    public class TaikhoanBLL
    {
        TaikhoanDAL taikhoanDAL = new TaikhoanDAL();

        //get all account 
        public DataTable getAllAccount()
        {
            return taikhoanDAL.getAllAccount();
        }

        //get account by id 
        public Taikhoan getAccountById(string ID)
        {
            return taikhoanDAL.getAccountById(ID);
        }

        //get account by username 
        public Taikhoan getAccountByUname(string uname)
        {
            return taikhoanDAL.getAccountByUName(uname);
        }

        //them account 
        public bool addAccount(Taikhoan tk)
        { 
            return taikhoanDAL.addAccount(tk);
        }

        //update account 
        public bool updateAccount(Taikhoan tk)
        {
            return taikhoanDAL.updateAccount(tk);
        }

        //delete account 
        public bool deleteAccount(string id)
        {
            return taikhoanDAL.deleteAccount(id);
        }

        //get all uname 
        public List<String> getAllUName()
        {
            return taikhoanDAL.getAllUName();
        }

        //get all pass
        public List<String> getAllPass()
        {
            return taikhoanDAL.getAllPass();
        }
    }
}
