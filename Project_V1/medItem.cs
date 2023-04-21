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
    public partial class medItem : UserControl
    {
        public string name;
        public int price;
        public int quantity;

        public medItem(string mname, int mprice, int quantity)
        {
            this.name = mname;
            this.price = mprice;
            this.quantity = quantity;
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void medItem_Load(object sender, EventArgs e)
        {
            medName.Text = this.name;
            medPrice.Text = this.price.ToString();
            medQuantity.Text = this.quantity.ToString();
        }

        private void medItem_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(94, 148, 255);
            int borderWidth = 1;
        }
    }
}
