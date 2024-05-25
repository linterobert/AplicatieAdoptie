using AplicatieAdoptie.Application.Commands.VetClinicCommands;
using AplicatieAdoptie.Domain.DTOs.VetClinicDTOs;
using AutoMapper;

namespace AplicatieAdoptie.Web.Profiles
{
    public class VetClinicProfile : Profile
    {
        public VetClinicProfile()
        {
            CreateMap<CreateVetClinicDTO, CreateVetClinicCommand>().ReverseMap();   
            CreateMap<UpdateVetClinicDTO, UpdateVetClinicCommand>().ReverseMap();
        }
    }
}
