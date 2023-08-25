using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookstoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a34c3d0d-777b-4c5d-8648-4479fe32c57e", 0, "a2005696-37a9-4342-9336-92df91423131", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEBKT3ZTZxyXKu7P1wYmfYySDRmfbWoI5CyCgJyRdm2yq6uLrjQn02kq3bUIa3n+7yQ==", null, false, "5da527ce-096d-4f90-a29a-cb31edeef5e9", false, "user@bookstore.com" },
                    { "f1652215-8e16-475c-a8c4-c974f76e1836", 0, "c061d200-3d1c-47c5-aa28-1bd921f5842b", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAELMxpezCd8zbbpdbEH52J1jEjv/sG0/IwgiKB51gZ1hjfJzMEIDHww2kAQ5MzUytwQ==", null, false, "823e141b-b6df-4cfa-a95b-5e921189edff", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad184e73-807a-45dc-b053-ff3965964a0d", "a34c3d0d-777b-4c5d-8648-4479fe32c57e" },
                    { "b93d694c-c048-4d97-83d8-7d57d94082b1", "f1652215-8e16-475c-a8c4-c974f76e1836" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad184e73-807a-45dc-b053-ff3965964a0d", "a34c3d0d-777b-4c5d-8648-4479fe32c57e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b93d694c-c048-4d97-83d8-7d57d94082b1", "f1652215-8e16-475c-a8c4-c974f76e1836" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a34c3d0d-777b-4c5d-8648-4479fe32c57e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1652215-8e16-475c-a8c4-c974f76e1836");
        }
    }
}
