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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = labelID.Text;
            string name = fullname.Text;
            string add = address.Text;
            string phoneNum = phone.Text;

            //set kh 
            kh = new Khachhang(id, name, add, phoneNum);
            if (khBLL.updateKH(kh))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
