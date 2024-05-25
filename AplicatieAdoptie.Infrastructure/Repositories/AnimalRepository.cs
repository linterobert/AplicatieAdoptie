using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Infrastructure.Data;

namespace AplicatieAdoptie.Infrastructure.Repositories
{
    public class AnimalRepository : GenericRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(AplicatieAdoptieContext _context) : base(_context) { }
    }
}
