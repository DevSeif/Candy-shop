using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class Iniit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrders_Carts_CartId",
                table: "ItemOrders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bdd546f2-0671-4a0f-bcd2-5706f3281667", "32f4de69-d6bf-45f5-8e2a-86f1deb05e87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fec23b7b-213c-460b-91b2-de00859d7d4c", "8723baaf-8f7c-4c90-8f4d-391030b6ba78" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdd546f2-0671-4a0f-bcd2-5706f3281667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fec23b7b-213c-460b-91b2-de00859d7d4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32f4de69-d6bf-45f5-8e2a-86f1deb05e87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8723baaf-8f7c-4c90-8f4d-391030b6ba78");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "ItemOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79b4808f-81a7-4ce7-a085-aa48f9220a09", "6cb5ebdb-438c-4298-89b6-9b38e2754b12", "User", "USER" },
                    { "f09c4969-25f1-4f21-8e14-a0daf651fbc8", "78546761-3afb-483b-a3f6-1cae622b0176", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "851938db-f54e-4812-8456-5d56b1d2c11d", 0, "Adminsgatan 8A", "Göteborg", "f65e2e80-129f-4c76-a0fa-52c41ea046d0", "Sweden", "00000 00000 00000", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEEVqWC67Ggykh8bwWQm2txth0SEooZi8W5Gvvfn+njhxcizVbDkH7ZhPko3j21EQ9g==", "0737555555", false, "411777", "d45ca5e3-77ca-4c01-8315-e532d55ac2c3", false, "admin@gmail.com" },
                    { "f79ace58-c8c4-4c3f-834a-fae52f4c0051", 0, "Usersgatan 8A", "Göteborg", "ba8848e1-ea50-41ac-b1ec-fd2ca1328ae7", "Sweden", "00000 00000 00000", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAEAs+Me6bVeuKonG2JGTh6RhC9HcYX6YMnfljhAxUGs1QJ/hOvUfIXr37vXIuX9erVA==", "0737555555", false, "411777", "d437e8e9-7c9a-4b1a-8358-35cf34ac3aed", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f09c4969-25f1-4f21-8e14-a0daf651fbc8", "851938db-f54e-4812-8456-5d56b1d2c11d" },
                    { "79b4808f-81a7-4ce7-a085-aa48f9220a09", "f79ace58-c8c4-4c3f-834a-fae52f4c0051" }
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1,
                column: "CustomerCartId",
                value: "851938db-f54e-4812-8456-5d56b1d2c11d");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 2,
                column: "CustomerCartId",
                value: "f79ace58-c8c4-4c3f-834a-fae52f4c0051");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrders_Carts_CartId",
                table: "ItemOrders",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrders_Carts_CartId",
                table: "ItemOrders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f09c4969-25f1-4f21-8e14-a0daf651fbc8", "851938db-f54e-4812-8456-5d56b1d2c11d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79b4808f-81a7-4ce7-a085-aa48f9220a09", "f79ace58-c8c4-4c3f-834a-fae52f4c0051" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79b4808f-81a7-4ce7-a085-aa48f9220a09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f09c4969-25f1-4f21-8e14-a0daf651fbc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "851938db-f54e-4812-8456-5d56b1d2c11d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f79ace58-c8c4-4c3f-834a-fae52f4c0051");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "ItemOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bdd546f2-0671-4a0f-bcd2-5706f3281667", "f6769013-6f1d-4445-b90d-88bbc2f5951a", "User", "USER" },
                    { "fec23b7b-213c-460b-91b2-de00859d7d4c", "449cb28c-8f20-427e-84a7-1a7dbc904a21", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32f4de69-d6bf-45f5-8e2a-86f1deb05e87", 0, "Usersgatan 8A", "Göteborg", "49e67245-a320-4568-a219-2fc1120ab2f9", "Sweden", "00000 00000 00000", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAEFHp0AdmuUKur8lluVMsJ7hlyRivHDbp7jp+lPxouVHq1G5zLjIwYAv2iXmQsA6NLA==", "0737555555", false, "411777", "d020e442-4129-46f2-8d72-1c1a32f4b79b", false, "user@gmail.com" },
                    { "8723baaf-8f7c-4c90-8f4d-391030b6ba78", 0, "Adminsgatan 8A", "Göteborg", "3da466cb-a12f-4060-abf1-0c0e43c5877f", "Sweden", "00000 00000 00000", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEPDn0/w3IYrL1Bv9+cbSorqoMYu6mSyot5SePO6DOeQtPgwZqfUo9IlIvfgsii2Arw==", "0737555555", false, "411777", "4894a37d-bae5-43d9-8c56-87bf2593075f", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bdd546f2-0671-4a0f-bcd2-5706f3281667", "32f4de69-d6bf-45f5-8e2a-86f1deb05e87" },
                    { "fec23b7b-213c-460b-91b2-de00859d7d4c", "8723baaf-8f7c-4c90-8f4d-391030b6ba78" }
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1,
                column: "CustomerCartId",
                value: "8723baaf-8f7c-4c90-8f4d-391030b6ba78");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 2,
                column: "CustomerCartId",
                value: "32f4de69-d6bf-45f5-8e2a-86f1deb05e87");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrders_Carts_CartId",
                table: "ItemOrders",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId");
        }
    }
}
