using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IService
{
    public interface IAspiranteService
    {
        List<Aspirante> GetAll();

        Aspirante GetById(int id);

        Aspirante Update(Aspirante aspirante);

        Aspirante Insert(Aspirante aspirante);

    }
}
