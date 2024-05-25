using AplicatieAdoptie.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AplicatieAdoptie.Infrastructure.Configurations
{
    public class MessageConfiguration: IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasOne(message => message.Sender)
                .WithMany(user => user.Senders)
                .HasForeignKey(message => message.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(message => message.Receiver)
                .WithMany(user => user.Receivers)
                .HasForeignKey(message => message.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
