using AplicatieAdoptie.Domain.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AplicatieAdoptie.Infrastructure.Configurations
{
    public class VetVisitConfiguration : IEntityTypeConfiguration<VetVisit>
    {
        public void Configure(EntityTypeBuilder<VetVisit> builder)
        {
            builder.HasOne(vetVisit => vetVisit.VetClinic)
                .WithMany(vetClinic => vetClinic.VetVisits)
                .HasForeignKey(vetVisit => vetVisit.VetClinicId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(vetVisit => vetVisit.Animal)
                .WithMany(animal => animal.VetVisits)
                .HasForeignKey(vetVisit => vetVisit.AnimalId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
