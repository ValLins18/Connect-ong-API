using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone> {
        public void Configure(EntityTypeBuilder<Phone> builder) {
            builder.ToTable("Phone", "dbo");

            builder.HasKey(builder => builder.PhoneId);
            builder.Property(builder => builder.PhoneId).HasColumnName(nameof(Phone.PhoneId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.DDD).HasColumnName(nameof(Phone.DDD)).IsRequired();
            builder.Property(builder => builder.PhoneNumber).HasColumnName(nameof(Phone.PhoneNumber)).IsRequired();
        }
    }
}
