using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Match_and_2_TeamID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_TeamsTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Result1",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Result2",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "TeamsTeamId",
                table: "Matches",
                newName: "HomeTeamID");

            migrationBuilder.RenameColumn(
                name: "TeamId2",
                table: "Matches",
                newName: "HomeResult");

            migrationBuilder.RenameColumn(
                name: "TeamId1",
                table: "Matches",
                newName: "GuestResult");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_TeamsTeamId",
                table: "Matches",
                newName: "IX_Matches_HomeTeamID");

            migrationBuilder.AddColumn<int>(
                name: "GuestTeamID",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_GuestTeamID",
                table: "Matches",
                column: "GuestTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_GuestTeamID",
                table: "Matches",
                column: "GuestTeamID",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_HomeTeamID",
                table: "Matches",
                column: "HomeTeamID",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_GuestTeamID",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_HomeTeamID",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_GuestTeamID",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GuestTeamID",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "HomeTeamID",
                table: "Matches",
                newName: "TeamsTeamId");

            migrationBuilder.RenameColumn(
                name: "HomeResult",
                table: "Matches",
                newName: "TeamId2");

            migrationBuilder.RenameColumn(
                name: "GuestResult",
                table: "Matches",
                newName: "TeamId1");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_HomeTeamID",
                table: "Matches",
                newName: "IX_Matches_TeamsTeamId");

            migrationBuilder.AddColumn<int>(
                name: "Result1",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Result2",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_TeamsTeamId",
                table: "Matches",
                column: "TeamsTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
