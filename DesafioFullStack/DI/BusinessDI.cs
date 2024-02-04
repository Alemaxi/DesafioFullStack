using Celular.Business;
using DesafioFullStack.Domain.Business;
using Impressora.Business;

namespace DesafioFullStack.DI
{
    public static class BusinessDI
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IImpressoraBusiness, ImpressoraBusiness>();
            services.AddScoped<ICelularBusiness, CelularBusiness>();
        }
    }
}
