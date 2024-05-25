using AplicatieAdoptie.Application.Commands.MessageComands;
using AplicatieAdoptie.Application.Queries.MessageQueries;
using AplicatieAdoptie.Domain.DTOs.MessageDTOs;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AplicatieAdoptie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public MessageController(IMediator mediator, ILogger<MessageController> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDTO createMessageDTO, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Create new message");
            var command = _mapper.Map<CreateMessageCommand>(createMessageDTO);

            var result = await _mediator.Send(command, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            _logger.LogInformation($"Get message with ID {id}");

            var query = new GetMessageByIdQuery()
            {
                MessageId = id
            };

            var result = await _mediator.Send(query);
            if (result == null)
            {
                _logger.LogError("Message not found!");
                return NotFound("Message not found!");
            }

            return Ok(result);
        }

        [HttpGet("receiver/{receiverID}/sender/{senderID}")]
        public async Task<IActionResult> GetConversation(string receiverID, string senderID)
        {
            _logger.LogInformation("Get conversation");
            var query = new GetConversationQuery
            {
                ReceiverId = receiverID,
                SenderId = senderID
            };

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMessage(int id, UpdateMessageDTO dto)
        {
            _logger.LogInformation($"Update message with id {id}");
            var command = _mapper.Map<UpdateMessageCommand>(dto);
            command.MessageId = id;

            var result = await _mediator.Send(command);

            if (result == null)
            {
                _logger.LogError($"Message with id {id} not found");
                return NotFound($"Message with id {id} not found");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            _logger.LogInformation($"Delete message with ID {id}");
            var command = new DeleteMessageCommand()
            {
                MessageId = id
            };

            var message = await _mediator.Send(command);

            if (message == null)
            {
                _logger.LogError("Message not found");
                return NotFound("Message not found");
            }
            return NoContent();
        }
    }

}