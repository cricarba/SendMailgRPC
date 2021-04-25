using Cricarba.Utilities.Services.Definitions;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Cricarba.Utilities.Mail.Services
{
    public class MailService : Mail.MailBase
    {
        private readonly ILogger<MailService> _logger;
        private readonly IMailService _mailService;

        public MailService(ILogger<MailService> logger, IMailService mailService)
        {
            _logger = logger;
            _mailService = mailService;
        }

        public override async Task<MailResponse> SendMail(MailRequest request, ServerCallContext context)
        {
            return await _mailService.SendMailAsync(request);
        }
    }
}