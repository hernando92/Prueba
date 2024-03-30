using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Universidad.Application.Interface.IRepository;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Repository
{
    public class ProgramaAcademicoRepository : IProgramaAcademicoRepository
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public ProgramaAcademicoRepository(UniversidadDbContext universidadDbContext)
        {
            _universidadDbContext = universidadDbContext;
        }

        public ProgramaAcademico GetById(int id)
        {
            ProgramaAcademico ProgramaAcademico = _universidadDbContext.ProgramaAcademico
                                                    .Include(w => w.TipoProgramaAcademico)
                                                    .Where(x => x.ProgramaAcademicoId == id)
                                                    .FirstOrDefault();
            return ProgramaAcademico;
        }

        public ProgramaAcademico GetByLinq(Expression<Func<ProgramaAcademico, bool>> predicate)
        {
            return _universidadDbContext.ProgramaAcademico
                                                    .Include(w => w.TipoProgramaAcademico)
                                                    .Where(predicate)
                                                    .FirstOrDefault();
        }

        public List<ProgramaAcademico> GetAll()
        {
            return _universidadDbContext.ProgramaAcademico
                                          .Include(w => w.TipoProgramaAcademico)
                                          .ToList();
        }

        public ProgramaAcademico Update(ProgramaAcademico programaAcademico)
        {
            _universidadDbContext.ProgramaAcademico.Update(programaAcademico);
            _universidadDbContext.SaveChanges();

            programaAcademico = GetById(programaAcademico.ProgramaAcademicoId);

            return programaAcademico;
        }

        public ProgramaAcademico Insert(ProgramaAcademico programaAcademico)
        {
            _universidadDbContext.ProgramaAcademico.Add(programaAcademico);
            _universidadDbContext.SaveChanges();

            programaAcademico = GetById(programaAcademico.ProgramaAcademicoId);

            return programaAcademico;
        }
    }
}