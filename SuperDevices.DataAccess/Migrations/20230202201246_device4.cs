using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperDevices.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class device4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("9e2c02ea-77ce-4b8b-ac19-97f02ff03fbb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("b7b68b63-cd51-4e11-a38f-7fd901d45741"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("ce603ed9-56c8-4369-b009-911508ef9f4a"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Creator", "DateCreate", "DateEdit", "Editor", "Name", "SerialNumber", "Version" },
                values: new object[,]
                {
                    { new Guid("9e2c02ea-77ce-4b8b-ac19-97f02ff03fbb"), "x@x.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Radio Y", "987654", 1 },
                    { new Guid("b7b68b63-cd51-4e11-a38f-7fd901d45741"), "x@x.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Telewizor X", "12345", 1 },
                    { new Guid("ce603ed9-56c8-4369-b009-911508ef9f4a"), "x@x.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Pilot Z", "123", 1 }
                });
        }
    }
}
