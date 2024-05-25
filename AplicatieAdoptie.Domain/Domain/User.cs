using Microsoft.AspNetCore.Identity;

namespace AplicatieAdoptie.Domain.Domain
{
    public class User : IdentityUser
    {
        public List<Ad> Ads { get; set; }
        public List<Message> Senders { get; set; }
        public List<Message> Receivers { get; set; }
    }
}
