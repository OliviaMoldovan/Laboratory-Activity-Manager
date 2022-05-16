using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class OptMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LabId",
                table: "SubmissionEntities");

            migrationBuilder.AddColumn<int>(
                name: "LabId",
                table: "AssignmentEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LabId",
                table: "AssignmentEntities");

            migrationBuilder.AddColumn<int>(
                name: "LabId",
                table: "SubmissionEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
