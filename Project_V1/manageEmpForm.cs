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
using BLL;
using DTO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class manageEmpForm : Form
    {
        public manageEmpForm()
        {
            InitializeComponent();
        }

        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv = new Nhanvien();
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk = new Taikhoan();
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt = new Vitri();

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void panelEmp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadComboPos()
        {
            DataTable dt = new DataTable();
            dt = vtBLL.getAllVitri();
            positionDisplay.DisplayMember = dt.Columns[1].ToString();
            positionDisplay.ValueMember = dt.Columns[0].ToString();
            positionDisplay.DataSource = dt;
        }

        public void loadAll()
        {
            DataTable dt = new DataTable();
            dt = nvBLL.getAllNV();
            datagridviewEmpList.DataSource = dt;
            datagridviewEmpList.Columns[0].HeaderText = "ID";
            datagridviewEmpList.Columns[1].HeaderText = "Họ tên";
            datagridviewEmpList.Columns[2].HeaderText = "Giới tính";
            datagridviewEmpList.Columns[3].HeaderText = "Ngày sinh";
            datagridviewEmpList.Columns[4].HeaderText = "Quê quán";
            datagridviewEmpList.Columns[5].HeaderText = "SĐT";
            datagridviewEmpList.Columns[6].HeaderText = "Mail";
            datagridviewEmpList.Columns[7].HeaderText = "Vị trí";
            datagridviewEmpList.Columns[8].HeaderText = "Ảnh";

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn = (DataGridViewImageColumn)datagridviewEmpList.Columns[8];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            editBtn.HeaderText = "Edit";
            editBtn.Name = "EditBtn";
            editBtn.Image = Properties.Resources.pencil1;
            editBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editBtn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editBtn.Width = 20;
            datagridviewEmpList.Columns.Add(editBtn);

            DataGridViewImageColumn delBtn = new DataGridViewImageColumn();
            delBtn.HeaderText = "Delete";
            delBtn.Name = "DeleteBtn";
            delBtn.Image = Properties.Resources.trash_can;
            delBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delBtn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            delBtn.Width = 20;
            datagridviewEmpList.Columns.Add(delBtn);
        }

        private void manageEmpForm_Load(object sender, EventArgs e)
        {
            loadComboPos();
            loadAll();
        }

        private void datagridviewEmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datagridviewEmpList.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string id = datagridviewEmpList.Rows[index].Cells[0].Value.ToString();
                string fname = datagridviewEmpList.Rows[index].Cells[1].Value + string.Empty;
                string gender = datagridviewEmpList.Rows[index].Cells[2].Value + string.Empty;
                DateTime dob = (DateTime)datagridviewEmpList.Rows[index].Cells[3].Value;
                string home = datagridviewEmpList.Rows[index].Cells[4].Value + string.Empty;
                string phone = datagridviewEmpList.Rows[index].Cells[5].Value + string.Empty;
                string email = datagridviewEmpList.Rows[index].Cells[6].Value + string.Empty;
                string pos = datagridviewEmpList.Rows[index].Cells[7].Value + string.Empty;
                byte[] ava = (byte[])datagridviewEmpList.Rows[index].Cells[8].Value;

                nv = new Nhanvien(id, fname, gender, dob, home, phone, email, pos, ava);
                tk = tkBLL.getAccountById(nv.Id);
                infoFormNV f = new infoFormNV(nv, tk);
                f.ShowDialog();
            }

            if (e.ColumnIndex == datagridviewEmpList.Columns["DeleteBtn"].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string id = datagridviewEmpList.Rows[index].Cells[0].Value.ToString();

                if (nvBLL.deleteNV(id) && tkBLL.deleteAccount(id))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmpForm f = new addEmpForm();
            f.ShowDialog();
        }

        public DataGridView GetDataGridView()
        {
            return datagridviewEmpList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //loadAll();
        }

        private void positionDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DataTable dt = new DataTable();
            dt = nvBLL.getNVByPos((string)positionDisplay.SelectedValue);
            datagridviewEmpList.DataSource = dt;
            datagridviewEmpList.Columns[0].HeaderText = "ID";
            datagridviewEmpList.Columns[1].HeaderText = "Họ tên";
            datagridviewEmpList.Columns[2].HeaderText = "Giới tính";
            datagridviewEmpList.Columns[3].HeaderText = "Ngày sinh";
            datagridviewEmpList.Columns[4].HeaderText = "Quê quán";
            datagridviewEmpList.Columns[5].HeaderText = "SĐT";
            datagridviewEmpList.Columns[6].HeaderText = "Mail";
            datagridviewEmpList.Columns[7].HeaderText = "Vị trí";
            datagridviewEmpList.Columns[8].HeaderText = "Ảnh";

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn = (DataGridViewImageColumn)datagridviewEmpList.Columns[8];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            editBtn.HeaderText = "Edit";
            editBtn.Name = "EditBtn";
            editBtn.Image = Properties.Resources.pencil1;
            editBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editBtn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editBtn.Width = 20;
            datagridviewEmpList.Columns.Add(editBtn);

            DataGridViewImageColumn delBtn = new DataGridViewImageColumn();
            delBtn.HeaderText = "Delete";
            delBtn.Name = "DeleteBtn";
            delBtn.Image = Properties.Resources.trash_can;
            delBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delBtn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            delBtn.Width = 20;
            datagridviewEmpList.Columns.Add(delBtn);
            */
        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
