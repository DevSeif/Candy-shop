﻿using CandyShop.Models;
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
                   CandyQuantity = 50,
                   CandyImage = "candy1"
               },
                new Candy
                {
                    CandyId = 2,
                    CandyName = "Caramel Crunch",
                    CandyCategoryId = 1,
                    CandyDescription = "A tasty Caramel and sugary Crunch",
                    CandyPrice = 15,
                    CandyQuantity = 50,
                    CandyImage = "candy2"
                },
                new Candy
                {
                    CandyId = 3,
                    CandyName = "Vanilla Caramel",
                    CandyCategoryId = 1,
                    CandyDescription = "The Vanila taste with the sweet of caramel",
                    CandyPrice = 10,
                    CandyQuantity = 50,
                    CandyImage = "candy3"
                },
                new Candy
                {
                    CandyId = 4,
                    CandyName = "Caramel Squares",
                    CandyCategoryId = 1,
                    CandyDescription = "The Vanila taste with the sweet of caramel",
                    CandyPrice = 10,
                    CandyQuantity = 50,
                    CandyImage = "candy4"
                },
                new Candy
                {
                    CandyId = 5,
                    CandyName = "Nut Caramel",
                    CandyCategoryId = 1,
                    CandyDescription = "Combination of nuts and the sweet of caramel",
                    CandyPrice = 15,
                    CandyQuantity = 40,
                    CandyImage = "candy5"
                },
                new Candy
                {
                    CandyId = 6,
                    CandyName = "M&Ms",
                    CandyCategoryId = 2,
                    CandyDescription = "Tastey colorful chocolate",
                    CandyPrice = 15,
                    CandyQuantity = 40,
                    CandyImage = "candy6"
                },
                 new Candy
                 {
                     CandyId = 7,
                     CandyName = "Kit Kat",
                     CandyCategoryId = 2,
                     CandyDescription = "A mini full of flavor chocolate",
                     CandyPrice = 11,
                     CandyQuantity = 45,
                     CandyImage = "candy7"
                 },
                new Candy
                {
                    CandyId = 8,
                    CandyName = "Almond Joy",
                    CandyCategoryId = 2,
                    CandyDescription = "Combination of Almond and the sweet of chocolate",
                    CandyPrice = 16,
                    CandyQuantity = 40,
                    CandyImage = "candy8"
                },
                new Candy
                {
                    CandyId = 9,
                    CandyName = "Chocolate Cherries",
                    CandyCategoryId = 2,
                    CandyDescription = "Combination of Cherries flavor and the sweet of chocolate",
                    CandyPrice = 15,
                    CandyQuantity = 50,
                    CandyImage = "candy9"
                },
                new Candy
                {
                    CandyId = 10,
                    CandyName = "Krackle",
                    CandyCategoryId = 2,
                    CandyDescription = "Biscute Coverd of chocolate",
                    CandyPrice = 11,
                    CandyQuantity = 50,
                    CandyImage = "candy10"
                },
                new Candy
                {
                    CandyId = 11,
                    CandyName = "Snickers",
                    CandyCategoryId = 2,
                    CandyDescription = "Combination of nuts and the sweet of chocolate",
                    CandyPrice = 15,
                    CandyQuantity = 40,
                    CandyImage = "candy11"
                },
                new Candy
                {
                    CandyId = 12,
                    CandyName = "Gummi Cheries",
                    CandyCategoryId = 3,
                    CandyDescription = "Gummies are gelatin based chewy candies",
                    CandyPrice = 18,
                    CandyQuantity = 55,
                    CandyImage = "candy12"
                },
                 new Candy
                 {
                     CandyId = 13,
                     CandyName = "Gummi worms",
                     CandyCategoryId = 3,
                     CandyDescription = "Chewy candies With different flavors",
                     CandyPrice = 5,
                     CandyQuantity = 60,
                     CandyImage = "candy13"
                 },

                 new Candy
                 {
                     CandyId = 14,
                     CandyName = "Gummi cola bottles",
                     CandyCategoryId = 3,
                     CandyDescription = "Chewy candies With cola flavor",
                     CandyPrice = 5,
                     CandyQuantity = 60,
                     CandyImage = "candy14"
                 },
                new Candy
                {
                    CandyId = 15,
                    CandyName = "Gummi strawberry",
                    CandyCategoryId = 3,
                    CandyDescription = "Chewy candies With stawberry flavor",
                    CandyPrice = 5,
                    CandyQuantity = 60,
                    CandyImage = "candy15"
                },
                new Candy
                {
                    CandyId = 16,
                    CandyName = "Gummi banana",
                    CandyCategoryId = 3,
                    CandyDescription = "Chewy candies With banana flavor",
                    CandyPrice = 5,
                    CandyQuantity = 60,
                    CandyImage = "candy16"
                },
                new Candy
                {
                    CandyId = 17,
                    CandyName = "Red Vines",
                    CandyCategoryId = 4,
                    CandyDescription = "Licorice is a semi-soft candy",
                    CandyPrice = 20,
                    CandyQuantity = 50,
                    CandyImage = "candy17"
                },
                 new Candy
                 {
                     CandyId = 18,
                     CandyName = "Twizzler",
                     CandyCategoryId = 4,
                     CandyDescription = "Licorice is a semi-soft candy with cherry flavor",
                     CandyPrice = 20,
                     CandyQuantity = 50,
                     CandyImage = "candy18"
                 },
                  new Candy
                  {
                      CandyId = 19,
                      CandyName = "Chupa Chups",
                      CandyCategoryId = 4,
                      CandyDescription = "A hard sweet candy",
                      CandyPrice = 15,
                      CandyQuantity = 40,
                      CandyImage = "candy19"
                  },
                   new Candy
                   {
                       CandyId = 20,
                       CandyName = "Sour Punch",
                       CandyCategoryId = 4,
                       CandyDescription = "A sour candy",
                       CandyPrice = 13,
                       CandyQuantity = 30,
                       CandyImage = "candy20"
                   },
                  new Candy
                  {
                      CandyId = 21,
                      CandyName = "Warheads",
                      CandyCategoryId = 4,
                      CandyDescription = "A sour candy",
                      CandyPrice = 15,
                      CandyQuantity = 40,
                      CandyImage = "candy21"
                  },
                   new Candy
                   {
                       CandyId = 22,
                       CandyName = "Abba-Zaba",
                       CandyCategoryId = 4,
                       CandyDescription = "Chewy sweet candy",
                       CandyPrice = 10,
                       CandyQuantity = 70,
                       CandyImage = "candy22"
                   },
                    new Candy
                    {
                        CandyId = 23,
                        CandyName = "Sky Bar",
                        CandyCategoryId = 4,
                        CandyDescription = "Chewy sweet candy",
                        CandyPrice = 5,
                        CandyQuantity = 60,
                        CandyImage = "candy23"
                    },
                     new Candy
                     {
                         CandyId = 24,
                         CandyName = "Peach Blossoms",
                         CandyCategoryId = 4,
                         CandyDescription = "Chewy with peach flavor candy",
                         CandyPrice = 10,
                         CandyQuantity = 50,
                         CandyImage = "candy24"
                     }

                );


            modelBuilder.Entity<Category>().HasData(

                 new Category
                 {
                     CategoryId = 1,
                     CategoryName = "Caramels",
                     CategoryImage = "category1"
                 },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Chocolate",
                    CategoryImage = "category2"
                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Gummies",
                    CategoryImage = "category3"
                },

                 new Category
                 {
                     CategoryId = 4,
                     CategoryName = "Combination",
                     CategoryImage = "category4"
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