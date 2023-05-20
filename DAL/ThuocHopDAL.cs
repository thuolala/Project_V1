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
    public class ThuocHopDAL : DatabaseAccess
    {
        //get all 
        public DataTable getAllThuocHop()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc_Hop", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get all  by type
        public Thuoc_Hop getThuocHopById(string id)
        {
            Thuoc_Hop th = new Thuoc_Hop();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc_Hop WHERE ID_Thuoc = '" + id + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string idt = dt.Rows[0]["ID_Thuoc"].ToString();
                int sl_hop = (int)dt.Rows[0]["SL_Hop"];
                int dg_hop = (int)dt.Rows[0]["Dongia_Hop"];
                int sl_vi = (int)dt.Rows[0]["SL_Vi"];
                int dg_vi = (int)dt.Rows[0]["Dongia_Vi"];
                int sl_vien = (int)dt.Rows[0]["SL_Vien"];
                int dg_vien = (int)dt.Rows[0]["Dongia_Vien"];
                th = new Thuoc_Hop(idt, sl_hop, dg_hop, sl_vi, dg_vi, sl_vien, dg_vien);
            }
            return th;
        }

        //them thuoc
        public bool addThuocHop(Thuoc_Hop thuoc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu  chua ton tai 
                if (this.getThuocHopById(thuoc.Id_thuoc) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("INSERT_Thuoc_Hop", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Thuoc", SqlDbType.VarChar)).Value = thuoc.Id_thuoc;
                    cmd.Parameters.Add(new SqlParameter("@SL_Hop", SqlDbType.Int)).Value = thuoc.Sl_hop;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Hop", SqlDbType.Int)).Value = thuoc.Dongia_hop;
                    cmd.Parameters.Add(new SqlParameter("@SL_Vi", SqlDbType.Int)).Value = thuoc.Sl_vi;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Vi", SqlDbType.Int)).Value = thuoc.Dongia_vi;
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

        public bool updateThuocHop(Thuoc_Hop thuoc)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu  chua ton tai 
                if (this.getThuocHopById(thuoc.Id_thuoc) != null)
                {
                    //Nhap vao bang 
                    SqlCommand cmd = new SqlCommand("UPDATE_Thuoc_Hop", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Thuoc", SqlDbType.VarChar)).Value = thuoc.Id_thuoc;
                    cmd.Parameters.Add(new SqlParameter("@SL_Hop", SqlDbType.Int)).Value = thuoc.Sl_hop;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Hop", SqlDbType.Int)).Value = thuoc.Dongia_hop;
                    cmd.Parameters.Add(new SqlParameter("@SL_Vi", SqlDbType.Int)).Value = thuoc.Sl_vi;
                    cmd.Parameters.Add(new SqlParameter("@Dongia_Vi", SqlDbType.Int)).Value = thuoc.Dongia_vi;
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
        public bool deleteThuocHop(string id)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu co ton tai 
                if (this.getThuocHopById(id) != null)
                {
                    //Cap nhat vao bang Nhan vien
                    String sql = "DELETE FROM Thuoc_Hop WHERE ID_Thuoc = '" + id + "'";
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
