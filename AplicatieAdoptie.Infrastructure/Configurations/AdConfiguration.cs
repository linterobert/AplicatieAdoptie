using AplicatieAdoptie.Domain.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AplicatieAdoptie.Infrastructure.Configurations
{
    public class AdConfiguration : IEntityTypeConfiguration<Ad>
    {
        public void Configure(EntityTypeBuilder<Ad> builder)
        {
            builder.HasOne(ad => ad.User)
                .WithMany(user => user.Ads)
                .HasForeignKey(ad => ad.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ad => ad.Animal)
                .WithMany(animal => animal.Ads)
                .HasForeignKey(ad => ad.AnimalId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
