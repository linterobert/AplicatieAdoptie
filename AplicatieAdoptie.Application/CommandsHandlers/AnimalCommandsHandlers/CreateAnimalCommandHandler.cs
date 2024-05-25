using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.AnimalCommands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.AnimalCommandsHandlers
{
    public class CreateAnimalCommandHandler : IRequestHandler<CreateAnimalCommand, Animal>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateAnimalCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Animal> Handle(CreateAnimalCommand command,CancellationToken cancellationToken)
        {
            var animal = new Animal();
            animal.HealthInfo = command.HealthInfo;
            animal.Name = command.Name;
            animal.BirthDate = command.BirthDate;
            animal.Breed = command.Breed;
            animal.History = command.History;
            animal.Sex = command.Sex;

            await _unitOfWork.AnimalRepository.Create(animal);
            await _unitOfWork.Save();
            return animal;
        }
    }
}
