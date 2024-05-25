using AplicatieAdoptie.Application.Commands.VetVisitCommands;
using AplicatieAdoptie.Application.Queries.VetVisitQueries;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Domain.DTOs.VetVisitDTOs;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AplicatieAdoptie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VetVisitController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public VetVisitController(IMediator mediator, ILogger<VetVisit> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVetVisit(CreateVetVisitDTO dto, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Create new vet visit");

            var command = _mapper.Map<CreateVetVisitCommand>(dto);

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVetVisitById(int id)
        {
            _logger.LogInformation($"Get Vet Visit with ID {id}");

            var query = new GetVetVisitByIdQuery()
            {
                VetVisitId = id
            };

            var result = await _mediator.Send(query);
            if (result == null)
            {
                _logger.LogError("Vet Visit not found!");
                return NotFound("Vet Visit not found!");
            }

            return Ok(result);
        }

        [HttpGet("VetClinic/{clinicID}")]
        public async Task<IActionResult> GetVetVisitsByClinicId(int clinicID)
        {
            _logger.LogInformation($"Get Vet Visits for clinic with id {clinicID}");

            var query = new GetVetVisitsByClinicIdQuery
            {
                VetClinicId = clinicID
            };

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("AnimalId/{animalID}")]
        public async Task<IActionResult> GetVetVisitsByAnimalId(int animalID)
        {
            _logger.LogInformation($"Get Vet Visits for animal with id {animalID}");

            var query = new GetVetVisitsByAnimalIdQuery
            {
                AnimalId = animalID
            };

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVetVisit(int id, UpdateVetVisitDTO dto)
        {
            _logger.LogInformation($"Update Vet Visit with ID {id}");

            var command = _mapper.Map<UpdateVetVisitCommand>(dto);
            command.VetVisitId = id;

            var result = await _mediator.Send(command);
            if (result == null)
            {
                _logger.LogError($"Vet Visit with id {id} not found!");
                return NotFound($"Vet Visit with id {id} not found!");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVetVisit(int id)
        {
            _logger.LogInformation($"Delete Vet Visit with ID {id}");
            var command = new DeleteVetVisitCommand()
            {
                VetVisitId = id
            };

            var animal = await _mediator.Send(command);

            if (animal == null)
            {
                _logger.LogError("Vet Visit not found");
                return NotFound("Vet Visit not found");
            }
            return NoContent();
        }
    }
}
