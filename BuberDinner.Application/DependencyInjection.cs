using BuberDinner.Application.Common.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);
            });

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
