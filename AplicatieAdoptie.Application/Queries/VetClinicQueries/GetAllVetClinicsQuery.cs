using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Queries.VetClinicQueries
{
    public class GetAllVetClinicsQuery : IRequest<List<VetClinic>>
    {
    }
}
