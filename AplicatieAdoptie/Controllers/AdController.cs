using AplicatieAdoptie.Application.Commands.AdCommands;
using AplicatieAdoptie.Application.Queries.AdQueries;
using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Domain.DTOs.AdDTOs;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AplicatieAdoptie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public AdController(IMediator mediator, ILogger<Ad> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAd(CreateAdDTO createAdDTO, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Create new ad");
            var command = _mapper.Map<CreateAdCommand>(createAdDTO);

            var result = await _mediator.Send(command, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdById(int id)
        {
            _logger.LogInformation($"Get ad with ID {id}");

            var query = new GetAdByIdQuery()
            {
                AdId = id
            };

            var result = await _mediator.Send(query);
            if (result == null)
            {
                _logger.LogError("Ad not found!");
                return NotFound("Ad not found!");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAds()
        {
            _logger.LogInformation("Get all ads");

            var query = new GetAllAdsQuery();

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAd(int id, UpdateAdDTO dto)
        {
            _logger.LogInformation($"Update ad with ID {id}");

            var command = _mapper.Map<UpdateAdCommand>(dto);
            command.AdId = id;

            var result = await _mediator.Send(command);
            if (result == null)
            {
                _logger.LogError($"Ad with id {id} not found!");
                return NotFound($"Ad with id {id} not found!");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAd(int id)
        {
            _logger.LogInformation($"Delete ad with ID {id}");
            var command = new DeleteAdCommand()
            {
                AdId = id
            };

            var ad = await _mediator.Send(command);

            if (ad == null)
            {
                _logger.LogError("Ad not found");
                return NotFound("Ad not found");
            }
            return NoContent();
        }
    }
}
