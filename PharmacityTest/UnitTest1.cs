using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BLL;
using DTO;

namespace PharmacityTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_addNV()
        {
            byte[] img = { 0x01, 0x02, 0x03 }; 
            Nhanvien nv = new Nhanvien("Đỗ Nhựt Khả Vy", "Nữ", new DateTime(2023, 4, 21, 12, 0, 0) , "TPHCM", "11111", "khavy@gmail.com", "BH", img);
            NhanvienBLL nvBLL = new NhanvienBLL();
            Assert.AreEqual(nvBLL.addNV(nv), true);
        }

        [TestMethod]
        public void Test_updateNV()
        {
            string phone = "1234567";
            NhanvienBLL nvBLL = new NhanvienBLL();
            Nhanvien nv = nvBLL.getNVById("NV003");
            nv.Phone = phone;
            Assert.AreEqual(nvBLL.updateNV(nv), true);
        }

        [TestMethod]
        public void Test_deleteNV()
        {
            NhanvienBLL nvBLL = new NhanvienBLL();
            Nhanvien nv = nvBLL.getNVById("NV003");
            Assert.AreEqual(nvBLL.deleteNV(nv.Id), true);
        }

        [TestMethod]
        public void Test_addTK()
        {
            Taikhoan tk = new Taikhoan("khavy", "123456789", 1); 
            TaikhoanBLL tkBLL = new TaikhoanBLL();
            Assert.AreEqual(tkBLL.addAccount(tk), true);
        }

        [TestMethod]
        public void Test_updateTK()
        {
            string password = "password";
            TaikhoanBLL tkBLL = new TaikhoanBLL();
            Taikhoan tk = tkBLL.getAccountById("NV003");
            Assert.AreEqual(tkBLL.updateAccount(tk), true);
        }

        [TestMethod]
        public void Test_deleteTK()
        {
            TaikhoanBLL tkBLL = new TaikhoanBLL();
            Taikhoan tk = tkBLL.getAccountById("NV003");
            Assert.AreEqual(tkBLL.deleteAccount(tk.Id), true);
        }

        [TestMethod]
        public void Test_addKH()
        {
            Khachhang kh = new Khachhang("Phạm Huỳnh Yến Vi", "Cao Lãnh", "11111");
            KhachhangBLL khBLL = new KhachhangBLL();
            Assert.AreEqual(khBLL.addKH(kh), true);
        }

        [TestMethod]
        public void Test_updateKH()
        {
            string phone = "0847608473";
            KhachhangBLL khBLL = new KhachhangBLL();
            Khachhang kh = khBLL.getKHById("KH0002");
            kh.Phone = phone;
            Assert.AreEqual(khBLL.updateKH(kh), true);
        }
    }
}
