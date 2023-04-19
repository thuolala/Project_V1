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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.ConstrainedExecution;


namespace GUI
{
    public partial class editInfo : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);

        public editInfo()
        {
            InitializeComponent();
        }

        //---FUNCTION TO CHECK---//
        //Check ID exist 
        private Boolean checkIDExist(String ID)
        {
            return false;
        }

        //Check phone 
        private Boolean checkPhone(String phone)
        {
            if(phone.Any(x => !char.IsLetter(x)))
            {
                return true;
            }
            MessageBox.Show("Số điện thoại sai định dạng!");
            return false;
        }

        //Check email format 
        private Boolean checkEmail(String email)
        {
            if (email[0].Equals("@") || email[email.Length - 1].Equals("@")) {
                MessageBox.Show("Email không đúng định dạng!");
                return false;
            }
            return true;
        }

        //Check password length 
        private Boolean checkPassword(String password)
        {
            if(password.Length < 8)
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
            if(fullname.Text == null)
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return false;
            }
            else if(radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
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
        
        //Check which form is used 
        public static string ID = "";
        public static string fname = "";
        public static string pos = "";
        public static string sex = "";
        public static string phoneNum = "";
        public static string birth = "";
        public static string town = "";
        public static string mailD = "";
        public static string username = "";
        public static string password = "";
        private static int per = 0;
        public static int point = 0;

        private void addEmployee_Load(object sender, EventArgs e)
        {
        }

        private void editInfo_Load(object sender, EventArgs e)
        {
            /*
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "adminForm")
                {
                    ID = adminForm.ID;
                    fname = adminForm.fname;
                    pos = adminForm.pos;
                    sex = adminForm.sex;
                    phoneNum = adminForm.phone;
                    birth = adminForm.birth;
                    town = adminForm.town;
                    mailD = adminForm.mailD;
                    username = adminForm.username;
                    password = adminForm.password;
                    per = 2;
                }
                else if (frm.Name == "nvBHForm")
                {
                    ID = nvBHForm.ID;
                    fname = nvBHForm.fname;
                    pos = nvBHForm.pos;
                    sex = nvBHForm.sex;
                    phoneNum = nvBHForm.phone;
                    birth = nvBHForm.birth;
                    town = nvBHForm.town;
                    mailD = nvBHForm.mailD;
                    username = nvBHForm.username;
                    password = nvBHForm.password;
                    per = 1;
                }

            }

            //Empty label 
            fullname.Text = string.Empty;
            displayID.Text = string.Empty;
            displayPos.Text = string.Empty;
            displayPhone.Text = string.Empty;
            displayBirth.Text = string.Empty;

            //Display 
            fullname.Text = fname;
            displayID.Text = ID;
            displayPos.Text = pos; 
            displayPhone.Text = phoneNum;
            displayBirth.Text = birth.Split(" ")[0];
            if (sex.Equals("Nam"))
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = true;
            }
            hometown.Text = town;
            phone.Text = phoneNum;
            email.Text = mailD;
            displayUsername.Text = username;
            displayPassword.Text = password;

            */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Lay du lieu 
            String newTown = hometown.Text;
            String newPhone = phone.Text;
            String newEmail = email.Text;

            if (!changePassword.Text.Equals(confirmPassword.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
            }
            if (changePassword.Text.Equals(confirmPassword.Text))
            {
                //Cap nhat vao bang Employee 
                SqlCommand cmd = new SqlCommand("UPDATE_NV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_EMPLOYEE", SqlDbType.NVarChar)).Value = ID;
                cmd.Parameters.Add(new SqlParameter("@FULLNAME", SqlDbType.NVarChar)).Value = fname;
                cmd.Parameters.Add(new SqlParameter("@GENDER", SqlDbType.NVarChar)).Value = sex;
                cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = birth;
                cmd.Parameters.Add(new SqlParameter("@HOMETOWN", SqlDbType.NVarChar)).Value = newTown;
                cmd.Parameters.Add(new SqlParameter("@PHONE", SqlDbType.VarChar)).Value = newPhone;
                cmd.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar)).Value = newEmail;
                cmd.Parameters.Add(new SqlParameter("@POSITION", SqlDbType.NVarChar)).Value = pos;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                //Cap nhat vao bang Account 
                cmd = new SqlCommand("UPDATE_ACCOUNT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@USERNAME", username));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", changePassword.Text));
                cmd.Parameters.Add(new SqlParameter("@PERMISSION", per));
                da = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                da.Dispose();

                MessageBox.Show("Cập nhật thành công!");

                displayPhone.Text = newPhone;
                displayPassword.Text = changePassword.Text;
            }
        }


        //Enter instead of click 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData== Keys.Enter)
            {
                btnSave.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void clearAll() {
            changePassword.Text = "";
            confirmPassword.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
