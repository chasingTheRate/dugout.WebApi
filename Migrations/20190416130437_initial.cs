﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace dugout.WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    link = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SpringLeague",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true),
                    abbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpringLeague", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true),
                    venueid = table.Column<int>(nullable: true),
                    teamCode = table.Column<string>(nullable: true),
                    fileCode = table.Column<string>(nullable: true),
                    abbreviation = table.Column<string>(nullable: true),
                    teamName = table.Column<string>(nullable: true),
                    locationName = table.Column<string>(nullable: true),
                    firstYearOfPlay = table.Column<string>(nullable: true),
                    leagueid = table.Column<int>(nullable: true),
                    divisionid = table.Column<int>(nullable: true),
                    sportid = table.Column<int>(nullable: true),
                    shortName = table.Column<string>(nullable: true),
                    springLeagueid = table.Column<int>(nullable: true),
                    allStarStatus = table.Column<string>(nullable: true),
                    active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                    table.ForeignKey(
                        name: "FK_Teams_Division_divisionid",
                        column: x => x.divisionid,
                        principalTable: "Division",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_League_leagueid",
                        column: x => x.leagueid,
                        principalTable: "League",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Sport_sportid",
                        column: x => x.sportid,
                        principalTable: "Sport",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_SpringLeague_springLeagueid",
                        column: x => x.springLeagueid,
                        principalTable: "SpringLeague",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Venue_venueid",
                        column: x => x.venueid,
                        principalTable: "Venue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_divisionid",
                table: "Teams",
                column: "divisionid");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_leagueid",
                table: "Teams",
                column: "leagueid");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_sportid",
                table: "Teams",
                column: "sportid");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_springLeagueid",
                table: "Teams",
                column: "springLeagueid");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_venueid",
                table: "Teams",
                column: "venueid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "SpringLeague");

            migrationBuilder.DropTable(
                name: "Venue");
        }
    }
}
