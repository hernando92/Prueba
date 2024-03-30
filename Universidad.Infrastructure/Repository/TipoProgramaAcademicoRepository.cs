using Universidad.Application.Interface.IRepository;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Repository
{
    public class TipoProgramaAcademicoRepository : ITipoProgramaAcademicoRepository
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public TipoProgramaAcademicoRepository(UniversidadDbContext universidadDbContext)
        {
            _universidadDbContext = universidadDbContext;
        }

        public TipoProgramaAcademico GetById(int id)
        {
            TipoProgramaAcademico tipoProgramaAcademico = _universidadDbContext.TipoProgramaAcademico.Where(x => x.TipoProgramaAcademicoId == id).FirstOrDefault();
            return tipoProgramaAcademico;
        }

        public List<TipoProgramaAcademico> GetAll()
        {
            return _universidadDbContext.TipoProgramaAcademico.ToList();
        }
    }
}
