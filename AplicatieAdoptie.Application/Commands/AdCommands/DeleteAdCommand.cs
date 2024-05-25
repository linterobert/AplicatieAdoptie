using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.AdCommands
{
    public class DeleteAdCommand : IRequest<Ad>
    {
        public int AdId { get; set; }
    }
}
