using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Infrastructure.Data;

namespace AplicatieAdoptie.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AplicatieAdoptieContext _context;
        public IAnimalRepository AnimalRepository { get; private set; }
        public IMessageRepository MessageRepository { get; private set; }
        public IVetClinicRepository VetClinicRepository { get; private set; }
        public IVetVisitRepository VetVisitRepository { get; private set; }
        public IAdRepository AdRepository { get; private set; }

        public UnitOfWork(AplicatieAdoptieContext context, IAnimalRepository animalRepository, IMessageRepository messageRepository, IVetClinicRepository vetClinicRepository, IVetVisitRepository vetVisitRepository, IAdRepository adRepository)
        {
            _context = context;
            AnimalRepository = animalRepository;
            MessageRepository = messageRepository;
            VetClinicRepository = vetClinicRepository;
            VetVisitRepository = vetVisitRepository;
            AdRepository = adRepository;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
