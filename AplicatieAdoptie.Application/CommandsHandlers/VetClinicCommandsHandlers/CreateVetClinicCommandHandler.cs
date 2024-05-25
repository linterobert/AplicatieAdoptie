using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.VetClinicCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.VetClinicCommandsHandlers
{
    public class CreateVetClinicCommandHandler : IRequestHandler<CreateVetClinicCommand, VetClinic>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateVetClinicCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<VetClinic> Handle(CreateVetClinicCommand command, CancellationToken cancellationToken)
        {
            var vetClinic = new VetClinic();
            vetClinic.Address = command.Address;
            vetClinic.Phone = command.Phone;
            vetClinic.OperatingHours = command.OperatingHours;
            vetClinic.Name = command.Name;

            await unitOfWork.VetClinicRepository.Create(vetClinic);
            await unitOfWork.Save();

            return vetClinic;   
        }
    }
}
