using AplicatieAdoptie.Domain.Domain;

namespace AplicatieAdoptie.Application.Abstract
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        Task<List<Message>> GetConversation(string SenderId, string ReceiverId);
    }
}
