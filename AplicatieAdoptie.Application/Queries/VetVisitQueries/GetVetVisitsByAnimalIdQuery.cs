using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.VetVisitQueries
{
    public class GetVetVisitsByAnimalIdQuery : IRequest<List<VetVisit>>
    {
        public int AnimalId { get; set; }
    }
}
