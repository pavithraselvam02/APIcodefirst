﻿// <auto-generated />
using System;
using APIcodefirst.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIcodefirst.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230528103507_Start")]
    partial class Start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIcodefirst.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("APIcodefirst.Models.Hotels", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"));

                    b.Property<string>("Amenities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RoomAvailability")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("APIcodefirst.Models.Rooms", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int?>("HotelsHotelId")
                        .HasColumnType("int");

                    b.Property<string>("Room_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.HasIndex("HotelsHotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("APIcodefirst.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<int?>("HotelsHotelId")
                        .HasColumnType("int");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.HasIndex("HotelsHotelId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Reservation", b =>
                {
                    b.Property<int>("Reservation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Reservation_id"));

                    b.Property<DateTime>("Check_in_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Check_out_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("hotelsHotelId")
                        .HasColumnType("int");

                    b.HasKey("Reservation_id");

                    b.HasIndex("CustomersCustomerId");

                    b.HasIndex("hotelsHotelId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("APIcodefirst.Models.Rooms", b =>
                {
                    b.HasOne("APIcodefirst.Models.Hotels", "Hotels")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelsHotelId");

                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("APIcodefirst.Models.Staff", b =>
                {
                    b.HasOne("APIcodefirst.Models.Hotels", "Hotels")
                        .WithMany("Staff")
                        .HasForeignKey("HotelsHotelId");

                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("ClassLibrary1.Models.Reservation", b =>
                {
                    b.HasOne("APIcodefirst.Models.Customers", "Customers")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomersCustomerId");

                    b.HasOne("APIcodefirst.Models.Hotels", "hotels")
                        .WithMany("Reservations")
                        .HasForeignKey("hotelsHotelId");

                    b.Navigation("Customers");

                    b.Navigation("hotels");
                });

            modelBuilder.Entity("APIcodefirst.Models.Customers", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("APIcodefirst.Models.Hotels", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Rooms");

                    b.Navigation("Staff");
                });
#pragma warning restore 612, 618
        }
    }
}
