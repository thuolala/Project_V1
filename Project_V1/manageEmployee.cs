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
    public partial class manageEmployee : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);

        public manageEmployee()
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
            getID.Text = "";
            fullname.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            //dob.Value = DateTime.MinValue;
            hometown.Text = "";
            phone.Text = "";
            email.Text = "";
            positionDisplay.SelectedItem = "";

            username.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Lay du lieu 
            String id = getID.Text;
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
            String pos = (position.SelectedItem).ToString();

            String uname = username.Text;
            String pass = password.Text;
            String conPass = confirmPassword.Text;
            int per = 1;
            //Check 
            checkEmpty();
            if (checkEmpty())
            {
                if (checkPhone(phoneNum) && checkEmail(mail) && checkPassword(pass))
                {
                    //Cap nhat vao bang Employee 
                    SqlCommand cmd = new SqlCommand("UPDATE_NV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_EMPLOYEE", SqlDbType.NVarChar)).Value = id;
                    cmd.Parameters.Add(new SqlParameter("@FULLNAME", SqlDbType.NVarChar)).Value = fname;
                    cmd.Parameters.Add(new SqlParameter("@GENDER", SqlDbType.NVarChar)).Value = sex;
                    cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = birth;
                    cmd.Parameters.Add(new SqlParameter("@HOMETOWN", SqlDbType.NVarChar)).Value = home;
                    cmd.Parameters.Add(new SqlParameter("@PHONE", SqlDbType.VarChar)).Value = phoneNum;
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar)).Value = mail;
                    cmd.Parameters.Add(new SqlParameter("@POSITION", SqlDbType.NVarChar)).Value = pos;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();

                    //Nhap vao bang Account 
                    cmd = new SqlCommand("UPDATE_ACCOUNT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@USERNAME", uname));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORD", pass));
                    cmd.Parameters.Add(new SqlParameter("@PERMISSION", per));
                    da = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    da.Dispose();

                    MessageBox.Show("Cập nhật thành công!");
                }
                LoadDataAll();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String id = getID.Text;

            //Nhap vao bang Employee 
            String sql1 = "DELETE FROM Employee WHERE ID_EMPLOYEE = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();

            //Nhap vao bang Account 
            String sql2 = "DELETE FROM Account WHERE ID = '" + id + "'";
            cmd = new SqlCommand(sql2, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            da.Dispose();


            MessageBox.Show("Xóa thành công!");
            LoadDataAll();
            clearAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void LoadDataAll()
        {

            //Select
            String sSQL = "SELECT * FROM EMPLOYEE";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                gridInfo.DataSource = dt;;
            }
            gridInfo.Refresh();
        }

        private void LoadDataEach()
        {

            //Select
            String sSQL = "SELECT * FROM EMPLOYEE WHERE POSITION = N'" + positionDisplay.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                gridInfo.DataSource = dt; ;
            }
            gridInfo.Refresh();
        }

        private void viewEmployee_Load(object sender, EventArgs e)
        {
            positionDisplay.Items.Insert(0, "Tất cả");
            positionDisplay.Items.Insert(1, "Bán hàng");
            positionDisplay.Items.Insert(2, "Kho");
            positionDisplay.Items.Insert(3, "Thu ngân");

            position.Items.Insert(0, "Bán hàng");
            position.Items.Insert(1, "Kho");
            position.Items.Insert(2, "Thu ngân");

            LoadDataAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            String pos = (position.SelectedItem).ToString();

            String uname = username.Text;
            String pass = password.Text;
            String conPass = confirmPassword.Text;

            //Check 
            checkEmpty();
            if (checkEmpty())
            {
                if (checkPhone(phoneNum) && checkEmail(mail) && checkPassword(pass) && checkConfirmPassword(pass, conPass))
                {
                    //Nhap vao bang Employee 
                    SqlCommand cmd = new SqlCommand("INSERT_NV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FULLNAME", SqlDbType.NVarChar)).Value = fname;
                    cmd.Parameters.Add(new SqlParameter("@GENDER", SqlDbType.NVarChar)).Value = sex;
                    cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = birth;
                    cmd.Parameters.Add(new SqlParameter("@HOMETOWN", SqlDbType.NVarChar)).Value = home;
                    cmd.Parameters.Add(new SqlParameter("@PHONE", SqlDbType.VarChar)).Value = phoneNum;
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar)).Value = mail;
                    cmd.Parameters.Add(new SqlParameter("@POSITION", SqlDbType.NVarChar)).Value = pos;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();

                    //Nhap vao bang Account 
                    cmd = new SqlCommand("INSERT_ACCOUNT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@USERNAME", uname));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORD", pass));
                    int per = 1;
                    cmd.Parameters.Add(new SqlParameter("@PERMISSION", per));
                    da = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    da.Dispose();

                    MessageBox.Show("Lưu thành công!");

                    clearAll();
                }
                LoadDataAll(); 
            }
        }

        private void positionDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(positionDisplay.SelectedIndex == 0) 
            {
                LoadDataAll();
                displayData();
            }
            else
            {
                LoadDataEach();
                displayData();
            }
        }

        private void displayData()
        {
            if (gridInfo.SelectedRows.Count > 0)
            {
                //From Employee
                getID.Text = gridInfo.SelectedRows[0].Cells[0].Value + string.Empty;
                fullname.Text = gridInfo.SelectedRows[0].Cells[1].Value + string.Empty;
                if((gridInfo.SelectedRows[0].Cells[2].Value + string.Empty).Equals("Nam"))
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }
                dob.Value = Convert.ToDateTime(gridInfo.SelectedRows[0].Cells[3].Value + string.Empty);
                hometown.Text = gridInfo.SelectedRows[0].Cells[4].Value + string.Empty;
                phone.Text = gridInfo.SelectedRows[0].Cells[5].Value + string.Empty;
                email.Text = gridInfo.SelectedRows[0].Cells[6].Value + string.Empty;
                position.SelectedItem = gridInfo.SelectedRows[0].Cells[7].Value + string.Empty;

                //From Account 
                String sSQL = "SELECT USERNAME, PASSWORD FROM Account WHERE " +
                           "ID='" + (gridInfo.SelectedRows[0].Cells[0].Value + string.Empty) + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0){
                    username.Text = dt.Rows[0]["USERNAME"].ToString();
                    password.Text = dt.Rows[0]["PASSWORD"].ToString();
                }
                da.Dispose();
            }
        }

        private void gridInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayData();
        }

        private void gridInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
