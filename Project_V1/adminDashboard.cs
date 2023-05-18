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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void panelTop_Layout(object sender, LayoutEventArgs e)
        {
            int newX = (panelTop.Width - labelDashboard.Width) / 2;
            int newY = (labelDashboard.Height - labelDashboard.Height) / 2;

            labelDashboard.Location = new Point(newX, newY);
        }
    }
}
