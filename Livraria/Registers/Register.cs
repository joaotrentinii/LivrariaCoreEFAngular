using Livraria.Data.Context;
using Livraria.Data.Repository;
using Livraria.Data.Repository.Interfaces;
using Livraria.Services;
using Livraria.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Registers
{
    public class Register
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //data
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<LivrariaContext>();

            //services
            services.AddScoped<ILivroService, LivroService>();                     
        }
    }
}
