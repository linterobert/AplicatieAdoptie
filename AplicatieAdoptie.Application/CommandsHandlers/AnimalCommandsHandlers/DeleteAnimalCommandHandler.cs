using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.AnimalCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.AnimalCommandsHandlers
{
    public class DeleteAnimalCommandHandler : IRequestHandler<DeleteAnimalCommand, Animal>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteAnimalCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Animal> Handle(DeleteAnimalCommand command, CancellationToken cancellationToken)
        {
            var animal = await unitOfWork.AnimalRepository.GetByIdAsync(command.AnimalId);

            if(animal == null)
            {
                return null;
            }

            unitOfWork.AnimalRepository.Delete(animal);
            await unitOfWork.Save();

            return animal;
        }
    }
}
