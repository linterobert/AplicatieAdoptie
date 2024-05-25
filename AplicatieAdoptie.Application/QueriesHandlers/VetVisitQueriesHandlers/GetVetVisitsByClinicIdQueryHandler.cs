using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.VetVisitQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.VetVisitQueriesHandlers
{
    public class GetVetVisitsByClinicIdQueryHandler : IRequestHandler<GetVetVisitsByClinicIdQuery, List<VetVisit>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetVetVisitsByClinicIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<VetVisit>> Handle(GetVetVisitsByClinicIdQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.VetVisitRepository.GetVetVisitsByClinicId(query.VetClinicId);
        }
    }
}
