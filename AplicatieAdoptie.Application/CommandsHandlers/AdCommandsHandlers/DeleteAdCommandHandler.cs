using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.AdCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.AdCommandsHandlers
{
    public class DeleteAdCommandHandler : IRequestHandler<DeleteAdCommand, Ad>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteAdCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Ad> Handle(DeleteAdCommand command, CancellationToken cancellationToken)
        {
            var ad = await unitOfWork.AdRepository.GetByIdAsync(command.AdId);

            if (ad == null)
            {
                return null;
            }

            unitOfWork.AdRepository.Delete(ad);
            await unitOfWork.Save();

            return ad;
        }
    }
}
