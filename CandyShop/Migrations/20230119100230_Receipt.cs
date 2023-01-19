using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class Receipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    ReceiptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.ReceiptId);
                    table.ForeignKey(
                        name: "FK_Receipts_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptItem",
                columns: table => new
                {
                    CandyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ReceiptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptItem", x => x.CandyName);
                    table.ForeignKey(
                        name: "FK_ReceiptItem_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "ReceiptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a12e4862-9b26-4cd1-855e-8b07eb2ab1cb", "a221f74b-3154-4d81-959e-256765dd6fcc", "Admin", "ADMIN" },
                    { "f67472a9-4702-4b7e-a535-761740987ba0", "375213ce-b63d-4ba6-b6a7-3120794aa47f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CreditCardNumber", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b1625925-8997-4a58-bc1d-863843027c26", 0, "Usersgatan 8A", "Göteborg", "83b90a49-0484-4ba1-b1ae-7ddcc604d280", "Sweden", "00000 00000 00000", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAECthO66+lc5QavMqMjWrAssY1Ci0FFpxlMdSkbT5gFFteUz5B+Qqz3U1OtD3H2EbjQ==", "0737555555", false, "411777", "269f1d94-abfc-4fdb-9f08-7b1c31d11f17", false, "user@gmail.com" },
                    { "cace7bc4-026f-403c-b63e-909359bf7ddc", 0, "Adminsgatan 8A", "Göteborg", "5f1cf9f6-62fe-45ef-abce-161150afa1e4", "Sweden", "00000 00000 00000", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEIVul2i5/PLvhZvbhNx4ijumA8OazR7liVG8g2ey3FsBU5JOKP4h7GdDOCBtx/MAmQ==", "0737555555", false, "411777", "e27b1dfe-cd09-44b1-9530-e980b8272487", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f67472a9-4702-4b7e-a535-761740987ba0", "b1625925-8997-4a58-bc1d-863843027c26" },
                    { "a12e4862-9b26-4cd1-855e-8b07eb2ab1cb", "cace7bc4-026f-403c-b63e-909359bf7ddc" }
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1,
                column: "CustomerCartId",
                value: "cace7bc4-026f-403c-b63e-909359bf7ddc");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 2,
                column: "CustomerCartId",
                value: "b1625925-8997-4a58-bc1d-863843027c26");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItem_ReceiptId",
                table: "ReceiptItem",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_CustomerId",
                table: "Receipts",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceiptItem");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f67472a9-4702-4b7e-a535-761740987ba0", "b1625925-8997-4a58-bc1d-863843027c26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a12e4862-9b26-4cd1-855e-8b07eb2ab1cb", "cace7bc4-026f-403c-b63e-909359bf7ddc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12e4862-9b26-4cd1-855e-8b07eb2ab1cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67472a9-4702-4b7e-a535-761740987ba0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1625925-8997-4a58-bc1d-863843027c26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cace7bc4-026f-403c-b63e-909359bf7ddc");

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
        }
    }
}
