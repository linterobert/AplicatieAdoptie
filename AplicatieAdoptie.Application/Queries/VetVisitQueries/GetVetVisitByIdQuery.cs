using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.VetVisitQueries
{
    public class GetVetVisitByIdQuery : IRequest<VetVisit>
    {
        public int VetVisitId {  get; set; }
    }
}
