﻿// <auto-generated />
using System;
using LPR.DAL.CoreDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LPR.DAL.Migrations
{
    [DbContext(typeof(LrpContext))]
    [Migration("20240416182432_addDates")]
    partial class addDates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LPR.DAL.Entities.DateAvailability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("dat_Id");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("dat_Label");

                    b.Property<Guid?>("ProfesionnalId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("dat_fk_Profesionnal");

                    b.Property<DateTime>("RealDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("dat_RealDate");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProfesionnalId");

                    b.ToTable("DateAvailabilities");
                });

            modelBuilder.Entity("LPR.DAL.Entities.Professional", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("pro_Id");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pro_FirstName");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pro_gender");

                    b.HasKey("Id");

                    b.ToTable("Profesionnals");
                });

            modelBuilder.Entity("LPR.DAL.Entities.DateAvailability", b =>
                {
                    b.HasOne("LPR.DAL.Entities.Professional", "Professional")
                        .WithMany()
                        .HasForeignKey("ProfesionnalId");

                    b.Navigation("Professional");
                });
#pragma warning restore 612, 618
        }
    }
}
