using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Reflection.Emit;

namespace GUI
{
    public partial class tuVan_KH : Form
    {
        TuvankhBLL getDataTable = new TuvankhBLL();
        //List chứa các thông tin trả lời cho câu hỏi được chọn
        public List<string[]> list = new List<string[]>();

        //List chứa các thông tin mới
        private List<string[]> listNews = new List<string[]>();

        //ID KHÁCH HÀNG                                                                                                         // THÊM ID KHÁCH HÀNG VÀO ĐÂY***
        string idKH = "KH0001";
        public tuVan_KH()
        {
            InitializeComponent();
        }

        private bool IsDeleteButtonColumnExists()
        {
            foreach (DataGridViewColumn column in showUserQuestion.Columns)
            {
                if (column.Name == "DeleteButtonColumn")
                {
                    return true;
                }
            }

            return false;
        }

        private void loadData()
        {
            //Thêm thông tin của những câu hỏi mới nhất
            listNews.Clear();
            listNews = getDataTable.getHotNews();
            news1.Text = listNews[0][1];
            news2.Text = listNews[1][1];
            news3.Text = listNews[2][1];

            //Load dữ liệu câu hỏi của khách hàng đang đăng nhập, mỗi dòng có một nút xóa
            showUserQuestion.ReadOnly = true;
            showUserQuestion.DataSource = getDataTable.showCustomerQuestion(idKH);                                                 //id khách hàng thêm vào đây**

            if (!IsDeleteButtonColumnExists())
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;

                showUserQuestion.Columns.Add(deleteButtonColumn);

                //Set độ rộng cột cho datagridview
                DataGridViewColumn colQuestion = showUserQuestion.Columns[0];
                DataGridViewColumn colAns = showUserQuestion.Columns[1];
                DataGridViewColumn colAnsDate = showUserQuestion.Columns[2];
                DataGridViewColumn colDelete = showUserQuestion.Columns[3];

                colDelete.Width = 90;
                colAns.Width = 330;
                colQuestion.Width = 330;
                colAnsDate.Width = 150;
            }
        }
        //Form Load
        private void tuVan_KH_Load(object sender, EventArgs e)
        {
            loadData();                                                                                                                 // Trở về gọi lại form load**
        }

        //Nhập câu hỏi mới
        //Bấm enter sẽ gửi, shift + Enter = tạo dòng mới
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
        private void sendButton_Click(object sender, EventArgs e)   
        {
            if(messBox.Text.Length > 0 && !string.IsNullOrEmpty(messBox.Text.Trim()))
            {
                string question = messBox.Text;
                messBox.Text = "";
                getDataTable.addQuestion(question,idKH);                                                                                //Thêm id KH vào đây ***
                tuVan_KH_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập câu trả lời của bạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messBox.Focus();
            }  
        }

        //Bấm vào các ô, sẽ xem câu trả lời
        private void showUserQuestion_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && showUserQuestion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && showUserQuestion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                string cell = showUserQuestion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string questioncontent = showUserQuestion.Rows[e.RowIndex].Cells["Câu Hỏi"].Value.ToString();
                string questionDate = Convert.ToDateTime(showUserQuestion.Rows[e.RowIndex].Cells["Ngày Khởi Tạo"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");
                //Nếu xóa câu hỏi
                if (cell == "Delete")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc mình muốn xóa câu hỏi này", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //Hàm xóa câu hỏi
                        int re = getDataTable.deleteQuestion(questioncontent, questionDate);
                        if (re > 0) {
                            MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { 
                            MessageBox.Show("Thao tác không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        tuVan_KH_Load(sender, e);
                    }
                }
                //Xem câu hỏi
                else
                {
                    loadNews(questioncontent,questionDate);
                }
            }
        }

        //Xem câu hỏi chi tiết, chuyển form
        private void loadNews(string questioncontent, string questionDate)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xem câu trả lời của câu hỏi này không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Chứa câu trả lời cho câu hỏi vừa chọn
                list = getDataTable.getAnswer(questioncontent, questionDate);

                //Chuyển form và biểu diễn
                detailsAnswer showAns = new detailsAnswer(list);
                    //Câu hỏi
                showAns.questionLbl.Text = questioncontent;
                showAns.dateQuestion.Text = questionDate;
                string username = getDataTable.getNameCus(questioncontent, questionDate);
                if (username != "-1")
                {
                    showAns.userNameQuestion.Text = username;
                }
                else
                {
                    showAns.userNameQuestion.Text = "Unknown";
                }
                showAns.questionLbl.Text = questioncontent;
                //Lấy ID của câu hỏi
                showAns.keyId = getDataTable.getIdQuestion(questioncontent, questionDate);
                showAns.ShowDialog();
            }
        }

        //Xem chi tiết các Hot News khi bấm nút
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadNews(listNews[0][1], listNews[0][2]);
        }
        private void newsbtn2_Click(object sender, EventArgs e)
        {
            loadNews(listNews[1][1], listNews[1][2]);

        }
        private void newsbtn3_Click(object sender, EventArgs e)
        {
            loadNews(listNews[2][1], listNews[2][2]);
        }

        //Thực hiện truy vấn bằng bàn phím thay vì nút click
        private void showUserQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = 0;
                // Kiểm tra xem có hàng được chọn hay không
                if (showUserQuestion.SelectedCells.Count > 0)
                {
                    //Kiểm tra từng ô
                    foreach (DataGridViewCell cell in showUserQuestion.SelectedCells)
                    {
                        object cellValue = cell.Value;
                        // Kiểm tra nếu giá trị ô là rỗng
                        if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                        {
                            break;
                        }
                        else
                        {
                            i++;
                            break;
                        }
                    }

                    if (i != 0)
                    {
                        int currentRowIndex = showUserQuestion.SelectedCells[0].RowIndex;
                        int currentColumnIndex = showUserQuestion.SelectedCells[0].ColumnIndex;
                        // Lấy thông tin ô vừa nhấn Enter
                        string cellValue = showUserQuestion.Rows[currentRowIndex].Cells[currentColumnIndex].Value.ToString();
                        if (cellValue != null && cellValue != "")
                        {
                            // Lấy thông tin câu trả lời được thực hiện để tìm câu hỏi
                            string questioncontent = showUserQuestion.Rows[currentRowIndex].Cells["Câu Hỏi"].Value.ToString();
                            string questionDate = Convert.ToDateTime(showUserQuestion.Rows[currentRowIndex].Cells["Ngày Khởi Tạo"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");

                            // Kiểm tra nếu cellValue là "Delete"
                            if (cellValue == "Delete")
                            {
                                DialogResult result = MessageBox.Show("Bạn có chắc mình muốn xóa câu hỏi này", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //Hàm xóa câu hỏi
                                    int re = getDataTable.deleteQuestion(questioncontent, questionDate);
                                    if (re > 0)
                                    {
                                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thao tác không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    tuVan_KH_Load(sender, e);
                                }
                            }
                            else
                            {
                                loadNews(questioncontent, questionDate);
                            }
                        }
                    }
                }
                e.Handled = true;
            }
        }
    }
}
