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
    public class NhomthuocDAL : DatabaseAccess
    {
        Nhomthuoc nhomthuoc = new Nhomthuoc();

        //get all
        public DataTable getAllNhomthuoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhomthuoc", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get by id 
        public Nhomthuoc getNTById(string ID)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhomthuoc WHERE ID LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string name = dt.Rows[0]["TEN"].ToString();
                nhomthuoc = new Nhomthuoc(id, name);
            }

            return nhomthuoc;
        }

        //get by id 
        public Nhomthuoc getNTByName(string tname)
        {
            Nhomthuoc nt = new Nhomthuoc();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhomthuoc WHERE TEN = N'%" + tname + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string name = dt.Rows[0]["TEN"].ToString();
                nt = new Nhomthuoc(id, name);
            }

            return nt;
        }

        //them 
        public bool addNT(Nhomthuoc nt)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu chua ton tai 
                if (this.getNTById(nt.Id) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("INSERT_Nhomthuoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TEN", nt.Name));
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

        //update 
        public bool updateNT(Nhomthuoc nt)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu co ton tai 
                if (this.getNTById(nt.Id) != null || this.getNTByName(nt.Name) != null)
                {
                    //Cap nhat vao bang 
                    SqlCommand cmd = new SqlCommand("UPDATE Nhomthuoc SET TEN = N'" + nt.Name + "'", conn);
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

        //get auto id
        public string getAutoIDNT()
        {
            string id = "";
            try
            {
                conn.Open();

                //Get id
                SqlCommand cmd = new SqlCommand("Return_IDNhomthuoc", conn);
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
    }
}
