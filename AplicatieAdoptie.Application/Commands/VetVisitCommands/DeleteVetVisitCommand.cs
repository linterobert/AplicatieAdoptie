using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.VetVisitCommands
{
    public class DeleteVetVisitCommand : IRequest<VetVisit>
    {
        public int VetVisitId { get; set; }
    }
}
