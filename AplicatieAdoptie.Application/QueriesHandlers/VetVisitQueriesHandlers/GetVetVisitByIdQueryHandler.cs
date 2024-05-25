using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.VetVisitQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.VetVisitQueriesHandlers
{
    public class GetVetVisitByIdQueryHandler : IRequestHandler<GetVetVisitByIdQuery, VetVisit>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetVetVisitByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<VetVisit> Handle(GetVetVisitByIdQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.VetVisitRepository.GetByIdAsync(query.VetVisitId);
        }
    }
}
