using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Universidad.Application.Interface.IService;
using Universidad.Application.Service;
using Universidad.Domain.DTO;
using Universidad.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universidad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspiranteController : ControllerBase
    {
        private readonly IAspiranteService _aspiranteService;
        private readonly IMapper _mapper;

        public AspiranteController(IAspiranteService aspiranteService, IMapper mapper)
        {
            _aspiranteService = aspiranteService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<AspiranteConsultarDTO>> Get()
        {
            List<Aspirante> aspirantes = _aspiranteService.GetAll();
            return Ok(_mapper.Map<List<AspiranteConsultarDTO>>(aspirantes));
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<AspiranteConsultarDTO> GetById(int id)
        {
            Aspirante aspirante = _aspiranteService.GetById(id);
            return Ok(_mapper.Map<AspiranteConsultarDTO>(aspirante));
        }

        [HttpPost]
        public ActionResult<AspiranteConsultarDTO> Create(AspiranteCrearDTO aspirante)
        {
            Aspirante resultAspirante = _aspiranteService.Insert(_mapper.Map<Aspirante>(aspirante));
            return Ok(_mapper.Map<AspiranteConsultarDTO>(resultAspirante));
        }

        [HttpPut]
        public ActionResult<AspiranteConsultarDTO> Update(AspiranteActualizarDTO aspirante)
        {
            Aspirante resultAspirante = _aspiranteService.Update(_mapper.Map<Aspirante>(aspirante));
            return Ok(_mapper.Map<AspiranteConsultarDTO>(resultAspirante));
        }

    }
}
