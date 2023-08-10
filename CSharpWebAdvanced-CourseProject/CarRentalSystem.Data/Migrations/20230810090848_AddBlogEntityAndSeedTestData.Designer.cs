﻿// <auto-generated />
using System;
using CarRentalSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalSystem.Data.Migrations
{
    [DbContext(typeof(CarRentingDbContext))]
    [Migration("20230810090848_AddBlogEntityAndSeedTestData")]
    partial class AddBlogEntityAndSeedTestData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarRentalSystem.Data.Models.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid?>("CreaterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreaterId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7daff10e-1eb4-457f-88b1-2f21b1867f28"),
                            CreatedOn = new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreaterId = new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                            Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.",
                            ImageUrl = "https://localhost:7263/images/blog/image_1.jpg",
                            IsActive = false,
                            Title = "Why Lead Generation Is Key For Business Growth"
                        });
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Acceleration")
                        .HasColumnType("float");

                    b.Property<int>("BodyType")
                        .HasColumnType("int");

                    b.Property<double>("Consumption")
                        .HasMaxLength(50)
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("EngineType")
                        .HasColumnType("int");

                    b.Property<byte>("FuelAmount")
                        .HasColumnType("tinyint");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<long?>("Mileage")
                        .HasColumnType("bigint");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte>("PassengerSeats")
                        .HasMaxLength(8)
                        .HasColumnType("tinyint");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Range")
                        .HasColumnType("int");

                    b.Property<Guid?>("RenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte?>("Safety")
                        .HasMaxLength(5)
                        .HasColumnType("tinyint");

                    b.Property<int>("TopSpeed")
                        .HasColumnType("int");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.HasIndex("RenterId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a6e93473-1479-442f-a73a-96a5f4f94b2f"),
                            Acceleration = 2.8999999999999999,
                            BodyType = 3,
                            Consumption = 20.199999999999999,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = 2,
                            FuelAmount = (byte)0,
                            HorsePower = 637,
                            ImageUrl = "https://www.cnet.com/a/img/resize/607531bf946fb55b78d58ddf654b802133f3aeb3/hub/2021/11/10/e0e04238-ff8d-4e5a-9cd7-1dca34ec7843/2022-audi-rs-e-tron-gt-ogi-1.jpg?auto=webp&fit=crop&height=675&width=1200",
                            IsActive = false,
                            MakeId = 3,
                            Mileage = 5000L,
                            Model = "RS e-tron GT",
                            PassengerSeats = (byte)5,
                            PricePerDay = 420m,
                            Range = 298,
                            Safety = (byte)5,
                            TopSpeed = 155,
                            Transmission = 1,
                            Year = 2021
                        },
                        new
                        {
                            Id = new Guid("e0076ee2-7eaa-4b5b-82cd-0e415b4df2dd"),
                            Acceleration = 6.2000000000000002,
                            BodyType = 4,
                            Consumption = 6.2000000000000002,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = 1,
                            FuelAmount = (byte)0,
                            HorsePower = 261,
                            ImageUrl = "https://imagizer.imageshack.com/a/img29/5097/gu89.jpg",
                            IsActive = false,
                            MakeId = 3,
                            Mileage = 450000L,
                            Model = "A5 SB basic",
                            PassengerSeats = (byte)5,
                            PricePerDay = 329m,
                            Range = 520,
                            Safety = (byte)4,
                            TopSpeed = 126,
                            Transmission = 1,
                            Year = 2013
                        },
                        new
                        {
                            Id = new Guid("0176c691-6be3-49bf-9399-42d8e9ebde86"),
                            Acceleration = 5.5,
                            BodyType = 1,
                            Consumption = 7.0999999999999996,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = 1,
                            FuelAmount = (byte)0,
                            HorsePower = 340,
                            ImageUrl = "https://avatars.mds.yandex.net/get-autoru-vos/5234682/06057d0f4b94a888f5c8112546a31a43/1200x900",
                            IsActive = false,
                            MakeId = 4,
                            Mileage = 53000L,
                            Model = "X6 40d",
                            PassengerSeats = (byte)5,
                            PricePerDay = 412m,
                            Range = 704,
                            Safety = (byte)4,
                            TopSpeed = 147,
                            Transmission = 1,
                            Year = 2012
                        },
                        new
                        {
                            Id = new Guid("247ae983-4cf8-4881-951d-f39e66b8877e"),
                            Acceleration = 3.6000000000000001,
                            BodyType = 18,
                            Consumption = 18.300000000000001,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = 1,
                            FuelAmount = (byte)0,
                            HorsePower = 483,
                            ImageUrl = "https://photos.carspecs.us/d389399428d2ba5d065c5b6f59aaf3771a41ca4b-2000.jpg",
                            IsActive = false,
                            MakeId = 6,
                            Mileage = 230532L,
                            Model = "F430",
                            PassengerSeats = (byte)2,
                            PricePerDay = 620m,
                            Range = 323,
                            Safety = (byte)3,
                            TopSpeed = 196,
                            Transmission = 1,
                            Year = 2004
                        },
                        new
                        {
                            Id = new Guid("5c85b4b3-10c9-4cec-b30b-ac226da7b60b"),
                            Acceleration = 5.4000000000000004,
                            BodyType = 0,
                            Consumption = 28.5,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = 1,
                            FuelAmount = (byte)0,
                            HorsePower = 280,
                            ImageUrl = "https://pbs.twimg.com/media/FxTMcyQWwAMqIYk?format=jpg&name=large",
                            IsActive = false,
                            MakeId = 2,
                            Mileage = 623142L,
                            Model = "Giulia",
                            PassengerSeats = (byte)5,
                            PricePerDay = 205m,
                            Range = 464,
                            Safety = (byte)4,
                            TopSpeed = 191,
                            Transmission = 0,
                            Year = 2018
                        },
                        new
                        {
                            Id = new Guid("b5cc05e9-2c12-4a5d-bccf-fc4a95ec04a6"),
                            Acceleration = 4.5,
                            BodyType = 0,
                            Consumption = 22.699999999999999,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = 1,
                            FuelAmount = (byte)0,
                            HorsePower = 500,
                            ImageUrl = "https://sun9-46.userapi.com/impg/jGF9KYUrkOJ81ExMSYNNE4L7fh4GD5Ryoic6zA/Iy6iwscdEg0.jpg?size=1920x1280&quality=95&sign=637909ae3d1112f8306502533c876ba3&c_uniq_tag=3K2cQHcDOmacj7mo5PNx7wX_XCN3EOQggqEfBc4h6iI&type=album",
                            IsActive = false,
                            MakeId = 4,
                            Mileage = 575531L,
                            Model = "e60 M5",
                            PassengerSeats = (byte)5,
                            PricePerDay = 130m,
                            Range = 293,
                            Safety = (byte)3,
                            TopSpeed = 190,
                            Transmission = 1,
                            Year = 2005
                        });
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NewInnovation")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Acura",
                            NewInnovation = "IntelliCruise"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Alfa Romeo",
                            NewInnovation = "Active Aero Splitter"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Audi",
                            NewInnovation = "Virtual Cockpit Plus"
                        },
                        new
                        {
                            Id = 4,
                            Name = "BMW",
                            NewInnovation = "Gesture Control 2.0"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bentley",
                            NewInnovation = "Self-Leveling Air Suspension"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ferrari",
                            NewInnovation = "Side Slip Control"
                        });
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Rental", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Deposit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ecdfd0a-5be5-434d-a3b3-cf7749ae21b0",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "hris",
                            LastName = "ivanov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMvoHPmH+l/Ge4SMNDwNzwhsfifu4dLpNU1Bj3wkUfGpOgYyjhMGOcwSFMEeqd0Vdw==",
                            PhoneNumber = "0895969391",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2210ff07-66f2-456a-b1aa-a58befe28250",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f9027cc-8849-4c49-9349-88cc5bde5671",
                            Email = "defi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "defne",
                            LastName = "ahmedova",
                            LockoutEnabled = false,
                            NormalizedEmail = "DEFI@GMAIL.COM",
                            NormalizedUserName = "DEFI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELiE9OjMWUpgs1cEQ/uADQnzDNTx7oNo/eB0LR1bY2HHxJZIjHPk+cvp7CIDdF07Sg==",
                            PhoneNumber = "0888888391",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c2db3c9-8ca6-4c2b-8816-0e0982c0265a",
                            TwoFactorEnabled = false,
                            UserName = "defi@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f52e95e-bf1a-4dd0-8a02-a961299cd097",
                            Email = "pesho_petrov@yahoo.com",
                            EmailConfirmed = false,
                            FirstName = "pesho",
                            LastName = "petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PESHO_PETROV@YAHOO.COM",
                            NormalizedUserName = "PESHO_PETROV@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOdCBeJUkiQH9qbvHxMlceLJ8181G/EyTKFH/02wh8ZW8MdKdYbzqMQ4SU8PH3WgMQ==",
                            PhoneNumber = "0878559310",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3da02f0f-ab72-4de8-8166-aff612286b48",
                            TwoFactorEnabled = false,
                            UserName = "pesho_petrov@yahoo.com"
                        });
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.UserRentals", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RentalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomerId", "RentalId");

                    b.HasIndex("RentalId");

                    b.ToTable("UsersRentals");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                            ConcurrencyStamp = "92380a2e-8e1b-467e-837c-dbf525eff0a7",
                            Name = "Master Administrator",
                            NormalizedName = "MASTER ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                            RoleId = new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Blog", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.User", "Creater")
                        .WithMany("Blogs")
                        .HasForeignKey("CreaterId");

                    b.Navigation("Creater");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Car", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.Make", "Make")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalSystem.Data.Models.User", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.Navigation("Make");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Contact", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Rental", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.UserRentals", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.User", "User")
                        .WithMany("UserRentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalSystem.Data.Models.Rental", "Rental")
                        .WithMany("UserRentals")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rental");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CarRentalSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Make", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.Rental", b =>
                {
                    b.Navigation("UserRentals");
                });

            modelBuilder.Entity("CarRentalSystem.Data.Models.User", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Contacts");

                    b.Navigation("UserRentals");
                });
#pragma warning restore 612, 618
        }
    }
}
