using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class ThuocDAL : DatabaseAccess
    {
        //get all 
        public DataTable getAllThuoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get all  by type
        public DataTable getThuocByType(string id_nt)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc WHERE ID_Nhomthuoc = '" + id_nt + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //by ncc
        public DataTable getThuocByNCC(string id_ncc)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc WHERE ID_NCC = '" + id_ncc + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get all nv by name
        public DataTable getThuocByName(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc WHERE TEN LIKE N'%" + name + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get by id 
        public Thuoc getThuocById(string ID)
        {
            Thuoc th = new Thuoc();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc WHERE ID LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string name = dt.Rows[0]["TEN"].ToString();
                DateTime ngaysx = Convert.ToDateTime(dt.Rows[0]["NSX"]);
                DateTime hsd = Convert.ToDateTime(dt.Rows[0]["HSD"]);
                string idncc = dt.Rows[0]["ID_NCC"].ToString();
                string idnt = dt.Rows[0]["ID_Nhomthuoc"].ToString();
                string nhasx = dt.Rows[0]["NHA_SX"].ToString();
                string chungnhan = dt.Rows[0]["CHUNGNHAN"].ToString();
                int hamluong = (int)dt.Rows[0]["HAMLUONG"];
                string tphan = dt.Rows[0]["THANHPHAN"].ToString();
                string chidinh = dt.Rows[0]["CHIDINH"].ToString();
                string chongcd = dt.Rows[0]["CHONGCD"].ToString();
                byte[] img = (byte[])dt.Rows[0]["IMG1"];

                th = new Thuoc(id, name, ngaysx, hsd, idncc, idnt, nhasx, chungnhan, hamluong, tphan, chidinh, chongcd, img);
            }

            return th;
        }

        //get  name
        public DataTable getAllName()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TEN FROM Thuoc", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //get nv id
        public DataTable getAllId()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM Thuoc", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //get auto id ql
        public string getAutoID()
        {
            string id = "";
            try
            {
                conn.Open();

                //Get id
                SqlCommand cmd = new SqlCommand("Return_IDThuoc", conn);
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

        //them thuoc
        public bool addThuoc(Thuoc thuoc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu nv chua ton tai 
                if (this.getThuocById(thuoc.Id) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("INSERT_Thuoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar)).Value = thuoc.Name;
                    cmd.Parameters.Add(new SqlParameter("@NSX", SqlDbType.DateTime)).Value = thuoc.Nsx;
                    cmd.Parameters.Add(new SqlParameter("@HSD", SqlDbType.DateTime)).Value = thuoc.Hsd;
                    cmd.Parameters.Add(new SqlParameter("@ID_NCC", SqlDbType.VarChar)).Value = thuoc.Id_ncc;
                    cmd.Parameters.Add(new SqlParameter("@ID_Nhomthuoc", SqlDbType.VarChar)).Value = thuoc.Id_nt;
                    cmd.Parameters.Add(new SqlParameter("@NHA_SX", SqlDbType.NVarChar)).Value = thuoc.Nhasx;
                    cmd.Parameters.Add(new SqlParameter("@CHUNGNHAN", SqlDbType.NVarChar)).Value = thuoc.Chungnhan;
                    cmd.Parameters.Add(new SqlParameter("@HAMLUONG", SqlDbType.Int)).Value = thuoc.Hamluong;
                    cmd.Parameters.Add(new SqlParameter("@THANHPHAN", SqlDbType.Text)).Value = thuoc.Thanhphan;
                    cmd.Parameters.Add(new SqlParameter("@CHIDINH", SqlDbType.Text)).Value = thuoc.Chidinh;
                    cmd.Parameters.Add(new SqlParameter("@CHONGCD", SqlDbType.Text)).Value = thuoc.Chongcd;
                    cmd.Parameters.Add(new SqlParameter("@IMG", SqlDbType.Image)).Value = thuoc.Img;

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

        public bool updateThuoc(Thuoc thuoc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu nv chua ton tai 
                if (this.getThuocById(thuoc.Id) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("UPDATE_Thuoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.VarChar)).Value = thuoc.Id;
                    cmd.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar)).Value = thuoc.Name;
                    cmd.Parameters.Add(new SqlParameter("@NSX", SqlDbType.DateTime)).Value = thuoc.Nsx;
                    cmd.Parameters.Add(new SqlParameter("@HSD", SqlDbType.DateTime)).Value = thuoc.Hsd;
                    cmd.Parameters.Add(new SqlParameter("@ID_NCC", SqlDbType.VarChar)).Value = thuoc.Id_ncc;
                    cmd.Parameters.Add(new SqlParameter("@ID_Nhomthuoc", SqlDbType.VarChar)).Value = thuoc.Id_nt;
                    cmd.Parameters.Add(new SqlParameter("@NHA_SX", SqlDbType.NVarChar)).Value = thuoc.Nhasx;
                    cmd.Parameters.Add(new SqlParameter("@CHUNGNHAN", SqlDbType.NVarChar)).Value = thuoc.Chungnhan;
                    cmd.Parameters.Add(new SqlParameter("@HAMLUONG", SqlDbType.Int)).Value = thuoc.Hamluong;
                    cmd.Parameters.Add(new SqlParameter("@THANHPHAN", SqlDbType.Text)).Value = thuoc.Thanhphan;
                    cmd.Parameters.Add(new SqlParameter("@CHIDINH", SqlDbType.Text)).Value = thuoc.Chidinh;
                    cmd.Parameters.Add(new SqlParameter("@CHONGCD", SqlDbType.Text)).Value = thuoc.Chongcd;
                    cmd.Parameters.Add(new SqlParameter("@IMG", SqlDbType.Image)).Value = thuoc.Img;

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

        //delete 
        public bool deleteThuoc(string id)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu co ton tai 
                if (this.getThuocById(id) != null)
                {
                    //Cap nhat vao bang Nhan vien
                    String sql = "DELETE FROM Thuoc WHERE ID = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
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
