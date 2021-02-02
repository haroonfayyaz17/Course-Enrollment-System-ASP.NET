using Microsoft.EntityFrameworkCore.Migrations;

namespace Course_Enrollment_System.Migrations
{
    public partial class Enrollment_update_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grades",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Enrollments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "Grades",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
