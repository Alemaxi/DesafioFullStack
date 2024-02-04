using Data.NHibernate.Repository;
using DesafioFullStack.Domain.Repository;

namespace DesafioFullStack.DI
{
    public static class RepositoryDI
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IImpressoraRepository, ImpressoraRepository>();
            services.AddScoped<ICelularRepository, CelularRepository>();
        }
    }
}
