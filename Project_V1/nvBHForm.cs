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
    public partial class nvBHForm : Form
    {
        public nvBHForm()
        {
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

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            medicineListForm manageMed = new medicineListForm();
            manageMed.TopLevel = false;
            manageMed.Dock = DockStyle.Fill;
            manageMed.Show();
            panelShow.Controls.Add(manageMed);
            manageMed.BringToFront();
        }
    }
}
