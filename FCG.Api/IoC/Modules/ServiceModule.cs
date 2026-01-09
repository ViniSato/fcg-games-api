using FCG.Application.Interfaces;
using FCG.Application.Interfaces.Mappers;
using FCG.Application.Interfaces.Services;
using FCG.Application.Mappers;
using FCG.Application.Services;

namespace FCG.Api.IoC.Modules
{
    public class ServiceModule
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddTransient<IJogoService, JogoService>();
            services.AddTransient<IPromocaoService, PromocaoService>();
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<IJogoMapper, JogoMapper>();
        }
    }
}
