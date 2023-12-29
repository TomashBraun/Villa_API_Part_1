using System.Runtime.InteropServices.JavaScript;
using AutoMapper;
using Villa_API.Models.Villa;
using Villa_API.Models.Villa.DTO;
using Villa_API.Models.VillaNumberModel;

namespace Villa_API
{
    public class MappingConfig :Profile
    {
        public MappingConfig()
        {
            CreateMap <Villa, VillaDTO>().ReverseMap();
            CreateMap <Villa, VillaCreateDTO>().ReverseMap();
            CreateMap <Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberCreateDTO, VillaNumber>()
                .ForMember(v => v.CreatedDate, o => o.MapFrom(src => DateTime.Now))
                .ForMember(v => v.UpdatedDate, o => o.MapFrom(src => DateTime.Now));

            CreateMap<VillaNumber, VillaNumberCreateDTO>();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
