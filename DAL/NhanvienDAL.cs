﻿using System;
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
    public class NhanvienDAL : DatabaseAccess
    {
        //get all nv 
        public DataTable getAllNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhanvien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //get nv by id 
        public Nhanvien getNVById(string ID)
        {
            Nhanvien nv = new Nhanvien();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhanvien WHERE IDNV LIKE '" + ID + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["IDNV"].ToString();
                string name = dt.Rows[0]["HOTEN"].ToString();
                string gender = dt.Rows[0]["GIOITINH"].ToString();
                DateTime birthday = Convert.ToDateTime(dt.Rows[0]["DOB"]);
                string hometown = dt.Rows[0]["QUEQUAN"].ToString();
                string phone = dt.Rows[0]["SDT"].ToString();
                string email = dt.Rows[0]["EMAIL"].ToString();
                string idpos = dt.Rows[0]["IDVitri"].ToString();

                nv = new Nhanvien(id, name, gender, birthday, hometown, phone, email, idpos);
            }

            return nv;
        }

        //them nv 
        public bool addNV(Nhanvien nv)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu nv chua ton tai 
                if (this.getNVById(nv.Id) != null)
                {
                    //Nhap vao bang Nhan vien
                    SqlCommand cmd = new SqlCommand("INSERT_NV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("HOTEN", SqlDbType.NVarChar)).Value = nv.Name;
                    cmd.Parameters.Add(new SqlParameter("@GIOITINH", SqlDbType.NVarChar)).Value = nv.Gender;
                    cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = nv.Birthday;
                    cmd.Parameters.Add(new SqlParameter("@QUEQUAN", SqlDbType.NVarChar)).Value = nv.Hometown;
                    cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.VarChar)).Value = nv.Phone;
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar)).Value = nv.Email;
                    cmd.Parameters.Add(new SqlParameter("@IDVitri", SqlDbType.NVarChar)).Value = nv.Idpos;

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

        //update nv 
        public bool updateNV(Nhanvien nv)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu nv co ton tai 
                if (this.getNVById(nv.Id) != null)
                {
                    //Cap nhat vao bang Nhan vien
                    SqlCommand cmd = new SqlCommand("UPDATE_NV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IDNV", SqlDbType.NVarChar)).Value = nv.Id;
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar)).Value = nv.Name;
                    cmd.Parameters.Add(new SqlParameter("@GIOITINH", SqlDbType.NVarChar)).Value = nv.Gender;
                    cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = nv.Birthday;
                    cmd.Parameters.Add(new SqlParameter("@QUEQUAN", SqlDbType.NVarChar)).Value = nv.Hometown;
                    cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.VarChar)).Value = nv.Phone;
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar)).Value = nv.Email;
                    cmd.Parameters.Add(new SqlParameter("@IDVitri", SqlDbType.NVarChar)).Value = nv.Idpos;

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

        //delete nv 
        public bool deleteAccount(string id)
        {
            bool result = false;

            try
            {
                conn.Open();

                //neu nv co ton tai 
                if (this.getNVById(id) != null)
                {
                    //Cap nhat vao bang Nhan vien
                    String sql = "DELETE FROM Nhanvien WHERE IDNV = '" + id + "'";
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
