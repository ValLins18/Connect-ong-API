﻿// <auto-generated />
using System;
using Connect_ong_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Connect_ong_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230329200239_updates")]
    partial class updates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Connect_ong_API.Core.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Neighborhood");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Number");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("State");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Street");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Adoption", b =>
                {
                    b.Property<int>("AdoptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AdoptionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdoptionId"), 1L, 1);

                    b.Property<DateTime>("AdoptionDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("AdoptionDate");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int")
                        .HasColumnName("AnimalId");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("PersonId");

                    b.HasKey("AdoptionId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("PersonId");

                    b.ToTable("Adoption", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AnimalId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Breed");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("Gender");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImgPath");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("OngId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecueDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RecueDate");

                    b.Property<string>("Specie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Specie");

                    b.Property<bool>("available")
                        .HasColumnType("bit")
                        .HasColumnName("available");

                    b.Property<bool>("castred")
                        .HasColumnType("bit")
                        .HasColumnName("castred");

                    b.HasKey("AnimalId");

                    b.HasIndex("OngId");

                    b.ToTable("Animal", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Donate", b =>
                {
                    b.Property<int>("DonateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DonateId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonateId"), 1L, 1);

                    b.Property<DateTime>("DonateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DonateDate");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("PersonId");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Value");

                    b.HasKey("DonateId");

                    b.HasIndex("PersonId");

                    b.ToTable("Donate", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PersonId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<int>("AdressId")
                        .HasColumnType("int")
                        .HasColumnName("AdressId");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CpfCnpj");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("Gender");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImgPath");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("PersonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("PersonType");

                    b.Property<int>("PhoneId")
                        .HasColumnType("int")
                        .HasColumnName("PhoneId");

                    b.HasKey("PersonId");

                    b.HasIndex("AdressId");

                    b.HasIndex("PhoneId");

                    b.ToTable("Person", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PhoneId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneId"), 1L, 1);

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DDD");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("PhoneId");

                    b.ToTable("Phone", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Ong", b =>
                {
                    b.HasBaseType("Connect_ong_API.Core.Models.Person");

                    b.ToTable("Ong", "dbo");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Adoption", b =>
                {
                    b.HasOne("Connect_ong_API.Core.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Connect_ong_API.Core.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Animal", b =>
                {
                    b.HasOne("Connect_ong_API.Core.Models.Ong", "Ong")
                        .WithMany("Animals")
                        .HasForeignKey("OngId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ong");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Donate", b =>
                {
                    b.HasOne("Connect_ong_API.Core.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Person", b =>
                {
                    b.HasOne("Connect_ong_API.Core.Models.Address", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Connect_ong_API.Core.Models.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Ong", b =>
                {
                    b.HasOne("Connect_ong_API.Core.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Connect_ong_API.Core.Models.Ong", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Connect_ong_API.Core.Models.Ong", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
