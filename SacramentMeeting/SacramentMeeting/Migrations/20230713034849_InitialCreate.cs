using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeeting.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumOfSpeakers = table.Column<int>(type: "int", nullable: false),
                    SpeakerSubjects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
