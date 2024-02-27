﻿// <auto-generated />
using System;
using HFInventApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HFInventApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HFInventApp.Models.BinLookup", b =>
                {
                    b.Property<int>("BinLookupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BinLookupId"));

                    b.Property<string>("BinNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("BinLookupId");

                    b.ToTable("BinLookups");

                    b.HasData(
                        new
                        {
                            BinLookupId = 1,
                            BinNumber = "T345",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 2, Slot 1",
                            Width = 50
                        },
                        new
                        {
                            BinLookupId = 2,
                            BinNumber = "T5789",
                            Description = "Small bin",
                            Height = 5,
                            Length = 5,
                            Location = "Row 1, Slot 1",
                            Width = 25
                        },
                        new
                        {
                            BinLookupId = 3,
                            BinNumber = "T9876",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 3, Slot 2",
                            Width = 50
                        },
                        new
                        {
                            BinLookupId = 4,
                            BinNumber = "T098",
                            Description = "Medium bin",
                            Height = 7,
                            Length = 10,
                            Location = "Row 3, Slot 1",
                            Width = 30
                        },
                        new
                        {
                            BinLookupId = 5,
                            BinNumber = "T349",
                            Description = "Small bin",
                            Height = 5,
                            Length = 5,
                            Location = "Row 1, Slot 2",
                            Width = 25
                        },
                        new
                        {
                            BinLookupId = 6,
                            BinNumber = "T5789",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 4, Slot 5",
                            Width = 50
                        },
                        new
                        {
                            BinLookupId = 7,
                            BinNumber = "T9875",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 2, Slot 2",
                            Width = 50
                        });
                });

            modelBuilder.Entity("HFInventApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("FaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "12 Beacon St",
                            City = "Boston",
                            CompanyName = "Adatum Corporation",
                            ContactTitle = "Manager",
                            Country = "USA",
                            CustomerName = "Adrian King",
                            Email = "adrian@example.com",
                            FacilityId = 1,
                            FaxNumber = "(123) 555-0124",
                            PhoneNumber = "(123) 555-0134",
                            State = "MA",
                            ZipCode = "98765"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "123 Main Street",
                            City = "Seattle",
                            CompanyName = "Adventure Works",
                            ContactTitle = "Sr. Buyer",
                            Country = "USA",
                            CustomerName = "Aidyn Zhanbolat",
                            Email = "aidyn@example.com",
                            FacilityId = 2,
                            FaxNumber = "(456) 555-0146",
                            PhoneNumber = "(456) 555-0145",
                            State = "WA",
                            ZipCode = "87654"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "321 Avenue A",
                            City = "Portland",
                            CompanyName = "Alpine Ski House",
                            ContactTitle = "Analyst",
                            Country = "USA",
                            CustomerName = "Alex Krejci",
                            Email = "alex@example.com",
                            FacilityId = 3,
                            FaxNumber = "(212) 555-0102",
                            PhoneNumber = "(212) 555-0101",
                            State = "OR",
                            ZipCode = "76543"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "89 Pacific Ave",
                            City = "San Francisco",
                            CompanyName = "Adventure Works",
                            ContactTitle = "Managing Partner",
                            Country = "USA",
                            CustomerName = "Alix Gauthier",
                            Email = "alix@example.com",
                            FacilityId = 4,
                            FaxNumber = "(786) 555-0151",
                            PhoneNumber = "(786) 555-0150",
                            State = "CA",
                            ZipCode = "65432"
                        });
                });

            modelBuilder.Entity("HFInventApp.Models.Cylinder", b =>
                {
                    b.Property<int>("CylinderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CylinderId"));

                    b.Property<Guid>("BatchNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CylinderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CylinderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Cylinders");

                    b.HasData(
                        new
                        {
                            CylinderId = 1,
                            BatchNumber = new Guid("6c5f8e9b-8ac5-4bb1-88d8-aa1496b4dc25"),
                            CustomerId = 1,
                            CylinderName = "Cylinder1"
                        },
                        new
                        {
                            CylinderId = 2,
                            BatchNumber = new Guid("dd698ae5-d69a-4614-9298-f0e8add9079e"),
                            CustomerId = 2,
                            CylinderName = "Cylinder2"
                        },
                        new
                        {
                            CylinderId = 3,
                            BatchNumber = new Guid("63b1edfc-796e-4934-8080-0124f13bd28e"),
                            CustomerId = 3,
                            CylinderName = "Cylinder3"
                        },
                        new
                        {
                            CylinderId = 4,
                            BatchNumber = new Guid("2c4db4d6-0d7e-429f-b846-45142858511d"),
                            CylinderName = "Cylinder4"
                        });
                });

            modelBuilder.Entity("HFInventApp.Models.CylinderRentHistory", b =>
                {
                    b.Property<int>("CylinderRentHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CylinderRentHistoryId"));

                    b.Property<string>("BatchNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Transaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CylinderRentHistoryId");

                    b.ToTable("CylinderRentHistories");
                });

            modelBuilder.Entity("HFInventApp.Models.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"));

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.ToTable("Facilities");

                    b.HasData(
                        new
                        {
                            FacilityId = 1,
                            FacilityName = "AbujaStore",
                            Location = "Abuja, Nigeria"
                        },
                        new
                        {
                            FacilityId = 2,
                            FacilityName = "LagosStore",
                            Location = "Lagos, Nigeria"
                        },
                        new
                        {
                            FacilityId = 3,
                            FacilityName = "TexasStore",
                            Location = "Texas, USA"
                        },
                        new
                        {
                            FacilityId = 4,
                            FacilityName = "AccraStore",
                            Location = "Accra, Ghana"
                        });
                });

            modelBuilder.Entity("HFInventApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<Guid>("BatchNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 30m,
                            ProductDescription = "Item 1",
                            ProductName = "Item 1"
                        },
                        new
                        {
                            ProductId = 2,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 40m,
                            ProductDescription = "Item 2",
                            ProductName = "Item 2"
                        },
                        new
                        {
                            ProductId = 3,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 5m,
                            ProductDescription = "Item 3",
                            ProductName = "Item 3"
                        },
                        new
                        {
                            ProductId = 4,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 15m,
                            ProductDescription = "Item 4",
                            ProductName = "Item 4"
                        },
                        new
                        {
                            ProductId = 5,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 26m,
                            ProductDescription = "Item 5",
                            ProductName = "Item 5"
                        },
                        new
                        {
                            ProductId = 6,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 50m,
                            ProductDescription = "Item 6",
                            ProductName = "Item 6"
                        },
                        new
                        {
                            ProductId = 7,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 10m,
                            ProductDescription = "Item 7",
                            ProductName = "Item 7"
                        },
                        new
                        {
                            ProductId = 8,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 3m,
                            ProductDescription = "Item 8",
                            ProductName = "Item 8"
                        },
                        new
                        {
                            ProductId = 9,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 14m,
                            ProductDescription = "Item 9",
                            ProductName = "Item 9"
                        },
                        new
                        {
                            ProductId = 10,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 60m,
                            ProductDescription = "Item 10",
                            ProductName = "Item 10"
                        },
                        new
                        {
                            ProductId = 11,
                            BatchNumber = new Guid("00000000-0000-0000-0000-000000000000"),
                            Price = 8m,
                            ProductDescription = "Item 11",
                            ProductName = "Item 11"
                        });
                });

            modelBuilder.Entity("HFInventApp.Models.ProductInventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<int>("BinLookupId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<Guid>("InventoryBatch")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InventorySKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("ProductInventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 1,
                            BinLookupId = 1,
                            FacilityId = 1,
                            InventoryBatch = new Guid("969203cb-aa59-48d0-ba65-bf075c89b80e"),
                            InventorySKU = "SP7875",
                            ProductId = 1,
                            Quantity = 20
                        },
                        new
                        {
                            InventoryId = 2,
                            BinLookupId = 2,
                            FacilityId = 2,
                            InventoryBatch = new Guid("677a4734-37ac-4d0e-bdad-0d733fb5c5a1"),
                            InventorySKU = "TR87680",
                            ProductId = 2,
                            Quantity = 45
                        },
                        new
                        {
                            InventoryId = 3,
                            BinLookupId = 2,
                            FacilityId = 1,
                            InventoryBatch = new Guid("7db69915-48e2-4c55-8221-f55aa1cd1c77"),
                            InventorySKU = "MK676554",
                            ProductId = 1,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 4,
                            BinLookupId = 3,
                            FacilityId = 2,
                            InventoryBatch = new Guid("00fbf402-a402-4eb1-baf5-05d291956f12"),
                            InventorySKU = "YE98767",
                            ProductId = 2,
                            Quantity = 30
                        },
                        new
                        {
                            InventoryId = 5,
                            BinLookupId = 4,
                            FacilityId = 1,
                            InventoryBatch = new Guid("d4c0939c-acf5-416d-bd93-44c712f23652"),
                            InventorySKU = "XR23423",
                            ProductId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            InventoryId = 6,
                            BinLookupId = 1,
                            FacilityId = 2,
                            InventoryBatch = new Guid("925d1f8e-f772-4926-9b44-361b5d908a9f"),
                            InventorySKU = "PW98762",
                            ProductId = 2,
                            Quantity = 25
                        },
                        new
                        {
                            InventoryId = 7,
                            BinLookupId = 3,
                            FacilityId = 1,
                            InventoryBatch = new Guid("44a18fc5-1573-4eb1-96c6-912496eb7e1d"),
                            InventorySKU = "BM87684",
                            ProductId = 1,
                            Quantity = 20
                        },
                        new
                        {
                            InventoryId = 8,
                            BinLookupId = 2,
                            FacilityId = 2,
                            InventoryBatch = new Guid("06809f24-e5cd-43f1-8d89-56a3779e88de"),
                            InventorySKU = "BH67655",
                            ProductId = 2,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 9,
                            BinLookupId = 1,
                            FacilityId = 1,
                            InventoryBatch = new Guid("78ac3742-924a-4b06-8e93-e33ee4693d4c"),
                            InventorySKU = "WT98768",
                            ProductId = 1,
                            Quantity = 50
                        },
                        new
                        {
                            InventoryId = 10,
                            BinLookupId = 4,
                            FacilityId = 2,
                            InventoryBatch = new Guid("edf9dfd4-93b3-47ec-8f4e-2915651fabcc"),
                            InventorySKU = "TS3456",
                            ProductId = 2,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 11,
                            BinLookupId = 1,
                            FacilityId = 1,
                            InventoryBatch = new Guid("04f96e71-e855-48e1-8299-39a5d6888bb6"),
                            InventorySKU = "WDG123",
                            ProductId = 1,
                            Quantity = 20
                        });
                });

            modelBuilder.Entity("HFInventApp.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SaleId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("HFInventApp.Models.SaleDetail", b =>
                {
                    b.Property<int>("SaleDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleDetailId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal?>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("QuantitySold")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("SaleDetailId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("HFInventApp.Models.UserFacility", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<int>("FacilityId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("UserId", "FacilityId");

                    b.ToTable("UserFacilities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HFInventApp.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("HFInventApp.Models.Customer", b =>
                {
                    b.HasOne("HFInventApp.Models.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("HFInventApp.Models.Cylinder", b =>
                {
                    b.HasOne("HFInventApp.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}