using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class ProductDAL : DatabaseAccess
    {
        //get all nv 
        public DataTable getAllProduct()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TEST", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool addProduct(Product product)
        {
            bool result = true;
            //Nhap vao bang Nhan vien
            SqlCommand cmd = new SqlCommand("INSERT_PRODUCT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@avatar", SqlDbType.Image)).Value = product.Image;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return result;
        }
    }
}
