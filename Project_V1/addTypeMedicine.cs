using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class addTypeMedicine : Form
    {
        public addTypeMedicine()
        {
            InitializeComponent();
        }

        NhomthuocBLL ntBLL = new NhomthuocBLL();
        Nhomthuoc nt = new Nhomthuoc();

        private string getID()
        {
            return ntBLL.getAutoIDNT();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = name_type.Text;
            nt = new Nhomthuoc(name);

            if (name == "")
            {
                errorInput.Text = "Tên không được trống!";
            }
            if (ntBLL.addNT(nt))
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
        }

        private void addTypeMedicine_Load(object sender, EventArgs e)
        {
            id_type.Text = getID();
        }
    }
}
