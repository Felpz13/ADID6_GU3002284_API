using ADID6_GU3002284_API.Repositorios;
using ADID6_GU3002284_API.Repositorios.Interfaces;
using ADID6_GU3002284_API.Servicos;
using ADID6_GU3002284_API.Servicos.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ADID6_GU3002284_API.Configuracoes
{
    public static class IoC
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection services)
        {
            //Repositories
            services.AddSingleton<IMockRepo, MockRepo>();
            //Services
            services.AddTransient<IItemService, ItemService>();

            //Utils

            return services;
        }
    }
}
