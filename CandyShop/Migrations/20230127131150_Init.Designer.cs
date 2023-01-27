﻿// <auto-generated />
using System;
using CandyShop.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CandyShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230127131150_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CandyShop.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLName")
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
                        .IsRequired()
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
                            Id = "72b56c09-cd76-4ce3-bf2a-8fedebc2aea5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd9fb75e-9696-4661-a4fa-b7dc768490ff",
                            CustomerFName = "Admin",
                            CustomerLName = "Adminsson",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL:COM",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEGKT0dtB7jPf8n+roM6Id46UOBn1qhOCgum3Ftrsf1pfuAgz/jlXDJQp4vsIrVkqrg==",
                            PhoneNumber = "0737555555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0881eb92-016c-422e-abca-c13ad3ddbcc3",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "921978db-6e84-4e67-a711-7cd635f8f85c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "98b6917f-d05c-4f47-b124-497cb97e94df",
                            CustomerFName = "User",
                            CustomerLName = "Usersson",
                            Email = "user@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@GMAIL:COM",
                            NormalizedUserName = "user@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEMNcFQ3x1AQkxLbN5K7UgA5GBz59UsqPevIBOmm3sp7DyMePS6LrEDKwLsd1qsgZaQ==",
                            PhoneNumber = "0737555555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d897b965-d986-403f-88f1-17f25ade0f32",
                            TwoFactorEnabled = false,
                            UserName = "user@gmail.com"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandyId"), 1L, 1);

                    b.Property<int>("CandyCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CandyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandyImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CandyPrice")
                        .HasColumnType("float");

                    b.Property<int>("CandyQuantity")
                        .HasColumnType("int");

                    b.HasKey("CandyId");

                    b.HasIndex("CandyCategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CandyCategoryId = 1,
                            CandyDescription = "Caramels are made by cooking sugar and water together",
                            CandyImage = "candy1",
                            CandyName = "Coffee Rio",
                            CandyPrice = 5.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 2,
                            CandyCategoryId = 1,
                            CandyDescription = "A tasty Caramel and sugary Crunch",
                            CandyImage = "candy2",
                            CandyName = "Caramel Crunch",
                            CandyPrice = 15.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 3,
                            CandyCategoryId = 1,
                            CandyDescription = "The Vanila taste with the sweet of caramel",
                            CandyImage = "candy3",
                            CandyName = "Vanilla Caramel",
                            CandyPrice = 10.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 4,
                            CandyCategoryId = 1,
                            CandyDescription = "The Vanila taste with the sweet of caramel",
                            CandyImage = "candy4",
                            CandyName = "Caramel Squares",
                            CandyPrice = 10.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 5,
                            CandyCategoryId = 1,
                            CandyDescription = "Combination of nuts and the sweet of caramel",
                            CandyImage = "candy5",
                            CandyName = "Nut Caramel",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 6,
                            CandyCategoryId = 2,
                            CandyDescription = "Tastey colorful chocolate",
                            CandyImage = "candy6",
                            CandyName = "M&Ms",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 7,
                            CandyCategoryId = 2,
                            CandyDescription = "A mini full of flavor chocolate",
                            CandyImage = "candy7",
                            CandyName = "Kit Kat",
                            CandyPrice = 11.0,
                            CandyQuantity = 45
                        },
                        new
                        {
                            CandyId = 8,
                            CandyCategoryId = 2,
                            CandyDescription = "Combination of Almond and the sweet of chocolate",
                            CandyImage = "candy8",
                            CandyName = "Almond Joy",
                            CandyPrice = 16.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 9,
                            CandyCategoryId = 2,
                            CandyDescription = "Combination of Cherries flavor and the sweet of chocolate",
                            CandyImage = "candy9",
                            CandyName = "Chocolate Cherries",
                            CandyPrice = 15.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 10,
                            CandyCategoryId = 2,
                            CandyDescription = "Biscute Coverd of chocolate",
                            CandyImage = "candy10",
                            CandyName = "Krackle",
                            CandyPrice = 11.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 11,
                            CandyCategoryId = 2,
                            CandyDescription = "Combination of nuts and the sweet of chocolate",
                            CandyImage = "candy11",
                            CandyName = "Snickers",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 12,
                            CandyCategoryId = 3,
                            CandyDescription = "Gummies are gelatin based chewy candies",
                            CandyImage = "candy12",
                            CandyName = "Gummi Cheries",
                            CandyPrice = 18.0,
                            CandyQuantity = 55
                        },
                        new
                        {
                            CandyId = 13,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With different flavors",
                            CandyImage = "candy13",
                            CandyName = "Gummi worms",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 14,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With cola flavor",
                            CandyImage = "candy14",
                            CandyName = "Gummi cola bottles",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 15,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With stawberry flavor",
                            CandyImage = "candy15",
                            CandyName = "Gummi strawberry",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 16,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With banana flavor",
                            CandyImage = "candy16",
                            CandyName = "Gummi banana",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 17,
                            CandyCategoryId = 4,
                            CandyDescription = "Licorice is a semi-soft candy",
                            CandyImage = "candy17",
                            CandyName = "Red Vines",
                            CandyPrice = 20.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 18,
                            CandyCategoryId = 4,
                            CandyDescription = "Licorice is a semi-soft candy with cherry flavor",
                            CandyImage = "candy18",
                            CandyName = "Twizzler",
                            CandyPrice = 20.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 19,
                            CandyCategoryId = 4,
                            CandyDescription = "A hard sweet candy",
                            CandyImage = "candy19",
                            CandyName = "Chupa Chups",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 20,
                            CandyCategoryId = 4,
                            CandyDescription = "A sour candy",
                            CandyImage = "candy20",
                            CandyName = "Sour Punch",
                            CandyPrice = 13.0,
                            CandyQuantity = 30
                        },
                        new
                        {
                            CandyId = 21,
                            CandyCategoryId = 4,
                            CandyDescription = "A sour candy",
                            CandyImage = "candy21",
                            CandyName = "Warheads",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 22,
                            CandyCategoryId = 4,
                            CandyDescription = "Chewy sweet candy",
                            CandyImage = "candy22",
                            CandyName = "Abba-Zaba",
                            CandyPrice = 10.0,
                            CandyQuantity = 70
                        },
                        new
                        {
                            CandyId = 23,
                            CandyCategoryId = 4,
                            CandyDescription = "Chewy sweet candy",
                            CandyImage = "candy23",
                            CandyName = "Sky Bar",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 24,
                            CandyCategoryId = 4,
                            CandyDescription = "Chewy with peach flavor candy",
                            CandyImage = "candy24",
                            CandyName = "Peach Blossoms",
                            CandyPrice = 10.0,
                            CandyQuantity = 50
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<string>("CustomerCartId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerCartId")
                        .IsUnique()
                        .HasFilter("[CustomerCartId] IS NOT NULL");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            CartId = 1,
                            CustomerCartId = "72b56c09-cd76-4ce3-bf2a-8fedebc2aea5"
                        },
                        new
                        {
                            CartId = 2,
                            CustomerCartId = "921978db-6e84-4e67-a711-7cd635f8f85c"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryImage = "category1",
                            CategoryName = "Caramels"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryImage = "category2",
                            CategoryName = "Chocolate"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryImage = "category3",
                            CategoryName = "Gummies"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryImage = "category4",
                            CategoryName = "Combination"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.ItemOrder", b =>
                {
                    b.Property<int>("ItemOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemOrderId"), 1L, 1);

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("CandyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemOrderId");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.ToTable("ItemOrders");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
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

                    b.HasData(
                        new
                        {
                            Id = "080f8271-bc82-470f-887b-00e7fcd5a664",
                            ConcurrencyStamp = "96b1617a-039c-41d7-8a44-a2cf6af049b4",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "1f3010f4-8e2c-4635-b336-629b6449e666",
                            ConcurrencyStamp = "861c87e0-5ae5-49e9-86d8-81fda70c9e5c",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "72b56c09-cd76-4ce3-bf2a-8fedebc2aea5",
                            RoleId = "080f8271-bc82-470f-887b-00e7fcd5a664"
                        },
                        new
                        {
                            UserId = "921978db-6e84-4e67-a711-7cd635f8f85c",
                            RoleId = "1f3010f4-8e2c-4635-b336-629b6449e666"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CandyCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CandyShop.Models.Cart", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("CandyShop.Models.Cart", "CustomerCartId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CandyShop.Models.ItemOrder", b =>
                {
                    b.HasOne("CandyShop.Models.Cart", "Cart")
                        .WithMany("ItemOrders")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
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
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
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

                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CandyShop.Models.Cart", b =>
                {
                    b.Navigation("ItemOrders");
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Navigation("Candies");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
