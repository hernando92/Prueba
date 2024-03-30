using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Universidad.Application.Interface.IService;
using Universidad.Domain.DTO;
using Universidad.Domain.Entities;

namespace Universidad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramaAcademicoController : ControllerBase
    {
        private readonly IProgramaAcademicoService _programaAcademicoService;
        private readonly IMapper _mapper;

        public ProgramaAcademicoController(IProgramaAcademicoService ProgramaAcademicoService, IMapper mapper)
        {
            _programaAcademicoService = ProgramaAcademicoService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ProgramaAcademicoConsultarDTO>> Get()
        {
            List<ProgramaAcademico> programaAcademicos = _programaAcademicoService.GetAll();
            return Ok(_mapper.Map<List<ProgramaAcademicoConsultarDTO>>(programaAcademicos));
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<ProgramaAcademicoConsultarDTO> GetById(int id)
        {
            ProgramaAcademico programaAcademico = _programaAcademicoService.GetById(id);
            return Ok(_mapper.Map<ProgramaAcademicoConsultarDTO>(programaAcademico));
        }

        [HttpPost]
        public ActionResult<ProgramaAcademicoConsultarDTO> Create(ProgramaAcademicoCrearDTO programaAcademico)
        {
            ProgramaAcademico resultProgramaAcademico = _programaAcademicoService.Insert(_mapper.Map<ProgramaAcademico>(programaAcademico));
            return Ok(_mapper.Map<ProgramaAcademicoConsultarDTO>(resultProgramaAcademico));
        }

        [HttpPut]
        public ActionResult<ProgramaAcademicoConsultarDTO> Update(ProgramaAcademicoActualizarDTO programaAcademico)
        {
            ProgramaAcademico resultProgramaAcademico = _programaAcademicoService.Update(_mapper.Map<ProgramaAcademico>(programaAcademico));
            return Ok(_mapper.Map<ProgramaAcademicoConsultarDTO>(resultProgramaAcademico));
        }


    }
}
