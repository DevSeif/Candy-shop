using CandyShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace CandyShop.Areas.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public DbSet<ApplicationUser> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Candy> Candies { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();

            string customerId = Guid.NewGuid().ToString();
            string customerId2 = Guid.NewGuid().ToString();

           // modelBuilder.Entity<ApplicationUser>().HasKey(p => p.CustomerId);
           modelBuilder.Entity<Cart>().HasKey(c => c.CartId);

            modelBuilder.Entity<ApplicationUser>().HasOne(c => c.Cart).WithOne(u => u.Customer).HasForeignKey<Cart>(c => c.CustomerCartId);
            modelBuilder.Entity<Candy>().HasOne(c => c.Category).WithMany(c => c.Candies).HasForeignKey(x => x.CandyCategoryId);


            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
            {
                Id = customerId,
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL:COM",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                PasswordHash = hasher.HashPassword(null, "password123"),
                CustomerFName = "Admin",
                CustomerLName = "Adminsson",
                Address = "Adminsgatan 8A",
                PhoneNumber = "0737555555",
                PostalCode = "411777",
                City = "Göteborg",
                Country = "Sweden",
                CreditCardNumber = "00000 00000 00000",
            },

                new ApplicationUser
            {
                Id = customerId2,
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL:COM",
                UserName = "user@gmail.com",
                NormalizedUserName = "user@gmail.com",
                PasswordHash = hasher.HashPassword(null, "password123"),
                CustomerFName = "User",
                CustomerLName = "Usersson",
                Address = "Usersgatan 8A",
                PhoneNumber = "0737555555",
                PostalCode = "411777",
                City = "Göteborg",
                Country = "Sweden",
                CreditCardNumber = "00000 00000 00000",
                }
            );

            modelBuilder.Entity<Candy>().HasData(
                new Candy
                {
                    CandyId = 1,
                    CandyName = "Coffee Rio",
                    CandyCategoryId = 1,
                    CandyDescription = "Caramels are made by cooking sugar and water together",
                    CandyPrice = 5,
                    CandyQuantity = 50
                },

                new Candy
                {
                    CandyId = 2,
                    CandyName = "M&Ms",
                    CandyCategoryId = 2,
                    CandyDescription = "Tastey colorful chocolate",
                    CandyPrice = 15,
                    CandyQuantity = 40
                },

                new Candy
                {
                    CandyId = 3,
                    CandyName = "Gummi Cheries",
                    CandyCategoryId = 3,
                    CandyDescription = "Gummies are gelatin based chewy candies",
                    CandyPrice = 18,
                    CandyQuantity = 55
                },

                new Candy
                {
                    CandyId = 4,
                    CandyName = "Red Vines",
                    CandyCategoryId = 4,
                    CandyDescription = "Licorice is a semi-soft candy",
                    CandyPrice = 20,
                    CandyQuantity = 50
                }


                );


            modelBuilder.Entity<Category>().HasData(

                 new Category
                 {
                     CategoryId = 1,
                     CategoryName = "Caramels",
                 },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Chocolate",

                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Gummies",
                },

                 new Category
                 {
                     CategoryId = 4,
                     CategoryName = "Licorice",
                 }

                );

            modelBuilder.Entity<Cart>().HasData(
                new Cart { CartId = 1, CustomerCartId = customerId, TotalPrice = 100},
                new Cart { CartId = 2, CustomerCartId = customerId2, TotalPrice = 150 }
                );




            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string> { RoleId = adminRoleId, UserId = customerId },
               new IdentityUserRole<string> { RoleId = userRoleId, UserId = customerId2 }
               );


        }

    }
}