using AplicatieAdoptie.Domain.Domain;

namespace AplicatieAdoptie.Application.Abstract
{
    public interface IVetVisitRepository : IGenericRepository<VetVisit>
    {
        Task<List<VetVisit>> GetVetVisitsByClinicId(int clinicId);  
        Task<List<VetVisit>> GetVetVisitsByAnimalId(int animalId);
    }
}
