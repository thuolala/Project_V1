using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class adminDashboard : Form
    {
        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv = new Nhanvien();
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk = new Taikhoan();
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt = new Vitri();
        KhachhangBLL khBLL = new KhachhangBLL();
        Khachhang kh = new Khachhang();

        public adminDashboard()
        {
            InitializeComponent();
        }

        private void panelTop_Layout(object sender, LayoutEventArgs e)
        {
            int newX = (panelTop.Width - labelDashboard.Width) / 2;
            int newY = (labelDashboard.Height - labelDashboard.Height) / 2;

            labelDashboard.Location = new Point(newX, newY);
        }

        private void panelBottom_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void panelData_Layout(object sender, LayoutEventArgs e)
        {
            //nhan vien 
            int newX1 = ((panelData.Width - panelEmp.Width * 4) / 2) - 5;
            int newY1 = (panelData.Height - panelEmp.Height) / 2;

            panelEmp.Location = new Point(newX1, newY1);

            //khach hang
            int newX2 = newX1 + panelCus.Width + 5;
            int newY2 = newY1 + (panelData.Height - panelCus.Height) / 2;

            panelCus.Location = new Point(newX2, newY2);

            //thuoc
            int newX3 = newX2 + panelMed.Width + 5;
            int newY3 = newY2 + (panelData.Height - panelMed.Height) / 2;

            panelMed.Location = new Point(newX3, newY3);

            //doanh thu
            int newX4 = newX3 + panelMoney.Width + 5;
            int newY4 = newY3 + (panelData.Height - panelMoney.Height) / 2;

            panelMoney.Location = new Point(newX4, newY4);
        }

        private void getCount()
        {
            empCount.Text = nvBLL.countAll().ToString();
            adminCount.Text = nvBLL.countEach("AD").ToString();
            bhCount.Text = nvBLL.countEach("BH").ToString();
            khoCount.Text = nvBLL.countEach("KHO").ToString();
            tnCount.Text = nvBLL.countEach("TN").ToString();

            cusCount.Text = khBLL.countAll().ToString();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            getCount();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
