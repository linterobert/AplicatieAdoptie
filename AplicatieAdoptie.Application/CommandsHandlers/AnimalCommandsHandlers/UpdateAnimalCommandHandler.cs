using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.AnimalCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.AnimalCommandsHandlers
{
    public class UpdateAnimalCommandHandler : IRequestHandler<UpdateAnimalCommand, Animal>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateAnimalCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Animal> Handle(UpdateAnimalCommand command, CancellationToken cancellationToken)
        {
            var animal = await unitOfWork.AnimalRepository.GetByIdAsync(command.AnimalId);

            if(animal == null)
            {
                return null;
            }

            animal.Breed = command.Breed;
            animal.HealthInfo = command.HealthInfo;
            animal.BirthDate = command.BirthDate;
            animal.Sex = command.Sex;
            animal.History = command.History;
            animal.Name = command.Name;

            await unitOfWork.AnimalRepository.Update(animal);
            await unitOfWork.Save();

            return animal;
        }
    }
}
