using AplicatieAdoptie.Application.Commands.VetClinicCommands;
using AplicatieAdoptie.Application.Queries.VetClinicQueries;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Domain.DTOs.VetClinicDTOs;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AplicatieAdoptie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VetClinicController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public VetClinicController(IMediator mediator, ILogger<VetClinic> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVetClinic(CreateVetClinicDTO createVetClinicDTO, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Create new vet clinic");
            var command = _mapper.Map<CreateVetClinicCommand>(createVetClinicDTO);

            var result = await _mediator.Send(command, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVetClinicById(int id)
        {
            _logger.LogInformation($"Get Vet Clinic with ID {id}");

            var query = new GetVetClinicByIdQuery()
            {
                VetClinicId = id
            };

            var result = await _mediator.Send(query);
            if (result == null)
            {
                _logger.LogError("Vet Clinic not found!");
                return NotFound("Vet Clinic not found!");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVetClinics()
        {
            _logger.LogInformation("Get all Vet Clinics");

            var query = new GetAllVetClinicsQuery();

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVetClinic(int id, UpdateVetClinicDTO dto)
        {
            _logger.LogInformation($"Update Vet Clinic with ID {id}");

            var command = _mapper.Map<UpdateVetClinicCommand>(dto);
            command.VetClinicId = id;

            var result = await _mediator.Send(command);
            if (result == null)
            {
                _logger.LogError($"Vet Clinic with id {id} not found!");
                return NotFound($"Vet Clinic with id {id} not found!");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVetClinic(int id)
        {
            _logger.LogInformation($"Delete Vet Clinic with ID {id}");
            var command = new DeleteVetClinicCommand()
            {
                VetClinicId = id
            };

            var animal = await _mediator.Send(command);

            if (animal == null)
            {
                _logger.LogError("Vet Clinic not found");
                return NotFound("Vet Clinic not found");
            }
            return NoContent();
        }
    }
}
