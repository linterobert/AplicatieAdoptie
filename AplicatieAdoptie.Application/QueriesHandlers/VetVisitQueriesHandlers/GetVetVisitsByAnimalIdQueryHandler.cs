using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.VetVisitQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.VetVisitQueriesHandlers
{
    public class GetVetVisitsByAnimalIdQueryHandler : IRequestHandler<GetVetVisitsByAnimalIdQuery, List<VetVisit>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetVetVisitsByAnimalIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<VetVisit>> Handle(GetVetVisitsByAnimalIdQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.VetVisitRepository.GetVetVisitsByAnimalId(query.AnimalId);
        }
    }
}
