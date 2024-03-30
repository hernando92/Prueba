using System.ComponentModel.DataAnnotations;
using Universidad.Application.Interface.IRepository;
using Universidad.Application.Interface.IService;
using Universidad.Domain.Entities;

namespace Universidad.Application.Service
{
    public class MatriculaService : IMatriculaService
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly IAspiranteRepository _aspiranteRepository;
        private readonly IProgramaAcademicoRepository _programaAcademicoRepository;

        public MatriculaService(IMatriculaRepository matriculaRepository, 
                                IAspiranteRepository aspiranteRepository, IProgramaAcademicoRepository programaAcademicoRepository)
        {
            _matriculaRepository = matriculaRepository;
            _aspiranteRepository = aspiranteRepository;
            _programaAcademicoRepository = programaAcademicoRepository;
        }

        public List<Matricula> GetAll()
        {
            return _matriculaRepository.GetAll();
        }

        public Matricula GetById(int id)
        {
            return _matriculaRepository.GetById(id);
        }

        public Matricula Insert(Matricula matricula)
        {
            Aspirante aspirante = _aspiranteRepository.GetById(matricula.AspiranteId);
            if (aspirante != null)
            {

                ProgramaAcademico programaAcademico = _programaAcademicoRepository.GetById(matricula.ProgramaAcademicoId);

                if (programaAcademico != null)
                {
                    matricula.MatriculaFechaRegistro = DateTime.Now;
                    return _matriculaRepository.Insert(matricula);
                }
                else
                {
                    throw new ValidationException($"El Programa Academico {matricula.ProgramaAcademicoId} no existe, por favor validar");
                }
            }
            else
            {
                throw new ValidationException($"El Aspirante {matricula.AspiranteId} no existe, por favor validar");
            }
        }

        public Matricula Update(Matricula matricula)
        {

            Matricula matriculaPersistente = _matriculaRepository.GetById(matricula.MatriculaId);

            if (matriculaPersistente != null)
            {
                matricula.AspiranteId = matriculaPersistente.AspiranteId;
                matricula.ProgramaAcademicoId = matriculaPersistente.ProgramaAcademicoId;
                matricula.MatriculaFechaRegistro = matriculaPersistente.MatriculaFechaRegistro;

                return _matriculaRepository.Update(matricula);
            }
            else
            {
                throw new ValidationException($"La matricula no es valida, MatriculaId : {matricula.MatriculaId}");
            }

        }

    }
}
