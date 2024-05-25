using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.AnimalQueries
{
    public class GetAllAnimalsQuery : IRequest<List<Animal>>
    {
    }
}
