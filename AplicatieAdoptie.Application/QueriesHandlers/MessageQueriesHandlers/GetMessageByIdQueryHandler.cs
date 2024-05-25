using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.MessageQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.MessageQueriesHandlers
{
    public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, Message>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetMessageByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Message> Handle(GetMessageByIdQuery query, CancellationToken cancellationToken)
        {
            var message = await unitOfWork.MessageRepository.GetByIdAsync(query.MessageId);

            if (message == null)
            {
                return null;
            }

            return message;
        }
    }
}
