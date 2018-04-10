using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentPlannerMVC.Migrations
{
    public partial class Inheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    hymnNumber = table.Column<int>(nullable: false),
                    hymnTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnID);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    IsActive = table.Column<bool>(nullable: true),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MeetingID = table.Column<int>(nullable: true),
                    MemberID = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClosingHymn = table.Column<int>(nullable: false),
                    ClosingPrayer = table.Column<string>(maxLength: 100, nullable: false),
                    ConductorID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IntermediateHymn = table.Column<int>(nullable: true),
                    OpeningHymn = table.Column<int>(nullable: false),
                    OpeningPrayer = table.Column<string>(maxLength: 100, nullable: false),
                    SacramentHymn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meeting_Member_ConductorID",
                        column: x => x.ConductorID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_ConductorID",
                table: "Meeting",
                column: "ConductorID");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MeetingID",
                table: "Member",
                column: "MeetingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meeting_MeetingID",
                table: "Member",
                column: "MeetingID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Member_ConductorID",
                table: "Meeting");

            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
