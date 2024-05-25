using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.MessageComands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.MessageCommandsHandlers
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, Message>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateMessageCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Message> Handle(CreateMessageCommand command, CancellationToken cancellationToken)
        {
            var message = new Message();
            message.SenderId = command.SenderId;
            message.ReceiverId = command.ReceiverId;
            message.Content = command.Content;
            message.Created = DateTime.Now;

            await unitOfWork.MessageRepository.Create(message);
            await unitOfWork.Save();

            return message;
        }
    }
}
