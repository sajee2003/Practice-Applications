using System;
using System.Configuration;
using MimeKit;
using System.Net;
using System.Net.Mail;

using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;


namespace WebApplication1
{
    //public interface IEmailService
    //{
    //    Task SendEmail(string toEmail, string subject, string body);
    //}

    public class EmailService
    {

        public void SendEmail(string recipientName, string recipientEmail, string subject, string body, string leavebody)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Cloudy (pvt) ltd", "kanesarajasajeevan295@gmail.com"));
            email.To.Add(new MailboxAddress(recipientName, recipientEmail));
            email.Subject = subject;

            var bodyBuilder = new BodyBuilder { TextBody = body };
            email.Body = bodyBuilder.ToMessageBody();

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate("kanesarajasajeevan295@gmail.com", "yhwn mnib vdra xeex");
                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }

        public string GenerateEmailContent(string recipientName, string ebody)
        {
            return $@"
                  

                 hi {recipientName}
       
                    {ebody}
                    ";
        }

    }
}
