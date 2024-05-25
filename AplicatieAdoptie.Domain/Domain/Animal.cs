using AplicatieAdoptie.Domain.Enums;

namespace AplicatieAdoptie.Domain.Domain
{
    public class Animal
    {
        public int AnimalId {  get; set; }
        public string Name { get; set; }
        public AnimalBreed Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string HealthInfo { get; set; }
        public string History { get; set; }

        //relatii
        public List<VetVisit> VetVisits { get; set; }

        public List<Ad> Ads {  get; set; }
    }
}
