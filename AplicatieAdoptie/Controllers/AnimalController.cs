using AplicatieAdoptie.Application.Commands.AnimalCommands;
using AplicatieAdoptie.Application.Queries.AnimalQueries;
using AplicatieAdoptie.Domain.DTOs.AnimalDTOs;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AplicatieAdoptie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public AnimalController(IMediator mediator, ILogger<AnimalController> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnimal(CreateAnimalDTO createAnimalDTO, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Create new animal");
            var command = _mapper.Map<CreateAnimalCommand>(createAnimalDTO);

            var result = await _mediator.Send(command, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimalById(int id)
        {
            _logger.LogInformation($"Get animal with ID {id}");

            var query = new GetAnimalByIdQuery()
            {
                AnimalId = id
            };

            var result = await _mediator.Send(query);
            if (result == null)
            {
                _logger.LogError("Animal not found!");
                return NotFound("Animal not found!");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnimals()
        {
            _logger.LogInformation("Get all animals");

            var query = new GetAllAnimalsQuery();

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnimal(int id, UpdateAnimalDTO dto)
        {
            _logger.LogInformation($"Update animal with ID {id}");

            var command = _mapper.Map<UpdateAnimalCommand>(dto);
            command.AnimalId = id;

            var result = await _mediator.Send(command);
            if(result == null)
            {
                _logger.LogError($"Animal with id {id} not found!");
                return NotFound($"Animal with id {id} not found!");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            _logger.LogInformation($"Delete animal with ID {id}");
            var command = new DeleteAnimalCommand()
            {
                AnimalId = id
            };

            var animal = await _mediator.Send(command);

            if (animal == null)
            {
                _logger.LogError("Animal not found");
                return NotFound("Animal not found");
            }
            return NoContent();
        }
    }
}
