using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class userAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2025, 2, 18, 23, 16, 31, 824, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2025, 2, 18, 23, 16, 31, 824, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "DateCreated", "Email", "Name", "Password", "Phone", "Role", "Status" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(2025, 2, 18, 23, 16, 31, 948, DateTimeKind.Local).AddTicks(2536), "admin@example.com", "Admin User", "$2a$11$mURUNCkbVkejWceHL.s3Ce8.BkVD0S67s2gzJAjKTGjgj7X8lLa.u", "123-456-7890", "Admin", "Active" },
                    { 2, "456 Oak Ave", new DateTime(2025, 2, 18, 23, 16, 32, 55, DateTimeKind.Local).AddTicks(6908), "user1@example.com", "Regular User 1", "$2a$11$Esj.YqKC3lrGrTrFlhzjqe84WQVgSyYhjcVm3LI2KHKmIGa/3ySkG", "987-654-3210", "User", "Active" },
                    { 3, "789 Pine Ln", new DateTime(2025, 2, 11, 23, 16, 32, 162, DateTimeKind.Local).AddTicks(2288), "user2@example.com", "Regular User 2", "$2a$11$xVbtgyD/hpOdLIsyHPYGu.UAFrZrG2TAqRoIJ35XpLdAi7J5nD5bC", "555-123-4567", "User", "Pending" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2025, 2, 13, 15, 52, 49, 27, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2025, 2, 13, 15, 52, 49, 27, DateTimeKind.Local).AddTicks(3247));
        }
    }
}
