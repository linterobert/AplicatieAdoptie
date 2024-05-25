using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.AdCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.AdCommandsHandlers
{
    public class UpdateAdCommandHandler : IRequestHandler<UpdateAdCommand, Ad>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateAdCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Ad> Handle(UpdateAdCommand command, CancellationToken cancellationToken)
        {
            var ad = await unitOfWork.AdRepository.GetByIdAsync(command.AdId);

            if (ad == null)
            {
                return null;
            }

            ad.Title = command.Title;
            ad.Description = command.Description;
            ad.Birthdate = command.Birthdate;
            ad.Sex = command.Sex;
            ad.IsSterilized = command.IsSterilized;
            ad.Picture = command.Picture;
            ad.Video = command.Video;
            ad.PostDate = command.PostDate;
            ad.AnimalId = command.AnimalId;
            ad.UserId = command.UserId;

            await unitOfWork.AdRepository.Update(ad);
            await unitOfWork.Save();

            return ad;
        }
    }
}
