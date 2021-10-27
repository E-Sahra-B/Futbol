using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class af2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_TeamName_TeamNameId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "TeamName");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamNameId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamNameId",
                table: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "TeamNameId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TeamName",
                columns: table => new
                {
                    TeamNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamName", x => x.TeamNameId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamNameId",
                table: "Teams",
                column: "TeamNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_TeamName_TeamNameId",
                table: "Teams",
                column: "TeamNameId",
                principalTable: "TeamName",
                principalColumn: "TeamNameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
