using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13Assignment.Migrations
{
    public partial class thirdMigration_table_modification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Toys");

            migrationBuilder.DropColumn(
                name: "ToyBasePrice",
                table: "Toys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Toys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToyBasePrice",
                table: "Toys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
