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

        public empItem(Nhanvien nvien)
        {
            InitializeComponent();
            this.nv = nvien;
        }

        private void empItem_Load(object sender, EventArgs e)
        {
            empName.Text = this.nv.Name;
            empID.Text = this.nv.Id;
            empPos.Text = this.nv.Idpos;
        }

        private void empItem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
