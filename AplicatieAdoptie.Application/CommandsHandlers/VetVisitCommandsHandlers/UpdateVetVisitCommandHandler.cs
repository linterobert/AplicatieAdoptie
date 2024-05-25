using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.VetVisitCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.VetVisitCommandsHandlers
{
    public class UpdateVetVisitCommandHandler : IRequestHandler<UpdateVetVisitCommand, VetVisit>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateVetVisitCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<VetVisit> Handle(UpdateVetVisitCommand command, CancellationToken cancellationToken)
        {
            var vetVisit = await unitOfWork.VetVisitRepository.GetByIdAsync(command.VetVisitId);

            if (vetVisit == null)
            {
                return null;
            }

            vetVisit.Purpose = command.Purpose;
            vetVisit.VetClinicId = command.VetClinicId;
            vetVisit.AnimalId = command.AnimalId;
            vetVisit.Date = command.Date;
            vetVisit.Notes = command.Notes;

            await unitOfWork.VetVisitRepository.Update(vetVisit);
            await unitOfWork.Save();

            return vetVisit;
        }
    }
}
