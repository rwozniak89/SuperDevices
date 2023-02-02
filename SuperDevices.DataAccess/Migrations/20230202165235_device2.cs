using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperDevices.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class device2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Creator", "DateCreate", "DateEdit", "Editor", "Name", "SerialNumber", "Test", "Version" },
                values: new object[,]
                {
                    { new Guid("1f3e7fa1-872a-4ab8-bd38-44f903bebbfb"), "admin@it.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Telewizor X", "12345", "", 1 },
                    { new Guid("2c062474-5923-469b-b506-ee6d7063e91e"), "admin@it.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Radio Y", "987654", "", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("1f3e7fa1-872a-4ab8-bd38-44f903bebbfb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("2c062474-5923-469b-b506-ee6d7063e91e"));
        }
    }
}
