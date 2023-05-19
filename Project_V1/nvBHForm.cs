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
using DTO;
namespace GUI
{
    public partial class nvBHForm : Form
    {
        Nhanvien nv = new Nhanvien();
        Taikhoan tk = new Taikhoan();
        NhanvienBLL nvBLL = new NhanvienBLL();
        TaikhoanBLL tkBLL = new TaikhoanBLL();

        public nvBHForm(Nhanvien nhanvien, Taikhoan taikhoan)
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

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            btnMedicine.BackColor = SystemColors.Control;
            changeColor(sender, e);

            panelDisplay.Controls.Clear();
            manageMedicine mM = new manageMedicine();
            mM.TopLevel = false;
            panelDisplay.Controls.Add(mM);
            mM.Dock = DockStyle.Fill;
            mM.Show();
        }

        private void nvBHForm_Load(object sender, EventArgs e)
        {
            displayName.Text = nv.Name;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnCustomer.BackColor = SystemColors.Control;
            changeColor(sender, e);

            panelDisplay.Controls.Clear();
            manageCustomer manageCus = new manageCustomer();
            manageCus.TopLevel = false;
            manageCus.Dock = DockStyle.Fill;
            manageCus.Show();
            panelDisplay.Controls.Add(manageCus);
            manageCus.BringToFront();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnInfo.BackColor = SystemColors.Control;
            changeColor(sender, e);

            Nhanvien nvien = nvBLL.getNVById(nv.Id);
            Taikhoan tkhoan = tkBLL.getAccountById(tk.Id);

            panelDisplay.Controls.Clear();
            selfEditForm info = new selfEditForm(nvien, tkhoan);
            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            info.Show();
            panelDisplay.Controls.Add(info);
            info.BringToFront();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            btnSale.BackColor = SystemColors.Control;
            changeColor(sender, e);

            panelDisplay.Controls.Clear();
        }


        //change color of button 
        private void changeColor(object sender, EventArgs e)
        {
            if (sender == btnDashboard)
            {
                btnDashboard.BackColor = SystemColors.Control;
                btnDashboard.ForeColor = Color.FromArgb(3, 49, 90);

                btnSale.BackColor = Color.Transparent;
                btnSale.ForeColor = Color.White;

                btnCustomer.BackColor = Color.Transparent;
                btnCustomer.ForeColor = Color.White;

                btnMedicine.BackColor = Color.Transparent;
                btnMedicine.ForeColor = Color.White;

                btnInfo.BackColor = Color.Transparent;
                btnInfo.ForeColor = Color.White;

                btnLogout.BackColor = Color.Transparent;
                btnLogout.ForeColor = Color.White;
            }
            if (sender == btnSale)
            {
                btnDashboard.BackColor = Color.Transparent;
                btnDashboard.ForeColor = Color.White;

                btnSale.BackColor = SystemColors.Control;
                btnSale.ForeColor = Color.FromArgb(3, 49, 90);

                btnCustomer.BackColor = Color.Transparent;
                btnCustomer.ForeColor = Color.White;

                btnMedicine.BackColor = Color.Transparent;
                btnMedicine.ForeColor = Color.White;

                btnInfo.BackColor = Color.Transparent;
                btnInfo.ForeColor = Color.White;

                btnLogout.BackColor = Color.Transparent;
                btnLogout.ForeColor = Color.White;
            }
            if (sender == btnCustomer)
            {
                btnDashboard.BackColor = Color.Transparent;
                btnDashboard.ForeColor = Color.White;

                btnSale.BackColor = Color.Transparent;
                btnSale.ForeColor = Color.White;

                btnCustomer.BackColor = SystemColors.Control;
                btnCustomer.ForeColor = Color.FromArgb(3, 49, 90);

                btnMedicine.BackColor = Color.Transparent;
                btnMedicine.ForeColor = Color.White;

                btnInfo.BackColor = Color.Transparent;
                btnInfo.ForeColor = Color.White;

                btnLogout.BackColor = Color.Transparent;
                btnLogout.ForeColor = Color.White;
            }
            if (sender == btnMedicine)
            {
                btnDashboard.BackColor = Color.Transparent;
                btnDashboard.ForeColor = Color.White;

                btnSale.BackColor = Color.Transparent;
                btnSale.ForeColor = Color.White;

                btnCustomer.BackColor = Color.Transparent;
                btnCustomer.ForeColor = Color.White;

                btnMedicine.BackColor = SystemColors.Control;
                btnMedicine.ForeColor = Color.FromArgb(3, 49, 90);

                btnInfo.BackColor = Color.Transparent;
                btnInfo.ForeColor = Color.White;

                btnLogout.BackColor = Color.Transparent;
                btnLogout.ForeColor = Color.White;
            }
            if (sender == btnInfo)
            {
                btnDashboard.BackColor = Color.Transparent;
                btnDashboard.ForeColor = Color.White;

                btnSale.BackColor = Color.Transparent;
                btnSale.ForeColor = Color.White;

                btnCustomer.BackColor = Color.Transparent;
                btnCustomer.ForeColor = Color.White;

                btnMedicine.BackColor = Color.Transparent;
                btnMedicine.ForeColor = Color.White;

                btnInfo.BackColor = SystemColors.Control;
                btnInfo.ForeColor = Color.FromArgb(3, 49, 90);

                btnLogout.BackColor = Color.Transparent;
                btnLogout.ForeColor = Color.White;
            }
            if (sender == btnLogout)
            {
                btnDashboard.BackColor = Color.Transparent;
                btnDashboard.ForeColor = Color.White;

                btnSale.BackColor = Color.Transparent;
                btnSale.ForeColor = Color.White;

                btnCustomer.BackColor = Color.Transparent;
                btnCustomer.ForeColor = Color.White;

                btnMedicine.BackColor = Color.Transparent;
                btnMedicine.ForeColor = Color.White;

                btnInfo.BackColor = Color.Transparent;
                btnInfo.ForeColor = Color.White;

                btnLogout.BackColor = SystemColors.Control;
                btnLogout.ForeColor = Color.FromArgb(3, 49, 90);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = SystemColors.Control;
            changeColor(sender, e);

            panelDisplay.Controls.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.BackColor = SystemColors.Control;
            changeColor(sender, e);

            openLogin(sender, e);
        }
    }
}
