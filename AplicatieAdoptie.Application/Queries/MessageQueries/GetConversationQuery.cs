using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.MessageQueries
{
    public class GetConversationQuery : IRequest<List<Message>>
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
    }
}
