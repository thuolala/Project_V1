using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TuvankhDAL : DatabaseAccess
    {
        //-------------------------------- Question -----------------------------------//
        //Lấy id câu hỏi thông qua nội dung câu hỏi và ngày khỏi tạo
        public string getIDQuestionDAL(string questioncontent, string questionDate)
        {
            conn.Open();
            string sql = "SELECT QuestionID FROM Question WHERE QuestionContent = @QuestionContent AND CreatedTime = @CreatedTime";
            //string sql = "SELECT QuestionID FROM Question WHERE QuestionContent = @QuestionContent";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@QuestionContent", questioncontent);
            cmd.Parameters.AddWithValue("@CreatedTime", questionDate);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string quesitonId = dr.GetString(0);
                    conn.Close();
                    return quesitonId;
                }
                dr.Close();
            }
            conn.Close();
            return "-1";
        }
        //Lấy tất cả câu hỏi
        public List<TuvankhDTO> getAllQuestion()
        {
            conn.Open();
            List<TuvankhDTO> listQuestion = new List<TuvankhDTO>();
            string sql = "SELECT * FROM Question";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtQuestion = new DataTable();
            dtQuestion.Load(dr);
            foreach (DataRow item in dtQuestion.Rows)
            {
                string QuestionID = item["QuestionID"].ToString();
                string QuestionContent = item["QuestionContent"].ToString();
                string IDKH = item["IDKH"].ToString();
                DateTime CreatedTime = (DateTime)item["CreatedTime"];
                int BeAnswered = int.Parse(item["BeAnswered"].ToString());
                int CategoryID = int.Parse(item["CategoryID"].ToString());

                TuvankhDTO questionG = new TuvankhDTO(QuestionID,QuestionContent,IDKH,CreatedTime,BeAnswered,CategoryID);
                listQuestion.Add(questionG);
            }
            conn.Close();
            return listQuestion;
        }

        //Lấy câu hỏi của khách hàng dựa vào idKH
        public List<TuvankhDTO> getCustomerQuestion(string idKH)
        {
            conn.Open();
            List<TuvankhDTO> listQuestion = new List<TuvankhDTO>();
            string sql = "SELECT * FROM Question WHERE IDKH = \'"+ idKH+"\'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtQuestion = new DataTable();
            dtQuestion.Load(dr);
            foreach (DataRow item in dtQuestion.Rows)
            {
                string QuestionID = item["QuestionID"].ToString();
                string QuestionContent = item["QuestionContent"].ToString();
                string IDKH = item["IDKH"].ToString();
                DateTime CreatedTime = (DateTime)item["CreatedTime"];
                int BeAnswered = int.Parse(item["BeAnswered"].ToString());
                int CategoryID = int.Parse(item["CategoryID"].ToString());

                TuvankhDTO questionG = new TuvankhDTO(QuestionID, QuestionContent, IDKH, CreatedTime, BeAnswered, CategoryID);
                listQuestion.Add(questionG);
            }
            conn.Close();
            return listQuestion;
        }

        //Lấy câu hỏi được trả lời HOẶC chưa được trả lời ( 0: chưa, 1 : đã Tl)
        public List<TuvankhDTO> getAnsweredQuestion(int state)
        {
            conn.Open();
            List<TuvankhDTO> listQuestion = new List<TuvankhDTO>();
            string sql = "SELECT * FROM Question WHERE BeAnswered="+state;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtQuestion = new DataTable();
            dtQuestion.Load(dr);
            foreach (DataRow item in dtQuestion.Rows)
            {
                string QuestionID = item["QuestionID"].ToString();
                string QuestionContent = item["QuestionContent"].ToString();
                string IDKH = item["IDKH"].ToString();
                DateTime CreatedTime = (DateTime)item["CreatedTime"];
                int BeAnswered = int.Parse(item["BeAnswered"].ToString());
                int CategoryID = int.Parse(item["CategoryID"].ToString());

                TuvankhDTO questionG = new TuvankhDTO(QuestionID, QuestionContent, IDKH, CreatedTime, BeAnswered, CategoryID);
                listQuestion.Add(questionG);
            }
            conn.Close();
            return listQuestion;
        }

        //Thêm câu hỏi cho khách hàng
        public void addQuestionDAL(string question, string idKH)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("createQuestion", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QuestionContent", question);
            cmd.Parameters.AddWithValue("@IDKH", idKH);
            cmd.Parameters.AddWithValue("@CategoryID", 1);
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();
            conn.Close();
        }
        //Lấy nội dung câu hỏi = id Câu hỏi
        private string getQuestionContentDAL(string questionid)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Open();
            string sql = "SELECT QuestionContent FROM Question WHERE QuestionID = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", questionid);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string quesitonContent = dr.GetString(0);
                    dr.Close();
                    conn.Close();
                    return quesitonContent;
                }
            }
            dr.Close();
            conn.Close();
            return "-1";
        }
        //Xóa câu hỏi của khách hàng
        public int deleteQuestionDAL(string questioncontent, string questionDate)
        {
            string questionId = getIDQuestionDAL(questioncontent, questionDate);
            if (questionId == "-1")
            {
                return 0;
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Question WHERE QuestionID = @id", conn);

                SqlParameter param1 = new SqlParameter("@id", questionId);
                cmd.Parameters.Add(param1);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                return rows;
            }
        }

        //Lấy nội dung câu hỏi và ngày khởi tạo thông qua câu trả lời
        public string[] getQCntAnDateDAL(string AnswerContent, string AnsweredTime)
        {
            conn.Open();
            string questionId = "";
            string sql = "SELECT QuestionID FROM Answer WHERE AnswerContent = @AnswerContent AND AnsweredTime = @AnsweredTime";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AnswerContent", AnswerContent);
            cmd.Parameters.AddWithValue("@AnsweredTime", AnsweredTime);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    questionId = dr.GetString(0);
                }
                dr.Close();
            }
            conn.Close();

            conn.Open();
            string sql2 = "SELECT * FROM Question WHERE QuestionID = @QuestionID";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@QuestionID", questionId);

            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dtQuestion = new DataTable();

            dtQuestion.Load(dr2);
            string[] arr = new string[2];
            foreach (DataRow item in dtQuestion.Rows)
            {
                arr[0] = item["QuestionContent"].ToString();
                arr[1] = ((DateTime)item["CreatedTime"]).ToString("yyyy-MM-dd HH:mm:ss.fff");
            }
            conn.Close();
            return arr;
        }

        //Lấy 3 tin mới nhất
        public List<string[]> getHotNewsDAL()
        {
            List<string[]> hotnews = new List<string[]>();
            conn.Open();

            string sql = "SELECT TOP 3 * FROM Question WHERE CreatedTime >= DATEADD(DAY, -7, GETDATE()) AND CreatedTime <= DATEADD(DAY, -0, GETDATE());";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string[] arr = new string[3];
                    arr[0] = dr.GetString(0);
                    arr[1] = dr.GetString(1);
                    arr[2] = dr.GetDateTime(3).ToString("yyyy-MM-dd HH:mm:ss.fff");

                    hotnews.Add(arr);
                }
                conn.Close();
                dr.Close();
                return hotnews;
            }
            conn.Close();
            return hotnews;
        }

        // ----------------------------- Answer ------------------------------------------//
        //Lấy ID câu trả lời dựa vào nội dung câu trả lời và ngày khởi tạo
        public string getIDAnswerDAL(string AnswerContent, string AnsweredTime)
        {
            conn.Open();
            string sql = "SELECT AnswerID FROM Answer WHERE AnswerContent = @AnswerContent AND AnsweredTime = @AnsweredTime";
            //string sql = "SELECT QuestionID FROM Question WHERE QuestionContent = @QuestionContent";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AnswerContent", AnswerContent);
            cmd.Parameters.AddWithValue("@AnsweredTime", AnsweredTime);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string ansId = dr.GetString(0);
                    conn.Close();
                    return ansId;
                }
                dr.Close();
            }
            conn.Close();
            return "-1";
        }
        //Xóa câu trả lời
        public int deleteAnswerDAL(string AnswerContent, string AnsweredTime)
        {
            string ansId = getIDAnswerDAL(AnswerContent,AnsweredTime);
            if (ansId == "-1")
            {
                return 0;
            }
            else
            {
                conn.Open();
                List<string[]> answers = new List<string[]>();
                SqlCommand cmd = new SqlCommand("deleteAns", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AnswerID", ansId);
                cmd.Connection = conn;
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                return 1;
            }
        }

        //Lấy câu trả lời dựa vào câu hỏi
        public List<string[]> getAnswerDAL(string questioncontent, string questionDate)
        {
            List<string[]> answers = new List<string[]>();
            string questionId = getIDQuestionDAL(questioncontent, questionDate);
            if (questionId == "-1")
            {
                return answers;
            }
            else
            {
                conn.Open();
                string sql = "SELECT * FROM Answer WHERE QuestionID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", questionId);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string[]arr= new string[3];
                        arr[0] = dr.GetString(1);
                        arr[1] = dr.GetString(3);
                        arr[2] = dr.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss.fff");

                        answers.Add(arr);
                    }
                    conn.Close();
                    dr.Close();
                    return answers;
                }
                conn.Close();
                return answers;
            }
        }
        //Lấy câu hỏi của nhân viên - idNV
        public List<TraloikhDTO> getEmpAnswer(string idNV)
        {
            conn.Open();
            List<TraloikhDTO> listQuestion = new List<TraloikhDTO>();
            string sql = "SELECT * FROM Answer WHERE IDNV = \'" + idNV + "\'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtQuestion = new DataTable();

            dtQuestion.Load(dr);

            foreach (DataRow item in dtQuestion.Rows)
            {
                string AnswerID = item["AnswerID"].ToString();
                string AnswerContent = item["AnswerContent"].ToString();
                string QuestionContent = getQuestionContentDAL(item["QuestionID"].ToString());
                DateTime AnsweredTime = (DateTime)item["AnsweredTime"];
                string TenNV =  getNameEmp(item["IDNV"].ToString());

                TraloikhDTO questionG = new TraloikhDTO(AnswerID, AnswerContent,QuestionContent, TenNV, AnsweredTime);
                listQuestion.Add(questionG);
            }
            conn.Close();
            return listQuestion;
        }

        //Thêm câu trả lời của nhân viên vào câu hỏi
        public List<string[]> addDetialsAnswerDAL(string keyId, string answer, string IDNV)
        {
            conn.Open();
            List<string[]> answers = new List<string[]>();
            SqlCommand cmd = new SqlCommand("createAns", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AnswerContent", answer);
            cmd.Parameters.AddWithValue("@QuestionID", keyId);
            cmd.Parameters.AddWithValue("@IDNV", IDNV);
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();

            conn.Open();
            string sql = "SELECT * FROM Answer WHERE QuestionID = @id and AnswerContent = @AnswerContent";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@id", keyId);
            cmd2.Parameters.AddWithValue("@AnswerContent", answer);

            SqlDataReader dr2 = cmd2.ExecuteReader();

            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    string[] arr = new string[3];
                    arr[0] = dr2.GetString(1);  
                    arr[1] = dr2.GetString(3);  
                    arr[2] = dr2.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss.fff");

                    answers.Add(arr);
                }
                conn.Close();
                dr2.Close();
                return answers;
            }
            conn.Close();
            return answers;
        }
        // ----------------------------- Thông tin khác -------------------------------------//
        //Lấy tên nhân viên
        public string getNameEmp (string idNV)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Open();
            string sql = "SELECT HOTEN FROM Nhanvien WHERE IDNV = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idNV);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string nameEmp = dr.GetString(0);
                    conn.Close();
                    return nameEmp;
                }
                dr.Close();
            }
            conn.Close();
            return "-1";

        }
        
        //Lấy tên của khách hàng thông qua idKH
        public string getNameCus(string idKH)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Open();
            string sql = "SELECT HOTEN FROM Khachhang WHERE IDKH = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idKH);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string nameEmp = dr.GetString(0);
                    conn.Close();
                    return nameEmp;
                }
                dr.Close();
            }
            conn.Close();
            return "-1";
        }

        //Lấy tên Khách hàng thông qua câu hỏi
        public string getNameCusDAL(string questioncontent, string questionDate)
        {
            string questionId = getIDQuestionDAL(questioncontent, questionDate);
            conn.Open();
            string sql = "SELECT IDKH FROM Question WHERE QuestionID = @QuestionID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@QuestionID", questionId);
            string idKH = "";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    idKH = dr.GetString(0);
                }
                dr.Close();
            }
            conn.Close();
            return getNameCus(idKH);
        }
    }
}
