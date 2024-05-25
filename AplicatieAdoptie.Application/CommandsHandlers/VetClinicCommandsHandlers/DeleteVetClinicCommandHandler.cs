using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.VetClinicCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.VetClinicCommandsHandlers
{
    public class DeleteVetClinicCommandHandler : IRequestHandler<DeleteVetClinicCommand, VetClinic>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteVetClinicCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<VetClinic> Handle(DeleteVetClinicCommand command, CancellationToken cancellationToken)
        {
            var vetClinic = await _unitOfWork.VetClinicRepository.GetByIdAsync(command.VetClinicId);

            if (vetClinic == null)
            {
                return null;
            }

            _unitOfWork.VetClinicRepository.Delete(vetClinic);
            await _unitOfWork.Save();
            return vetClinic;
        }
    }
}
