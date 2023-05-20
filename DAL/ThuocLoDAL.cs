using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuocLoDAL : DatabaseAccess
    {
        //get all 
        public DataTable getAllThuocLo()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc_Lo", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get all  by type
        public Thuoc_Lo getThuocLoById(string id)
        {
            Thuoc_Lo th = new Thuoc_Lo();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc_Lo WHERE ID_Thuoc = '" + id + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string idt = dt.Rows[0]["ID_Thuoc"].ToString();
                int sl_hop = (int)dt.Rows[0]["SL_Lo"];
                int dg_hop = (int)dt.Rows[0]["Dongia_Lo"];
                int sl_vien = (int)dt.Rows[0]["SL_Vien"];
                int dg_vien = (int)dt.Rows[0]["Dongia_Vien"];
                th = new Thuoc_Lo(idt, sl_hop, dg_hop, sl_vien, dg_vien);
            }
            return th;
        }

        //them thuoc
        public bool addThuocLo(Thuoc_Lo thuoc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu  chua ton tai 
                if (this.getThuocLoById(thuoc.Id_thuoc) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("INSERT_Thuoc_Lo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Thuoc", SqlDbType.VarChar)).Value = thuoc.Id_thuoc;
                    cmd.Parameters.Add(new SqlParameter("@SL_Lo", SqlDbType.Int)).Value = thuoc.Sl_lo;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Lo", SqlDbType.Int)).Value = thuoc.Dongia_lo;
                    cmd.Parameters.Add(new SqlParameter("@SL_Vien", SqlDbType.Int)).Value = thuoc.Sl_vien;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Vien", SqlDbType.Int)).Value = thuoc.Dongia_vien;

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

        public bool updateThuocLo(Thuoc_Lo thuoc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu  chua ton tai 
                if (this.getThuocLoById(thuoc.Id_thuoc) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("UPDATE_Thuoc_Lo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Thuoc", SqlDbType.VarChar)).Value = thuoc.Id_thuoc;
                    cmd.Parameters.Add(new SqlParameter("@SL_Lo", SqlDbType.Int)).Value = thuoc.Sl_lo;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Lo", SqlDbType.Int)).Value = thuoc.Dongia_lo;
                    cmd.Parameters.Add(new SqlParameter("@SL_Vien", SqlDbType.Int)).Value = thuoc.Sl_vien;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Vien", SqlDbType.Int)).Value = thuoc.Dongia_vien;

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
        public bool deleteThuocLo(string id)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu co ton tai 
                if (this.getThuocLoById(id) != null)
                {
                    //Cap nhat vao bang Nhan vien
                    String sql = "DELETE FROM Thuoc_Lo WHERE ID_Thuoc = '" + id + "'";
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
