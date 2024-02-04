using Celular.Application;
using Data.NHibernate.Repository;
using DesafioFullStack.Domain.Application;
using DesafioFullStack.Domain.Repository;
using Impressora.Application;

namespace DesafioFullStack.DI
{
    public static class ApplicationDI
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IImpressoraApplication, ImpressoraApplication>();
            services.AddScoped<ICelularApplication, CelularApplication>();
        }   
    }
}
