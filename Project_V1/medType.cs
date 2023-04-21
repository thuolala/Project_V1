using Guna.UI2.WinForms;
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
    public partial class medType : UserControl
    {
        public string name;
        public medType(string tname)
        {
            this.name = tname;
            InitializeComponent();
        }

        private void medType_Load(object sender, EventArgs e)
        {
            typeName.Text = name;
        }

        private void panelPic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void typeName_Click(object sender, EventArgs e)
        {

        }

        private void panelName_Paint(object sender, PaintEventArgs e)
        {
        }

        private void typePic_Click(object sender, EventArgs e)
        {
        }

        private void medType_Click(object sender, EventArgs e)
        {

        }
    }
}
