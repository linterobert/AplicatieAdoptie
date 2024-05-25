using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.MessageQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.MessageQueriesHandlers
{
    public class GetConversationQueryHandler : IRequestHandler<GetConversationQuery, List<Message>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetConversationQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Message>> Handle(GetConversationQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.MessageRepository.GetConversation(query.SenderId, query.ReceiverId);
        }
    }
}
