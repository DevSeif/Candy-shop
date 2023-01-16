using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class Seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candies_Categories_CandyCategoryId",
                table: "Candies");

            migrationBuilder.DropIndex(
                name: "IX_Candies_CandyCategoryId",
                table: "Candies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72d94030-7b6a-4c8b-b7a7-8fd2363c9131", "7e82665a-189c-4d49-80c4-affb9e9bc8aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d71753c8-99da-4527-99a2-fb5c87277c56", "d6e0a51b-d276-46fe-bc3c-75a8e0478477" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72d94030-7b6a-4c8b-b7a7-8fd2363c9131");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d71753c8-99da-4527-99a2-fb5c87277c56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e82665a-189c-4d49-80c4-affb9e9bc8aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6e0a51b-d276-46fe-bc3c-75a8e0478477");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Candies",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "090fd892-b09a-40f5-80c6-f5498633daf4", "df7d2052-cf18-4dad-9941-7e097a179f7b", "User", "USER" },
                    { "abf89200-196e-4ea6-a79e-de76dfe5b8de", "be0184f9-49dd-4d58-9e18-d4cd4f82e59d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CandyCategoryId", "CandyDescription", "CandyName", "CandyPrice", "CandyQuantity", "CartId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1, "Caramels are made by cooking sugar and water together", "Coffee Rio", 5.0, 50, null, null },
                    { 2, 2, "Tastey colorful chocolate", "M&Ms", 15.0, 40, null, null },
                    { 3, 3, "Gummies are gelatin based chewy candies", "Gummi Cheries", 18.0, 55, null, null },
                    { 4, 4, "Licorice is a semi-soft candy", "Red Vines", 20.0, 50, null, null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "CustomerId", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0, 0.0 },
                    { 2, 0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CandyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Caramels" },
                    { 2, 2, "Chocolate" },
                    { 3, 3, "Gummies" },
                    { 4, 4, "Licorice" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "TotalAmount" },
                values: new object[] { 1, new DateTime(2023, 1, 16, 10, 59, 11, 926, DateTimeKind.Local).AddTicks(3831), 0m });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "249a51b1-b3e9-46a5-adb4-2f52358c49fc", 0, "South earth", 2, "Stockholm", "611a3580-1db9-4c9b-b895-8d0cb921a018", "Sweden", "555", "User", "Usersson", "user@user.com", false, false, null, "USER@USER.COM", "USER", 2, "AQAAAAEAACcQAAAAELuEl3uQgut34OcWsaWGy7FZofNZDA9wdEKuR1VP4c+oqfajcxBWrcMHTxsk/ncNNQ==", "7777", false, 0, "fd8bf5c5-66bf-4704-8006-ac959eb5acd1", false, "User" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ce2bfa7-4805-4d19-a857-4e68af80fea1", 0, "North earth", 1, "Gothenburg", "533385db-1306-4679-ae47-6cc8c3c893e2", "Sweden", "785 785 744", "Admin", "Adminson", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEDWqmrCpkFeUyvLR8fEMz7wbsfx1S3TE6X6M2Uz2x4jiwVd6KH7APfYXs70w5bLQrA==", "8888", false, 0, "b2c1d2dc-f5f2-42d3-be67-11063ae282be", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "090fd892-b09a-40f5-80c6-f5498633daf4", "249a51b1-b3e9-46a5-adb4-2f52358c49fc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "abf89200-196e-4ea6-a79e-de76dfe5b8de", "4ce2bfa7-4805-4d19-a857-4e68af80fea1" });

            migrationBuilder.CreateIndex(
                name: "IX_Candies_CategoryId",
                table: "Candies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies");

            migrationBuilder.DropIndex(
                name: "IX_Candies_CategoryId",
                table: "Candies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "090fd892-b09a-40f5-80c6-f5498633daf4", "249a51b1-b3e9-46a5-adb4-2f52358c49fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abf89200-196e-4ea6-a79e-de76dfe5b8de", "4ce2bfa7-4805-4d19-a857-4e68af80fea1" });

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "090fd892-b09a-40f5-80c6-f5498633daf4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abf89200-196e-4ea6-a79e-de76dfe5b8de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "249a51b1-b3e9-46a5-adb4-2f52358c49fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ce2bfa7-4805-4d19-a857-4e68af80fea1");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Candies");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72d94030-7b6a-4c8b-b7a7-8fd2363c9131", "ff02d69e-ca22-4d1f-93c3-b96c5cfa2adb", "Admin", "ADMIN" },
                    { "d71753c8-99da-4527-99a2-fb5c87277c56", "c14c7c90-9390-4d12-8625-7d48299e7ff4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartId", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7e82665a-189c-4d49-80c4-affb9e9bc8aa", 0, "North earth", 1, "Gothenburg", "ede71a3a-1334-4f21-a3dc-0d0230c912e5", "Sweden", "785 785 744", "Admin", "Adminson", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN", 1, "AQAAAAEAACcQAAAAEIXI05EqUkZrXxiEs2aTxTnoUMrwNBdkcb6zm8RXHbqwQnfE6Rp3AicKrcbn89muzw==", "8888", false, 0, "2e1d3c8e-f953-44a7-8c05-1554a010aa73", false, "Admin" },
                    { "d6e0a51b-d276-46fe-bc3c-75a8e0478477", 0, "South earth", 2, "Stockholm", "ec8c25ba-6a94-4e70-ae9b-caf1e31042d5", "Sweden", "555", "User", "Usersson", "user@user.com", false, false, null, "USER@USER.COM", "USER", 2, "AQAAAAEAACcQAAAAEMrZrONja7wvHshMqcXf3FyFzURGx8PkSkPnhyToUm08OjIb86x+FogAz0HjnUTk3Q==", "7777", false, 0, "54d31f5c-ee50-4f81-8fb5-e760bd5be489", false, "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "72d94030-7b6a-4c8b-b7a7-8fd2363c9131", "7e82665a-189c-4d49-80c4-affb9e9bc8aa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d71753c8-99da-4527-99a2-fb5c87277c56", "d6e0a51b-d276-46fe-bc3c-75a8e0478477" });

            migrationBuilder.CreateIndex(
                name: "IX_Candies_CandyCategoryId",
                table: "Candies",
                column: "CandyCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candies_Categories_CandyCategoryId",
                table: "Candies",
                column: "CandyCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
