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
    public partial class empItem : UserControl
    {
        public Nhanvien nv;
        public Taikhoan tk;
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        VitriBLL vtBLL = new VitriBLL();

        public empItem(Nhanvien nvien, Taikhoan tkhoan)
        {
            this.nv = nvien;
            this.tk = tkhoan;
            InitializeComponent();
        }

        private void empItem_Load(object sender, EventArgs e)
        {
            empName.Text = this.nv.Name;
            empID.Text = this.nv.Id;
            empPos.Text = vtBLL.getVTName(this.nv.Idpos);
            /*
            try
            {
                using (MemoryStream stream = new MemoryStream(nv.Avatar))
                {
                    Image image = Image.FromStream(stream);
                    empPic.Image = image;
                }
            }
            catch (ArgumentException ex)
            {
                // Handle the exception here, for example:
                MessageBox.Show("Error loading image: " + ex.Message);
            }
            */
        }

        private void empItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empPic_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            infoFormNV f = new infoFormNV(this.nv, this.tk);
            f.ShowDialog();
        }
    }
}
