using AplicatieAdoptie.Application.Abstract;
using AplicatieAdoptie.Application.Commands.MessageComands;
using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.CommandsHandlers.MessageCommandsHandlers
{
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand, Message>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateMessageCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Message> Handle(UpdateMessageCommand command, CancellationToken cancellationToken)
        {
            var message = await unitOfWork.MessageRepository.GetByIdAsync(command.MessageId);

            if (message == null)
            {
                return null;
            }

            message.Content = command.Content;

            await unitOfWork.MessageRepository.Update(message);
            await unitOfWork.Save();

            return message;
        }
    }
}
