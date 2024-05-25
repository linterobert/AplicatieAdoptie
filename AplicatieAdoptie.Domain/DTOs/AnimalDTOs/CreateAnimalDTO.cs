using AplicatieAdoptie.Domain.Enums;

namespace AplicatieAdoptie.Domain.DTOs.AnimalDTOs
{
    public class CreateAnimalDTO
    {
        public string Name { get; set; }
        public AnimalBreed Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string HealthInfo { get; set; }
        public string History { get; set; }
    }
}
