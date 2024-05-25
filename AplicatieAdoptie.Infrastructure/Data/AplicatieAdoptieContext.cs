using AplicatieAdoptie.Domain.Domain;
using AplicatieAdoptie.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplicatieAdoptie.Infrastructure.Data
{
    public class AplicatieAdoptieContext : IdentityDbContext<User>
    {
        public AplicatieAdoptieContext(DbContextOptions<AplicatieAdoptieContext> options) : base(options) { }
        public DbSet<Message> Messages {  get; set; }
        public DbSet<VetVisit> VetVisits {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\local;Initial Catalog=EstateAppDatabase;Integrated Security=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AdConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new VetVisitConfiguration());
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        //optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EstateAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
