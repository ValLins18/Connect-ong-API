using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class PersonConfiguration : IEntityTypeConfiguration<Person> {
        public void Configure(EntityTypeBuilder<Person> builder) {
            builder.ToTable("Person", "dbo");

            builder.HasKey(builder => builder.PersonId);
            builder.Property(builder => builder.PersonId).HasColumnName(nameof(Person.PersonId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.Name).HasColumnName(nameof(Person.Name)).IsRequired();
            builder.Property(builder => builder.BirthDate).HasColumnName(nameof(Person.BirthDate)).IsRequired();
            builder.Property(builder => builder.Gender).HasColumnName(nameof(Person.Gender)).IsRequired().HasColumnType("nvarchar(1)");
            builder.Property(builder => builder.PersonType).HasColumnName(nameof(Person.PersonType)).IsRequired().HasColumnType("nvarchar(1)");
            builder.Property(builder => builder.AdressId).HasColumnName(nameof(Person.AdressId)).IsRequired();
            builder.Property(builder => builder.CpfCnpj).HasColumnName(nameof(Person.CpfCnpj)).IsRequired();
            builder.Property(builder => builder.Email).HasColumnName(nameof(Person.Email)).IsRequired(false);
            builder.Property(builder => builder.ImgPath).HasColumnName(nameof(Person.ImgPath)).IsRequired();
            builder.Property(builder => builder.PhoneId).HasColumnName(nameof(Person.PhoneId)).IsRequired();
        }
    }
}
