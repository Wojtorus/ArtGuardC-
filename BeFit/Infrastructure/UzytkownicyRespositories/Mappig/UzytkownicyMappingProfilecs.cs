using AutoMapper;
using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Infrastructure.CwiczenieRepositories.Mapping;
using BeFit.Infrastructure.UzytkownicyRespositories.DTO;
using BeFit.Models;

namespace BeFit.Infrastructure.UzytkownicyRespositories.Mappig
{
    public class UzytkownicyMappingProfilecs : Profile
    {
        public UzytkownicyMappingProfilecs()
        {
                CreateMap<UzytkownikDTO, Uzytkownicy>().ReverseMap();
        }
    }
}
