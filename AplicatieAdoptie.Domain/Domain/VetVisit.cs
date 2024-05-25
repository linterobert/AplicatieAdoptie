namespace AplicatieAdoptie.Domain.Domain
{
    public class VetVisit
    {
        public int VetVisitId {  get; set; }
        public DateTime Date {  get; set; }
        public string Purpose {  get; set; }
        public string Notes { get; set; }

        //relatii
        public int VetClinicId { get; set; }
        public VetClinic VetClinic { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
