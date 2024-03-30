using Microsoft.EntityFrameworkCore;
using Universidad.Application.Interface.IRepository;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Repository
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public MatriculaRepository(UniversidadDbContext universidadDbContext)
        {
            _universidadDbContext = universidadDbContext;
        }

        public Matricula GetById(int id)
        {
            Matricula Matricula = _universidadDbContext.Matricula
                                                        .Include(x => x.Aspirante).ThenInclude(x => x.TipoDocumento)
                                                        .Include(x => x.ProgramaAcademico).ThenInclude( x=> x.TipoProgramaAcademico)
                                                        .Where(x => x.MatriculaId == id).FirstOrDefault(); ;
            return Matricula;
        }

        public List<Matricula> GetAll()
        {
            return _universidadDbContext.Matricula
                                            .Include(x => x.Aspirante).ThenInclude(x => x.TipoDocumento)
                                            .Include(x => x.ProgramaAcademico).ThenInclude(x => x.TipoProgramaAcademico)
                                            .ToList();
        }

        public Matricula Update(Matricula matricula)
        {
            _universidadDbContext.Matricula.Update(matricula);
            _universidadDbContext.SaveChanges();

            matricula = GetById(matricula.MatriculaId);

            return matricula;
        }

        public Matricula Insert(Matricula matricula)
        {
            _universidadDbContext.Matricula.Add(matricula);
            _universidadDbContext.SaveChanges();

            matricula = GetById(matricula.MatriculaId);
            return matricula;
        }
    }
}