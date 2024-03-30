using System.ComponentModel.DataAnnotations;
using Universidad.Application.Interface.IRepository;
using Universidad.Application.Interface.IService;
using Universidad.Domain.Entities;

namespace Universidad.Application.Service
{
    public class AspiranteService : IAspiranteService
    {
        private readonly IAspiranteRepository _aspiranteRepository;
        private readonly ITipoDocumentoRepository _tipoDocumentoRepository;

        public AspiranteService(IAspiranteRepository aspiranteRepository, ITipoDocumentoRepository tipoDocumentoRepository)
        {
            _aspiranteRepository = aspiranteRepository;
            _tipoDocumentoRepository = tipoDocumentoRepository;
        }

        public List<Aspirante> GetAll()
        {
            return _aspiranteRepository.GetAll();
        }

        public Aspirante GetById(int id)
        {
            return _aspiranteRepository.GetById(id);
        }

        public Aspirante Insert(Aspirante aspirante)
        {
            TipoDocumento tipoDocumento = _tipoDocumentoRepository.GetById(aspirante.TipoDocumentoId);
            if (tipoDocumento != null)
            {
                aspirante.AspiranteActivo = true;
                return _aspiranteRepository.Insert(aspirante);
            }
            else
            {
                throw new ValidationException($"El tipo de documento no es valido, TipoDocumentoId : {aspirante.TipoDocumentoId}");
            }

        }

        public Aspirante Update(Aspirante aspirante)
        {
            Aspirante aspirantePersistente = GetById(aspirante.AspiranteId);

            if (aspirantePersistente != null)
            {
                TipoDocumento tipoDocumento = _tipoDocumentoRepository.GetById(aspirante.TipoDocumentoId);
                if (tipoDocumento != null)
                {
                    return _aspiranteRepository.Update(aspirante);
                }
                else
                {
                    throw new ValidationException($"El tipo de documento no es valido, TipoDocumentoId : {aspirante.TipoDocumentoId}");
                }
            }
            else
            {
                throw new ValidationException($"El aspirante no es valido, AspiranteId : {aspirante.AspiranteId}");
            }
        }

    }
}
