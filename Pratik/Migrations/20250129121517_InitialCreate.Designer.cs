﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pratik.Data;

#nullable disable

namespace Pratik.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250129121517_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Pratik.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("boolean");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Pratik.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Comment")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Pratik.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<bool>("EmployeeStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Mail")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Pratik.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Address")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("City")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CoverImage")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("District")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductCategory")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Pratik.Models.ProductDetails", b =>
                {
                    b.Property<int>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductDetailId"));

                    b.Property<int>("BathCount")
                        .HasColumnType("integer");

                    b.Property<int>("BedroomCount")
                        .HasColumnType("integer");

                    b.Property<char>("BuildYear")
                        .HasColumnType("char(4)");

                    b.Property<int>("GarageSize")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductSize")
                        .HasColumnType("integer");

                    b.Property<int>("RoomCount")
                        .HasColumnType("integer");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("varchar(1000)");

                    b.HasKey("ProductDetailId");

                    b.ToTable("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
