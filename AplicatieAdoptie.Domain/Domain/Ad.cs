using AplicatieAdoptie.Domain.Enums;

namespace AplicatieAdoptie.Domain.Domain
{
    public class Ad
    {
        public int AdId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Birthdate { get; set; }
        public Sex Sex { get; set; }
        public Boolean IsSterilized {  get; set; }
        public byte[] Picture { get; set; }
        public byte[] Video { get; set; }
        public DateTime PostDate { get; set; }
        
        //relatii
        public int AnimalId {  get; set; }
        public Animal Animal { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
