using BLL;
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
    public partial class infoFormKH : Form
    {
        KhachhangBLL khBLL = new KhachhangBLL();
        Khachhang kh = new Khachhang();

        public infoFormKH(Khachhang kkh)
        {
            this.kh = kkh;
            InitializeComponent();
        }

        private void infoFormKH_Load(object sender, EventArgs e)
        {
            labelID.Text = kh.Id;
            fullname.Text = kh.Name;
            address.Text = kh.Address;
            phone.Text = kh.Phone;
            email.Text = kh.Email;
            date_created.Value = kh.Created;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = labelID.Text;
            string name = fullname.Text;
            string add = address.Text;
            string phoneNum = phone.Text;
            string mail = email.Text;
            DateTime created = date_created.Value;

            //set kh 
            kh = new Khachhang(id, name, add, phoneNum, mail, created);
            if (khBLL.updateKH(kh))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fullname.Text = "";
            address.Text = "";
            phone.Text = "";
            email.Text = "";
        }
    }
}
