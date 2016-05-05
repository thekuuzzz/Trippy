using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace WebApplication2.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.ID);
                });
            migrationBuilder.CreateTable(
                name: "Stop",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    TripID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stop", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stop_Trip_TripID",
                        column: x => x.TripID,
                        principalTable: "Trip",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Stop");
            migrationBuilder.DropTable("Trip");
        }
    }
}
