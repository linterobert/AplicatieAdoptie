using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.AnimalQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.AnimalQueriesHandlers
{
    public class GetAllAnimalsQueryHandler : IRequestHandler<GetAllAnimalsQuery, List<Animal>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllAnimalsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Animal>> Handle(GetAllAnimalsQuery query, CancellationToken cancellationToken)
        {
            return await _unitOfWork.AnimalRepository.GetAll();
        }
    }
}
