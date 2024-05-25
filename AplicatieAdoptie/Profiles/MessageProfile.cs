using AplicatieAdoptie.Application.Commands.MessageComands;
using AplicatieAdoptie.Application.Queries.MessageQueries;
using AplicatieAdoptie.Domain.DTOs.MessageDTOs;
using AutoMapper;

namespace AplicatieAdoptie.Web.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile() 
        {
            CreateMap<CreateMessageDTO, CreateMessageCommand>().ReverseMap();
            CreateMap<GetConversationDTO, GetConversationQuery>().ReverseMap();
            CreateMap<UpdateMessageDTO, UpdateMessageCommand>().ReverseMap();
        }
    }
}
