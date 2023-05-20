using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Excel = Microsoft;

namespace GUI
{
    public partial class manageMedicine : Form
    {
        public manageMedicine()
        {
            InitializeComponent();
        }

        Nhomthuoc nt = new Nhomthuoc();
        NhomthuocBLL ntBLL = new NhomthuocBLL();
        Thuoc th = new Thuoc();
        ThuocBLL thBLL = new ThuocBLL();

        //load all 
        private void loadBy(DataTable dt)
        {
            panelDisplay.Controls.Clear();

            //define thuoc
            string _id;
            string _name;
            DateTime _nsx;
            DateTime _hsd;
            string id_ncc;
            string id_nt;
            string _nhasx;
            string _chungnhan;
            int _hamluong;
            string _thanhphan;
            string _chidinh;
            string _chongcd;
            byte[] img;

            //create list of user control of thuoc
            medicineItem[] listItem = new medicineItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _id = dt.Rows[i]["ID"].ToString();
                _name = dt.Rows[i]["TEN"].ToString();
                _nsx = (DateTime)dt.Rows[i]["NSX"];
                _hsd = (DateTime)dt.Rows[i]["HSD"];
                id_ncc = dt.Rows[i]["ID_NCC"].ToString();
                id_nt = dt.Rows[i]["ID_NHOMTHUOC"].ToString();
                _nhasx = dt.Rows[i]["NHA_SX"].ToString();
                _chungnhan = dt.Rows[i]["CHUNGNHAN"].ToString();
                _hamluong = (int)dt.Rows[i]["HAMLUONG"];
                _thanhphan = dt.Rows[i]["THANHPHAN"].ToString();
                _chidinh = dt.Rows[i]["CHIDINH"].ToString();
                _chongcd = dt.Rows[i]["CHONGCD"].ToString();
                img = (byte[])dt.Rows[i]["IMG1"]; ;

                Thuoc thuoc = new Thuoc(_id, _name, _nsx, _hsd, id_ncc, id_nt, _nhasx, _chungnhan, _hamluong, _thanhphan, _chidinh, _chongcd, img);
                listItem[i] = new medicineItem(thuoc);
                panelDisplay.Controls.Add(listItem[i]);
            }
        }

        private void loadAll()
        {
            //get all nv
            DataTable dt = new DataTable();
            dt = thBLL.getAllThuoc();
            loadBy(dt);
        }

        //search event 
        //Get data for search box by Name 
        private List<String> getSearchSource()
        {
            DataTable dt = thBLL.getAllName();
            List<String> searchSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchSource.Add(dt.Rows[i]["TEN"].ToString());
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

        private void manageMedForm_Load(object sender, EventArgs e)
        {
            loadComboBoxType();
            searchAction();
            loadAll();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            addMedicine f = new addMedicine();
            f.ShowDialog();
            //
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            addTypeMedicine f = new addTypeMedicine();
            f.ShowDialog();
        }

        private void loadComboBoxType()
        {
            string fitem = "Tất cả";
            string fvalue = "ALL";

            DataTable dt = ntBLL.getAllNhomthuoc();
            Dictionary<string, string> listType = new Dictionary<string, string>();
            listType.Add(fitem, fvalue);

            foreach (DataRow row in dt.Rows)
            {
                listType.Add(row["TEN"].ToString(), row["ID"].ToString());
            }

            List<KeyValuePair<string, string>> list = listType.ToList();

            comboboxType.DataSource = list;
            comboboxType.DisplayMember = "Key";
            comboboxType.ValueMember = "Value";

            comboboxType.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadComboBoxType();
            panelDisplay.Controls.Clear();
            loadAll();

            comboboxType.SelectedIndex = 0;
            search.Text = "";
        }

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            addNCC f = new addNCC();
            f.ShowDialog();
        }

        private void comboboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear
            panelDisplay.Controls.Clear();
            search.Text = "";

            //get by type
            string type = comboboxType.SelectedValue.ToString();
            if (type.Equals("ALL"))
            {
                loadAll();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = thBLL.getThuocByType(type);
                loadBy(dt);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            //clear
            panelDisplay.Controls.Clear();

            DataTable dt = new DataTable();
            dt = thBLL.getThuocByName(search.Text);
            loadBy(dt);
        }
    }
}
