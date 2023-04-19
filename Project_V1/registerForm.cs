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
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace GUI
{
    public partial class registerForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);

        public registerForm()
        {
            InitializeComponent();
        }

        //move function 
        private Point mouse;

        private void registerForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        private void registerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouse.X;
                int dy = e.Location.Y - mouse.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        //

        private Boolean checkPhone(String phone)
        {
            if (phone.Any(x => !char.IsLetter(x)))
            {
                return true;
            }
            MessageBox.Show("Số điện thoại sai định dạng!");
            return false;
        }

        //Check email format 
        private Boolean checkEmail(String email)
        {
            if (email[0].Equals("@") || email[email.Length - 1].Equals("@"))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return false;
            }
            return true;
        }

        //Check password length 
        private Boolean checkPassword(String password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!");
                return false;
            }
            return true;
        }

        //Check confirm password
        private Boolean checkConfirmPassword(String password, String confirmPassword)
        {
            if (password.Equals(confirmPassword))
            {
                return true;
            }
            return false;
        }

        private Boolean checkEmpty()
        {
            if (fullname.Text == null)
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return false;
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }
            else if (hometown.Text == null)
            {
                MessageBox.Show("Vui lòng nhập quê quán!");
                return false;
            }
            else if (phone.Text == null)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                return false;
            }
            else if (email.Text == null)
            {
                MessageBox.Show("Vui lòng nhập email!");
                return false;
            }
            return true;

        }

        private void clearAll()
        {
            fullname.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            //dob.Value = DateTime.MinValue;
            hometown.Text = "";
            phone.Text = "";
            email.Text = "";

            email.Text = "";
            password.Text = "";
            confirmPass.Text = "";
        }

        //close register and open login
        private void openLogin(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            //Lay du lieu 
            String fname = fullname.Text;
            String sex = "";
            if (radioButtonMale.Checked)
            {
                sex += "Nam";
            }
            else if (radioButtonFemale.Checked)
            {
                sex += "Nữ";
            }
            DateTime birth = dob.Value;
            String home = hometown.Text;
            String phoneNum = phone.Text;


            String mail = email.Text;
            String pass = password.Text;
            String conPass = confirmPass.Text;
            int per = 0;

            //Check 
            checkEmpty();
            if (checkEmpty())
            {
                if (checkPhone(phoneNum) && checkEmail(mail) && checkPassword(pass) && checkConfirmPassword(pass, conPass))
                {
                    //Nhap vao bang Employee 
                    SqlCommand cmd = new SqlCommand("INSERT_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FULLNAME", SqlDbType.NVarChar)).Value = fname;
                    cmd.Parameters.Add(new SqlParameter("@GENDER", SqlDbType.NVarChar)).Value = sex;
                    cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = birth;
                    cmd.Parameters.Add(new SqlParameter("@HOMETOWN", SqlDbType.NVarChar)).Value = home;
                    cmd.Parameters.Add(new SqlParameter("@PHONE", SqlDbType.VarChar)).Value = phoneNum;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();

                    //Nhap vao bang Account 
                    cmd = new SqlCommand("INSERT_ACCOUNTKH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", mail));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORD", pass));
                    cmd.Parameters.Add(new SqlParameter("@PERMISSION", per));
                    da = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    da.Dispose();

                    MessageBox.Show("Đăng ký thành công!");

                    clearAll();
                }
            }
            openLogin(sender, e);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegis;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }
    }
}
