using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Universidad.Application.Interface.IService;
using Universidad.Domain.DTO;
using Universidad.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universidad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService _matriculaService;
        private readonly IMapper _mapper;

        public MatriculaController(IMatriculaService matriculaService, IMapper mapper)
        {
            _matriculaService = matriculaService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<MatriculaConsultarDTO>> Get()
        {
            List<Matricula> matriculas = _matriculaService.GetAll();
            return Ok(_mapper.Map<List<MatriculaConsultarDTO>>(matriculas));
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<MatriculaConsultarDTO> GetById(int id)
        {
            Matricula matricula = _matriculaService.GetById(id);
            return Ok(_mapper.Map<MatriculaConsultarDTO>(matricula));
        }

        [HttpPost]
        public ActionResult<MatriculaConsultarDTO> Create(MatriculaCrearDTO aspirante)
        {
            Matricula resultMatricula = _matriculaService.Insert(_mapper.Map<Matricula>(aspirante));
            return Ok(_mapper.Map<MatriculaConsultarDTO>(resultMatricula));
        }

        [HttpPut]
        public ActionResult<MatriculaConsultarDTO> Update(MatriculaActualizarDTO aspirante)
        {
            Matricula resultMatricula = _matriculaService.Update(_mapper.Map<Matricula>(aspirante));
            return Ok(_mapper.Map<MatriculaConsultarDTO>(resultMatricula));
        }

    }
}
