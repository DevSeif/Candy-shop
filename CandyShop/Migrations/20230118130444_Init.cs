using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    CustomerCartId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_CustomerCartId",
                        column: x => x.CustomerCartId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candies",
                columns: table => new
                {
                    CandyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandyCategoryId = table.Column<int>(type: "int", nullable: false),
                    CandyPrice = table.Column<double>(type: "float", nullable: false),
                    CandyQuantity = table.Column<int>(type: "int", nullable: false),
                    CandyImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candies", x => x.CandyId);
                    table.ForeignKey(
                        name: "FK_Candies_Categories_CandyCategoryId",
                        column: x => x.CandyCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemOrders",
                columns: table => new
                {
                    ItemOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandyId = table.Column<int>(type: "int", nullable: false),
                    CandyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrders", x => x.ItemOrderId);
                    table.ForeignKey(
                        name: "FK_ItemOrders_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "192f35b6-4182-4edc-9b66-82e602851393", "e398201f-9b9e-46d7-9e2a-5ad1f372f2bf", "User", "USER" },
                    { "f4c5db8d-dbd7-4abd-b2ab-115d20d9bfab", "3af30d3d-6605-4657-b9b5-a5a6ae1e7588", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4e52bff5-5d2c-4b25-ae56-7d9233ef6efb", 0, "Usersgatan 8A", "Göteborg", "b2422928-07ba-4cd3-b3bf-d8109e2749c9", "Sweden", "00000 00000 00000", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAEJBWJ5S3Hw+EMQUYSMaHzlXkWwDGOzxeg4apyBp6WvozBgiY/BBI7K/+bqFehyeNEg==", "0737555555", false, "411777", "200a4ec2-afb6-4268-a99d-1e782376b902", false, "user@gmail.com" },
                    { "bb3cdafc-eef5-45c5-b642-866f9ccb08e1", 0, "Adminsgatan 8A", "Göteborg", "87144dd3-62ee-4a5a-9809-410c37889be2", "Sweden", "00000 00000 00000", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEL32W3ZKhAEPWr1DwfGb+Kju0lZPGkKO6CtEcMgG3LIaK7fVKXa7wErmoAOlXK03NA==", "0737555555", false, "411777", "c0285dac-b662-47a0-8d84-234ca63de55e", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[,]
                {
                    { 1, "category1", "Caramels" },
                    { 2, "category2", "Chocolate" },
                    { 3, "category3", "Gummies" },
                    { 4, "category4", "Combination" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "192f35b6-4182-4edc-9b66-82e602851393", "4e52bff5-5d2c-4b25-ae56-7d9233ef6efb" },
                    { "f4c5db8d-dbd7-4abd-b2ab-115d20d9bfab", "bb3cdafc-eef5-45c5-b642-866f9ccb08e1" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CandyCategoryId", "CandyDescription", "CandyImage", "CandyName", "CandyPrice", "CandyQuantity" },
                values: new object[,]
                {
                    { 1, 1, "Caramels are made by cooking sugar and water together", "candy1", "Coffee Rio", 5.0, 50 },
                    { 2, 1, "A tasty Caramel and sugary Crunch", "candy2", "Caramel Crunch", 15.0, 50 },
                    { 3, 1, "The Vanila taste with the sweet of caramel", "candy3", "Vanilla Caramel", 10.0, 50 },
                    { 4, 1, "The Vanila taste with the sweet of caramel", "candy4", "Caramel Squares", 10.0, 50 },
                    { 5, 1, "Combination of nuts and the sweet of caramel", "candy5", "Nut Caramel", 15.0, 40 },
                    { 6, 2, "Tastey colorful chocolate", "candy6", "M&Ms", 15.0, 40 },
                    { 7, 2, "A mini full of flavor chocolate", "candy7", "Kit Kat", 11.0, 45 },
                    { 8, 2, "Combination of Almond and the sweet of chocolate", "candy8", "Almond Joy", 16.0, 40 },
                    { 9, 2, "Combination of Cherries flavor and the sweet of chocolate", "candy9", "Chocolate Cherries", 15.0, 50 },
                    { 10, 2, "Biscute Coverd of chocolate", "candy10", "Krackle", 11.0, 50 },
                    { 11, 2, "Combination of nuts and the sweet of chocolate", "candy11", "Snickers", 15.0, 40 },
                    { 12, 3, "Gummies are gelatin based chewy candies", "candy12", "Gummi Cheries", 18.0, 55 },
                    { 13, 3, "Chewy candies With different flavors", "candy13", "Gummi worms", 5.0, 60 },
                    { 14, 3, "Chewy candies With cola flavor", "candy14", "Gummi cola bottles", 5.0, 60 },
                    { 15, 3, "Chewy candies With stawberry flavor", "candy15", "Gummi strawberry", 5.0, 60 },
                    { 16, 3, "Chewy candies With banana flavor", "candy16", "Gummi banana", 5.0, 60 },
                    { 17, 4, "Licorice is a semi-soft candy", "candy17", "Red Vines", 20.0, 50 },
                    { 18, 4, "Licorice is a semi-soft candy with cherry flavor", "candy18", "Twizzler", 20.0, 50 },
                    { 19, 4, "A hard sweet candy", "candy19", "Chupa Chups", 15.0, 40 },
                    { 20, 4, "A sour candy", "candy20", "Sour Punch", 13.0, 30 },
                    { 21, 4, "A sour candy", "candy21", "Warheads", 15.0, 40 },
                    { 22, 4, "Chewy sweet candy", "candy22", "Abba-Zaba", 10.0, 70 },
                    { 23, 4, "Chewy sweet candy", "candy23", "Sky Bar", 5.0, 60 },
                    { 24, 4, "Chewy with peach flavor candy", "candy24", "Peach Blossoms", 10.0, 50 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "CustomerCartId", "TotalPrice" },
                values: new object[,]
                {
                    { 1, "bb3cdafc-eef5-45c5-b642-866f9ccb08e1", 100 },
                    { 2, "4e52bff5-5d2c-4b25-ae56-7d9233ef6efb", 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Candies_CandyCategoryId",
                table: "Candies",
                column: "CandyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerCartId",
                table: "Carts",
                column: "CustomerCartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrders_CartId",
                table: "ItemOrders",
                column: "CartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Candies");

            migrationBuilder.DropTable(
                name: "ItemOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
