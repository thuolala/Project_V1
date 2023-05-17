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
    public partial class manageEmployee : Form
    {
        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv = new Nhanvien();
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk = new Taikhoan();
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt = new Vitri();

        public manageEmployee()
        {
            InitializeComponent();
        }

        private void loadAll()
        {
            //get all nv
            DataTable dt = new DataTable();
            dt = nvBLL.getAllNV();

            //define nv
            string _id;
            string _name;
            string _gender;
            DateTime _birthday;
            string _hometown;
            string _phone;
            string _email;
            string _idpos;
            byte[] _ava;

            //create list of user control of nv 
            empItem[] listItem = new empItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _id = dt.Rows[i]["IDNV"].ToString();
                _name = dt.Rows[i]["HOTEN"].ToString();
                _gender = dt.Rows[i]["GIOITINH"].ToString();
                _birthday = (DateTime)dt.Rows[i]["DOB"];
                _hometown = dt.Rows[i]["QUEQUAN"].ToString();
                _phone = dt.Rows[i]["SDT"].ToString();
                _email = dt.Rows[i]["EMAIL"].ToString();
                _idpos = dt.Rows[i]["IDVitri"].ToString();
                _ava = (byte[])dt.Rows[i]["AVATAR"];

                Nhanvien nvien = new Nhanvien(_id, _name, _gender, _birthday, _hometown, _phone, _email, _idpos, _ava);
                Taikhoan tkhoan = tkBLL.getAccountById(_id);
                listItem[i] = new empItem(nvien, tkhoan);
                panelDisplay.Controls.Add(listItem[i]);
            }
        }

        private void manageEmployee_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        //close and open login form
        private void openLogin(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmpForm f = new addEmpForm();
            f.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            openLogin(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            loadAll();
        }
    }
}
