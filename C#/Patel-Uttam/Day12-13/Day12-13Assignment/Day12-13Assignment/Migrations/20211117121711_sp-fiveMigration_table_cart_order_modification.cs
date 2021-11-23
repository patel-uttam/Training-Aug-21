using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13Assignment.Migrations
{
    public partial class spfiveMigration_table_cart_order_modification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // store procedure
            var sp = @"CREATE PROCEDURE [dbo].[Toys_By_Category] @ToyName varchar(MAX)
                    AS 
                    BEGIN
                    SET NOCOUNT ON;
                    SELECT * FROM Toys WHERE ToyType LIKE '%'+@ToyName+'%'
                    END
            ";
            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
