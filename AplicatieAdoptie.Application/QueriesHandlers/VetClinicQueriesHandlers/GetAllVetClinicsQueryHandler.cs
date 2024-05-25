using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Queries.VetClinicQueries;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.QueriesHandlers.VetClinicQueriesHandlers
{
    public class GetAllVetClinicsQueryHandler : IRequestHandler<GetAllVetClinicsQuery, List<VetClinic>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllVetClinicsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<VetClinic>> Handle(GetAllVetClinicsQuery query, CancellationToken cancellationToken)
        {
            return await unitOfWork.VetClinicRepository.GetAll();
        }
    }
}
