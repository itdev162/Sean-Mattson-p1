using AutoMapper;
using Sean_Mattson_p1.Dtos.Character;
using Sean_Mattson_p1.Models;

namespace Sean_Mattson_p1
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>(); 
            CreateMap<AddCharacterDto, Character>();
        }
    }
}