using AutoMapper;
using LasPepas.Entidades;
using LasPepas.Entidades.Dtos;

namespace LasPepas.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Prenda, PrendaDTO>().ReverseMap();
            CreateMap<PrendaCreacionDTO, Prenda>().ReverseMap();
            CreateMap<Caja, CajaDTO>().ReverseMap();
            CreateMap<CajaCreacionDTO, Caja>().ReverseMap();
        }
    }
}
