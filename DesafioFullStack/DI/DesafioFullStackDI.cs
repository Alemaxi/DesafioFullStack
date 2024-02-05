using Data.NHibernate.Repository;
using DesafioFullStack.Application.Implementations;
using DesafioFullStack.Business.Implementation;
using DesafioFullStack.Domain.Application;
using DesafioFullStack.Domain.Business;
using DesafioFullStack.Domain.Repository;

namespace DesafioFullStack.DI
{
    public static class DesafioFullStackDI
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterApplications(services);
            RegisterBusiness(services);
            RegisterRepository(services);
        }


        static void RegisterApplications(IServiceCollection services)
        {
            services.AddScoped<IEquipamentoApplication, EquipamentoApplication>();
        }

        static void RegisterBusiness(IServiceCollection services)
        {
            services.AddScoped<IEquipamentoBusiness, EquipamentoBusiness>();
        }

        static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IEquipamentoRepository, EquipamentoRepository>();
        }
    }
}
