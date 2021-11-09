using FoodDelivery.Application.Contracts.Infrastructure;
using FoodDelivery.Application.Models;
using FoodDelivery.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();

            return services;
        }
    }
}
