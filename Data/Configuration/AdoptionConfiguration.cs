using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class AdoptionConfiguration : IEntityTypeConfiguration<Adoption>{
        public void Configure(EntityTypeBuilder<Adoption> builder) {
            builder.ToTable("Adoption", "dbo");

            builder.HasKey(builder=> builder.AdoptionId);
            builder.Property(builder => builder.AdoptionId).HasColumnName(nameof(Adoption.AdoptionId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.AdoptionDate).HasColumnName(nameof(Adoption.AdoptionDate)).IsRequired();
            builder.Property(builder => builder.AnimalId).HasColumnName(nameof(Adoption.AnimalId)).IsRequired();
            builder.Property(builder => builder.PersonId).HasColumnName(nameof(Adoption.PersonId)).IsRequired();
        }
    }
}
