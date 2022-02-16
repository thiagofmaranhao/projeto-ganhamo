using Microsoft.Extensions.DependencyInjection;
using PedidoApi.Business.Services;
using PedidoApi.Business.Services.Interfaces;
using PedidoApi.Repository;
using PedidoApi.Repository.Events;
using PedidoApi.Repository.Events.Interfaces;
using PedidoApi.Repository.Interfaces;

namespace PedidoApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoEvent, PedidoEvent>();
            services.AddScoped<IPedidoService, PedidoService>();

            return services;
        }
    }
}