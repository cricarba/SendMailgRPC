using Cricarba.Utilities.Domain;
using Cricarba.Utilities.Services.Definitions;
using SendGrid;
using System;
using System.Threading.Tasks;

namespace Cricarba.Utilities.Services.Implementations
{
    public class SendGridMail : ITypeMail
    {
        public MailResult SendMail(MailConfig mailConfig)
        {
            return SendMailAsync(mailConfig).Result;
        }

        public async Task<MailResult> SendMailAsync(MailConfig mailConfig)
        {
            var apiKey = mailConfig.Password;
            var client = new SendGridClient(apiKey);
            return await client.SendEmailAsync(mailConfig);
        }
    }
}