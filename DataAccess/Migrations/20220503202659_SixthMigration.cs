using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SubmissionEntities",
                columns: table => new
                {
                    SubmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LabId = table.Column<int>(type: "int", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmissionEntities", x => x.SubmissionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubmissionEntities");

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
    }
}
