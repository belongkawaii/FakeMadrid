using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FakeMadrid.Controllers
{
    public static class SendMail
    {
        public static string taikhoan = "fakemadridofficial001@gmail.com";
        public static string matkhau = "@@AaBcd123456";



        public static bool sendMailTo(string emailTo, string content)
        {
            var fromAddress = new MailAddress(taikhoan, "Fake Madrid Quản lý tài khoản");
            var toAddress = new MailAddress(emailTo, emailTo);
            string fromPassword = matkhau;
            const string subject = "Thông báo từ hệ thống quản lý đội bóng Fake Madrid";
            string body = content;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            try
            {
                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    message.Subject = subject;
                    message.Body = body;

                    smtp.Send(message);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
