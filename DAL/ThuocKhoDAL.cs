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
    public class ThuocKhoDAL : DatabaseAccess
    {
        //get all 
        public DataTable getAllThuocKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc_Kho", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get  by id 
        public Thuoc_Kho getThuocKhoById(string ID)
        {
            Thuoc_Kho th = new Thuoc_Kho();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc_Kho WHERE ID_Thuoc LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ID_Thuoc"].ToString();
                DateTime ngaynhap = Convert.ToDateTime(dt.Rows[0]["NGAYNHAP"]);
                string quycach = dt.Rows[0]["QUYCACHDONGGOI"].ToString();
                int sl_donggoi = (int)dt.Rows[0]["SL_DVDONGGOI"];
                string dv_donggoi = dt.Rows[0]["DONVI_DONGGOI"].ToString();
                int dongia = (int)dt.Rows[0]["DONGIA_DONGGOI"];
                int total = (int)dt.Rows[0]["TIENGOC_DONGGOI"];
                string dv_ban = dt.Rows[0]["DONVIBAN"].ToString();
                int dongia_ban = (int)dt.Rows[0]["DONGIA_DVBAN"];

                th = new Thuoc_Kho(id, ngaynhap, quycach, sl_donggoi, dv_donggoi, dongia, total, dv_ban, dongia_ban);
            }

            return th;
        }

        //them thuoc
        public bool addThuocKho(Thuoc_Kho thuockho)
        {
            bool result = false;

            try
            {
                conn.Open();

                //Nhap vao bang 
                SqlCommand cmd = new SqlCommand("INSERT_Thuoc_Kho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_Thuoc", SqlDbType.VarChar)).Value = thuockho.Id;
                cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", SqlDbType.DateTime)).Value = thuockho.Ngaynhap;
                cmd.Parameters.Add(new SqlParameter("@QUYCACHDONGGOI", SqlDbType.NVarChar)).Value = thuockho.Quycach;
                cmd.Parameters.Add(new SqlParameter("@SL_DVDONGGOI", SqlDbType.Int)).Value = thuockho.Sl_donggoi;
                cmd.Parameters.Add(new SqlParameter("@DONVI_DONGGOI", SqlDbType.NVarChar)).Value = thuockho.Dv_donggoi;
                cmd.Parameters.Add(new SqlParameter("@DONGIA_DONGGOI", SqlDbType.Int)).Value = thuockho.Dongia_donggoi;
                cmd.Parameters.Add(new SqlParameter("@TIENGOC_DONGGOI", SqlDbType.Int)).Value = thuockho.Total_nhap;
                cmd.Parameters.Add(new SqlParameter("@DONVIBAN", SqlDbType.NVarChar)).Value = thuockho.Dv_ban;
                cmd.Parameters.Add(new SqlParameter("@DONGIA_DVBAN", SqlDbType.Int)).Value = thuockho.Dongia_dvban;


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                result = true;
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

        public bool updateThuocKho(Thuoc_Kho thuockho)
        {
            bool result = false;

            try
            {
                conn.Open();

                //Nhap vao bang 
                SqlCommand cmd = new SqlCommand("UPDATE_ThuocKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_Thuoc", SqlDbType.VarChar)).Value = thuockho.Id;
                cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", SqlDbType.DateTime)).Value = thuockho.Ngaynhap;
                cmd.Parameters.Add(new SqlParameter("@QUYCACHDONGGOI", SqlDbType.NVarChar)).Value = thuockho.Quycach;
                cmd.Parameters.Add(new SqlParameter("@SL_DVDONGGOI", SqlDbType.Int)).Value = thuockho.Sl_donggoi;
                cmd.Parameters.Add(new SqlParameter("@DONVI_DONGGOI", SqlDbType.NVarChar)).Value = thuockho.Dv_donggoi;
                cmd.Parameters.Add(new SqlParameter("@DONGIA_DONGGOI", SqlDbType.Int)).Value = thuockho.Dongia_donggoi;
                cmd.Parameters.Add(new SqlParameter("@TIENGOC_DONGGOI", SqlDbType.Int)).Value = thuockho.Total_nhap;
                cmd.Parameters.Add(new SqlParameter("@DONVIBAN", SqlDbType.NVarChar)).Value = thuockho.Dv_ban;
                cmd.Parameters.Add(new SqlParameter("@DONGIA_DVBAN", SqlDbType.Int)).Value = thuockho.Dongia_dvban;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                result = true;
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
        public bool deleteThuocKho(string id)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu co ton tai 
                String sql = "DELETE FROM Thuoc_Kho WHERE ID_Thuoc = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                result = true;
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
