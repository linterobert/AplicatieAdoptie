using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Infrastructure.Data;

namespace AplicatieAdoptie.Infrastructure.Repositories
{
    public class AdRepository : GenericRepository<Ad>, IAdRepository
    {
        public AdRepository(AplicatieAdoptieContext _context) : base(_context) { }
    }
}
