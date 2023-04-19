using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        //move 
        private bool mouse;
        private Point lastPos;

        VitriBLL vtBLL = new VitriBLL();
        TaikhoanBLL taikhoanBLL = new TaikhoanBLL();
        NhanvienBLL nhanvienBLL = new NhanvienBLL();

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void loginF_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            lastPos = e.Location;
        }

        private void loginF_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void loginF_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }


        //-----------REDICT-----------//
        //close login and open register
        private void openRegister(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm f = new registerForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        //close and open admin
        private void openAdmin(object sender, EventArgs e)
        {
            this.Hide();
            //String uname = username.Text;
            adminForm f = new adminForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        //close and open NV Ban Hang
        private void openNVBH(object sender, EventArgs e)
        {
            this.Hide();
            //String uname = username.Text;
            nvBHForm f = new nvBHForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        //close and open NV Kho
        private void openNVKho(object sender, EventArgs e)
        {
            this.Hide();
            //String uname = username.Text;
            nvKhoForm f = new nvKhoForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        //-----------LOGIN-----------//
        //check which users 
        private void checkUser(object sender, EventArgs e)
        {
            //Select
            Taikhoan tk = taikhoanBLL.getAccountByUname(username.Text);
            Nhanvien nv = nhanvienBLL.getNVById(tk.Id);

            if (tk != null)
            {
                if (nv.Idpos.Equals("AD"))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    openAdmin(sender, e);
                }
                if (nv.Idpos.Equals("BH"))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    openNVBH(sender, e);
                }
                if (nv.Idpos.Equals("KHO"))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    openNVKho(sender, e);
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //checkUser(sender, e);
            if (username.Text.Equals("admin"))
            {
                openAdmin(sender, e);
            }
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
