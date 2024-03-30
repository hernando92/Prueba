using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IRepository
{
    public interface IMatriculaRepository
    {
        List<Matricula> GetAll();

        Matricula GetById(int id);

        Matricula Update(Matricula matricula);

        Matricula Insert(Matricula matricula);

    }
}
