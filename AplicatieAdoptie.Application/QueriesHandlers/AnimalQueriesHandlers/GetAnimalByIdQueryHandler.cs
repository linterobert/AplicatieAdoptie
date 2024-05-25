using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.AnimalQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.AnimalQueriesHandlers
{
    public class GetAnimalByIdQueryHandler : IRequestHandler<GetAnimalByIdQuery, Animal>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAnimalByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Animal> Handle(GetAnimalByIdQuery query, CancellationToken cancellationToken)
        {
            var animal = await _unitOfWork.AnimalRepository.GetByIdAsync(query.AnimalId);

            if (animal == null)
            {
                return null;
            }

            return animal;
        }
    }
}
