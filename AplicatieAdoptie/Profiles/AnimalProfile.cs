using AplicatieAdoptie.Application.Commands.AnimalCommands;
using AplicatieAdoptie.Domain.DTOs.AnimalDTOs;
using AutoMapper;

namespace AplicatieAdoptie.Web.Profiles
{
    public class AnimalProfile : Profile
    {
        public AnimalProfile() 
        {
            CreateMap<CreateAnimalDTO, CreateAnimalCommand>().ReverseMap();
            CreateMap<UpdateAnimalDTO, UpdateAnimalCommand>().ReverseMap();
        }
    }
}
