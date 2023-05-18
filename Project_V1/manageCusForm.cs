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
        private void loadBy(DataTable dt)
        {
            panelDisplay.Controls.Clear();

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

        private void loadAll()
        {
            //get all nv
            DataTable dt = new DataTable();
            dt = khBLL.getAllKH();
            loadBy(dt);
        }

        private void manageCusForm_Load(object sender, EventArgs e)
        {
            loadComboBox();
            searchAction();
            loadAll();
        }

        //search event 
        //Get data for search box by phone
        private List<String> getSearchSource()
        {
            DataTable dt = khBLL.getAllPhone();
            List<String> searchSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchSource.Add(dt.Rows[i]["SDT"].ToString());
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            //clear
            panelDisplay.Controls.Clear();

            DataTable dt = new DataTable();
            dt = khBLL.getKHByPhone(search.Text);
            loadBy(dt);
        }

        //self define combobox 
        private void loadComboBox()
        {
            comboboxSort.Items.Insert(0, "Tất cả");
            comboboxSort.Items.Insert(1, "Mua nhiều nhất");
            comboboxSort.Items.Insert(2, "Lâu năm");
            comboboxSort.Items.Insert(3, "Mới");

            comboboxSort.SelectedIndex = 0;
        }

        private void comboboxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear
            panelDisplay.Controls.Clear();
            search.Text = "";

            //get by 
            int index = comboboxSort.SelectedIndex;
            if (index == 0)
            {
                loadAll();
            }
            else
            {
                /*
                DataTable dt = new DataTable();
                dt = nvBLL.getNVByPos(pos);
                loadBy(dt);
                */
            }
        }
    }
}
