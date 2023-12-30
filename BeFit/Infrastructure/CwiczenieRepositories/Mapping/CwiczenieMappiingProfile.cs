using AutoMapper;
using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BeFit.Infrastructure.CwiczenieRepositories.Mapping
{
    public class CwiczenieMappiingProfile : Profile
    {
        public CwiczenieMappiingProfile()
        {
            CreateMap<CwiczenieDTO, Cwiczenie>().ReverseMap();
        }
    }
}
