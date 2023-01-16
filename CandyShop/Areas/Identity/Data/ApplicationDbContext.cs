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
    }

}
