using Universidad.Domain.Entities;

namespace Universidad.Application.Interface.IRepository
{
    public interface ITipoDocumentoRepository
    {
        List<TipoDocumento> GetAll();

        TipoDocumento GetById(int id);

    }
}
