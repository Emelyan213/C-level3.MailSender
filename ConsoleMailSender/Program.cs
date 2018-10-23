using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleMailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new MailMessage();
            mail.Sender = new MailAddress("shmachilin@gmail.com");
            mail.From = new MailAddress("shmachilin@gmail.com");
            mail.To.Add("shmachilin@yandex.ru");
            mail.Subject = "Hello World";
            mail.Body = "Тело письма";

            var client = new SmtpClient("smtp.gmail.com", 58);
            client.Credentials = new NetworkCredential("user", "password");
            client.EnableSsl = true;
            
            client.Send(mail);

            Console.ReadLine();
        }
    }
}
