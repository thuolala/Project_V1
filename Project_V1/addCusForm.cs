using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace GUI
{
    public partial class addCusForm : Form
    {
        public addCusForm()
        {
            InitializeComponent();
        }

        KhachhangBLL khBLL = new KhachhangBLL();
        Khachhang kh = new Khachhang();

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = fullname.Text;
            string add = address.Text;
            string phoneNum = phone.Text;

            //set kh 
            kh = new Khachhang(name, add, phoneNum);
            if (khBLL.addKH(kh))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }
    }
}
