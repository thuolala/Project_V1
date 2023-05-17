using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class adminForm : Form
    {
        Nhanvien nv = new Nhanvien();
        Taikhoan tk = new Taikhoan();

        public adminForm(Nhanvien nhanvien, Taikhoan taikhoan)
        {
            this.nv = nhanvien;
            this.tk = taikhoan;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();

        }

        bool sidebarExpand;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerMenu.Stop();
                }
            }
        }

        //close and open login form
        private void openLogin(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            manageEmployee manageEmp = new manageEmployee();
            manageEmp.TopLevel = false;
            manageEmp.Dock = DockStyle.Fill;
            manageEmp.Show();
            panelShow.Controls.Add(manageEmp);
            manageEmp.BringToFront();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            displayName.Text = nv.Name;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            manageCusForm manageCus = new manageCusForm();
            manageCus.TopLevel = false;
            manageCus.Dock = DockStyle.Fill;
            manageCus.Show();
            panelShow.Controls.Add(manageCus);
            manageCus.BringToFront();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            selfEditForm info = new selfEditForm(nv, tk);
            info.TopLevel = false;
            panelShow.Controls.Add(info);
            info.Dock = DockStyle.Fill;
            info.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            openLogin(sender, e);
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
