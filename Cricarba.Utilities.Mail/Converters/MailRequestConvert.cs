using Cricarba.Utilities.Domain;

namespace Cricarba.Utilities.Mail
{
    public partial class MailRequest
    {
        public static implicit operator MailConfig(MailRequest request)
        {
            return new MailConfig
            {
                Subject = request.Subject,
                Body = request.Body,
                From = request.From,
                Host = request.Host,
                User = request.User,
                Password = request.Password
            };
        }
    }
}