using AutoMapper;
using Livraria.Models;
using Livraria.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Livraria.AutoMappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMapper(IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<LivroViewModel, Livro>();
                c.CreateMap<Livro, LivroViewModel>();                
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
