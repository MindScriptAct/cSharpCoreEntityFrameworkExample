using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListApp.Migrations
{
    public partial class TodoItemsCanHaveCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "TodoItem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItem_CategoryId",
                table: "TodoItem",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_Category_CategoryId",
                table: "TodoItem",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_Category_CategoryId",
                table: "TodoItem");

            migrationBuilder.DropIndex(
                name: "IX_TodoItem_CategoryId",
                table: "TodoItem");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TodoItem");
        }
    }
}
