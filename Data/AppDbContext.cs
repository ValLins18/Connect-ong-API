using Connect_ong_API.Core.Models;
using Connect_ong_API.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Connect_ong_API.Data {
    public class AppDbContext : DbContext {

        public AppDbContext( DbContextOptions options) : base(options) {}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Donate> Donates { get; set; }
        public DbSet<Ong> Ongs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new AdoptionConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new DonateConfiguration());
            modelBuilder.ApplyConfiguration(new OngConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneConfiguration());
        }

    }
}
