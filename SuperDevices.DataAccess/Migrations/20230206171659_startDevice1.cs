using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperDevices.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class startDevice1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Creator = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateEdit = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Editor = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Creator", "DateCreate", "DateEdit", "Editor", "Name", "SerialNumber", "Version" },
                values: new object[,]
                {
                    { new Guid("1aa64943-a2b8-4615-b1b4-623a2e6b1541"), "x@x.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Telewizor X", "12345", 1 },
                    { new Guid("582258d3-6621-4b41-82e5-1e89f1c4fff1"), "x@x.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Radio Y", "987654", 1 },
                    { new Guid("c7deaff3-6b2a-4727-966a-5f2b9a2ceb1a"), "x@x.com", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "x@x.com", "Pilot Z", "123", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
