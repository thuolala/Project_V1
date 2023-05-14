using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Guna.UI2.WinForms;

namespace BLL
{
    public class TuvankhBLL
    {
        TuvankhDAL dataTuvankh = new TuvankhDAL();

        //----------------------------- Question ------------------------------------//

        //Lấy id câu hỏi
        public string getIdQuestion(string questioncontent, string questionDate)
        {
            return dataTuvankh.getIDQuestionDAL(questioncontent, questionDate);
        }

        //Câu hỏi của khách hàng đăng nhập
        public DataTable showCustomerQuestion(string idKH)
        {
            List<TuvankhDTO> qList = new List<TuvankhDTO>();
            qList = dataTuvankh.getCustomerQuestion(idKH);
            DataTable dt = new DataTable();
            dt.Columns.Add("QuestionContent", typeof(string));
            dt.Columns.Add("CreatedTime", typeof(DateTime));
            dt.Columns.Add("BeAnswered", typeof(string));

            foreach (var item in qList)
            {
                DataRow dr = dt.NewRow();
                dr["QuestionContent"] = item.QuestionContent;
                dr["CreatedTime"] = item.CreatedTime;
                dr["BeAnswered"] = (item.BeAnswered == 1) ? "Đã trả lời" : "Chưa trả lời";
                dt.Rows.Add(dr);
            }
            dt.Columns["CreatedTime"].ColumnName = "Ngày Khởi Tạo";
            dt.Columns["QuestionContent"].ColumnName = "Câu Hỏi";
            dt.Columns["BeAnswered"].ColumnName = "Tình Trạng";
            return dt;
        }

        //Tất cả các câu hỏi
        public DataTable showAllQuestion()
        {
            List<TuvankhDTO> qList = new List<TuvankhDTO>();
            qList = dataTuvankh.getAllQuestion();
            DataTable dt = new DataTable();
            dt.Columns.Add("QuestionContent", typeof(string));
            dt.Columns.Add("CreatedTime", typeof(DateTime));
            dt.Columns.Add("BeAnswered", typeof(string));

            foreach (var item in qList)
            {
                DataRow dr = dt.NewRow();
                dr["QuestionContent"] = item.QuestionContent;
                dr["CreatedTime"] = item.CreatedTime;
                dr["BeAnswered"] = (item.BeAnswered == 1) ? "Đã trả lời" : "Chưa trả lời";
                dt.Rows.Add(dr);
            }
            dt.Columns["CreatedTime"].ColumnName = "Ngày Khởi Tạo";
            dt.Columns["QuestionContent"].ColumnName = "Câu Hỏi";
            dt.Columns["BeAnswered"].ColumnName = "Tình Trạng";
            return dt;
        }
        
        //Lấy những câu hỏi dựa theo tình trạng trả lời
        public DataTable showAnweredQuestion(int state)
        {
            List<TuvankhDTO> qList = new List<TuvankhDTO>();
            qList = dataTuvankh.getAnsweredQuestion(state);
            DataTable dt = new DataTable();
            dt.Columns.Add("QuestionContent", typeof(string));
            dt.Columns.Add("CreatedTime", typeof(DateTime));
            dt.Columns.Add("BeAnswered", typeof(string));

            foreach (var item in qList)
            {
                DataRow dr = dt.NewRow();
                dr["QuestionContent"] = item.QuestionContent;
                dr["CreatedTime"] = item.CreatedTime;
                dr["BeAnswered"] = (item.BeAnswered == 1) ? "Đã trả lời" : "Chưa trả lời";

                dt.Rows.Add(dr);
            }
            dt.Columns["CreatedTime"].ColumnName = "Ngày Khởi Tạo";
            dt.Columns["QuestionContent"].ColumnName = "Câu Hỏi";
            dt.Columns["BeAnswered"].ColumnName = "Tình Trạng";

            return dt;
        }
        //Lấy những câu hỏi mới nhất
        public List<string[]> getHotNews()
        {
            return dataTuvankh.getHotNewsDAL();
        }

        //Xóa những câu hỏi của khách hàng
        public int deleteQuestion(string questioncontent, string questionDate)
        {
            return dataTuvankh.deleteQuestionDAL(questioncontent, questionDate);
        }

        //Thêm câu hỏi của khách hàng đang đăng nhập
        public void addQuestion(string question, string idKH)
        {
            dataTuvankh.addQuestionDAL(question, idKH);
        }

        //Lấy câu hỏi và ngày tạo câu hỏi dựa vào câu trả lời
        public string[] getQuestionCntAnDate(string AnswerContent, string AnsweredTime)
        {
            return dataTuvankh.getQCntAnDateDAL(AnswerContent, AnsweredTime);
        }

        //--------------------------------------- Answer --------------------------------------//

        //Lấy câu trả lời của nhân viên
        public DataTable showEmpAnswer(string idNV)
        {
            List<TraloikhDTO> qList = new List<TraloikhDTO>();
            qList = dataTuvankh.getEmpAnswer(idNV);
            DataTable dt = new DataTable();
            dt.Columns.Add("QuestionContent", typeof(string));
            dt.Columns.Add("AnswerContent", typeof(string));
            //dt.Columns.Add("TenNV", typeof(string));
            dt.Columns.Add("AnsweredTime ", typeof(DateTime));
            
            //Tạo datatable chứa hàng và cột
            foreach (var item in qList)
            {
                DataRow dr = dt.NewRow();
                dr["AnswerContent"] = item.AnswerContent;
                dr["QuestionContent"] = item.QuestionContent;
                dr["AnsweredTime "] = item.AnsweredTime;
                dt.Rows.Add(dr);
            }
            dt.Columns["QuestionContent"].ColumnName = "Câu Hỏi";
            dt.Columns["AnswerContent"].ColumnName = "Câu Trả Lời";
            dt.Columns["AnsweredTime "].ColumnName = "Ngày Khởi Tạo";
            return dt;
        }

        //Lấy câu trả lời dựa theo câu hỏi được chọn
        public List<string[]> getAnswer(string questioncontent, string questionDate)
        {
            return dataTuvankh.getAnswerDAL(questioncontent, questionDate);
        }

        //Thêm câu trả lời
        public List<string[]> addDetailsAnswer(string keyId, string answer, string IDNV)
        {
            return dataTuvankh.addDetialsAnswerDAL(keyId, answer, IDNV);
        }

        //Xóa câu trả lời của nhân viên đăng nhập - chỉ xóa được của mình
        public int deleteAnswer(string AnswerContent, string AnsweredTime)
        {
            return dataTuvankh.deleteAnswerDAL(AnswerContent, AnsweredTime);
        }
        //---------------------------- Thông tin khác ----------------------------//

        //Lấy tên khách hàng vừa hỏi câu hỏi
        public string getNameCus(string questioncontent, string questionDate)
        {
            return dataTuvankh.getNameCusDAL(questioncontent, questionDate);
        }

        //Lấy tên nhân viên trả lời câu trả lời vừa r dựa theo idNV
        public string getNameEmp(string idNV)
        {
            string nameEmp = dataTuvankh.getNameEmp(idNV);
            if (nameEmp !="-1")
            {
                return nameEmp;
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
