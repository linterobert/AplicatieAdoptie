using MediatR;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Domain.Enums;

namespace AplicatieAdoptie.Application.Commands.AnimalCommands
{
    public class CreateAnimalCommand : IRequest<Animal>
    {
        public string Name { get; set; }
        public AnimalBreed Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string HealthInfo { get; set; }
        public string History { get; set; }
    }
}
