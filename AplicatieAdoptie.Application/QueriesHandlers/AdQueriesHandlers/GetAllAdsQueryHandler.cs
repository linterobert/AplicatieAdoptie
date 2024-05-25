using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.AdQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.AdQueriesHandlers
{
    public class GetAllAdsQueryHandler : IRequestHandler<GetAllAdsQuery, List<Ad>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllAdsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Ad>> Handle(GetAllAdsQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.AdRepository.GetAll();
        }
    }
}
