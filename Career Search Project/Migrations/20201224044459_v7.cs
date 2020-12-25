using Microsoft.EntityFrameworkCore.Migrations;

namespace Career_Search_Project.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobEmployers_TopJobs_TopJobId",
                table: "JobEmployers");

            migrationBuilder.DropIndex(
                name: "IX_JobEmployers_TopJobId",
                table: "JobEmployers");

            migrationBuilder.DropColumn(
                name: "TopJobId",
                table: "JobEmployers");

            migrationBuilder.AddColumn<int>(
                name: "JobEmployerId",
                table: "TopJobs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TopJobs_JobEmployerId",
                table: "TopJobs",
                column: "JobEmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TopJobs_JobEmployers_JobEmployerId",
                table: "TopJobs",
                column: "JobEmployerId",
                principalTable: "JobEmployers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TopJobs_JobEmployers_JobEmployerId",
                table: "TopJobs");

            migrationBuilder.DropIndex(
                name: "IX_TopJobs_JobEmployerId",
                table: "TopJobs");

            migrationBuilder.DropColumn(
                name: "JobEmployerId",
                table: "TopJobs");

            migrationBuilder.AddColumn<int>(
                name: "TopJobId",
                table: "JobEmployers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobEmployers_TopJobId",
                table: "JobEmployers",
                column: "TopJobId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobEmployers_TopJobs_TopJobId",
                table: "JobEmployers",
                column: "TopJobId",
                principalTable: "TopJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
