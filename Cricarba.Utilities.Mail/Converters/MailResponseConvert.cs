using Cricarba.Utilities.Domain;

namespace Cricarba.Utilities.Mail
{
    public partial class MailResponse
    {
        public static implicit operator MailResponse(MailResult response)
        {
            return new MailResponse
            {
                Error = response.Error,
                Message = response.Message,
                Status = response.Status.ToString(),
            };
        }
    }
}