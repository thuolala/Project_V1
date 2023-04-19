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
    public partial class manageEmpForm : Form
    {
        public manageEmpForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void panelEmp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageEmpForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Họ tên", typeof(string));
            dt.Rows.Add("NV001", "Họ tên");
            dt.Rows.Add("NV002", "Họ tên");

            datagridviewEmpList.DataSource = dt;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            editBtn.HeaderText = "Edit";
            editBtn.Name = "EditBtn";
            editBtn.Image = Properties.Resources.pencil1;
            editBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editBtn.Width = 20;
            datagridviewEmpList.Columns.Add(editBtn);

            DataGridViewImageColumn delBtn = new DataGridViewImageColumn();
            delBtn.HeaderText = "Delete";
            delBtn.Name = "DeleteBtn";
            delBtn.Image = Properties.Resources.trash_can;
            delBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delBtn.Width = 20;
            datagridviewEmpList.Columns.Add(delBtn);
        }

        private void datagridviewEmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datagridviewEmpList.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {
                infoForm f = new infoForm();
                f.ShowDialog();
            }
        }
    }
}
