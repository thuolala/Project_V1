using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class nvBHForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);

        //
        private editInfo editInfo = new editInfo();

        public nvBHForm()
        {
            InitializeComponent();
        }

        //move function 
        private Point mouse;

        private void nvBHForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        private void nvBHForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouse.X;
                int dy = e.Location.Y - mouse.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        //Get info  
        public static string ID = "";
        public static string fname = "";
        public static string pos = "";
        public static string sex = "";
        public static string phone = "";
        public static string birth = "";
        public static string town = "";
        public static string mailD = "";
        public static string username = "";
        public static string password = "";
        public static int point = 0;

        public void getInfo()
        {
            ID = loginForm.ID;
            fname = loginForm.fname;
            //Select ID 
            String sSQL = "SELECT * FROM Employee WHERE " +
                           "ID_EMPLOYEE = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                pos = dt.Rows[0]["POSITION"].ToString();
                sex = dt.Rows[0]["GENDER"].ToString();
                phone = dt.Rows[0]["PHONE"].ToString();
                birth = dt.Rows[0]["DOB"].ToString();
                town = dt.Rows[0]["HOMETOWN"].ToString();
                mailD = dt.Rows[0]["EMAIL"].ToString();
            }
            da.Dispose();
        }

        public void getAccount()
        {
            String sSQL = "SELECT * FROM Account WHERE " +
                           "ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                username = dt.Rows[0]["USERNAME"].ToString();
                password = dt.Rows[0]["PASSWORD"].ToString();
            }
            da.Dispose();
        }

        private void logout_Click(object sender, EventArgs e)
        {
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void nvBHForm_Load(object sender, EventArgs e)
        {
            getInfo();
            getAccount();
            displayName.Text = string.Empty;
            displayName.Text = fname;
        }

        private void panelAction_Paint(object sender, PaintEventArgs e)
        {

        }

        //Open edit form 
        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            editInfo.Dock = DockStyle.Fill;
            editInfo.Show();
            panelAction.Controls.Add(editInfo);
            editInfo.BringToFront();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        private void logout_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
