﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectForInfoDev.Models;

#nullable disable

namespace ProjectForInfoDev.Migrations
{
    [DbContext(typeof(BloodContext))]
    partial class BloodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectForInfoDev.Models.Blood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ABnegative")
                        .HasColumnType("int");

                    b.Property<int>("ABpositive")
                        .HasColumnType("int");

                    b.Property<int>("Anegative")
                        .HasColumnType("int");

                    b.Property<int>("Apositive")
                        .HasColumnType("int");

                    b.Property<int>("Bnegative")
                        .HasColumnType("int");

                    b.Property<int>("Bpositive")
                        .HasColumnType("int");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastReviewed")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Onegative")
                        .HasColumnType("int");

                    b.Property<int>("Opositive")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bloods");
                });

            modelBuilder.Entity("ProjectForInfoDev.Models.SpecialQuery", b =>
                {
                    b.Property<int>("SpecialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialId"), 1L, 1);

                    b.Property<string>("SpecialAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpecialEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpecialMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SpecialId");

                    b.ToTable("Queries");
                });
#pragma warning restore 612, 618
        }
    }
}
