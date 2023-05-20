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
    public partial class addNCC : Form
    {
        public addNCC()
        {
            InitializeComponent();
        }

        NhacungcapBLL nccBLL = new NhacungcapBLL();
        Nhacungcap ncc = new Nhacungcap();

        private string getID()
        {
            return nccBLL.getAutoID();
        }

        private void addNCC_Load(object sender, EventArgs e)
        {
            id_ncc.Text = getID().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Nhacungcap nh = new Nhacungcap(name_ncc.Text, address_ncc.Text, phone_ncc.Text, email_ncc.Text);
            if (nccBLL.addNCC(nh))
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
        }
    }
}
