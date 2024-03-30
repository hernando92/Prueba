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
    public class TipoProgramaAcademicoController : ControllerBase
    {
        private readonly ITipoProgramaAcademicoService _tipoProgramaAcademicoService;
        private readonly IMapper _mapper;

        public TipoProgramaAcademicoController(ITipoProgramaAcademicoService tipoProgramaAcademicoService, IMapper mapper)
        {
            _tipoProgramaAcademicoService = tipoProgramaAcademicoService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<TipoProgramaAcademicoDTO>> Get()
        {
            List<TipoProgramaAcademico> tipoProgramaAcademicos = _tipoProgramaAcademicoService.GetAll();
            return Ok(_mapper.Map<List<TipoProgramaAcademicoDTO>>(tipoProgramaAcademicos));
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<TipoProgramaAcademicoDTO> GetById(int id)
        {
            TipoProgramaAcademico tipoProgramaAcademicos = _tipoProgramaAcademicoService.GetById(id);
            return Ok(_mapper.Map<TipoProgramaAcademicoDTO>(tipoProgramaAcademicos));
        }


    }
}
