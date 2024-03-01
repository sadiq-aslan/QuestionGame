﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Reflection;

namespace Game.Aplication
{
    public static class ConfigureService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.Scan(scan => scan.FromAssemblies(
           typeof(IApplicationAssemblyMarker).Assembly).AddClasses(@class =>
           @class.Where(type =>
           !type.Name.StartsWith('I')
           && type.Name.EndsWith("Service")))
           .UsingRegistrationStrategy(RegistrationStrategy.Skip)
           .AsImplementedInterfaces()
           .WithScopedLifetime());

            return services;

        }
    }
}
