using CandyShop.Areas.Identity.Data;
using CandyShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CandyShop.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext()
    {

    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    //Database
    public DbSet<Candy> Candies { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> Items { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Category> Categories { get; set; }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("ConnectionString");
    //}

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        base.OnModelCreating(modelbuilder);

        //Identity
        string adminRoleId = Guid.NewGuid().ToString();
        string userRoleID = Guid.NewGuid().ToString();

        modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = adminRoleId,
            Name = "Admin",
            NormalizedName = "ADMIN",
        });

        modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = userRoleID,
            Name = "User",
            NormalizedName = "USER",
        });


        string adminId = Guid.NewGuid().ToString();
        string userId = Guid.NewGuid().ToString();
        string userId2 = Guid.NewGuid().ToString();
        PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
        
        modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
        {
            Id = adminId,
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            CustomerFName = "Admin",
            CustomerLName = "Adminson",
            CreditCardNumber = "785 785 744",
            Address = "North earth",
            City = "Gothenburg",
            Country = "Sweden",
            PhoneNumber = "8888",
            CartId = 1,
            OrderId = 1,

            PasswordHash = hasher.HashPassword(null, "password")
        });


        modelbuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = userId,
                Email = "user@user.com",
                NormalizedEmail = "USER@USER.COM",
                UserName = "User",
                NormalizedUserName = "USER",
                CustomerFName = "User",
                CustomerLName = "Usersson",
                CreditCardNumber = "555",
                Address = "South earth",
                City = "Stockholm",
                Country = "Sweden",
                PhoneNumber = "7777",
                CartId = 2,
                OrderId = 2,

                PasswordHash = hasher.HashPassword(null, "password")
            });

        modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = adminRoleId,
            UserId = adminId
        });
        modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = userRoleID,
            UserId = userId,
        });

        //Candy

        modelbuilder.Entity<Candy>().HasData(new Candy
        {
            CandyId = 1,
            CandyName = "Coffee Rio",
            CandyCategoryId = 1,
            CandyDescription = "Caramels are made by cooking sugar and water together",
            CandyPrice = 5,
            CandyQuantity = 50
        });
        modelbuilder.Entity<Candy>().HasData(new Candy
        {
            CandyId = 2,
            CandyName = "M&Ms",
            CandyCategoryId = 2,
            CandyDescription = "Tastey colorful chocolate",
            CandyPrice = 15,
            CandyQuantity = 40
        });
        modelbuilder.Entity<Candy>().HasData(new Candy
        {
            CandyId = 3,
            CandyName = "Gummi Cheries",
            CandyCategoryId = 3,
            CandyDescription = "Gummies are gelatin based chewy candies",
            CandyPrice = 18,
            CandyQuantity = 55
        });
        modelbuilder.Entity<Candy>().HasData(new Candy
        {
            CandyId = 4,
            CandyName = "Red Vines",
            CandyCategoryId = 4,
            CandyDescription = "Licorice is a semi-soft candy",
            CandyPrice = 20,
            CandyQuantity = 50
        });
        //Category
        modelbuilder.Entity<Category>().HasData(new Category
        {
            CategoryId = 1,
            Name = "Caramels",
           CandyId = 1

        });
        modelbuilder.Entity<Category>().HasData(new Category
        {
            CategoryId = 2,
            Name = "Chocolate",
            CandyId = 2

        });
        modelbuilder.Entity<Category>().HasData(new Category
        {
            CategoryId = 3,
            Name = "Gummies",
            CandyId = 3

        });
        modelbuilder.Entity<Category>().HasData(new Category
        {
            CategoryId = 4,
            Name = "Licorice",
            CandyId = 4

        });
        //cart
        modelbuilder.Entity<Cart>().HasData(new Cart { CartId = 1 });
        modelbuilder.Entity<Cart>().HasData(new Cart { CartId = 2 });

        //Order
        modelbuilder.Entity<Order>().HasData(new Order { 
            OrderId = 1,
            OrderDate = DateTime.Now,
            
        });
    
    }

}
