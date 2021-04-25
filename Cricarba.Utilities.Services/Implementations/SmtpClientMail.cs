using Cricarba.Utilities.Domain;
using Cricarba.Utilities.Services.Definitions;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Cricarba.Utilities.Services.Implementations
{
    public class SmtpClientMail : ITypeMail
    {
        public MailResult SendMail(MailConfig mailConfig)
        {
            SmtpClient client = new SmtpClient(mailConfig.Host);
            client.Credentials = new NetworkCredential(mailConfig.User, mailConfig.Password);
            client.SendCompleted += Mail_SendCompleted; 
            try
            {
                client.Send(mailConfig);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
            return new MailResult();

        }

        private void Mail_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
           //
        }

        public async Task<MailResult> SendMailAsync(MailConfig mailConfig)
        {
            SmtpClient client = new SmtpClient(mailConfig.Host);
            client.Credentials = new NetworkCredential(mailConfig.User, mailConfig.Password); 
            client.SendCompleted += Mail_SendCompleted;

            try
            {
                await client.SendMailAsync(mailConfig);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
            return new MailResult();

        }
    }
}