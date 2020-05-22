using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMvcProject.Migrations
{
    public partial class coursesWithManySubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Subjects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CourseId",
                table: "Subjects",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_CourseId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Subjects");
        }
    }
}
