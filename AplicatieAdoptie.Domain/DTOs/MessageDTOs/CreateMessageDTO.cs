namespace AplicatieAdoptie.Domain.DTOs.MessageDTOs
{
    public class CreateMessageDTO
    {
        public string Content { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
    }
}
