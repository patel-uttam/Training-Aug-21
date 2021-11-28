using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13Practice.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "Grade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Grade",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
