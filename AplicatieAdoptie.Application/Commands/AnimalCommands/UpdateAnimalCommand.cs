using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Domain.Enums;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.AnimalCommands
{
    public class UpdateAnimalCommand : IRequest<Animal>
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public AnimalBreed Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string HealthInfo { get; set; }
        public string History { get; set; }
    }
}
