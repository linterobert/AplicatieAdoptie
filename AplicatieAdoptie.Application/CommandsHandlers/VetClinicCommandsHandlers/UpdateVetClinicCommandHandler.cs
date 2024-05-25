using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.VetClinicCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.VetClinicCommandsHandlers
{
    public class UpdateVetClinicCommandHandler : IRequestHandler<UpdateVetClinicCommand, VetClinic>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateVetClinicCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<VetClinic> Handle(UpdateVetClinicCommand command, CancellationToken cancellationToken)
        {
            var vetClinic = await _unitOfWork.VetClinicRepository.GetByIdAsync(command.VetClinicId);

            if (vetClinic == null)
            {
                return null;
            }

            vetClinic.Phone = command.Phone;
            vetClinic.Address = command.Address;
            vetClinic.Name = command.Name;
            vetClinic.OperatingHours = command.OperatingHours;

            await _unitOfWork.VetClinicRepository.Update(vetClinic);
            await _unitOfWork.Save();

            return vetClinic;
        }
    }
}
