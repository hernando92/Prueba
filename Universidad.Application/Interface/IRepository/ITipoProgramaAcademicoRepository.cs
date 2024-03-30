using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IRepository
{
    public interface ITipoProgramaAcademicoRepository
    {

        List<TipoProgramaAcademico> GetAll();

        TipoProgramaAcademico GetById(int id);

    }
}
