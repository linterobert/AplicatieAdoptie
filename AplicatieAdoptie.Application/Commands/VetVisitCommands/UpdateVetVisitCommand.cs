using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.VetVisitCommands
{
    public class UpdateVetVisitCommand : IRequest<VetVisit>
    {
        public int VetVisitId {  get; set; }
        public DateTime Date { get; set; }
        public string Purpose { get; set; }
        public string Notes { get; set; }
        public int VetClinicId { get; set; }
        public int AnimalId { get; set; }
    }
}
