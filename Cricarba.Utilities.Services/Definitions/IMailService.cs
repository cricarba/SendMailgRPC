using Cricarba.Utilities.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cricarba.Utilities.Services.Definitions
{
    public interface IMailService
    {
        MailResult Send(MailConfig mailConfig);

        Task<MailResult> SendAsync(MailConfig mailConfig);
    }
}
