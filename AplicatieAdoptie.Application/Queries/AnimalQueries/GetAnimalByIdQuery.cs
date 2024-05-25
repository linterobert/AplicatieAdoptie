using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.AnimalQueries
{
    public class GetAnimalByIdQuery : IRequest<Animal>
    {
        public int AnimalId {  get; set; }
    }
}
