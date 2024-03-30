using Universidad.Application.Interface.IRepository;
using Universidad.Application.Interface.IService;
using Universidad.Domain.Entities;

namespace Universidad.Application.Service
{
    public class TipoProgramaAcademicoService : ITipoProgramaAcademicoService
    {
        private readonly ITipoProgramaAcademicoRepository _tipoProgramaAcademicoRepository;

        public TipoProgramaAcademicoService(ITipoProgramaAcademicoRepository tipoProgramaAcademicoRepository)
        {
            _tipoProgramaAcademicoRepository = tipoProgramaAcademicoRepository;
        }

        public TipoProgramaAcademico GetById(int id)
        {
            return _tipoProgramaAcademicoRepository.GetById(id);
        }

        public List<TipoProgramaAcademico> GetAll()
        {
            List<TipoProgramaAcademico> listTipoProgramaAcademico = _tipoProgramaAcademicoRepository.GetAll();

            return listTipoProgramaAcademico;
        }
    }
}
