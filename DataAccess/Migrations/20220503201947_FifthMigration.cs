using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignmentEntities",
                table: "AssignmentEntities");

            migrationBuilder.RenameTable(
                name: "AssignmentEntities",
                newName: "AssignmentEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignmentEntity",
                table: "AssignmentEntity",
                column: "AssignmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignmentEntity",
                table: "AssignmentEntity");

            migrationBuilder.RenameTable(
                name: "AssignmentEntity",
                newName: "AssignmentEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignmentEntities",
                table: "AssignmentEntities",
                column: "AssignmentId");
        }
    }
}
