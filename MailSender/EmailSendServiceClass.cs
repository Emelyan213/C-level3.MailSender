using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    public class EmailSendServiceClass
    {
        //public EmailSendServiceClass()
        //{
        //}

        public void SendEmail(string UserName, System.Security.SecureString Password, string nameMessage, string bodyMassage)
        {
            using (var email = new MailMessage("emelyan980@yandex.ru", "emel_galushko@mail.ru"))
            {
                email.Subject = nameMessage;
                email.Body = bodyMassage;

                using (var client = new SmtpClient(WpfTestMailSender.serverSMTP))
                {
                    var user = UserName;
                    var password = Password;
                    client.Credentials = new NetworkCredential(user, password);
                    client.EnableSsl = false;

                    client.Send(email);
                }
            }
        }
    }
}
