using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperDevices.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class device3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("1f3e7fa1-872a-4ab8-bd38-44f903bebbfb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("2c062474-5923-469b-b506-ee6d7063e91e"));

            migrationBuilder.AlterColumn<string>(
                name: "Editor",
                table: "Devices",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEdit",
                table: "Devices",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Creator", "DateCreate", "DateEdit", "Editor", "Name", "SerialNumber", "Test", "Version" },
                values: new object[,]
                {
                    { new Guid("11fa6aba-df06-42b7-9dff-cd154922454d"), "x@x.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Pilot Z", "123", "", 1 },
                    { new Guid("4caec09f-e142-4437-b865-95dfea8f1f14"), "x@x.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Radio Y", "987654", "", 1 },
                    { new Guid("51c97818-699b-48e7-8094-0246cf6f096a"), "x@x.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Telewizor X", "12345", "", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("11fa6aba-df06-42b7-9dff-cd154922454d"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("4caec09f-e142-4437-b865-95dfea8f1f14"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("51c97818-699b-48e7-8094-0246cf6f096a"));

            migrationBuilder.AlterColumn<string>(
                name: "Editor",
                table: "Devices",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEdit",
                table: "Devices",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Creator", "DateCreate", "DateEdit", "Editor", "Name", "SerialNumber", "Test", "Version" },
                values: new object[,]
                {
                    { new Guid("1f3e7fa1-872a-4ab8-bd38-44f903bebbfb"), "admin@it.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Telewizor X", "12345", "", 1 },
                    { new Guid("2c062474-5923-469b-b506-ee6d7063e91e"), "admin@it.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Radio Y", "987654", "", 1 }
                });
        }
    }
}
