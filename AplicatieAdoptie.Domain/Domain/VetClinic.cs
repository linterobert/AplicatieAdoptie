namespace AplicatieAdoptie.Domain.Domain
{
    public class VetClinic
    {
        public int VetClinicId {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OperatingHours { get; set; }

        //relatii
        public List<VetVisit> VetVisits { get; set; }
    }
}
