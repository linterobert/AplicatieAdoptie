using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.VetClinicCommands
{
    public class CreateVetClinicCommand : IRequest<VetClinic>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OperatingHours { get; set; }
    }
}
