using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class loginForm : Form
    {
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);

        public loginForm()
        {
            InitializeComponent();
        }

        TaikhoanBLL taikhoanBLL = new TaikhoanBLL();
        NhanvienBLL nhanvienBLL = new NhanvienBLL();

        //Get ID & fname
        public static string ID;
        public static string fname = "";

        /*
        public void getFullName()
        {
            //Select ID 
            String sSQL1 = "SELECT ID FROM Account WHERE " +
                           "USERNAME = '" + username.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL1, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                ID = dt1.Rows[0]["ID"].ToString();

                String sSQL2 = "SELECT FULLNAME FROM Employee WHERE " +
                           "ID_EMPLOYEE = '" + ID + "'";
                cmd = new SqlCommand(sSQL2, conn);
                da = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                if(dt2.Rows.Count > 0)
                {
                    fname = dt2.Rows[0]["FULLNAME"].ToString();
                }
            }
            da.Dispose();
        }
        */



        //move function 
        private Point mouse;

        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                int dx = e.Location.X - mouse.X;
                int dy = e.Location.Y - mouse.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        public void start()
        {
            Application.Run(new welcomeForm());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        //exit 
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        /*
        public void openEmployee(object sender, EventArgs e, String id)
        {
            //Select
            String sSQL = "SELECT * FROM Employee WHERE ID_EMPLOYEE LIKE '" + id + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String pos = dt.Rows[0]["POSITION"].ToString();
                if (pos.Equals("Bán hàng"))
                {
                    openNVBH(sender, e);
                }
                if (pos.Equals("Kho"))
                {
                    openNVKho(sender, e);
                }
            }
        }
        */

        //redict to register form 
        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openRegister(sender, e);
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

            }

            /*
            String sSQL = "SELECT ID,   USERNAME, PASSWORD, PERMISSION FROM Account WHERE " +
                           "USERNAME='" + username.Text + "' and PASSWORD='" + password.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int permission = Int32.Parse(dt.Rows[0]["PERMISSION"].ToString());
                String id = dt.Rows[0]["ID"].ToString();
                getFullName();
                switch (permission)
                {
                    //check if admin
                    case 2:
                        MessageBox.Show("Đăng nhập thành công!");
                        openAdmin(sender, e);
                        break;
                    //check if employee
                    case 1:
                        MessageBox.Show("Đăng nhập thành công!");
                        openEmployee(sender, e, id);
                        break;
                    //check if customer
                    case 0:
                        MessageBox.Show("Đăng nhập thành công!");
                        break;
                    default:
                        MessageBox.Show("Tài khoản không tồn tại. Vui lòng tạo tài khoản mới!");
                        break;
                }

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập hoặc mật khẩu!");
            }
            da.Dispose();
            */
        }

        //login 
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            checkUser(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm f = new registerForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            password.Controls.Add(showPass);
            this.AcceptButton = btnLogin;
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void changeLanguage(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void showPass_MouseDown(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
            showPass.Visible = false;
        }

        private void showPass_MouseUp(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = true;
            showPass.Visible = true;
        }

        private void showPass_Click(object sender, EventArgs e)
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
    }
}
