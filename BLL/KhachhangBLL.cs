﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachhangBLL
    {
        KhachhangDAL khDAL = new KhachhangDAL();

        //get all kh 
        public DataTable getAllKH()
        {
            return khDAL.getAllKH();
        }

        //count all
        public int countAll()
        {
            return this.getAllKH().Rows.Count;
        }

        //get all kh by id 
        public Khachhang getKHById(string id)
        {
            return khDAL.getKHById(id);
        }

        //get kh by phone
        public DataTable getKHByPhone(string phoneN)
        {
            return khDAL.getKHByPhone(phoneN);
        }

        //them kh
        public bool addKH(Khachhang kh)
        {
            return khDAL.addKH(kh);
        }

        //cap nhat kh 
        public bool updateKH(Khachhang kh)
        {
            return khDAL.updateKH(kh);
        }

        //get auto id 
        public string getAutoID()
        {
            return khDAL.getAutoID();
        }

        //get all phone
        public DataTable getAllPhone()
        {
            return khDAL.getAllPhone();
        }
    }
}
