using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class _1st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    TeamHobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamNameId = table.Column<int>(nullable: false),
                    HobbyName = table.Column<string>(nullable: true),
                    YearStarted = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.TeamHobbyId);
                });

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    TeamNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Birthate = table.Column<string>(nullable: true),
                    CollegeProgram = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.TeamNameId);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "TeamHobbyId", "Frequency", "HobbyName", "Location", "TeamNameId", "YearStarted" },
                values: new object[,]
                {
                    { 1, "4/Month", "Martial Art", "Fairfield", 1, "04/04/1999" },
                    { 2, "8/Month", "Guitar", "Home", 2, "10/30/2009" },
                    { 3, "8/Month", "Hiking", "Park", 3, "10/30/2009" }
                });

            migrationBuilder.InsertData(
                table: "Names",
                columns: new[] { "TeamNameId", "Birthate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, "04/04/1995", "Networking System", "Guy-David Ngondo", "Senior" },
                    { 2, "02/20/2000", "Software Dev", "Mitchell Hansbauer", "Sophomore" },
                    { 3, "04/04/1990", "Software Dev", "Robert Champion", "Senior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Names");
        }
    }
}
