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
    public class KhachhangDAL : DatabaseAccess
    {
        //get all kh 
        public DataTable getAllKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khachhang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get kh by id 
        public Khachhang getKHById(string ID)
        {
            Khachhang kh = new Khachhang();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khachhang WHERE IDKH LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["IDKH"].ToString();
                string name = dt.Rows[0]["HOTEN"].ToString();
                string address = dt.Rows[0]["DIACHI"].ToString();
                string phone = dt.Rows[0]["SDT"].ToString();

                kh = new Khachhang(id, name, address, phone);
            }

            return kh;
        }

        //them kh 
        public bool addKH(Khachhang kh)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu kh chua ton tai 
                if (this.getKHById(kh.Id) != null)
                {
                    //Nhap vao bang Khach hang 
                    SqlCommand cmd = new SqlCommand("INSERT_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar)).Value = kh.Name;
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", SqlDbType.Text)).Value = kh.Address;
                    cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.VarChar)).Value = kh.Phone;

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

        //update kh 
        public bool updateKH(Khachhang kh)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu kh co ton tai 
                if (this.getKHById(kh.Id) != null)
                {
                    //Cap nhat vao bang Nhan vien
                    SqlCommand cmd = new SqlCommand("UPDATE_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IDKH", SqlDbType.NVarChar)).Value = kh.Id;
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar)).Value = kh.Name;
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", SqlDbType.Text)).Value = kh.Address;
                    cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.VarChar)).Value = kh.Phone;

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
