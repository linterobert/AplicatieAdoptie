using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AplicatieAdoptie.Infrastructure.Repositories
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(AplicatieAdoptieContext _context) : base(_context) { }

        public Task<List<Message>> GetConversation(string SenderId, string ReceiverId)
        {
            return _context.Messages.Where(message => (message.SenderId == SenderId && message.ReceiverId == ReceiverId) || (message.SenderId == ReceiverId && message.ReceiverId == SenderId)).OrderBy(message => message.Created).ToListAsync();
        }
    }
}
