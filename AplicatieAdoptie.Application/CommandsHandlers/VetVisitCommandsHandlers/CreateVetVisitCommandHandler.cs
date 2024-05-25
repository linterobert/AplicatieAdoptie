using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.VetVisitCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.VetVisitCommandsHandlers
{
    public class CreateVetVisitCommandHandler : IRequestHandler<CreateVetVisitCommand, VetVisit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateVetVisitCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<VetVisit> Handle(CreateVetVisitCommand command, CancellationToken cancellationToken)
        {
            var vetVisit = new VetVisit();
            vetVisit.Purpose = command.Purpose;
            vetVisit.AnimalId = command.AnimalId;
            vetVisit.VetClinicId = command.VetClinicId;
            vetVisit.Date = command.Date;
            vetVisit.Notes = command.Notes;

            await unitOfWork.VetVisitRepository.Create(vetVisit);
            await unitOfWork.Save();

            return vetVisit;
        }
    }
}
