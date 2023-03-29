using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class DonateConfiguration : IEntityTypeConfiguration<Donate>{
        

        public void Configure(EntityTypeBuilder<Donate> builder) {
            builder.ToTable("Donate", "dbo");

            builder.HasKey(builder => builder.DonateId);
            builder.Property(builder => builder.DonateId).HasColumnName(nameof(Donate.DonateId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.DonateDate).HasColumnName(nameof(Donate.DonateDate)).IsRequired();
            builder.Property(builder => builder.Value).HasColumnName(nameof(Donate.Value));
            builder.Property(builder => builder.PersonId).HasColumnName(nameof(Donate.PersonId)).IsRequired();
        }
    }
}
