using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;

namespace Cricarba.Utilities.Domain
{
    public class MailConfig
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public static implicit operator MailMessage(MailConfig mailConfig)
        {
            MailAddress from = new MailAddress(mailConfig.From);
            MailAddress to = new MailAddress(mailConfig.To);
            MailMessage message = new MailMessage(from, to);
            message.Subject = mailConfig.Subject;
            message.Body = mailConfig.Body;
            message.IsBodyHtml = true;
            return message;
        }

        public static implicit operator SendGridMessage(MailConfig mailConfig)
        {           
            SendGridMessage message = new SendGridMessage();
            EmailAddress from = new EmailAddress(mailConfig.From);
            message.SetFrom(from);
            EmailAddress to = new EmailAddress(mailConfig.To);            
            message.AddTo(to);
            message.SetSubject(mailConfig.Subject);
            message.AddContent(MimeType.Html, mailConfig.Body);
            return message;
        }
    }
}