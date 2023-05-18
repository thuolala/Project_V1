using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DTO; 

namespace BLL
{

    /// <summary>
    /// This class for handle input, output, generate,. . .
    /// </summary>
    /// 
    public class Handle
    {
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk = new Taikhoan();

        //Random password
        public string generatePass()
        {
            string pass = "";
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder sb = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(validChars.Length);
                sb.Append(validChars[index]);
            }

            pass = sb.ToString();
            return pass;
        }

        public string randomPass()
        {
            string pass = generatePass();
            List<string> listPass = tkBLL.getAllPass();
            if (listPass.Contains(pass) == true)
            {
                Console.WriteLine(pass);
                pass = generatePass();
            }
            return pass;
        }

        //Send mail 
        public void SendEmail(Taikhoan test, string email, string fullname, List<MailAddress> bcc = null)
        {
            //cau hinh gui mail 
            MailAddress from = new MailAddress("extractteam123@gmail.com", "Pharmacity");
            MailAddress to = new MailAddress(email, fullname);
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("extractteam123@gmail.com", "Pharmacity"));

            string resetPass = randomPass();
            string subject = "Đặt lại mật khẩu";
            string body = "Mật khẩu mới của bạn là: " + resetPass + "\n Vui lòng không chia sẻ mật khẩu cho bất kỳ ai vì lý do bảo mật.";

            SmtpClient mailClient = new SmtpClient();
            mailClient.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntcd = new NetworkCredential();
            ntcd.UserName = "extractteam123@gmail.com";
            ntcd.Password = "ykjkrhvphtuifjah";
            mailClient.Credentials = ntcd;
            mailClient.EnableSsl = true;
            mailClient.Port = 587;

            MailMessage msgMail;
            msgMail = new MailMessage();
            msgMail.From = from;
            msgMail.To.Add(to);
            foreach (MailAddress addr in cc)
            {
                msgMail.CC.Add(addr);
            }
            if (bcc != null)
            {
                foreach (MailAddress addr in bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = subject;
            msgMail.Body = body;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);

            //update mk 
            tk = new Taikhoan(test.Id, test.Userame, resetPass, test.Permission);
            tkBLL.updateAccount(tk);

            msgMail.Dispose();
        }
    }
}
