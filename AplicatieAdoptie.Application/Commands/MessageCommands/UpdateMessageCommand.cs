using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.MessageComands
{
    public class UpdateMessageCommand : IRequest<Message>
    {
        public int MessageId { get; set; }
        public string Content { get; set; }
    }
}
