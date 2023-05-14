using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraloikhDTO
    {
            public string AnswerID { get; set; }
            public string AnswerContent { get; set; }
            public string QuestionContent { get; set; }
            public string TenNV { get; set; }
            public DateTime AnsweredTime { get; set; }

            public TraloikhDTO(string AnswerID, string AnswerContent, string QuestionContent, string TenNV, DateTime AnsweredTime)
            {
                this.AnswerID = AnswerID;
                this.AnswerContent = AnswerContent;
                this.QuestionContent = QuestionContent;
                this.TenNV = TenNV;
                this.AnsweredTime = AnsweredTime;
            }

        
    }
}
