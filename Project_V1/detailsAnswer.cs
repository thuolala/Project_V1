using BLL;
using Guna.UI2.WinForms;
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
    public partial class detailsAnswer : Form
    {
        TuvankhBLL getDataTable = new TuvankhBLL();
        private List<string[]> listAns;
        public string keyId;

        public detailsAnswer(List<string[]> listAns)
        {
            InitializeComponent();
            this.listAns = listAns;
        }

        //Load câu trả lời
        private void loadData()
        {
            if (listAns.Count > 0)
            {
                foreach (string[] item in listAns)                                              //Chỉnh màu chữ trong phần box chat trả lời
                {
                    TableLayoutPanel containAnswer = new TableLayoutPanel();
                    containAnswer.ColumnCount = 2;
                    containAnswer.RowCount = 3;
                    containAnswer.Width = answerContainer.Width - 10;
                    containAnswer.Height = 180;
                    containAnswer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.66F));
                    containAnswer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.34F));
                    containAnswer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
                    containAnswer.RowStyles.Add(new RowStyle(SizeType.Percent, 60.00F));
                    containAnswer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
                    containAnswer.BackColor = Color.White;
                    containAnswer.Dock = DockStyle.Top;

                    int i = 0;
                    foreach (string value in item)
                    {
                        System.Windows.Forms.Label ans = new System.Windows.Forms.Label();
                        ans.Text = value;
                        ans.AutoSize = true;
                        //Lấy nội dung câu trả lời
                        if (i == 0)
                        {
                            Guna2TextBox gunaTextBox = new Guna2TextBox();
                            gunaTextBox.ReadOnly = true; 
                            gunaTextBox.FillColor = System.Drawing.Color.White; 
                            gunaTextBox.BorderRadius = 10; 
                            gunaTextBox.Text = ans.Text;
                            gunaTextBox.Dock = DockStyle.Bottom;
                            gunaTextBox.Multiline = true;
                            gunaTextBox.MaxLength = 50;
                            gunaTextBox.ForeColor = Color.Navy;
                            gunaTextBox.Font = new Font("Segoe UI", 12);
                            gunaTextBox.TextAlign = HorizontalAlignment.Left;
                            int maxWidth = containAnswer.Width - 150;
                            gunaTextBox.Height = 120;
                            gunaTextBox.ScrollBars = ScrollBars.Vertical;
                            gunaTextBox.MaximumSize = new System.Drawing.Size(maxWidth, gunaTextBox.Height);
                            containAnswer.Controls.Add(gunaTextBox, 1, 1);
                        }
                        //Lấy tên người hỏi
                        else if (i == 1)
                        {
                            string nameEmp = getDataTable.getNameEmp(ans.Text);
                            ans.Text = nameEmp;
                            ans.Font = new Font("Segoe UI", 14);
                            ans.ForeColor = Color.FromArgb(125, 137, 149);
                            ans.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                            ans.Dock = DockStyle.Bottom;
                            containAnswer.Controls.Add(ans, 1, 0);
                        }
                        else
                        {
                            ans.AutoSize = false;
                            ans.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            ans.Dock = DockStyle.Top;
                            ans.Font = new Font("Segoe UI", 10);
                            containAnswer.Controls.Add(ans, 1, 2);
                        }
                        i++;
                    }

                    PictureBox pictureBox = new PictureBox();
                    Panel panel = new Panel();
                    pictureBox.Image = Image.FromFile("../../../Resources/icons8-user-480.png");
                    pictureBox.Dock = DockStyle.Bottom;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel.Controls.Add(pictureBox);
                    panel.Dock = DockStyle.Fill;
                    containAnswer.Controls.Add(panel, 0, 1);
                    answerContainer.Controls.Add(containAnswer);
                }
            }
            else
            {
                answerLbl.Text = "Chưa có câu trả lời";                                                 //Chỉnh màu chữ
                giaidapLbl.ForeColor = Color.White;
                answerLbl.ForeColor = Color.Black;
            }
        }

        private void detailsAnswer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void answerContainer_SizeChanged(object sender, EventArgs e)
        {
            //answerContainer.Controls.Clear();
            //loadData();
        }
    }
}
