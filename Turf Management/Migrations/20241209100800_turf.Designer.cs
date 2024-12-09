﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Turf_Management.Data;

#nullable disable

namespace Turf_Management.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241209100800_turf")]
    partial class turf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Turf_Management.Models.Booking", b =>
                {
                    b.Property<int>("B_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("B_id"));

                    b.Property<string>("B_To_time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_acc_details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_availability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_booking_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_from_time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_payment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("C_id")
                        .HasColumnType("int");

                    b.Property<int>("T_id")
                        .HasColumnType("int");

                    b.HasKey("B_id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Turf_Management.Models.Customer", b =>
                {
                    b.Property<int>("C_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("C_id"));

                    b.Property<string>("C_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("C_ph")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("C_id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Turf_Management.Models.Feedback", b =>
                {
                    b.Property<int>("F_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("F_id"));

                    b.Property<int>("C_id")
                        .HasColumnType("int");

                    b.Property<string>("F_feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("F_id");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Turf_Management.Models.Login", b =>
                {
                    b.Property<int>("L_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("L_id"));

                    b.Property<int>("C_id")
                        .HasColumnType("int");

                    b.Property<string>("L_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("L_id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("Turf_Management.Models.Turf_details", b =>
                {
                    b.Property<int>("T_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("T_id"));

                    b.Property<string>("T_from_timing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_ph")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_to_timing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("T_id");

                    b.ToTable("Turf_details");
                });
#pragma warning restore 612, 618
        }
    }
}
