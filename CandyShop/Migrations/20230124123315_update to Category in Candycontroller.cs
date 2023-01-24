using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class updatetoCategoryinCandycontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_CustomerCartId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CustomerCartId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7521e293-361e-417e-afce-0e9487ab15e9", "08724a51-4414-4801-9b16-aac2ec42b58c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98bd5272-84d1-492d-baba-a7aa374ed7f8", "d674492d-02ab-4f05-9dfe-566a546191d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7521e293-361e-417e-afce-0e9487ab15e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98bd5272-84d1-492d-baba-a7aa374ed7f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08724a51-4414-4801-9b16-aac2ec42b58c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d674492d-02ab-4f05-9dfe-566a546191d8");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryImage",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCartId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CandyName",
                table: "Candies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CandyImage",
                table: "Candies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CandyDescription",
                table: "Candies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67a7d866-71b0-4218-b40c-a5f12ecf658c", "c73d6b64-6eb7-41b3-9870-cfc84bc7e5fc", "User", "USER" },
                    { "6ebb72cc-aa37-4d5d-979d-4e485f0f2403", "6f583152-8427-41c6-b119-e305acea9ab0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ae66b829-2bfc-4448-a67f-6f288e569919", 0, "Usersgatan 8A", "Göteborg", "4177cbd0-73ae-4127-b656-5cf4d39669bc", "Sweden", "00000 00000 00000", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAEFYHsdjXOa4vMPHyw6n5sUP5OqJxRwV8li8JXF26fHskvtNFa73xzWD6aS0bTG3XMA==", "0737555555", false, "411777", "b8fef4c3-6356-445d-877c-89da24cc635e", false, "user@gmail.com" },
                    { "cc2214ad-755e-4fca-ac3a-60c2f41af185", 0, "Adminsgatan 8A", "Göteborg", "b8d58e99-1561-4286-8490-9aa3ece2656d", "Sweden", "00000 00000 00000", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEBHzwhsOPc3cLr8gXdnRCYEQIUN+vG19plsqkBnisn1Is+jakOElP5WV0uIxrIkhAQ==", "0737555555", false, "411777", "32cd3e13-d21e-4bcd-9f83-5960e0cfac24", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "67a7d866-71b0-4218-b40c-a5f12ecf658c", "ae66b829-2bfc-4448-a67f-6f288e569919" },
                    { "6ebb72cc-aa37-4d5d-979d-4e485f0f2403", "cc2214ad-755e-4fca-ac3a-60c2f41af185" }
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1,
                column: "CustomerCartId",
                value: "cc2214ad-755e-4fca-ac3a-60c2f41af185");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 2,
                column: "CustomerCartId",
                value: "ae66b829-2bfc-4448-a67f-6f288e569919");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerCartId",
                table: "Carts",
                column: "CustomerCartId",
                unique: true,
                filter: "[CustomerCartId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_CustomerCartId",
                table: "Carts",
                column: "CustomerCartId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_CustomerCartId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CustomerCartId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67a7d866-71b0-4218-b40c-a5f12ecf658c", "ae66b829-2bfc-4448-a67f-6f288e569919" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ebb72cc-aa37-4d5d-979d-4e485f0f2403", "cc2214ad-755e-4fca-ac3a-60c2f41af185" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a7d866-71b0-4218-b40c-a5f12ecf658c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ebb72cc-aa37-4d5d-979d-4e485f0f2403");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae66b829-2bfc-4448-a67f-6f288e569919");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2214ad-755e-4fca-ac3a-60c2f41af185");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryImage",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCartId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CandyName",
                table: "Candies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CandyImage",
                table: "Candies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CandyDescription",
                table: "Candies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7521e293-361e-417e-afce-0e9487ab15e9", "404a4bf1-d8cb-4c7b-bbbd-b2cb82a93d4d", "Admin", "ADMIN" },
                    { "98bd5272-84d1-492d-baba-a7aa374ed7f8", "6bf83663-596c-48bc-9183-c4a8ebfd26fc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08724a51-4414-4801-9b16-aac2ec42b58c", 0, "Adminsgatan 8A", "Göteborg", "019959da-1b89-4ce5-87cb-ef02a31c2aa2", "Sweden", "00000 00000 00000", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEC+Jd2ApEJ3h7WYuLLqRr8kFOkTtU/oNhIdWdv1UFqRxRZGfrcEYyF5zxTRCbguG0Q==", "0737555555", false, "411777", "fbb5bebf-e642-4034-b0ff-e08ed08a3333", false, "admin@gmail.com" },
                    { "d674492d-02ab-4f05-9dfe-566a546191d8", 0, "Usersgatan 8A", "Göteborg", "0dceee35-c744-4938-9c08-99f5d94a3760", "Sweden", "00000 00000 00000", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAEIHOGYicE6VWCUWa9px2XpIJtg60dzZe10wl/GHPe2KT8rqQduKU9c4oqiokMZdIPg==", "0737555555", false, "411777", "6ae695be-9c8d-44f8-9725-a14327a33c2e", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7521e293-361e-417e-afce-0e9487ab15e9", "08724a51-4414-4801-9b16-aac2ec42b58c" },
                    { "98bd5272-84d1-492d-baba-a7aa374ed7f8", "d674492d-02ab-4f05-9dfe-566a546191d8" }
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1,
                column: "CustomerCartId",
                value: "08724a51-4414-4801-9b16-aac2ec42b58c");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 2,
                column: "CustomerCartId",
                value: "d674492d-02ab-4f05-9dfe-566a546191d8");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerCartId",
                table: "Carts",
                column: "CustomerCartId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_CustomerCartId",
                table: "Carts",
                column: "CustomerCartId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
