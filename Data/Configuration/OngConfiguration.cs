using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class OngConfiguration : IEntityTypeConfiguration<Ong> {
        public void Configure(EntityTypeBuilder<Ong> builder) {
            builder.ToTable("Ong", "dbo");

            builder.Property(builder => builder.PersonId).HasColumnName(nameof(Ong.PersonId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.Name).HasColumnName(nameof(Ong.Name)).IsRequired();
            builder.Property(builder => builder.BirthDate).HasColumnName(nameof(Ong.BirthDate));
            builder.Property(builder => builder.Gender).HasColumnName(nameof(Ong.Gender)).IsRequired().HasColumnType("nvarchar(1)");
            builder.Property(builder => builder.PersonType).HasColumnName(nameof(Ong.PersonType)).IsRequired();
            builder.Property(builder => builder.AdressId).HasColumnName(nameof(Ong.AdressId)).IsRequired();
            builder.Property(builder => builder.CpfCnpj).HasColumnName(nameof(Ong.CpfCnpj)).IsRequired();
            builder.Property(builder => builder.Email).HasColumnName(nameof(Ong.Email)).IsRequired();
            builder.Property(builder => builder.ImgPath).HasColumnName(nameof(Ong.ImgPath)).IsRequired();
            builder.Property(builder => builder.PhoneId).HasColumnName(nameof(Ong.PhoneId)).IsRequired();
        }
    }
}
