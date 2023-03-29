using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class AddressConfiguration : IEntityTypeConfiguration<Address> {

        public void Configure(EntityTypeBuilder<Address> builder) {
            builder.ToTable("Address", "dbo");

            builder.HasKey(builder => builder.AddressId);
            builder.Property(builder => builder.AddressId).HasColumnName(nameof(Address.AddressId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.Street).HasColumnName(nameof(Address.Street)).IsRequired();
            builder.Property(builder => builder.Neighborhood).HasColumnName(nameof(Address.Neighborhood)).IsRequired();
            builder.Property(builder => builder.State).HasColumnName(nameof(Address.State)).IsRequired();
            builder.Property(builder => builder.Number).HasColumnName(nameof(Address.Number)).IsRequired();
            builder.Property(builder => builder.City).HasColumnName(nameof(Address.City)).IsRequired();
        }
    }
}
