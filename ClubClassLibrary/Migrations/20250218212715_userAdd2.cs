using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class userAdd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2025, 2, 18, 23, 27, 14, 327, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2025, 2, 18, 23, 27, 14, 327, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Name", "Password" },
                values: new object[] { new DateTime(2025, 2, 18, 23, 27, 14, 439, DateTimeKind.Local).AddTicks(1327), "Admin", "$2a$11$2dOlF8TaEUAED0vm7cN54eavRH3QOaKEOghAqNJ79NvueoVp46Deu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Password" },
                values: new object[] { new DateTime(2025, 2, 18, 23, 27, 14, 539, DateTimeKind.Local).AddTicks(9777), "$2a$11$uOG9V248ngP/Jk7bc6WXyOD/azcwtaA5QXeZVhaZH5nKdNNBIUTWa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Password" },
                values: new object[] { new DateTime(2025, 2, 11, 23, 27, 14, 645, DateTimeKind.Local).AddTicks(6075), "$2a$11$Had/qsygdJhd2y/Pskr2pu1R/D3MUKKub69frOxdlsaFWn6VWzUNC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Name", "Password" },
                values: new object[] { new DateTime(2025, 2, 18, 23, 16, 31, 948, DateTimeKind.Local).AddTicks(2536), "Admin User", "$2a$11$mURUNCkbVkejWceHL.s3Ce8.BkVD0S67s2gzJAjKTGjgj7X8lLa.u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Password" },
                values: new object[] { new DateTime(2025, 2, 18, 23, 16, 32, 55, DateTimeKind.Local).AddTicks(6908), "$2a$11$Esj.YqKC3lrGrTrFlhzjqe84WQVgSyYhjcVm3LI2KHKmIGa/3ySkG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Password" },
                values: new object[] { new DateTime(2025, 2, 11, 23, 16, 32, 162, DateTimeKind.Local).AddTicks(2288), "$2a$11$xVbtgyD/hpOdLIsyHPYGu.UAFrZrG2TAqRoIJ35XpLdAi7J5nD5bC" });
        }
    }
}
