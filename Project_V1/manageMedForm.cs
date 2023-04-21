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

namespace GUI
{
    public partial class manageMedForm : Form
    {
        public manageMedForm()
        {
            InitializeComponent();
        }

        private void manageMedForm_Load(object sender, EventArgs e)
        {
            // Set up the SQL connection and command
            string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Pharmacity; Integrated Security=True";
            string sql = "SELECT name, price, sl FROM MED"; // Replace "MyTable" with the name of your table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);
                medItem[] listItem = new medItem[dataTable.Rows.Count];

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    string name = dataTable.Rows[i]["name"].ToString();
                    int price = (int)dataTable.Rows[i]["price"];
                    int quantity = (int)dataTable.Rows[i]["sl"];

                    listItem[i] = new medItem(name, price, quantity);
                    panelData.Controls.Add(listItem[i]);

                }
            }

            //
            sql = "SELECT name FROM TYPE";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);
                medType[] listType = new medType[dataTable.Rows.Count];

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    string name = dataTable.Rows[i]["name"].ToString();

                    listType[i] = new medType(name);
                    panelType.Controls.Add(listType[i]);
                }
            }
        }

        private void panelMed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelData_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(94, 148, 255);
            int borderWidth = 1;

            // Draw the border using the ControlPaint.DrawBorder method
            ControlPaint.DrawBorder(e.Graphics, panelData.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMedicineForm f = new addMedicineForm();
            f.ShowDialog();
        }
    }
}
