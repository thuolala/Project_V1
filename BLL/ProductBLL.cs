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
    public class ProductBLL
    {
        ProductDAL pDAL = new ProductDAL();

        //get all p 
        public DataTable getAllProduct()
        {
            return pDAL.getAllProduct();
        }

        //them p 
        public bool addProduct(Product p)
        {
            return pDAL.addProduct(p);
        }
    }
}
