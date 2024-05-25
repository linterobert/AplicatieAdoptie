using AplicatieAdoptie.Domain.Domain;
using MediatR;

namespace AplicatieAdoptie.Application.Commands.AnimalCommands
{
    public class DeleteAnimalCommand : IRequest<Animal>
    {
        public int AnimalId { get; set; }
    }
}
