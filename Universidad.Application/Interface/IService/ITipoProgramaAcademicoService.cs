using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IService
{
    public interface ITipoProgramaAcademicoService
    {
        List<TipoProgramaAcademico> GetAll();

        TipoProgramaAcademico GetById(int Id);

    }
}
