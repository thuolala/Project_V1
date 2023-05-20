using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhacungcapDAL : DatabaseAccess
    {
        //get all 
        public DataTable getAllNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NCC", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get by id 
        public Nhacungcap getNCCByID(string id)
        {
            Nhacungcap nh = new Nhacungcap();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NCC WHERE ID LIKE '" + id + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string idncc = dt.Rows[0]["ID"].ToString();
                string name = dt.Rows[0]["TEN"].ToString();
                string address = dt.Rows[0]["DIACHI"].ToString();
                string phone = dt.Rows[0]["SDT"].ToString();
                string email = dt.Rows[0]["EMAIL"].ToString();
                nh = new Nhacungcap(id, name, address, phone, email);
            }
            return nh;
        }

        //get auto id 
        public string getAutoID()
        {
            string id = "";
            try
            {
                conn.Open();

                //Get id
                SqlCommand cmd = new SqlCommand("Return_IDNCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    id = dt.Rows[0][0].ToString();
                }
                da.Dispose();
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        public bool addNCC(Nhacungcap ncc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu chua ton tai 
                if (this.getNCCByID(ncc.Id) != null)
                {
                    //Nhap vao bang Tai khoan 
                    SqlCommand cmd = new SqlCommand("INSERT_NCC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TEN", ncc.Name));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", ncc.Address));
                    cmd.Parameters.Add(new SqlParameter("@SDT", ncc.Phone));
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", ncc.Email));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();

                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}
