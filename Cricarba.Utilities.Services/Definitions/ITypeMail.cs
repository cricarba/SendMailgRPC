using Cricarba.Utilities.Domain;
using System.Threading.Tasks;

namespace Cricarba.Utilities.Services.Definitions
{
    internal interface ITypeMail
    {
        MailResult SendMail(MailConfig mailConfig);
        Task<MailResult> SendMailAsync(MailConfig mailConfig);
    }
}