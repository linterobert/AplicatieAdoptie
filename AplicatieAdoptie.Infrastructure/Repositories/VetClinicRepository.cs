using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Infrastructure.Data;

namespace AplicatieAdoptie.Infrastructure.Repositories
{
    public class VetClinicRepository : GenericRepository<VetClinic>, IVetClinicRepository
    {
        public VetClinicRepository(AplicatieAdoptieContext _context) : base(_context) { }
    }
}
