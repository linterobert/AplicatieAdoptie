using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.VetVisitQueries
{
    public class GetVetVisitsByClinicIdQuery : IRequest<List<VetVisit>>
    {
        public int VetClinicId { get; set; }
    }
}
