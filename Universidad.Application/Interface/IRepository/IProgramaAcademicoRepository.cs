using System.Linq.Expressions;
using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IRepository
{
    public interface IProgramaAcademicoRepository
    {
        List<ProgramaAcademico> GetAll();

        ProgramaAcademico GetById(int id);

        ProgramaAcademico GetByLinq(Expression<Func<ProgramaAcademico, bool>> predicate);

        ProgramaAcademico Update(ProgramaAcademico programaAcademico);

        ProgramaAcademico Insert(ProgramaAcademico programaAcademico);

    }
}
