using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class _1st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    TeamClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    ClassName = table.Column<string>(nullable: true),
                    Grade = table.Column<int>(nullable: false),
                    YearStarted = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.TeamClassId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    TeamGameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamNameId = table.Column<int>(nullable: false),
                    GameName = table.Column<string>(nullable: true),
                    YearStarted = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.TeamGameId);
                });

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
                table: "Classes",
                columns: new[] { "TeamClassId", "ClassName", "Grade", "TeamName", "YearStarted" },
                values: new object[,]
                {
                    { 1, "Contemperary Programming", 100, "Guy-David Ngondo", "5/8/2022" },
                    { 2, "Contemperary Programming", 100, "Mitchell Hansbauer", "5/8/2022" },
                    { 3, "Contemperary Programming", 100, "Robert Champion", "5/8/2022" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "TeamGameId", "Frequency", "GameName", "TeamNameId", "YearStarted" },
                values: new object[,]
                {
                    { 1, "4/month", "Call of Duty Black Ops 2", 1, "5/8/2022" },
                    { 2, "12/month", "Minecraft", 2, "5/8/2022" },
                    { 3, "8/month", "Far Cry 3", 3, "5/8/2022" }
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
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Names");
        }
    }
}
