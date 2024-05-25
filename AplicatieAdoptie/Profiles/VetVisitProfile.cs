using AplicatieAdoptie.Application.Commands.VetVisitCommands;
using AplicatieAdoptie.Domain.DTOs.VetVisitDTOs;
using AutoMapper;

namespace AplicatieAdoptie.Web.Profiles
{
    public class VetVisitProfile : Profile
    {
        public VetVisitProfile()
        {
            CreateMap<CreateVetVisitDTO, CreateVetVisitCommand>().ReverseMap();
            CreateMap<UpdateVetVisitDTO, UpdateVetVisitCommand>().ReverseMap();
        }
    }
}
