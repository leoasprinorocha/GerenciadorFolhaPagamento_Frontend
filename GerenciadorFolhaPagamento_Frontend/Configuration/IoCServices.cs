using GerenciadorFolhaPagamento_Frontend_Client;
using GerenciadorFolhaPagamento_Frontend_Client.Interfaces;
using GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services;
using GerenciadorFolhaPagamento_Frontend_Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorFolhaPagamento_Frontend.Configuration
{
    public static class IoCServices
    {

        public static IServiceCollection AddIoCServices(this IServiceCollection services)
        {
            services.AddDomainServices();
            services.AddHelperServices();
            return services;
        }

        private static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IParametrosServices, ParametrosServices>();
            services.AddScoped<IProcessamentosServices, ProcessamentosServices>();
            return services;
        }

        private static IServiceCollection AddHelperServices(this IServiceCollection services)
        {
            services.AddScoped<IClientBase, ClientBase>();
            services.AddHttpClient<ClientBase>();
            return services;
        }

    }
}
