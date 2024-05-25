using AplicatieAdoptie.Domain.Domain;
using MediatR;
namespace AplicatieAdoptie.Application.Commands.MessageComands
{
    public class CreateMessageCommand : IRequest<Message>
    {
        public string Content { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
    }
}
