using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Universidad.Application.Interface.IRepository;
using Universidad.Application.Interface.IService;
using Universidad.Domain.Entities;

namespace Universidad.Application.Service
{
    public class ProgramaAcademicoService : IProgramaAcademicoService
    {
        private readonly IProgramaAcademicoRepository _programaAcademicoRepository;
        private readonly ITipoProgramaAcademicoRepository _tipoProgramaAcademicoRepository;

        public ProgramaAcademicoService(IProgramaAcademicoRepository programaAcademicoRepository, ITipoProgramaAcademicoRepository tipoProgramaAcademicoRepository)
        {
            _programaAcademicoRepository = programaAcademicoRepository;
            _tipoProgramaAcademicoRepository = tipoProgramaAcademicoRepository;
        }

        public List<ProgramaAcademico> GetAll()
        {
            return _programaAcademicoRepository.GetAll();
        }

        public ProgramaAcademico GetById(int id)
        {
            return _programaAcademicoRepository.GetById(id);
        }

        public ProgramaAcademico GetByLinq(Expression<Func<ProgramaAcademico, bool>> predicate)
        {
            return _programaAcademicoRepository.GetByLinq(predicate);
        }

        public ProgramaAcademico Insert(ProgramaAcademico programaAcademico)
        {
            TipoProgramaAcademico tipoProgramaAcademico = _tipoProgramaAcademicoRepository.GetById(programaAcademico.TipoProgramaAcademicoId);

            if (tipoProgramaAcademico != null)
            {

                ProgramaAcademico programa = GetByLinq(x => x.ProgramaAcademicoCodigo == programaAcademico.ProgramaAcademicoCodigo);

                if (programa == null)
                {
                    programaAcademico.ProgramaAcademicoActivo = true;
                    return _programaAcademicoRepository.Insert(programaAcademico);
                }
                else
                {
                    throw new ValidationException($"El Codigo {programaAcademico.ProgramaAcademicoCodigo} ya existe, por favor ingrese otro valor");
                }
            }
            else
            {
                throw new ValidationException($"El tipo de programa academico no es valido, TipoProgramaAcademicoId : {programaAcademico.TipoProgramaAcademicoId}");
            }
        }

        public ProgramaAcademico Update(ProgramaAcademico programaAcademico)
        {

            ProgramaAcademico programa = GetById(programaAcademico.ProgramaAcademicoId);

            if (programa != null)
            {
                TipoProgramaAcademico tipoProgramaAcademico = _tipoProgramaAcademicoRepository.GetById(programaAcademico.TipoProgramaAcademicoId);

                if (tipoProgramaAcademico != null)
                {
                    ProgramaAcademico programaPersistente = GetByLinq(x => x.ProgramaAcademicoCodigo == programaAcademico.ProgramaAcademicoCodigo && x.ProgramaAcademicoId != programaAcademico.ProgramaAcademicoId);

                    if (programaPersistente == null)
                    {
                        programaAcademico.ProgramaAcademicoCodigo = programa.ProgramaAcademicoCodigo;
                        return _programaAcademicoRepository.Update(programaAcademico);
                    }
                    else
                    {
                        throw new ValidationException($"El Codigo {programaAcademico.ProgramaAcademicoCodigo} ya existe, por favor ingrese otro valor");
                    }
                }
                else
                {
                    throw new ValidationException($"El tipo de programa academico no es valido, TipoProgramaAcademicoId : {programaAcademico.TipoProgramaAcademicoId}");
                }
            }
            else
            {
                throw new ValidationException($"El programa academico no es valido, ProgramaAcademicoId : {programaAcademico.ProgramaAcademicoId}");
            }
        }
    }
}
