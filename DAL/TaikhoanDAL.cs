using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaikhoanDAL : DatabaseAccess
    {
        //get all account 
        public DataTable getAllAccount()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Taikhoan", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get account by id 
        public Taikhoan getAccountById(string ID)
        {
            Taikhoan taikhoan = new Taikhoan();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Taikhoan WHERE ID LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string username = dt.Rows[0]["TENDANGNHAP"].ToString();
                string password = dt.Rows[0]["MATKHAU"].ToString();
                int per = Int32.Parse(dt.Rows[0]["QUYEN"].ToString());
                taikhoan = new Taikhoan(id, username, password, per);
            }

            return taikhoan;
        }

        //get account by username 
        public Taikhoan getAccountByUName(string uname)
        {
            Taikhoan taikhoan = new Taikhoan();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Taikhoan WHERE TENDANGNHAP LIKE '" + uname + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID"].ToString();
                string username = dt.Rows[0]["TENDANGNHAP"].ToString();
                string password = dt.Rows[0]["MATKHAU"].ToString();
                int per = Int32.Parse(dt.Rows[0]["QUYEN"].ToString());
                taikhoan = new Taikhoan(id, username, password, per);
            }

            return taikhoan;
        }

        //them account 
        public bool addAccount(Taikhoan tk)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu account chua ton tai 
                if(this.getAccountByUName(tk.Userame) != null)
                {
                    //Nhap vao bang Tai khoan 
                    SqlCommand cmd = new SqlCommand("INSERT_TK", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", tk.Userame));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", tk.Password));
                    cmd.Parameters.Add(new SqlParameter("@QUYEN", tk.Permission));
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

        //update account 
        public bool updateAccount(Taikhoan tk)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu account co ton tai 
                if (this.getAccountById(tk.Id) != null)
                {

                    //Cap nhat vao bang Tai khoan 
                    SqlCommand cmd = new SqlCommand("UPDATE_TKNV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", tk.Id));
                    cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", tk.Userame));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", tk.Password));
                    cmd.Parameters.Add(new SqlParameter("@QUYEN", tk.Permission));
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

        //delete account 
        public bool deleteAccount(string id)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu account co ton tai 
                if (this.getAccountById(id) != null)
                {
                    //Cap nhat vao bang Tai khoan 
                    String sql = "DELETE FROM Taikhoan WHERE ID = '" + id + "'";
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
