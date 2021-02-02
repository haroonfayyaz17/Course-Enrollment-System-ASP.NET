using Microsoft.EntityFrameworkCore.Migrations;

namespace Course_Enrollment_System.Migrations
{
    public partial class Enrollment_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credits",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "Grades",
                table: "Enrollments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grades",
                table: "Enrollments");

            migrationBuilder.AddColumn<float>(
                name: "Credits",
                table: "Enrollments",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
