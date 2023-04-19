using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class VitriDAL : DatabaseAccess
    {
        //get all vi tri 
        public DataTable getAllVitri()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Vitri", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get vitri by id 
        public Vitri getVTById(string ID)
        {
            Vitri vt = new Vitri();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Vitri WHERE ID LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string name = dt.Rows[0]["TEN"].ToString();
                vt = new Vitri(id, name);
            }

            return vt;
        }

        //get vi tri by name 
        public Vitri getVTByName(string nname)
        {
            Vitri vt = new Vitri();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Vitri WHERE TEN LIKE '" + nname + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string name = dt.Rows[0]["TEN"].ToString();
                vt = new Vitri(id, name);
            }

            return vt;
        }

        //them vi tri 
        public bool addVT(Vitri vt)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu vi tri chua ton tai 
                if (this.getVTById(vt.Id) != null || this.getVTByName(vt.Name) != null)
                {
                    //Nhap vao bang Vi tri 
                    SqlCommand cmd = new SqlCommand("INSERT_VT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", vt.Id));
                    cmd.Parameters.Add(new SqlParameter("@TEN", vt.Name));
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

        //update vi tri 
        public bool updateVT(Vitri vt)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu vi tri co ton tai 
                if (this.getVTById(vt.Id) != null || this.getVTByName(vt.Name) != null)
                {
                    //Cap nhat vao bang Vi tri
                    SqlCommand cmd = new SqlCommand("UPDATE_VT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", vt.Id));
                    cmd.Parameters.Add(new SqlParameter("@TEN", vt.Name));
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
