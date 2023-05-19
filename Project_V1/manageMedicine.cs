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

namespace GUI
{
    public partial class manageMedicine : Form
    {
        public manageMedicine()
        {
            InitializeComponent();
        }

        private void manageMedForm_Load(object sender, EventArgs e)
        {
            medicineItem mI = new medicineItem("A", 10);
            panelDisplay.Controls.Add(mI);
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {

        }
    }
}
