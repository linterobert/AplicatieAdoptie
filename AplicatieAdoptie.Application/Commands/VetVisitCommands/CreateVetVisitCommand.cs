using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.VetVisitCommands
{
    public class CreateVetVisitCommand : IRequest<VetVisit>
    {
        public DateTime Date { get; set; }
        public string Purpose { get; set; }
        public string Notes { get; set; }
        public int VetClinicId { get; set; }
        public int AnimalId { get; set; }
    }
}
