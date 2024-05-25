using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.AdQueries
{
    public class GetAdByIdQuery : IRequest<Ad>
    {
        public int AdId { get; set; }
    }
}
