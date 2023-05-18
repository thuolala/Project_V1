using BLL;
using DTO;
using System;
using System.Collections;
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
    public partial class manageEmployee : Form
    {
        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv = new Nhanvien();
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk = new Taikhoan();
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt = new Vitri();

        public manageEmployee()
        {
            InitializeComponent();
        }

        private void loadBy(DataTable dt)
        {
            panelDisplay.Controls.Clear();

            //define nv
            string _id;
            string _name;
            string _gender;
            DateTime _birthday;
            string _hometown;
            string _phone;
            string _email;
            string _idpos;
            DateTime _created;
            byte[] _ava;

            //create list of user control of nv 
            empItem[] listItem = new empItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _id = dt.Rows[i]["IDNV"].ToString();
                _name = dt.Rows[i]["HOTEN"].ToString();
                _gender = dt.Rows[i]["GIOITINH"].ToString();
                _birthday = (DateTime)dt.Rows[i]["DOB"];
                _hometown = dt.Rows[i]["QUEQUAN"].ToString();
                _phone = dt.Rows[i]["SDT"].ToString();
                _email = dt.Rows[i]["EMAIL"].ToString();
                _idpos = dt.Rows[i]["IDVitri"].ToString();
                _created = (DateTime)dt.Rows[i]["CREATED"];
                _ava = (byte[])dt.Rows[i]["AVATAR"];

                Nhanvien nvien = new Nhanvien(_id, _name, _gender, _birthday, _hometown, _phone, _email, _idpos, _created, _ava);
                Taikhoan tkhoan = tkBLL.getAccountById(_id);
                listItem[i] = new empItem(nvien, tkhoan);
                panelDisplay.Controls.Add(listItem[i]);
            }
        }

        //load All 
        public void loadAll()
        {
            //get all nv
            DataTable dt = new DataTable();
            dt = nvBLL.getAllNV();
            loadBy(dt);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmpForm f = new addEmpForm();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            loadAll();

            comboboxPos.SelectedIndex = 0;
            search.Text = "";
        }

        //search event 
        //Get data for search box by Name 
        private List<String> getSearchSource()
        {
            DataTable dt = nvBLL.getAllName();
            List<String> searchSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchSource.Add(dt.Rows[i]["HOTEN"].ToString());
            }
            return searchSource;
        }

        //parse autosource  
        private void searchAction()
        {
            AutoCompleteStringCollection searchSource = new AutoCompleteStringCollection();
            searchSource.AddRange(getSearchSource().ToArray());

            search.AutoCompleteCustomSource = searchSource;
            search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            search.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //load combobox pos 
        private void loadComboBox()
        {
            string fitem = "Tất cả";
            string fvalue = "ALL";

            DataTable dt = vtBLL.getAllVitri();
            Dictionary<string, string> listPos = new Dictionary<string, string>();
            listPos.Add(fitem, fvalue);

            foreach (DataRow row in dt.Rows)
            {
                listPos.Add(row["TEN"].ToString(), row["ID"].ToString());
            }

            List<KeyValuePair<string, string>> list = listPos.ToList();

            comboboxPos.DataSource = list;
            comboboxPos.DisplayMember = "Key";
            comboboxPos.ValueMember = "Value";

            comboboxPos.SelectedIndex = 0;
        }

        private void manageEmployee_Load(object sender, EventArgs e)
        {
            loadComboBox();
            searchAction();
            loadAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void comboboxPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear
            panelDisplay.Controls.Clear();
            search.Text = "";

            //get by pos
            string pos = comboboxPos.SelectedValue.ToString();
            if (pos.Equals("ALL"))
            {
                loadAll();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = nvBLL.getNVByPos(pos);
                loadBy(dt);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            //clear
            panelDisplay.Controls.Clear();

            DataTable dt = new DataTable();
            dt = nvBLL.getNVByName(search.Text);
            loadBy(dt);
        }
    }
}
