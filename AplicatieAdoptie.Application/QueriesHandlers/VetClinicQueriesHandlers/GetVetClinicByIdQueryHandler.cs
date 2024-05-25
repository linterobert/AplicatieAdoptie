using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.VetClinicQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.VetClinicQueriesHandlers
{
    public class GetVetClinicByIdQueryHandler : IRequestHandler<GetVetClinicByIdQuery, VetClinic>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetVetClinicByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<VetClinic> Handle(GetVetClinicByIdQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.VetClinicRepository.GetByIdAsync(request.VetClinicId);
        }
    }
}
