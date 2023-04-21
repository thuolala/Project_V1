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
    public partial class manageCusForm : Form
    {
        public manageCusForm()
        {
            InitializeComponent();
        }

        KhachhangBLL khBLL = new KhachhangBLL();
        Khachhang kh = new Khachhang();

        private void panelCus_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadAll()
        {
            DataTable dt = new DataTable();
            dt = khBLL.getAllKH();
            datagridviewCusList.DataSource = dt;
            datagridviewCusList.Columns[0].HeaderText = "ID";
            datagridviewCusList.Columns[1].HeaderText = "Họ tên";
            datagridviewCusList.Columns[2].HeaderText = "Địa chỉ";
            datagridviewCusList.Columns[3].HeaderText = "SĐT";

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            editBtn.HeaderText = "Edit";
            editBtn.Name = "EditBtn";
            editBtn.Image = Properties.Resources.pencil1;
            editBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editBtn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editBtn.Width = 20;
            datagridviewCusList.Columns.Add(editBtn);
        }

        private void manageCusForm_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void datagridviewCusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addCusForm f = new addCusForm();
            f.ShowDialog();
        }

        private void datagridviewCusList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datagridviewCusList.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string id = datagridviewCusList.Rows[index].Cells[0].Value.ToString();
                string fname = datagridviewCusList.Rows[index].Cells[1].Value + string.Empty;
                string address = datagridviewCusList.Rows[index].Cells[2].Value + string.Empty;
                string phone = datagridviewCusList.Rows[index].Cells[3].Value + string.Empty;

                kh = new Khachhang(id, fname, address, phone);
                infoFormKH f = new infoFormKH(kh);
                f.ShowDialog();
            }
        }
    }
}
