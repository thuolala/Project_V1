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
    public partial class medicineItem : UserControl
    {
        public string name;
        public int price;

        public medicineItem(string mname, int mprice)
        {
            InitializeComponent();
            this.name = mname;
            this.price = mprice;
        }

        private void medicineItem_Load(object sender, EventArgs e)
        {
            medName.Text = this.name;
            medPrice.Text = this.price.ToString();
        }
    }
}
