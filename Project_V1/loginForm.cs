using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

using BLL;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.JavaScript;
using System.Net;

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
        Handle handle = new Handle();

        //show password
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

        //move fucntion
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
            try
            {
                //Select
                tk = taikhoanBLL.getAccountByUname(username.Text);
                nv = nhanvienBLL.getNVById(tk.Id);
                int per = tk.Permission;
                if (username.Text == "" && string.IsNullOrEmpty(password.Text))
                {
                    errorLogin.Text = "Tên đăng nhập và mật khẩu không được trống!";
                    panelUname.BorderColor = Color.Red;
                    panelPass.BorderColor = Color.Red;
                }

                else
                {
                    panelUname.BorderColor = Color.FromArgb(3, 49, 90);
                    panelPass.BorderColor = Color.FromArgb(3, 49, 90);

                    if (tk.Userame.Equals(username.Text) == false){
                        errorLogin.Text = "Tên đăng nhập sai!";
                        panelUname.BorderColor = Color.Red;
                        panelPass.BorderColor = Color.FromArgb(3, 49, 90);
                    }
                    else if ((username.Text == ""))
                    {
                        errorLogin.Text = "Tên đăng nhập không được trống!";
                        panelUname.BorderColor = Color.Red;
                        panelPass.BorderColor = Color.FromArgb(3, 49, 90);
                    }
                    else if ((string.IsNullOrEmpty(password.Text))) 
                    {
                        errorLogin.Text = "Mật khẩu không được trống!";
                        panelUname.BorderColor = Color.FromArgb(3, 49, 90);
                        panelPass.BorderColor = Color.Red;
                    }
                    else if (tk.Password.Equals(password.Text) == false)
                    {
                        errorLogin.Text = "Mật khẩu sai!";
                        panelUname.BorderColor = Color.FromArgb(3, 49, 90);
                        panelPass.BorderColor = Color.Red;
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
            }
            catch (Exception ex)
            {
                errorLogin.Text = "Tên đăng nhập hoặc mật khẩu sai!";
                panelUname.BorderColor = Color.FromArgb(3, 49, 90);
                panelPass.BorderColor = Color.Red;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkUser(sender, e);
        }

        //minimize
        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //exit
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //send mail forgot pass
        private void linkLabelForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Taikhoan test = taikhoanBLL.getAccountByUname(username.Text);
            string email = nhanvienBLL.getNVById(test.Id).Email;

            MailAddress from = new MailAddress("extractteam123@gmail.com", "Pharmacity");
            MailAddress to = new MailAddress(email, nhanvienBLL.getNVById(test.Id).Name);
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("extractteam123@gmail.com", "Pharmacity"));
            handle.SendEmail(from, to, cc);
            MessageBox.Show("Mail đã được gửi!");
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
