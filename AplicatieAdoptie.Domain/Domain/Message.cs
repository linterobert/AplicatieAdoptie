namespace AplicatieAdoptie.Domain.Domain
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Content {  get; set; }
        public DateTime Created { get; set; }
        public string SenderId { get; set; }
        public User Sender { get; set; }
        public string ReceiverId {  get; set; }
        public User Receiver {  get; set; }
    }
}
