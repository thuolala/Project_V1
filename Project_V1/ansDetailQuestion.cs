using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ansDetailQuestion : Form
    {
        TuvankhBLL getAnswerBLL = new TuvankhBLL();
        private List<string[]> listAnsD;
        public string keyId;
        public ansDetailQuestion(List<string[]> listAnsD)
        {
            InitializeComponent();
            this.listAnsD = listAnsD;
        }
        //Set câu trả lời vào form
        private void loadData()
        {
            if (listAnsD.Count > 0)
            {
                foreach (string[] item in listAnsD)                                                                     //Chỉnh màu chữ
                {
                    //Tạo một tableLayout chứa câu trả lời
                    TableLayoutPanel containAnswer = new TableLayoutPanel();
                    containAnswer.ColumnCount = 2;
                    containAnswer.RowCount = 3;
                    containAnswer.Width = answerDetailContainer.Width-10;
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
                        //Tạo nội dung và gán vào từng ô trong table
                        System.Windows.Forms.Label ans = new System.Windows.Forms.Label();
                        ans.Text = value;
                        ans.AutoSize = true;

                        if (i == 0)
                        {
                            Guna2TextBox gunaTextBox = new Guna2TextBox();
                            gunaTextBox.Text = ans.Text;
                            gunaTextBox.ReadOnly = true; 

                            gunaTextBox.FillColor = System.Drawing.Color.White; 
                            gunaTextBox.ForeColor = Color.Navy;
                            gunaTextBox.Font = new Font("Segoe UI", 12);
                            gunaTextBox.Multiline = true;
                            gunaTextBox.TextAlign = HorizontalAlignment.Left;

                            gunaTextBox.BorderRadius = 10; 
                            gunaTextBox.MaxLength= 50;
                            int maxWidth = containAnswer.Width - 150;
                            gunaTextBox.Height = 120;
                            gunaTextBox.ScrollBars = ScrollBars.Vertical;
                            gunaTextBox.Dock = DockStyle.Bottom;
                            gunaTextBox.MaximumSize = new System.Drawing.Size(maxWidth,gunaTextBox.Height);
                            containAnswer.Controls.Add(gunaTextBox, 1, 1);
                        }
                        //Lấy tên người hỏi
                        else if (i == 1)
                        {
                            string nameEmp = getAnswerBLL.getNameEmp(ans.Text);
                            ans.Text = nameEmp;
                            ans.Font = new Font("Segoe UI", 14);
                            ans.ForeColor = Color.FromArgb(125, 137, 149);      //Màu chữ
                            ans.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                            ans.Dock = DockStyle.Bottom;
                            containAnswer.Controls.Add(ans, 1, 0);
                        }
                        else
                        {
                            ans.AutoSize = false;
                            ans.Font = new Font("Segoe UI", 10);
                            ans.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                            ans.Dock = DockStyle.Top;
                            containAnswer.Controls.Add(ans, 1, 2);
                        }
                        i++;
                    }
                    //Thêm ảnh vào ô
                    PictureBox pictureBox = new PictureBox();
                    Panel panel = new Panel();
                    pictureBox.Image = Image.FromFile("../../../Resources/icons8-user-480.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel.Controls.Add(pictureBox);
                    pictureBox.Dock = DockStyle.Bottom;
                    panel.Dock=DockStyle.Fill;
                    containAnswer.Controls.Add(panel, 0, 1);
                    answerDetailContainer.Controls.Add(containAnswer);
                }
            }
            else
            {
                answerLbl.Text = "Chưa có câu trả lời";
                giaidapLbl.ForeColor= Color.White;
                answerLbl.ForeColor = Color.Black;
            }
        }

        private void ansDetailQuestion_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //Nút gửi
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (messBox.Text != "" && !string.IsNullOrEmpty(messBox.Text.Trim()))
            {
                string answer  = messBox.Text;
                listAnsD.Clear();
                answerLbl.ForeColor = Color.White;                                                                 //Chỉnh màu chữ
                giaidapLbl.ForeColor= Color.Black;
                messBox.Text = "";
                listAnsD = getAnswerBLL.addDetailsAnswer(keyId, answer, "NV000");
                ansDetailQuestion_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập câu trả lời của bạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messBox.Focus();
            }
        }
        
        //Gửi bằng nút enter, shift enter thêm dòng mới
        private void messBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                messBox.AppendText(Environment.NewLine);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, e);
                e.Handled = true; 
            }
        }

        private void answerDetailContainer_SizeChanged(object sender, EventArgs e)
        {
            //answerDetailContainer.Controls.Clear();
            //loadData();
        }

    }
}
