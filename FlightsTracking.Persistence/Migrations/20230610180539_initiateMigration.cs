using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightsTracking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initiateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureAirport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArrivalAirport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("57d0c2a5-796b-49bf-8336-fcf749008971"), "CMN", 33.3699704, -7.5857231000000001, "Aéroport Mohamed V" },
                    { new Guid("5f0adf77-6c6b-4b06-a61e-a9e302af7a46"), "ORY", 48.727699999999999, 2.3670800000000001, "Paris ORLY" },
                    { new Guid("b0c36946-e543-4c3b-9daf-7e0724db4ffc"), "RAK", 32.926253600000003, 8.4107988999999996, "Marrakech" },
                    { new Guid("e4af1efb-4549-4cb1-bf02-21491e2f2261"), "CDG", 49.006999999999998, 2.55979, "Charles de Gaulle" },
                    { new Guid("ea017e0e-e6eb-40fe-bca9-4eeecf47d58d"), "LHR", 51.4700256, -0.45648420000000001, "Londres Heathrow" },
                    { new Guid("fe6a6ade-af16-48e7-a323-432b4c4d2615"), "MAD", 40.493499999999997, -3.56629, "Madrid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
