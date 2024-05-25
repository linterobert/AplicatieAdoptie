using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.AdQueries
{
    public class GetAllAdsQuery : IRequest<List<Ad>>
    {
    }
}
