using Cricarba.Utilities.Services.Definitions;
using Cricarba.Utilities.Services.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cricarba.Utilities.Services
{
    public static class AppServicesIoCExtension
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<IMailService, MailService>();
            return services;
        }
    }
}
