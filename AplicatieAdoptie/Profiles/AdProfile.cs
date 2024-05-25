using AplicatieAdoptie.Application.Commands.AdCommands;
using AplicatieAdoptie.Domain.DTOs.AdDTOs;
using AutoMapper;

namespace AplicatieAdoptie.Web.Profiles
{
    public class AdProfile : Profile
    {
        public AdProfile()
        {
            CreateMap<CreateAdDTO, CreateAdCommand>().ReverseMap();
        }
    }
}
