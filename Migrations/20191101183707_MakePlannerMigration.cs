using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivityCenter.Migrations
{
    public partial class MakePlannerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlannerUserId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_PlannerUserId",
                table: "Events",
                column: "PlannerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_PlannerUserId",
                table: "Events",
                column: "PlannerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_PlannerUserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_PlannerUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PlannerUserId",
                table: "Events");
        }
    }
}
