namespace AplicatieAdoptie.Domain.DTOs.VetVisitDTOs
{
    public class CreateVetVisitDTO
    {
        public DateTime Date { get; set; }
        public string Purpose { get; set; }
        public string Notes { get; set; }
        public int VetClinicId { get; set; }
        public int AnimalId { get; set; }
    }
}
