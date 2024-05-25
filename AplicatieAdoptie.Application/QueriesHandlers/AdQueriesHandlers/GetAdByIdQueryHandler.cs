using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.AdQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.AdQueriesHandlers
{
    public class GetAdByIdQueryHandler : IRequestHandler<GetAdByIdQuery, Ad>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAdByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Ad> Handle(GetAdByIdQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.AdRepository.GetByIdAsync(query.AdId);
        }
    }
}
