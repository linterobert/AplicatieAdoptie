using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.VetClinicCommands
{
    public class DeleteVetClinicCommand : IRequest<VetClinic>
    {
        public int VetClinicId { get; set; }
    }
}
