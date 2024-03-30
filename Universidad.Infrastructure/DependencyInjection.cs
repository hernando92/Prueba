using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Universidad.Application.Interface.IRepository;
using Universidad.Application.Interface.IService;
using Universidad.Application.Service;
using Universidad.Infrastructure.Repository;

namespace Universidad.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection ImplementPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UniversidadDbContext>(options => options.UseMySQL(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAspiranteService, AspiranteService>();
            services.AddTransient<IMatriculaService, MatriculaService>();
            services.AddTransient<IProgramaAcademicoService, ProgramaAcademicoService>();
            services.AddTransient<ITipoProgramaAcademicoService, TipoProgramaAcademicoService>();


            services.AddTransient<IAspiranteRepository, AspiranteRepository>();
            services.AddTransient<IMatriculaRepository, MatriculaRepository>();
            services.AddTransient<IProgramaAcademicoRepository, ProgramaAcademicoRepository>();
            services.AddTransient<ITipoDocumentoRepository, TipoDocumentoRepository>();
            services.AddTransient<ITipoProgramaAcademicoRepository, TipoProgramaAcademicoRepository>();

            return services;

        }

    }
}
