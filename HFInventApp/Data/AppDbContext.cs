using HFInventApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HFInventApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Create DbSets for the Tables
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Customer> Customers { get; set; }        
        public DbSet<Product> Products { get; set; }
        public DbSet<BinLookup> BinLookups { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }


        //Add SeedData for all Base Tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Facility>().HasData(
                    new Facility { FacilityId = 1, FacilityName = "AbujaStore", Location = "Abuja, Nigeria" },
                    new Facility { FacilityId = 2, FacilityName = "LagosStore", Location = "Lagos, Nigeria" },
                    new Facility { FacilityId = 3, FacilityName = "TexasStore", Location = "Texas, USA" },
                    new Facility { FacilityId = 4, FacilityName = "AccraStore", Location = "Accra, Ghana" }
                );

            modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        CustomerId = 1,
                        CustomerName = "Adrian King",
                        ContactTitle = "Manager",
                        CompanyName = "Adatum Corporation",
                        Address = "12 Beacon St",
                        City = "Boston",
                        State = "MA",
                        Country = "USA",
                        ZipCode = "98765",
                        PhoneNumber = "(123) 555-0134",
                        FaxNumber = "(123) 555-0124",
                        Email = "adrian@example.com",
                        FacilityId = 1,
                    },
                    new Customer
                    {
                        CustomerId = 2,
                        CustomerName = "Aidyn Zhanbolat",
                        ContactTitle = "Sr. Buyer",
                        CompanyName = "Adventure Works",
                        Address = "123 Main Street",
                        City = "Seattle",
                        State = "WA",
                        Country = "USA",
                        ZipCode = "87654",
                        PhoneNumber = "(456) 555-0145",
                        FaxNumber = "(456) 555-0146",
                        Email = "aidyn@example.com",
                        FacilityId = 2,
                    },
                    new Customer
                    {
                        CustomerId = 3,
                        CustomerName = "Alex Krejci",
                        ContactTitle = "Analyst",
                        CompanyName = "Alpine Ski House",
                        Address = "321 Avenue A",
                        City = "Portland",
                        State = "OR",
                        Country = "USA",
                        ZipCode = "76543",
                        PhoneNumber = "(212) 555-0101",
                        FaxNumber = "(212) 555-0102",
                        Email = "alex@example.com",
                        FacilityId = 3,
                    },
                    new Customer
                    {
                        CustomerId = 4,
                        CustomerName = "Alix Gauthier",
                        ContactTitle = "Managing Partner",
                        CompanyName = "Adventure Works",
                        Address = "89 Pacific Ave",
                        City = "San Francisco",
                        State = "CA",
                        Country = "USA",
                        ZipCode = "65432",
                        PhoneNumber = "(786) 555-0150",
                        FaxNumber = "(786) 555-0151",
                        Email = "alix@example.com",
                        FacilityId = 4,
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                   new Product { ProductId = 1, ProductName = "Item 1", ProductDescription = "Item 1", Price = 30 },
                   new Product { ProductId = 2, ProductName = "Item 2", ProductDescription = "Item 2", Price = 40 },
                   new Product { ProductId = 3, ProductName = "Item 3", ProductDescription = "Item 3", Price = 5 },
                   new Product { ProductId = 4, ProductName = "Item 4", ProductDescription = "Item 4", Price = 15 },
                   new Product { ProductId = 5, ProductName = "Item 5", ProductDescription = "Item 5", Price = 26 },
                   new Product { ProductId = 6, ProductName = "Item 6", ProductDescription = "Item 6", Price = 50 },
                   new Product { ProductId = 7, ProductName = "Item 7", ProductDescription = "Item 7", Price = 10 },
                   new Product { ProductId = 8, ProductName = "Item 8", ProductDescription = "Item 8", Price = 3 },
                   new Product { ProductId = 9, ProductName = "Item 9", ProductDescription = "Item 9", Price = 14 },
                   new Product { ProductId = 10, ProductName = "Item 10", ProductDescription = "Item 10", Price = 60 },
                   new Product { ProductId = 11, ProductName = "Item 11", ProductDescription = "Item 11", Price = 8 }
               );

            modelBuilder.Entity<BinLookup>().HasData(
                   new BinLookup { BinLookupId = 1, BinNumber = "T345", Description = "Large bin", Location = "Row 2, Slot 1", Width = 50, Height = 10, Length = 10 },
                   new BinLookup { BinLookupId = 2, BinNumber = "T5789", Description = "Small bin", Location = "Row 1, Slot 1", Width = 25, Height = 5, Length = 5 },
                   new BinLookup { BinLookupId = 3, BinNumber = "T9876", Description = "Large bin", Location = "Row 3, Slot 2", Width = 50, Height = 10, Length = 10 },
                   new BinLookup { BinLookupId = 4, BinNumber = "T098", Description = "Medium bin", Location = "Row 3, Slot 1", Width = 30, Height = 7, Length = 10 },
                   new BinLookup { BinLookupId = 5, BinNumber = "T349", Description = "Small bin", Location = "Row 1, Slot 2", Width = 25, Height = 5, Length = 5 },
                   new BinLookup { BinLookupId = 6, BinNumber = "T5789", Description = "Large bin", Location = "Row 4, Slot 5", Width = 50, Height = 10, Length = 10 },
                   new BinLookup { BinLookupId = 7, BinNumber = "T9875", Description = "Large bin", Location = "Row 2, Slot 2", Width = 50, Height = 10, Length = 10 }
               );

            modelBuilder.Entity<ProductInventory>().HasData(
                   new ProductInventory { InventoryId = 1, InventorySKU = "SP7875", FacilityId = 1, ProductId = 1, BinLookupId = 1, Quantity = 20 },
                   new ProductInventory { InventoryId = 2, InventorySKU = "TR87680", FacilityId = 2, ProductId = 2, BinLookupId = 2, Quantity = 45 },
                   new ProductInventory { InventoryId = 3, InventorySKU = "MK676554", FacilityId = 1, ProductId = 1, BinLookupId = 2, Quantity = 15 },
                   new ProductInventory { InventoryId = 4, InventorySKU = "YE98767", FacilityId = 2, ProductId = 2, BinLookupId = 3, Quantity = 30 },
                   new ProductInventory { InventoryId = 5, InventorySKU = "XR23423", FacilityId = 1, ProductId = 1, BinLookupId = 4, Quantity = 10 },
                   new ProductInventory { InventoryId = 6, InventorySKU = "PW98762", FacilityId = 2, ProductId = 2, BinLookupId = 1, Quantity = 25 },
                   new ProductInventory { InventoryId = 7, InventorySKU = "BM87684", FacilityId = 1, ProductId = 1, BinLookupId = 3, Quantity = 20 },
                   new ProductInventory { InventoryId = 8, InventorySKU = "BH67655", FacilityId = 2, ProductId = 2, BinLookupId = 2, Quantity = 15 },
                   new ProductInventory { InventoryId = 9, InventorySKU = "WT98768", FacilityId = 1, ProductId = 1, BinLookupId = 1, Quantity = 50 },
                   new ProductInventory { InventoryId = 10, InventorySKU = "TS3456", FacilityId = 2, ProductId = 2, BinLookupId = 4, Quantity = 15 },
                   new ProductInventory { InventoryId = 11, InventorySKU = "WDG123", FacilityId = 1, ProductId = 1, BinLookupId = 1, Quantity = 20 }
               );

        }

    }
}
