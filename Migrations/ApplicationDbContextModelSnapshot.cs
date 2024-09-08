﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecurePoll_BE.Data;

#nullable disable

namespace SecurePoll_BE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("SecurePoll_BE.Models.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("abbreviation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("document_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "CC",
                            Name = "Cédula de Ciudadanía"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "TI",
                            Name = "Tarjeta de Identidad"
                        },
                        new
                        {
                            Id = 3,
                            Abbreviation = "PS",
                            Name = "Pasaporte"
                        },
                        new
                        {
                            Id = 4,
                            Abbreviation = "NIT",
                            Name = "Número de Identificación Tributaria"
                        },
                        new
                        {
                            Id = 5,
                            Abbreviation = "CE",
                            Name = "Cédula de Extranjería"
                        },
                        new
                        {
                            Id = 6,
                            Abbreviation = "RC",
                            Name = "Registro Civil"
                        },
                        new
                        {
                            Id = 7,
                            Abbreviation = "PEP",
                            Name = "Permiso Especial de Permanencia"
                        });
                });

            modelBuilder.Entity("SecurePoll_BE.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrador"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cliente"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Votante"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Candidato"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
