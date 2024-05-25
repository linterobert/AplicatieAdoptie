using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.VetVisitCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.VetVisitCommandsHandlers
{
    public class DeleteVetVisitCommandHandler : IRequestHandler<DeleteVetVisitCommand, VetVisit>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteVetVisitCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<VetVisit> Handle(DeleteVetVisitCommand command, CancellationToken cancellationToken)
        {
            var vetVisit = await unitOfWork.VetVisitRepository.GetByIdAsync(command.VetVisitId);

            if (vetVisit == null)
            {
                return null;
            }

            unitOfWork.VetVisitRepository.Delete(vetVisit);
            await unitOfWork.Save();

            return vetVisit;
        }
    }
}
