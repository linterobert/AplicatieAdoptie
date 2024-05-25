using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.MessageComands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.MessageCommandsHandlers
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, Message>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteMessageCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Message> Handle(DeleteMessageCommand command, CancellationToken cancellationToken)
        {
            var message = await unitOfWork.MessageRepository.GetByIdAsync(command.MessageId);

            if (message == null)
            {
                return null;
            }

            unitOfWork.MessageRepository.Delete(message);
            await unitOfWork.Save();

            return message;
        }
    }
}
