using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.MessageComands
{
    public class DeleteMessageCommand : IRequest<Message>
    {
        public int MessageId { get; set; }
    }
}
