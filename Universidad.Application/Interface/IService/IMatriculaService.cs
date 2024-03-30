using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IService
{
    public interface IMatriculaService
    {
        List<Matricula> GetAll();

        Matricula GetById(int id);

        Matricula Update(Matricula matricula);

        Matricula Insert(Matricula matricula);

    }
}
