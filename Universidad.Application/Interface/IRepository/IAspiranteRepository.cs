using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IRepository
{
    public interface IAspiranteRepository
    {
        List<Aspirante> GetAll();

        Aspirante GetById(int id);

        Aspirante Update(Aspirante aspirante);

        Aspirante Insert(Aspirante aspirante);

    }
}
