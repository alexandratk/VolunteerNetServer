using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class UserDateOfBirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("00965288-d952-4d0f-8bd7-0c5d0ab2eb5b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("15128cf2-1ecf-4a87-9577-5fcdab4ced18"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[] { new Guid("8258416d-b7e6-4e94-8bae-d5234ab7c5b0"), "cook" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[] { new Guid("eb01f78a-8ba9-4852-95b3-9691501236b2"), "medicine" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8258416d-b7e6-4e94-8bae-d5234ab7c5b0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eb01f78a-8ba9-4852-95b3-9691501236b2"));

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[] { new Guid("00965288-d952-4d0f-8bd7-0c5d0ab2eb5b"), "medicine" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[] { new Guid("15128cf2-1ecf-4a87-9577-5fcdab4ced18"), "cook" });
        }
    }
}
