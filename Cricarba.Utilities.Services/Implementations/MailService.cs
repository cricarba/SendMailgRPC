using Cricarba.Utilities.Domain;
using Cricarba.Utilities.Services.Definitions;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Cricarba.Utilities.Services.Implementations
{
    internal class MailService : IMailService
    {
        private readonly ITypeMail _mailServices;

        public MailService(IConfiguration configuration)
        {
            IConfigurationSection typeServices = configuration.GetSection("MailService");
            if (typeServices != null)
            {
                Enum.TryParse(typeServices.Value, out MailType mailType);
                _mailServices = MailFabric.Create(mailType);
            }
            else
                _mailServices = MailFabric.Create(MailType.Smtp);

        }

        public MailResult SendMail(MailConfig mailConfig)
        {
            return _mailServices.SendMail(mailConfig);
        }

        public Task<MailResult> SendMailAsync(MailConfig mailConfig)
        {
            return _mailServices.SendMailAsync(mailConfig);
        }
    }
}