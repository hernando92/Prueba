using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IService
{
    public interface IProgramaAcademicoService
    {
        List<ProgramaAcademico> GetAll();

        ProgramaAcademico GetById(int id);

        ProgramaAcademico Update(ProgramaAcademico programaAcademico);

        ProgramaAcademico Insert(ProgramaAcademico programaAcademico);

    }
}
