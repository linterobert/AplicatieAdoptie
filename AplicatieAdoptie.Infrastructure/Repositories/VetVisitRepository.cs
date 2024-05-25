using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AplicatieAdoptie.Infrastructure.Repositories
{
    public class VetVisitRepository : GenericRepository<VetVisit>, IVetVisitRepository
    {
        public VetVisitRepository(AplicatieAdoptieContext _context) : base(_context) { }

        public Task<List<VetVisit>> GetVetVisitsByAnimalId(int animalId)
        {
            return _context.VetVisits.Where(vetVisit => vetVisit.AnimalId == animalId).ToListAsync();
        }

        public Task<List<VetVisit>> GetVetVisitsByClinicId(int clinicId)
        {
            return _context.VetVisits.Where(vetVisit => vetVisit.VetClinicId == clinicId).ToListAsync();
        }
    }
}
