using Microsoft.EntityFrameworkCore;
using Universidad.Application.Interface.IRepository;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Repository
{
    public class AspiranteRepository : IAspiranteRepository
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public AspiranteRepository(UniversidadDbContext universidadDbContext)
        {
            _universidadDbContext = universidadDbContext;
        }

        public Aspirante GetById(int id)
        {
            Aspirante Aspirante = _universidadDbContext.Aspirante
                                                        .Include(x => x.TipoDocumento)
                                                        .Where(x => x.AspiranteId == id)
                                                        .FirstOrDefault();
            return Aspirante;
        }

        public List<Aspirante> GetAll()
        {
            return _universidadDbContext.Aspirante
                                            .Include(x => x.TipoDocumento)
                                            .ToList();
        }

        public Aspirante Update(Aspirante aspirante)
        {
            _universidadDbContext.Aspirante.Update(aspirante);
            _universidadDbContext.SaveChanges();

            aspirante = GetById(aspirante.AspiranteId);

            return aspirante;
        }

        public Aspirante Insert(Aspirante aspirante)
        {
            _universidadDbContext.Aspirante.Add(aspirante);
            _universidadDbContext.SaveChanges();

            aspirante = GetById(aspirante.AspiranteId);

            return aspirante;
        }
    }
}