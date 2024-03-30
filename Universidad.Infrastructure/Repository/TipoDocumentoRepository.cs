using Universidad.Application.Interface.IRepository;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Repository
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public TipoDocumentoRepository(UniversidadDbContext universidadDbContext)
        {
            _universidadDbContext = universidadDbContext;
        }

        public TipoDocumento GetById(int id)
        {
            TipoDocumento TipoDocumento = _universidadDbContext.TipoDocumento.Where(x => x.TipoDocumentoId == id).FirstOrDefault(); ;
            return TipoDocumento;
        }

        public List<TipoDocumento> GetAll()
        {
            return _universidadDbContext.TipoDocumento.ToList();
        }
    }
}