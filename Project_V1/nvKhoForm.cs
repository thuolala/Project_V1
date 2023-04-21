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
    public partial class nvKhoForm : Form
    {
        Nhanvien nv = new Nhanvien();
        Taikhoan tk = new Taikhoan();
        public nvKhoForm(Nhanvien nhanvien, Taikhoan taikhoan)
        {
            this.nv = nhanvien;
            this.tk = taikhoan;
            InitializeComponent();
        }

        //close and open login form
        private void openLogin(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            openLogin(sender, e);
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

        private void btnWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void nvKhoForm_Load(object sender, EventArgs e)
        {
            displayName.Text = nv.Name;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            selfEditForm info = new selfEditForm(nv, tk);
            info.TopLevel = false;
            panelShow.Controls.Add(info);
            info.Dock = DockStyle.Fill;
            info.Show();
        }
    }
}
