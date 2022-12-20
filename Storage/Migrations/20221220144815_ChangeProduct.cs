using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storage.Migrations
{
    public partial class ChangeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, 2, 0, "", "Titanic", new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.0F" },
                    { 2, 7, 0, "", "Screem", new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.0F" },
                    { 3, 6, 0, "", "The Shining", new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.0F" },
                    { 4, 0, 0, "", "300", new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.0F" },
                    { 5, 32, 0, "", "Interstellar", new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.0F" },
                    { 6, 2, 0, "", "The Dark Knight", new DateTime(2008, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.0F" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
