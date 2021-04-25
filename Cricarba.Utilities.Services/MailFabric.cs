using Cricarba.Utilities.Domain;
using Cricarba.Utilities.Services.Definitions;
using Cricarba.Utilities.Services.Implementations;
using System;

namespace Cricarba.Utilities.Services
{
    internal static class MailFabric
    {
        internal static ITypeMail Create(MailType type)
        {
            switch (type)
            {
                case MailType.Smtp:
                    return new SmtpClientMail();

                case MailType.SendGrid:
                    return new SendGridMail();

                default:
                    throw new ArgumentException("Type not defined", "type");
            }
        }
    }
}