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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        Taikhoan tk = new Taikhoan();
        Nhanvien nv = new Nhanvien();

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
        private void openAdmin(object sender, EventArgs e, Nhanvien nhanvien, Taikhoan taikhoan)
        {
            this.Hide();
            //String uname = username.Text;
            adminForm f = new adminForm(nhanvien, taikhoan);
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        //close and open NV Ban Hang
        private void openNVBH(object sender, EventArgs e, Nhanvien nhanvien, Taikhoan taikhoan)
        {
            this.Hide();
            //String uname = username.Text;
            nvBHForm f = new nvBHForm(nhanvien, taikhoan);
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        //close and open NV Kho
        private void openNVKho(object sender, EventArgs e, Nhanvien nhanvien, Taikhoan taikhoan)
        {
            this.Hide();
            //String uname = username.Text;
            nvKhoForm f = new nvKhoForm(nhanvien, taikhoan);
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
            int per = tk.Permission;

            if (username.Text == "" || tk.Userame.Equals(username.Text) == false)
            {
                errorLogin.Text = "Tên đăng nhập sai!";
            }
            else if (string.IsNullOrEmpty(password.Text) || tk.Password.Equals(password.Text) == false)
            {
                errorLogin.Text = "Mật khẩu sai!";
            }
            else
            {
                if (per == 2)
                {
                    openAdmin(sender, e, nv, tk);
                }
                if (per == 1)
                {
                    if (nv.Idpos.Equals("BH"))
                    {
                        openNVBH(sender, e, nv, tk);
                    }
                    if (nv.Idpos.Equals("KHO"))
                    {
                        openNVKho(sender, e, nv, tk);
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            checkUser(sender, e);

            /*
            if (username.Text.Equals("admin"))
            {
                openAdmin(sender, e);
            }
            if (username.Text.Equals("bh"))
            {
                openNVBH(sender, e);
            }
            if (username.Text.Equals("kho"))
            {
                openNVKho(sender, e);
            }
            */
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
