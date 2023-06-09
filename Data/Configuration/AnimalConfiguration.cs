﻿using Connect_ong_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connect_ong_API.Data.Configuration {
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal> {
        public void Configure(EntityTypeBuilder<Animal> builder) {
            builder.ToTable("Animal", "dbo");

            builder.HasKey(builder => builder.AnimalId);
            builder.Property(builder => builder.AnimalId).HasColumnName(nameof(Animal.AnimalId)).ValueGeneratedOnAdd().IsRequired();
            builder.Property(builder => builder.Name).HasColumnName(nameof(Animal.Name)).IsRequired();
            builder.Property(builder => builder.BirthDate).HasColumnName(nameof(Animal.BirthDate)).IsRequired(false);
            builder.Property(builder => builder.Gender).HasColumnName(nameof(Animal.Gender)).IsRequired().HasColumnType("nvarchar(1)");
            builder.Property(builder => builder.Specie).HasColumnName(nameof(Animal.Specie)).IsRequired();
            builder.Property(builder => builder.Castred).HasColumnName(nameof(Animal.Castred)).IsRequired();
            builder.Property(builder => builder.Breed).HasColumnName(nameof(Animal.Breed)).IsRequired();
            builder.Property(builder => builder.RescueDate).HasColumnName(nameof(Animal.RescueDate)).IsRequired();
            builder.Property(builder => builder.Available).HasColumnName(nameof(Animal.Available)).IsRequired();
            builder.Property(builder => builder.ImgPath).HasColumnName(nameof(Animal.ImgPath)).IsRequired(false);
            builder.Property(builder => builder.PersonId).HasColumnName(nameof(Animal.PersonId)).IsRequired();

        }
    }
}
