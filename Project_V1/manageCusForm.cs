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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addCusForm f = new addCusForm();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            loadAll();
        }

        //load all 
        private void loadAll()
        {
            //get all nv
            DataTable dt = new DataTable();
            dt = khBLL.getAllKH();

            //define nv
            string _id;
            string _name;
            string _address;
            string _phone;
            string _email;
            DateTime _created;

            //create list of user control of kh
            cusItem[] listItem = new cusItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _id = dt.Rows[i]["IDKH"].ToString();
                _name = dt.Rows[i]["HOTEN"].ToString();
                _address = dt.Rows[i]["DIACHI"].ToString();
                _phone = dt.Rows[i]["SDT"].ToString();
                _email = dt.Rows[i]["EMAIL"].ToString();
                _created = (DateTime)dt.Rows[i]["CREATED"];

                Khachhang khang = new Khachhang(_id, _name, _address, _phone, _email, _created);
                listItem[i] = new cusItem(khang);
                panelDisplay.Controls.Add(listItem[i]);
            }
        }

        private void manageCusForm_Load(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
