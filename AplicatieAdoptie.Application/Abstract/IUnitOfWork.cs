namespace AplicatieAdoptie.Application.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        public IAnimalRepository AnimalRepository { get; }
        public IMessageRepository MessageRepository { get; }
        public IVetClinicRepository VetClinicRepository { get; }
        public IVetVisitRepository VetVisitRepository { get; }
        public IAdRepository AdRepository { get; }

        Task Save();
    }
}
