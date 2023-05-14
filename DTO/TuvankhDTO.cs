using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuvankhDTO
    {
       
        public string QuestionID { get ; set; }
        public string QuestionContent { get; set; }
        public string IDKH { get; set; }
        public DateTime CreatedTime { get; set; }
        public int BeAnswered { get; set; }
        public int CategoryID { get; set; }

        public TuvankhDTO(string QuestionID, string QuestionContent, string IDKH, DateTime CreatedTime, int BeAnswered, int CategoryID)
        {
            this.QuestionID = QuestionID;
            this.QuestionContent = QuestionContent; 
            this.IDKH = IDKH;
            this.CreatedTime = CreatedTime;
            this.BeAnswered= BeAnswered;
            this.CategoryID= CategoryID;
        }

    }
}
