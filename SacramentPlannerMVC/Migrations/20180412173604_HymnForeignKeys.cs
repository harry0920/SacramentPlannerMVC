using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentPlannerMVC.Migrations
{
    public partial class HymnForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Member_ConductorID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Meeting_MeetingID",
                table: "Member");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hymn",
                table: "Hymn");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "hymnNumber",
                table: "Hymn");

            migrationBuilder.RenameTable(
                name: "Hymn",
                newName: "Hymns");

            migrationBuilder.RenameColumn(
                name: "MeetingID",
                table: "Member",
                newName: "MeetingId");

            migrationBuilder.RenameIndex(
                name: "IX_Member_MeetingID",
                table: "Member",
                newName: "IX_Member_MeetingId");

            migrationBuilder.RenameColumn(
                name: "SacramentHymn",
                table: "Meeting",
                newName: "SacramentHymnID");

            migrationBuilder.RenameColumn(
                name: "OpeningHymn",
                table: "Meeting",
                newName: "OpeningHymnID");

            migrationBuilder.RenameColumn(
                name: "IntermediateHymn",
                table: "Meeting",
                newName: "IntermediateHymnID");

            migrationBuilder.RenameColumn(
                name: "ConductorID",
                table: "Meeting",
                newName: "ClosingHymnID");

            migrationBuilder.RenameColumn(
                name: "ClosingHymn",
                table: "Meeting",
                newName: "BishopricID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Meeting",
                newName: "MeetingId");

            migrationBuilder.RenameIndex(
                name: "IX_Meeting_ConductorID",
                table: "Meeting",
                newName: "IX_Meeting_ClosingHymnID");

            migrationBuilder.RenameColumn(
                name: "hymnTitle",
                table: "Hymns",
                newName: "HymnTitle");

            migrationBuilder.RenameColumn(
                name: "HymnID",
                table: "Hymns",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hymns",
                table: "Hymns",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Bishopric",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bishopric", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_BishopricID",
                table: "Meeting",
                column: "BishopricID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_IntermediateHymnID",
                table: "Meeting",
                column: "IntermediateHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_OpeningHymnID",
                table: "Meeting",
                column: "OpeningHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SacramentHymnID",
                table: "Meeting",
                column: "SacramentHymnID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Bishopric_BishopricID",
                table: "Meeting",
                column: "BishopricID",
                principalTable: "Bishopric",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Hymns_ClosingHymnID",
                table: "Meeting",
                column: "ClosingHymnID",
                principalTable: "Hymns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Hymns_IntermediateHymnID",
                table: "Meeting",
                column: "IntermediateHymnID",
                principalTable: "Hymns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Hymns_OpeningHymnID",
                table: "Meeting",
                column: "OpeningHymnID",
                principalTable: "Hymns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Hymns_SacramentHymnID",
                table: "Meeting",
                column: "SacramentHymnID",
                principalTable: "Hymns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meeting_MeetingId",
                table: "Member",
                column: "MeetingId",
                principalTable: "Meeting",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Bishopric_BishopricID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Hymns_ClosingHymnID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Hymns_IntermediateHymnID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Hymns_OpeningHymnID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Hymns_SacramentHymnID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Meeting_MeetingId",
                table: "Member");

            migrationBuilder.DropTable(
                name: "Bishopric");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_BishopricID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_IntermediateHymnID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_OpeningHymnID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_SacramentHymnID",
                table: "Meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hymns",
                table: "Hymns");

            migrationBuilder.RenameTable(
                name: "Hymns",
                newName: "Hymn");

            migrationBuilder.RenameColumn(
                name: "MeetingId",
                table: "Member",
                newName: "MeetingID");

            migrationBuilder.RenameIndex(
                name: "IX_Member_MeetingId",
                table: "Member",
                newName: "IX_Member_MeetingID");

            migrationBuilder.RenameColumn(
                name: "SacramentHymnID",
                table: "Meeting",
                newName: "SacramentHymn");

            migrationBuilder.RenameColumn(
                name: "OpeningHymnID",
                table: "Meeting",
                newName: "OpeningHymn");

            migrationBuilder.RenameColumn(
                name: "IntermediateHymnID",
                table: "Meeting",
                newName: "IntermediateHymn");

            migrationBuilder.RenameColumn(
                name: "ClosingHymnID",
                table: "Meeting",
                newName: "ConductorID");

            migrationBuilder.RenameColumn(
                name: "BishopricID",
                table: "Meeting",
                newName: "ClosingHymn");

            migrationBuilder.RenameColumn(
                name: "MeetingId",
                table: "Meeting",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Meeting_ClosingHymnID",
                table: "Meeting",
                newName: "IX_Meeting_ConductorID");

            migrationBuilder.RenameColumn(
                name: "HymnTitle",
                table: "Hymn",
                newName: "hymnTitle");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Hymn",
                newName: "HymnID");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hymnNumber",
                table: "Hymn",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hymn",
                table: "Hymn",
                column: "HymnID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Member_ConductorID",
                table: "Meeting",
                column: "ConductorID",
                principalTable: "Member",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meeting_MeetingID",
                table: "Member",
                column: "MeetingID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
