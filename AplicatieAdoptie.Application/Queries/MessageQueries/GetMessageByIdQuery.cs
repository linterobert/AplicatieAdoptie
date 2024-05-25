using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.MessageQueries
{
    public class GetMessageByIdQuery : IRequest<Message>
    {
        public int MessageId { get; set; }
    }
}
