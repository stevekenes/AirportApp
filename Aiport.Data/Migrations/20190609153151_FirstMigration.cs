using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiport.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightCategories_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    RouteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightRoutes_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightRoutes_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 6, 9, 16, 31, 47, 168, DateTimeKind.Local).AddTicks(7605), new DateTime(2019, 6, 9, 16, 31, 47, 168, DateTimeKind.Local).AddTicks(7624), "Local" },
                    { 2, new DateTime(2019, 6, 9, 16, 31, 47, 168, DateTimeKind.Local).AddTicks(7664), new DateTime(2019, 6, 9, 16, 31, 47, 168, DateTimeKind.Local).AddTicks(7669), "International" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 101, new DateTime(2019, 6, 9, 16, 31, 47, 161, DateTimeKind.Local).AddTicks(8052), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(1049), "British Airways" },
                    { 201, new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2507), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2526), "Lofthanza" },
                    { 301, new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2544), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2548), "Sosoliso" },
                    { 401, new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2553), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2553), "Ethiopian Air" },
                    { 501, new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2557), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2557), "Air France" },
                    { 601, new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2562), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2562), "Emirates" },
                    { 701, new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2566), new DateTime(2019, 6, 9, 16, 31, 47, 163, DateTimeKind.Local).AddTicks(2566), "Nigerian Airways" }
                });

            migrationBuilder.InsertData(
                table: "FlightCategories",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "FlightId" },
                values: new object[,]
                {
                    { 20, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5609), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5631), 101 },
                    { 27, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5717), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5717), 601 },
                    { 26, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5713), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5713), 501 },
                    { 25, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5708), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5708), 401 },
                    { 24, 1, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5704), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5704), 401 },
                    { 23, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5699), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5699), 301 },
                    { 22, 1, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5695), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5695), 301 },
                    { 21, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5690), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5690), 201 },
                    { 29, 2, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5722), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5726), 701 },
                    { 28, 1, new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5717), new DateTime(2019, 6, 9, 16, 31, 47, 171, DateTimeKind.Local).AddTicks(5722), 701 }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 888, 2, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3462), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3467), "Lagos Dubai" },
                    { 777, 2, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3458), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3462), "Lagos Adis Ababa" },
                    { 666, 2, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3453), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3453), "Lagos Paris" },
                    { 555, 2, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3449), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3449), "Lagos London" },
                    { 444, 2, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3444), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3444), "Lagos Johanesburg" },
                    { 333, 2, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3435), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3440), "Lagos Acra" },
                    { 222, 1, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3431), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3431), "Lagos Enugu" },
                    { 111, 1, new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3317), new DateTime(2019, 6, 9, 16, 31, 47, 167, DateTimeKind.Local).AddTicks(3345), "Lagos Abuja" }
                });

            migrationBuilder.InsertData(
                table: "FlightRoutes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FlightId", "RouteId" },
                values: new object[,]
                {
                    { 3, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3589), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3589), 301, 111 },
                    { 6, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3603), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3603), 401, 111 },
                    { 11, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3621), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3621), 701, 111 },
                    { 12, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3626), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3626), 701, 111 },
                    { 4, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3594), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3594), 301, 222 },
                    { 7, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3607), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3607), 401, 222 },
                    { 5, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3598), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3598), 301, 333 },
                    { 13, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3630), 701, 333 },
                    { 2, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3585), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3585), 201, 444 },
                    { 1, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3494), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3526), 101, 555 },
                    { 14, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3635), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3635), 701, 555 },
                    { 9, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3612), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3616), 501, 666 },
                    { 8, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3612), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3612), 401, 777 },
                    { 10, new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3616), new DateTime(2019, 6, 9, 16, 31, 47, 175, DateTimeKind.Local).AddTicks(3621), 601, 888 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightCategories_CategoryId",
                table: "FlightCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightCategories_FlightId",
                table: "FlightCategories",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightRoutes_FlightId",
                table: "FlightRoutes",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightRoutes_RouteId",
                table: "FlightRoutes",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CategoryId",
                table: "Routes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightCategories");

            migrationBuilder.DropTable(
                name: "FlightRoutes");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
