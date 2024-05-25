using AplicatieAdoptie.Domain.Domain;
using MediatR;
namespace AplicatieAdoptie.Application.Queries.VetClinicQueries
{
    public class GetVetClinicByIdQuery : IRequest<VetClinic>
    {
        public int VetClinicId { get; set; }
    }
}
