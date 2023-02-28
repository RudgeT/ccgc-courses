using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class Disciplines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplineID",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DisciplineID",
                table: "Courses",
                column: "DisciplineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Disciplines_DisciplineID",
                table: "Courses",
                column: "DisciplineID",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Disciplines_DisciplineID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DisciplineID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DisciplineID",
                table: "Courses");
        }
    }
}
