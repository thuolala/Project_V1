﻿using System;
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
    public partial class nvBHForm : Form
    {
        Nhanvien nv = new Nhanvien();
        Taikhoan tk = new Taikhoan();

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
            medicineListForm manageMed = new medicineListForm();
            manageMed.TopLevel = false;
            manageMed.Dock = DockStyle.Fill;
            manageMed.Show();
            panelShow.Controls.Add(manageMed);
            manageMed.BringToFront();
        }

        private void nvBHForm_Load(object sender, EventArgs e)
        {
            displayName.Text = nv.Name;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            manageCusForm manageCus = new manageCusForm();
            manageCus.TopLevel = false;
            manageCus.Dock = DockStyle.Fill;
            manageCus.Show();
            panelShow.Controls.Add(manageCus);
            manageCus.BringToFront();
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
