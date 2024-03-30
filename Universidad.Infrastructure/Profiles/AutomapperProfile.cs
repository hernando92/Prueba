using AutoMapper;
using Universidad.Domain.DTO;
using Universidad.Domain.Entities;

namespace Universidad.Infrastructure.Profiles
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<TipoProgramaAcademico, TipoProgramaAcademicoDTO>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoDTO>().ReverseMap();

            CreateMap<ProgramaAcademico, ProgramaAcademicoActualizarDTO>().ReverseMap();
            CreateMap<ProgramaAcademico, ProgramaAcademicoCrearDTO>().ReverseMap();
            CreateMap<ProgramaAcademico, ProgramaAcademicoConsultarDTO>().ReverseMap();

            CreateMap<Aspirante, AspiranteActualizarDTO>().ReverseMap();
            CreateMap<Aspirante, AspiranteCrearDTO>().ReverseMap();
            CreateMap<Aspirante, AspiranteConsultarDTO>().ReverseMap();

            CreateMap<Matricula, MatriculaActualizarDTO>().ReverseMap();
            CreateMap<Matricula, MatriculaConsultarDTO>().ReverseMap();
            CreateMap<Matricula, MatriculaCrearDTO>().ReverseMap();
        }
    }
}
