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
    public partial class customerItem : UserControl
    {
        public Khachhang kh;
        KhachhangBLL khBLL = new KhachhangBLL();

        public customerItem(Khachhang khachhang)
        {
            this.kh = khachhang;
            InitializeComponent();
        }

        private void cusItem_Load(object sender, EventArgs e)
        {
            cusName.Text = this.kh.Name;
            cusID.Text = this.kh.Id;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            infoFormKH f = new infoFormKH(this.kh);
            f.ShowDialog();
        }
    }
}
