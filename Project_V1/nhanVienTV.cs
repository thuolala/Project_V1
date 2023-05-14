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
using DTO;
using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class nhanVienTV : Form
    {
        TuvankhBLL getAnswerBLL = new TuvankhBLL();
        public List<string[]> list = new List<string[]>();

        //THÊM IDNV                                                                                                               //THÊM IDNV VÀO ĐÂY******
        string idNV = "NV000";
        public nhanVienTV()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //Chuyển nội dung trong datagridview khi bấm vào các tag tương ứng
        private void loadData()
        {
            allQuestionTable.ReadOnly = true;
            if (tieudebang.Text == allQuestion2.Text)
            {
                //Hiển thị tất cả câu hỏi
                allQuestionTable.DataSource = getAnswerBLL.showAllQuestion();
            }
            else if (tieudebang.Text == answeredQuestion2.Text)
            {
                //Hiển thị những câu hỏi đã trả lời
                allQuestionTable.DataSource = getAnswerBLL.showAnweredQuestion(1);
            }
            else if (tieudebang.Text == questionWithoutAns2.Text)
            {
                //Hiển thị những câu hỏi chưa trả lời
                allQuestionTable.DataSource = getAnswerBLL.showAnweredQuestion(0);
            }
        }

        //Load những câu trả lời của nhân viên đang đăng nhập
        private void loadEmpData()
        {
            containEmpAnswer.ReadOnly= true;
            //Nhập ID nhân viên vào đây để lấy dữ liệu
            containEmpAnswer.DataSource = getAnswerBLL.showEmpAnswer(idNV);                                                  //Thêm ID nhân viên đang đăng nhập vào đây**

            //Tồn tại nút xóa r thì k thêm vào nữa
            if (!IsDeleteButtonColumnExists())
            {
                //Add các nút xóa cho các dòng dữ liệu
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.HeaderText = "Xóa câu trả lời";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                containEmpAnswer.Columns.Add(deleteButtonColumn);

                //Set độ rộng cột cho datagridview
                DataGridViewColumn colQuestion = containEmpAnswer.Columns[0]; 
                DataGridViewColumn colAns = containEmpAnswer.Columns[1]; 
                DataGridViewColumn colAnsDate = containEmpAnswer.Columns[2];
                DataGridViewColumn colDelete = containEmpAnswer.Columns[3];

                colDelete.Width = 90;
                colAns.Width = 330;
                colQuestion.Width = 330;
                colAnsDate.Width = 150;
            }
        }

        //Kiểm tra xem có tồn tại nút Delete chưa
        private bool IsDeleteButtonColumnExists()
        {
            foreach (DataGridViewColumn column in containEmpAnswer.Columns)
            {
                if (column.Name == "DeleteButtonColumn")
                {
                    return true;
                }
            }

            return false;
        }

        //Load 2 bảng datagridview _ Form load                                                             
        private void nhanVienTV_Load(object sender, EventArgs e)                                                    //Trở về gọi lại form load**
        {
            tieudebang.Text = questionWithoutAns2.Text;
            changeColorBtn(questionWithoutAns2);
            loadData();
            loadEmpData();
        }

        //Bấm vào nút sẽ đổi màu
        private void changeColorBtn(Guna.UI2.WinForms.Guna2GradientButton selectedBtn)                          //Chỉnh màu nút bấm
        {
            allQuestion2.FillColor = Color.Transparent;
            allQuestion2.FillColor2 = Color.Transparent;
            allQuestion2.ForeColor = Color.Black;

            questionWithoutAns2.FillColor = Color.Transparent;
            questionWithoutAns2.FillColor2 = Color.Transparent;
            questionWithoutAns2.ForeColor = Color.Black;


            answeredQuestion2.FillColor = Color.Transparent;
            answeredQuestion2.FillColor2 = Color.Transparent;
            answeredQuestion2.ForeColor = Color.Black;


            selectedBtn.FillColor = Color.SkyBlue;
            selectedBtn.FillColor2 = Color.SkyBlue;
            selectedBtn.ForeColor = Color.White;

        }
        private void allQuestion2_Click(object sender, EventArgs e)
        {
            tieudebang.Text = allQuestion2.Text;
            changeColorBtn(allQuestion2);
            loadData();
        }
        private void questionWithoutAns2_Click(object sender, EventArgs e)
        {
            tieudebang.Text = questionWithoutAns2.Text;
            changeColorBtn(questionWithoutAns2);
            loadData();
        }
        private void answeredQuestion2_Click(object sender, EventArgs e)
        {
            tieudebang.Text = answeredQuestion2.Text;
            changeColorBtn(answeredQuestion2);
            loadData();
        }

        private void loadAnswer(string questioncontent, string questionDate)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn trả lời câu hỏi này không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Gán đáp án tìm được vào danh sách -> Mở form mới thể hiện câu hỏi và câu trả lời
                list = getAnswerBLL.getAnswer(questioncontent, questionDate);
                ansDetailQuestion showAns = new ansDetailQuestion(list);
                //Hiển thị câu hỏi
                showAns.questionLbl.Text = questioncontent;
                showAns.dateQuestion.Text = questionDate;
                string username = getAnswerBLL.getNameCus(questioncontent, questionDate);
                if (username != "-1")
                {
                    showAns.userNameQuestion.Text = username;
                }
                else
                {
                    showAns.userNameQuestion.Text = "Unknown";
                }

                showAns.keyId = getAnswerBLL.getIdQuestion(questioncontent, questionDate);
                showAns.ShowDialog();
            }
        }

        //Chọn thể xem chi tiết câu trả lời trong bảng tra tất cả câu hỏi
        private void allQuestionTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && allQuestionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && allQuestionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                //Lấy thông tin câu hỏi -> tìm câu trả lời
                string questioncontent = allQuestionTable.Rows[e.RowIndex].Cells["Câu Hỏi"].Value.ToString();
                string questionDate = Convert.ToDateTime(allQuestionTable.Rows[e.RowIndex].Cells["Ngày Khởi Tạo"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");
                loadAnswer(questioncontent, questionDate);
            }
        }

        //Xóa và mở những câu trả lời nhân viên đã thực hiện
        private void containEmpAnswer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && containEmpAnswer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && containEmpAnswer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                //Lấy thông tin ô vừa bấm
                string cell = containEmpAnswer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //Lấy thông tin câu trả lời được thực hiện để tìm câu hỏi
                string AnswerContent = containEmpAnswer.Rows[e.RowIndex].Cells["Câu Trả Lời"].Value.ToString();
                string AnsweredTime = Convert.ToDateTime(containEmpAnswer.Rows[e.RowIndex].Cells["Ngày Khởi Tạo"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");
                
                //Tìm được nội dung câu hỏi
                string[] arr = getAnswerBLL.getQuestionCntAnDate(AnswerContent, AnsweredTime);
                string questioncontent = arr[0];
                string questionDate = arr[1];

                //Nếu bấm nút delete
                if (cell == "Delete")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc mình muốn xóa câu hỏi này", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int re = getAnswerBLL.deleteAnswer(AnswerContent, AnsweredTime);
                        if (re > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thao tác không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        nhanVienTV_Load(sender, e);
                    }
                }
                else
                {
                    loadAnswer(questioncontent, questionDate);
                }
            }
        }

        //Thực hiện bằng bàn phím thay cho nút click
        private void containEmpAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = 0;
                // Kiểm tra xem có hàng được chọn hay không
                if (containEmpAnswer.SelectedCells.Count > 0)
                {
                    //Kiểm tra từng ô
                    foreach (DataGridViewCell cell in containEmpAnswer.SelectedCells)
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
                        int currentRowIndex = containEmpAnswer.SelectedCells[0].RowIndex;
                        int currentColumnIndex = containEmpAnswer.SelectedCells[0].ColumnIndex;
                        // Lấy thông tin ô vừa nhấn Enter
                        string cellValue = containEmpAnswer.Rows[currentRowIndex].Cells[currentColumnIndex].Value.ToString();
                        if (cellValue != null && cellValue != "")
                        {
                            // Lấy thông tin câu trả lời được thực hiện để tìm câu hỏi
                            string answerContent = containEmpAnswer.Rows[currentRowIndex].Cells["Câu Trả Lời"].Value.ToString();
                            string answeredTime = Convert.ToDateTime(containEmpAnswer.Rows[currentRowIndex].Cells["Ngày Khởi Tạo"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");

                            // Tìm nội dung câu hỏi
                            string[] questionInfo = getAnswerBLL.getQuestionCntAnDate(answerContent, answeredTime);
                            string questionContent = questionInfo[0];
                            string questionDate = questionInfo[1];

                            // Kiểm tra nếu cellValue là "Delete"
                            if (cellValue == "Delete")
                            {
                                DialogResult result = MessageBox.Show("Bạn có chắc mình muốn xóa câu hỏi này", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    int re = getAnswerBLL.deleteAnswer(answerContent, answeredTime);
                                    if (re > 0)
                                    {
                                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thao tác không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    nhanVienTV_Load(sender, e);
                                }
                            }
                            else
                            {
                                loadAnswer(questionContent, questionDate);
                            }
                        }
                    }
                }
                e.Handled = true; 
            }
        }

        //Thực hiện bằng bàn phím thay cho nút click
        private void allQuestionTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = 0;
                // Kiểm tra xem có hàng được chọn hay không
                if (allQuestionTable.SelectedCells.Count > 0)
                {
                    //Kiểm tra từng ô
                    foreach (DataGridViewCell cell in containEmpAnswer.SelectedCells)
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
                            MessageBox.Show("Ô hiện tại không rỗng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if(i!=0)
                    {
                        int currentRowIndex = allQuestionTable.SelectedCells[0].RowIndex;
                        int currentColumnIndex = allQuestionTable.SelectedCells[0].ColumnIndex;
                        string cellValue = containEmpAnswer.Rows[currentRowIndex].Cells[currentColumnIndex].Value.ToString();
                        if (cellValue != null && cellValue != "")
                        {
                            // Lấy thông tin câu hỏi
                            string questioncontent = allQuestionTable.Rows[currentRowIndex].Cells["Câu Hỏi"].Value.ToString();
                            string questionDate = Convert.ToDateTime(allQuestionTable.Rows[currentRowIndex].Cells["Ngày Khởi Tạo"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");
                            loadAnswer(questioncontent, questionDate);
                        }
                    }
                }
                e.Handled = true; 
            }
        }
    }
}
