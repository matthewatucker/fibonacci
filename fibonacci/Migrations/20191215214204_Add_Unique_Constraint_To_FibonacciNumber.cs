using Microsoft.EntityFrameworkCore.Migrations;

namespace fibonacci.Migrations
{
    public partial class Add_Unique_Constraint_To_FibonacciNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FibonacciNumbers_Value",
                table: "FibonacciNumbers");

            migrationBuilder.CreateIndex(
                name: "IX_FibonacciNumbers_Value",
                table: "FibonacciNumbers",
                column: "Value",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FibonacciNumbers_Value",
                table: "FibonacciNumbers");

            migrationBuilder.CreateIndex(
                name: "IX_FibonacciNumbers_Value",
                table: "FibonacciNumbers",
                column: "Value");
        }
    }
}
