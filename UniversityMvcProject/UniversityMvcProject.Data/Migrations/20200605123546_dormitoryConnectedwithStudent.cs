using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMvcProject.Data.Migrations
{
    public partial class dormitoryConnectedwithStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DormitoryId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DormitoryId",
                table: "Students",
                column: "DormitoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Dormitories_DormitoryId",
                table: "Students",
                column: "DormitoryId",
                principalTable: "Dormitories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Dormitories_DormitoryId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DormitoryId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DormitoryId",
                table: "Students");
        }
    }
}
