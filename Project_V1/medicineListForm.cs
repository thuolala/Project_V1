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
    public partial class medicineListForm : Form
    {
        public medicineListForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMedicineForm f = new addMedicineForm();
            f.ShowDialog();
        }

        private void medicineListForm_Load(object sender, EventArgs e)
        {
            medItem med = new medItem();
            med.Dock = DockStyle.Fill;
            med.Show();
            panelShow.Controls.Add(med);
            med.BringToFront();
        }
    }
}
